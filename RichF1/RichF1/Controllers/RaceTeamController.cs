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
    public class RaceTeamController : Controller
    {
        private RichF1ModelContext db = new RichF1ModelContext();

        // GET: RaceTeam
        public ActionResult Index()
        {
            return View(db.RaceTeams.ToList());
        }

        // GET: RaceTeam/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RaceTeam raceTeam = db.RaceTeams.Find(id);
            if (raceTeam == null)
            {
                return HttpNotFound();
            }
            return View(raceTeam);
        }

        // GET: RaceTeam/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: RaceTeam/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "RaceTeamId,RaceTeamName,RaceTeamNum,RaceTeamNation,EngineMaker,TyreMaker,ChampionshipWins,EstablishedDate")] RaceTeam raceTeam)
        {
            if (ModelState.IsValid)
            {
                db.RaceTeams.Add(raceTeam);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(raceTeam);
        }

        // GET: RaceTeam/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RaceTeam raceTeam = db.RaceTeams.Find(id);
            if (raceTeam == null)
            {
                return HttpNotFound();
            }
            return View(raceTeam);
        }

        // POST: RaceTeam/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "RaceTeamId,RaceTeamName,RaceTeamNum,RaceTeamNation,EngineMaker,TyreMaker,ChampionshipWins,EstablishedDate")] RaceTeam raceTeam)
        {
            if (ModelState.IsValid)
            {
                db.Entry(raceTeam).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(raceTeam);
        }

        // GET: RaceTeam/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RaceTeam raceTeam = db.RaceTeams.Find(id);
            if (raceTeam == null)
            {
                return HttpNotFound();
            }
            return View(raceTeam);
        }

        // POST: RaceTeam/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            RaceTeam raceTeam = db.RaceTeams.Find(id);
            db.RaceTeams.Remove(raceTeam);
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
