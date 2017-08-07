using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using themiamiagency.Models;

namespace themiamiagency.Controllers
{
    public class AutoQuoteController : Controller
    {
        private MyDbContext db = new MyDbContext();
        //
        // GET: /AutoQuote/
        public ActionResult Index()
        {
            return View();
        }

        //
        // GET: /AutoQuote/Details
        public ActionResult Details()
        {
            var autoQuote = new AutoQuote { FirstName = "Angelica", LastName = "Rodriguez", PhoneNumber = "954-662-2188", Email = "jcs571@yahoo.com", ZipCode = "33029" };
            return View(autoQuote);
        }

        //
        // GET: /AutoQuote/Create
        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /AutoQuote/Create
        [HttpPost]
        public ActionResult Create(AutoQuote AutoQuote) //Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                db.AutoQuotes.Add(AutoQuote);
                db.SaveChanges();

                return View ("Success");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /AutoQuote/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /AutoQuote/Edit/5
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

        //
        // GET: /AutoQuote/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /AutoQuote/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
