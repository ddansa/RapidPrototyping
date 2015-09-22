using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;

using L4WebApp.Models;


namespace L4WebApp.Controllers
{

    public class HomeController : Controller
    {


        private ContactsDBEntities _db = new ContactsDBEntities();
        // GET: Home
        public ActionResult Index()
        {
            return View(_db.Contacts.ToList());
        }

        public ActionResult GetContacts()
        {
            ContactsDBEntities model = new ContactsDBEntities();
            return PartialView("_contTable", model.Contacts.ToList());
        }

        // GET: Home/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Home/Create
        [HttpPost]
        public ActionResult Create(List<string> values)
        {
            foreach(var n in values)
            {
                if (String.IsNullOrEmpty(n))
                {
                    return Json(false);
                }
            }
            var newContact = new Contact();
            newContact.Fname = values[0];
            newContact.Lname = values[1];
            newContact.Telnum = values[2];
            newContact.Email = values[3];

            _db.Contacts.Add(newContact);
            _db.SaveChanges();
            return Json(true);
        }

        // GET: Home/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
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
