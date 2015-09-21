using System;
using System.Collections.Generic;
using System.Data.Entity;
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
        
        //[HttpPost]
        public ActionResult DropTables(int[] ids)
        {
            return View(ids);
        }

        // GET: Home/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Home/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Home/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Home/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Home/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Home/Delete/5
        [HttpPost]
        public JsonResult Delete(List<int> ids)
        {
            return Json(ids);
        }
    }
}
