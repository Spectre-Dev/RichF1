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
    public class RaceTrackController : Controller
    {
        private RichF1ModelContext db = new RichF1ModelContext();

        // GET: RaceTrack
        public ActionResult Index()
        {
            return View(db.RaceTracks.ToList());
        }

        // GET: RaceTrack/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RaceTrack raceTrack = db.RaceTracks.Find(id);
            if (raceTrack == null)
            {
                return HttpNotFound();
            }
            return View(raceTrack);
        }

        // GET: RaceTrack/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: RaceTrack/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "RaceTrackId,Trackname,RaceTrackNum,Location,EstablishedDate,RaceMonth")] RaceTrack raceTrack)
        {
            if (ModelState.IsValid)
            {
                db.RaceTracks.Add(raceTrack);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(raceTrack);
        }

        // GET: RaceTrack/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RaceTrack raceTrack = db.RaceTracks.Find(id);
            if (raceTrack == null)
            {
                return HttpNotFound();
            }
            return View(raceTrack);
        }

        // POST: RaceTrack/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "RaceTrackId,Trackname,RaceTrackNum,Location,EstablishedDate,RaceMonth")] RaceTrack raceTrack)
        {
            if (ModelState.IsValid)
            {
                db.Entry(raceTrack).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(raceTrack);
        }

        // GET: RaceTrack/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RaceTrack raceTrack = db.RaceTracks.Find(id);
            if (raceTrack == null)
            {
                return HttpNotFound();
            }
            return View(raceTrack);
        }

        // POST: RaceTrack/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            RaceTrack raceTrack = db.RaceTracks.Find(id);
            db.RaceTracks.Remove(raceTrack);
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
