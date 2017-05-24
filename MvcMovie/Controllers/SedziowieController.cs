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
    public class SedziowieController : Controller
    {
        private MovieDBContext db = new MovieDBContext();

        // GET: Sedziowie
        public ActionResult Index()
        {
            return View(db.SEDZIOWIE.ToList());
        }

        // GET: Sedziowie/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Sedziowie sedziowie = db.SEDZIOWIE.Find(id);
            if (sedziowie == null)
            {
                return HttpNotFound();
            }
            return View(sedziowie);
        }

        // GET: Sedziowie/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Sedziowie/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID_SEDZI,IMIE_SEDZI,NAZWISKO_SEDZI")] Sedziowie sedziowie)
        {
            if (ModelState.IsValid)
            {
                db.SEDZIOWIE.Add(sedziowie);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(sedziowie);
        }

        // GET: Sedziowie/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Sedziowie sedziowie = db.SEDZIOWIE.Find(id);
            if (sedziowie == null)
            {
                return HttpNotFound();
            }
            return View(sedziowie);
        }

        // POST: Sedziowie/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID_SEDZI,IMIE_SEDZI,NAZWISKO_SEDZI")] Sedziowie sedziowie)
        {
            if (ModelState.IsValid)
            {
                db.Entry(sedziowie).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(sedziowie);
        }

        // GET: Sedziowie/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Sedziowie sedziowie = db.SEDZIOWIE.Find(id);
            if (sedziowie == null)
            {
                return HttpNotFound();
            }
            return View(sedziowie);
        }

        // POST: Sedziowie/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Sedziowie sedziowie = db.SEDZIOWIE.Find(id);
            db.SEDZIOWIE.Remove(sedziowie);
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
