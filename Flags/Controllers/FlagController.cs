using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Flags.Controllers
{
    public class FlagController : Controller
    {
        // GET: Flag
        public ActionResult Index()
        {
            Random rnd = new Random();
            int flagImageIndex = rnd.Next(0, 3);
            IList<string> flagImages = new List<string>{ "Afghanistan.jpg", "Albania.jpg", "Algeria.jpg" };
            return Content($"<img src=\"Images\\{flagImages[flagImageIndex]}\" />");
        }

        // GET: Flag/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Flag/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Flag/Create
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

        // GET: Flag/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Flag/Edit/5
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

        // GET: Flag/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Flag/Delete/5
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
