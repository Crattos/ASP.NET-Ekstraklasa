using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MvcMovie.Models;

namespace MvcMovie.Controllers
{
    public class PilkarzeController : Controller
    {
        private MovieDBContext db = new MovieDBContext();

        // GET: Pilkarze
        public ActionResult Index()
        {
            return View(db.PILKARZE.ToList());
        }

        // GET: Pilkarze/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Pilkarze pilkarze = db.PILKARZE.Find(id);
            if (pilkarze == null)
            {
                return HttpNotFound();
            }
            return View(pilkarze);
        }

        // GET: Pilkarze/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Pilkarze/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID_PILKARZA,ID_DRUZYNY,IMIE_PILKARZA,NAZWISKO_PILKARZA,WIEK_PILKARZA,POZYCJA,NARODOWOSC_PILKARZA")] Pilkarze pilkarze)
        {
            if (ModelState.IsValid)
            {
                db.PILKARZE.Add(pilkarze);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(pilkarze);
        }

        // GET: Pilkarze/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Pilkarze pilkarze = db.PILKARZE.Find(id);
            if (pilkarze == null)
            {
                return HttpNotFound();
            }
            return View(pilkarze);
        }

        // POST: Pilkarze/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID_PILKARZA,ID_DRUZYNY,IMIE_PILKARZA,NAZWISKO_PILKARZA,WIEK_PILKARZA,POZYCJA,NARODOWOSC_PILKARZA")] Pilkarze pilkarze)
        {
            if (ModelState.IsValid)
            {
                db.Entry(pilkarze).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(pilkarze);
        }

        // GET: Pilkarze/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Pilkarze pilkarze = db.PILKARZE.Find(id);
            if (pilkarze == null)
            {
                return HttpNotFound();
            }
            return View(pilkarze);
        }

        // POST: Pilkarze/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Pilkarze pilkarze = db.PILKARZE.Find(id);
            db.PILKARZE.Remove(pilkarze);
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
