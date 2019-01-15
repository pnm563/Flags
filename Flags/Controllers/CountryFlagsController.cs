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
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri(ConfigurationManager.AppSettings[ConfigurationParams.WCAPIURL]);

                HttpResponseMessage theResponse = client.GetAsync(ConfigurationParams.FlagsChunkedURN).Result;

                if (!theResponse.IsSuccessStatusCode)
                {
                    APIError aPIError = JsonConvert.DeserializeObject<APIError>(theResponse.Content.ReadAsStringAsync().Result);
                    aPIError.MessageDetail += $"HTTP response: {theResponse.StatusCode.ToString()} ";
                    throw new Exception($"Message: {aPIError.Message} MessageDetail:{aPIError.MessageDetail}");
                }

                return View(JsonConvert.DeserializeObject<IEnumerable<IEnumerable<CountryFlag>>>(theResponse.Content.ReadAsStringAsync().Result));
                
            }

            

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
        [ValidateAntiForgeryToken, ValidateInput(false)]
        public ActionResult Create([Bind(Include = "ID,CountryCode,Description")] CountryFlag countryFlag)
        {
            if (ModelState.IsValid)
            {

                string JSONtheCountryFlag = JsonConvert.SerializeObject(countryFlag);

                HttpContent content = new StringContent(JSONtheCountryFlag, Encoding.UTF8, "application/json");

                using (HttpClient client = new HttpClient())
                {
                    client.BaseAddress = new Uri(ConfigurationManager.AppSettings[ConfigurationParams.WCAPIURL]);

                    HttpResponseMessage response = client.PostAsync(ConfigurationParams.FlagsURN, content).Result;

                    if (!response.IsSuccessStatusCode)
                    {
                        APIError aPIError = JsonConvert.DeserializeObject<APIError>(response.Content.ReadAsStringAsync().Result);
                        aPIError.MessageDetail += $"HTTP response: {response.StatusCode.ToString()} ";
                        throw new Exception($"Message: {aPIError.Message} MessageDetail:{aPIError.MessageDetail}");
                    }
                }
                return RedirectToAction("Index");


            }
            else
            {
                throw new Exception(ConfigurationManager.AppSettings[ConfigurationParams.WCCountryFlagCreateFormInvalid]);
            }
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
