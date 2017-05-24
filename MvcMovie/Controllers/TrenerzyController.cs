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
    public class TrenerzyController : Controller
    {
        private MovieDBContext db = new MovieDBContext();

        // GET: Trenerzy
        public ActionResult Index()
        {
            return View(db.TRENERZY.ToList());
        }

        // GET: Trenerzy/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Trenerzy trenerzy = db.TRENERZY.Find(id);
            if (trenerzy == null)
            {
                return HttpNotFound();
            }
            return View(trenerzy);
        }

        // GET: Trenerzy/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Trenerzy/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID_TRENERA,ID_DRUZYNY,IMIE_TRENERA,NAZWISKO_TRENERA,WIEK_TRENERA,NARODOWOSC_TRENERA")] Trenerzy trenerzy)
        {
            if (ModelState.IsValid)
            {
                db.TRENERZY.Add(trenerzy);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(trenerzy);
        }

        // GET: Trenerzy/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Trenerzy trenerzy = db.TRENERZY.Find(id);
            if (trenerzy == null)
            {
                return HttpNotFound();
            }
            return View(trenerzy);
        }

        // POST: Trenerzy/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID_TRENERA,ID_DRUZYNY,IMIE_TRENERA,NAZWISKO_TRENERA,WIEK_TRENERA,NARODOWOSC_TRENERA")] Trenerzy trenerzy)
        {
            if (ModelState.IsValid)
            {
                db.Entry(trenerzy).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(trenerzy);
        }

        // GET: Trenerzy/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Trenerzy trenerzy = db.TRENERZY.Find(id);
            if (trenerzy == null)
            {
                return HttpNotFound();
            }
            return View(trenerzy);
        }

        // POST: Trenerzy/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Trenerzy trenerzy = db.TRENERZY.Find(id);
            db.TRENERZY.Remove(trenerzy);
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
