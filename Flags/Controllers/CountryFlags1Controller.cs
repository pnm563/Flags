using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Flags.Models;
using Models;

namespace Flags.Controllers
{
    public class CountryFlags1Controller : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: CountryFlags1
        public ActionResult Index()
        {
            return View(db.CountryFlags.ToList());
        }

        // GET: CountryFlags1/Details/5
        public ActionResult Details(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CountryFlag countryFlag = db.CountryFlags.Find(id);
            if (countryFlag == null)
            {
                return HttpNotFound();
            }
            return View(countryFlag);
        }

        // GET: CountryFlags1/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CountryFlags1/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,CountryCode,Description")] CountryFlag countryFlag)
        {
            if (ModelState.IsValid)
            {
                countryFlag.ID = Guid.NewGuid();
                db.CountryFlags.Add(countryFlag);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(countryFlag);
        }

        // GET: CountryFlags1/Edit/5
        public ActionResult Edit(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CountryFlag countryFlag = db.CountryFlags.Find(id);
            if (countryFlag == null)
            {
                return HttpNotFound();
            }
            return View(countryFlag);
        }

        // POST: CountryFlags1/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,CountryCode,Description")] CountryFlag countryFlag)
        {
            if (ModelState.IsValid)
            {
                db.Entry(countryFlag).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(countryFlag);
        }

        // GET: CountryFlags1/Delete/5
        public ActionResult Delete(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CountryFlag countryFlag = db.CountryFlags.Find(id);
            if (countryFlag == null)
            {
                return HttpNotFound();
            }
            return View(countryFlag);
        }

        // POST: CountryFlags1/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(Guid id)
        {
            CountryFlag countryFlag = db.CountryFlags.Find(id);
            db.CountryFlags.Remove(countryFlag);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
