using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Web;
using System.Web.Mvc;
using Common;
using Flags.Models;
using Models;
using Newtonsoft.Json;

namespace Flags.Controllers
{
    public class CountryFlagsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: CountryFlags
        public ActionResult Index()
        {
            //return View(db.CountryFlags.ToList());
            return View();
        }

        //GET: CountryFlags/Details/5
        public ActionResult Details(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            //CountryFlag countryFlag = db.CountryFlags.Find(id);
            CountryFlag countryFlag = new CountryFlag();
            if (countryFlag == null)
            {
                return HttpNotFound();
            }
            return View(countryFlag);
        }

        // GET: CountryFlags/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CountryFlags/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,CountryCode,Description")] CountryFlag countryFlag)
        {
            if (ModelState.IsValid)
            {

                string JSONtheCountryFlag = JsonConvert.SerializeObject(countryFlag);

                HttpContent content = new StringContent(JSONtheCountryFlag, Encoding.UTF8, "application/json");

                try
                {
                    using (HttpClient client = new HttpClient())
                    {
                        client.BaseAddress = new Uri(ConfigurationManager.AppSettings[ConfigurationParams.APIURL]);

                        HttpResponseMessage response = client.PostAsync(ConfigurationManager.AppSettings[ConfigurationParams.CountryFlagAPIURN], content).Result;

                        if (!response.IsSuccessStatusCode)
                        {
                            APIError aPIError = JsonConvert.DeserializeObject<APIError>(response.Content.ReadAsStringAsync().Result);
                            aPIError.MessageDetail += $"HTTP response: {response.StatusCode.ToString()}";
                            throw new Exception($"Message: {aPIError.Message} MessageDetail:{aPIError.MessageDetail}");
                        }
                    }
                    return RedirectToAction("Index");
                }
                catch (Exception ex)
                {
                    if (ex.Message.Equals("No Content"))
                    {
                        return RedirectToAction("Index");
                    }
                    else
                    {
                        string innerExceptions = String.Empty;
                        while (ex.InnerException != null)
                        {
                            innerExceptions += $"{ex.Message} ";
                            ex = ex.InnerException;
                        }
                        ViewBag.ViewError = String.Format(ConfigurationManager.AppSettings[ConfigurationParams.CountryFlagCreateAPIFailed], $"{ex.Message} {innerExceptions}");
                    }
                }
            }
            else
            {
                ViewBag.ViewError = ConfigurationManager.AppSettings[ConfigurationParams.CountryFlagCreateFormInvalid];
            }
            return View(countryFlag);
        }

        // GET: CountryFlags/Edit/5
        public ActionResult Edit(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            //CountryFlag countryFlag = db.CountryFlags.Find(id);
            CountryFlag countryFlag = new CountryFlag();
            if (countryFlag == null)
            {
                return HttpNotFound();
            }
            return View(countryFlag);
        }

        // POST: CountryFlags/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,CountryCode,Description")] CountryFlag countryFlag)
        {
            if (ModelState.IsValid)
            {
                //db.Entry(countryFlag).State = EntityState.Modified;
                //db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(countryFlag);
        }

        // GET: CountryFlags/Delete/5
        public ActionResult Delete(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            //CountryFlag countryFlag = db.CountryFlags.Find(id);
            CountryFlag countryFlag = new CountryFlag();
            if (countryFlag == null)
            {
                return HttpNotFound();
            }
            return View(countryFlag);
        }

        // POST: CountryFlags/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(Guid id)
        {
            //CountryFlag countryFlag = db.CountryFlags.Find(id);
            //db.CountryFlags.Remove(countryFlag);
            //db.SaveChanges();
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
