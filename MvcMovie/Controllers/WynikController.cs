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
    public class WynikController : Controller
    {
        private MovieDBContext db = new MovieDBContext();

        // GET: Wynik
        public ActionResult Index()
        {
            return View(db.WYNIK.ToList());
        }

        // GET: Wynik/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Wynik wynik = db.WYNIK.Find(id);
            if (wynik == null)
            {
                return HttpNotFound();
            }
            return View(wynik);
        }

        // GET: Wynik/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Wynik/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID_SPOTKANIA,ID_DRUZYNY,ID_PILKARZA,MINUTA_WYNIKU")] Wynik wynik)
        {
            if (ModelState.IsValid)
            {
                db.WYNIK.Add(wynik);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(wynik);
        }

        // GET: Wynik/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Wynik wynik = db.WYNIK.Find(id);
            if (wynik == null)
            {
                return HttpNotFound();
            }
            return View(wynik);
        }

        // POST: Wynik/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID_SPOTKANIA,ID_DRUZYNY,ID_PILKARZA,MINUTA_WYNIKU")] Wynik wynik)
        {
            if (ModelState.IsValid)
            {
                db.Entry(wynik).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(wynik);
        }

        // GET: Wynik/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Wynik wynik = db.WYNIK.Find(id);
            if (wynik == null)
            {
                return HttpNotFound();
            }
            return View(wynik);
        }

        // POST: Wynik/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Wynik wynik = db.WYNIK.Find(id);
            db.WYNIK.Remove(wynik);
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
