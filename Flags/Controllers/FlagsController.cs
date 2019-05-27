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
using Common.Helpers;
using Flags.Models;
using Models;
using Newtonsoft.Json;
using Microsoft.AspNet.Identity;

namespace Flags.Controllers
{
    public class FlagsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        


        // GET: Flags
        [Authorize]
        public ActionResult Index()
        {

            Dictionary<string, string> inbound = new Dictionary<string, string>();
            inbound["aspNetUserID"] = User.Identity.GetUserId();

            QuestionViewModel QVM = FlagsAPIClient.GetAsync<QuestionViewModel>(
                ConfigurationManager.AppSettings[ConfigurationParams.WCAPIURLScheme],
                ConfigurationManager.AppSettings[ConfigurationParams.WCAPIHost],
                ConfigurationParams.FlagQuestionURN,
                inbound
            );

            return View(QVM);

        }

        [Authorize]
        public ActionResult GetAll()
        {
            Dictionary<string, string> inbound = new Dictionary<string, string>();
            inbound["all"] = "3";


            List<Flag> fullList = FlagsAPIClient.GetAsync<List<Flag>>(
                ConfigurationManager.AppSettings[ConfigurationParams.WCAPIURLScheme],
                ConfigurationManager.AppSettings[ConfigurationParams.WCAPIHost],
                ConfigurationParams.FlagsAllURN,
                inbound

                ).OrderBy(x => x.Description).ToList();

                IEnumerable<IEnumerable<Flag>> thing = Paginate.splitList(fullList, 3);

                return View(thing);

        }


        //GET: Flags/Details/5
        public ActionResult Details(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            //Flag Flag = db.Flags.Find(id);
            Flag Flag = new Flag();
            if (Flag == null)
            {
                return HttpNotFound();
            }
            return View(Flag);
        }

        // GET: Flags/Create
        [Authorize(Roles = "badger")]
        public ActionResult Create()
        {
            return View();
        }

        // POST: Flags/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost,Authorize(Roles = "badger")]
        [ValidateAntiForgeryToken, ValidateInput(false)]
        public ActionResult Create([Bind(Include = "ID,CountryCode,Description")] Flag Flag)
        {
            if (ModelState.IsValid)
            {

                string JSONtheFlag = JsonConvert.SerializeObject(Flag);

                HttpContent content = new StringContent(JSONtheFlag, Encoding.UTF8, "application/json");

                using (HttpClient client = new HttpClient())
                {
                    client.BaseAddress = new Uri(ConfigurationManager.AppSettings[ConfigurationParams.WCAPIHost]);

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
                throw new Exception(ConfigurationManager.AppSettings[ConfigurationParams.WCFlagCreateFormInvalid]);
            }
        }

        // GET: Flags/Edit/5
        [Authorize(Roles = "badger")]
        public ActionResult Edit(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            //Flag Flag = db.Flags.Find(id);
            Flag Flag = new Flag();
            if (Flag == null)
            {
                return HttpNotFound();
            }
            return View(Flag);
        }

        // POST: Flags/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost,Authorize(Roles = "badger")]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,CountryCode,Description")] Flag Flag)
        {
            if (ModelState.IsValid)
            {
                //db.Entry(Flag).State = EntityState.Modified;
                //db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(Flag);
        }

        // GET: Flags/Delete/5
        [Authorize(Roles = "badger")]
        public ActionResult Delete(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            //Flag Flag = db.Flags.Find(id);
            Flag Flag = new Flag();
            if (Flag == null)
            {
                return HttpNotFound();
            }
            return View(Flag);
        }

        // POST: Flags/Delete/5
        [HttpPost, Authorize(Roles = "badger"), ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(Guid id)
        {
            //Flag Flag = db.Flags.Find(id);
            //db.Flags.Remove(Flag);
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
