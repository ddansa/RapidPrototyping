//using System;
using System.Collections.Generic;
//using System.Data.Entity;
//using System.Diagnostics;
using System.Linq;
using System.Text.RegularExpressions;
//using System.Web;
using System.Web.Mvc;
//using System.Web.Optimization;
using L4WebApp.Models;
//using Microsoft.Ajax.Utilities;


namespace L4WebApp.Controllers
{
    

    public class HomeController : Controller
    {

        // Simple method to clear Whitespace characters from a string
        public static string ClearWhitespace(string input)
        {
            return new string(input.Where(c => !char.IsWhiteSpace(c)).ToArray());
        }

        // List of the entry types used in our form
        public enum Types { Name, Telnum, Email }

        // Validation method for all the data types we check
        public static bool Validation(string input, Types type)
        {
            // Creates a dictionary of Regex patterns, used for easier access
            // Each entry contains the type of data we validate and the regex pattern for that data.
            Dictionary<Types, Regex> regexes = new Dictionary<Types, Regex>()
            {
                {
                    Types.Name, new Regex(@"^[\p{L}\s'.-]{2,20}$")
                },
                {
                    Types.Telnum, new Regex(@"^[\+]?[\s\d]{8,15}$")
                },
                {
                    Types.Email, new Regex(@"^[a-z0-9._+-]+@[a-z0-9.-]+\.[a-z]{2,4}$")
                }
            };
            // Checks the input towards the specified type in our regex dictionary
            return regexes[type].IsMatch(input);
        }

        // GET: Home/RemoteCheckName
        // Front-end validation of names
        // Used because javascript regex does not support checking for unicode characters such as åäö
        [HttpPost]
        public JsonResult RemoteCheckName(string input)
        {
            // Checks the input towards our validation method
            if (!Validation(input, Types.Name))
            {
                // If the name is denied by the validation, an error message is sent to front end 
                return Json("Not a valid name.", JsonRequestBehavior.AllowGet);
            }
            // "True" is returned to front end if validation accepts the input 
            return Json(true, JsonRequestBehavior.AllowGet);
        }

        // Initiates Context connection to database through a Entity Framework model
        private readonly ContactsDBazEntities _db = new ContactsDBazEntities();

        // GET: Home
        // Renders the Index page
        public ActionResult Index()
        {
            // Sends contact data from the Database connection to the MVC view
            return View(_db.Contacts.ToList());
        }

        // GET: Home/GetContacts
        public ActionResult GetContacts()
        {
            // Refreshes the contacts table (Partial view is used to prevent full-page refresh)
            return PartialView("_contTable", _db.Contacts.ToList());
        }

 
        // POST: Home/Create
        [HttpPost]
        public ActionResult Create(List<string> values)
        {
            if (values.Any(string.IsNullOrEmpty))
            {
                return Json(false);
            }

            if (!Validation(values[0], Types.Name) || !Validation(values[1], Types.Name) || !Validation(values[2], Types.Telnum) || !Validation(values[3], Types.Email))
            {
                return Json(false);
            }

            var newContact = new Contact
            {
                Fname = values[0],
                Lname = values[1],
                Telnum = ClearWhitespace(values[2]),
                Email = ClearWhitespace(values[3])
            };           

            _db.Contacts.Add(newContact);
            _db.SaveChanges();
            return Json(true);
        }

        // POST: Home/Delete/5
        [HttpPost]
        public JsonResult Delete(List<int> ids)
        {
            if (ids == null) {
                return Json(false);
            }
            foreach (var n in ids)
            {
                _db.Contacts.Where(c => c.Id == n)
                    .ToList().ForEach(c => _db.Contacts.Remove(c));
                _db.SaveChanges();
            }
            return Json(true);
        }
    }
}
