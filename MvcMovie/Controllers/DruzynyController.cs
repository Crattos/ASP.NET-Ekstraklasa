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
    public class DruzynyController : Controller
    {
        private MovieDBContext db = new MovieDBContext();

        // GET: Druzyny
        public ActionResult Index()
        {
            return View(db.DRUZYNY.ToList());
        }

        // GET: Druzyny/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Druzyny druzyny = db.DRUZYNY.Find(id);
            if (druzyny == null)
            {
                return HttpNotFound();
            }
            return View(druzyny);
        }

        // GET: Druzyny/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Druzyny/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID_DRUZYNY,ID_MIASTA,NAZWA_DRUZYNY,PUNKTY,BRAMKI,ILOSC_SPOTKAN")] Druzyny druzyny)
        {
            if (ModelState.IsValid)
            {
                db.DRUZYNY.Add(druzyny);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(druzyny);
        }

        // GET: Druzyny/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Druzyny druzyny = db.DRUZYNY.Find(id);
            if (druzyny == null)
            {
                return HttpNotFound();
            }
            return View(druzyny);
        }

        // POST: Druzyny/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID_DRUZYNY,ID_MIASTA,NAZWA_DRUZYNY,PUNKTY,BRAMKI,ILOSC_SPOTKAN")] Druzyny druzyny)
        {
            if (ModelState.IsValid)
            {
                db.Entry(druzyny).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(druzyny);
        }

        // GET: Druzyny/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Druzyny druzyny = db.DRUZYNY.Find(id);
            if (druzyny == null)
            {
                return HttpNotFound();
            }
            return View(druzyny);
        }

        // POST: Druzyny/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Druzyny druzyny = db.DRUZYNY.Find(id);
            db.DRUZYNY.Remove(druzyny);
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
