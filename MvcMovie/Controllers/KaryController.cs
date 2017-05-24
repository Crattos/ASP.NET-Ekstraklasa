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
    public class KaryController : Controller
    {
        private MovieDBContext db = new MovieDBContext();

        // GET: Kary
        public ActionResult Index()
        {
            return View(db.KARY.ToList());
        }

        // GET: Kary/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Kary kary = db.KARY.Find(id);
            if (kary == null)
            {
                return HttpNotFound();
            }
            return View(kary);
        }

        // GET: Kary/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Kary/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID_PILKARZA,ID_SPOTKANIA,ID_DRUZYNY,MINUTA_KARY,KARA")] Kary kary)
        {
            if (ModelState.IsValid)
            {
                db.KARY.Add(kary);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(kary);
        }

        // GET: Kary/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Kary kary = db.KARY.Find(id);
            if (kary == null)
            {
                return HttpNotFound();
            }
            return View(kary);
        }

        // POST: Kary/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID_PILKARZA,ID_SPOTKANIA,ID_DRUZYNY,MINUTA_KARY,KARA")] Kary kary)
        {
            if (ModelState.IsValid)
            {
                db.Entry(kary).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(kary);
        }

        // GET: Kary/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Kary kary = db.KARY.Find(id);
            if (kary == null)
            {
                return HttpNotFound();
            }
            return View(kary);
        }

        // POST: Kary/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Kary kary = db.KARY.Find(id);
            db.KARY.Remove(kary);
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
