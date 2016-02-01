using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using RichF1.Models;

namespace RichF1.Controllers
{
    public class SponsorController : Controller
    {
        private RichF1ModelContext db = new RichF1ModelContext();

        // GET: Sponsor
        public ActionResult Index()
        {
            return View(db.Sponsors.ToList());
        }

        // GET: Sponsor/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Sponsor sponsor = db.Sponsors.Find(id);
            if (sponsor == null)
            {
                return HttpNotFound();
            }
            return View(sponsor);
        }

        // GET: Sponsor/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Sponsor/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "SponsorId,SponsorName,SponsorCountry,DateFounded")] Sponsor sponsor)
        {
            if (ModelState.IsValid)
            {
                db.Sponsors.Add(sponsor);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(sponsor);
        }

        // GET: Sponsor/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Sponsor sponsor = db.Sponsors.Find(id);
            if (sponsor == null)
            {
                return HttpNotFound();
            }
            return View(sponsor);
        }

        // POST: Sponsor/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "SponsorId,SponsorName,SponsorCountry,DateFounded")] Sponsor sponsor)
        {
            if (ModelState.IsValid)
            {
                db.Entry(sponsor).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(sponsor);
        }

        // GET: Sponsor/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Sponsor sponsor = db.Sponsors.Find(id);
            if (sponsor == null)
            {
                return HttpNotFound();
            }
            return View(sponsor);
        }

        // POST: Sponsor/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Sponsor sponsor = db.Sponsors.Find(id);
            db.Sponsors.Remove(sponsor);
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
