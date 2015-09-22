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
        
        // GET: Home/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Home/Create
        [HttpPost]
        public ActionResult Create(List<string> newContact)
        {
                /*var Fname = newContact[0];
                var Lname = newContact[1];
                var Telnum = newContact[2];
                var Email = newContact[3];*/
                return Json(newContact);
                    return RedirectToAction("Index");
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
            if (ids != null) { 
                foreach (var n in ids)
                {
                    //var i = ids[n];
                    _db.Contacts.Where(c => c.Id == n)
                        .ToList().ForEach(c => _db.Contacts.Remove(c));

                    _db.SaveChanges();
                }
            }
            RedirectToAction("Index", "Home");
            return Json(ids);
        }
    }
}
