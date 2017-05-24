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
    public class MiastaController : Controller
    {
        private MovieDBContext db = new MovieDBContext();

        // GET: Miasta
        public ActionResult Index()
        {
            return View(db.MIASTA.ToList());
        }

        // GET: Miasta/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Miasta miasta = db.MIASTA.Find(id);
            if (miasta == null)
            {
                return HttpNotFound();
            }
            return View(miasta);
        }

        // GET: Miasta/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Miasta/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID_MIASTA,NAZWA_MIASTA")] Miasta miasta)
        {
            if (ModelState.IsValid)
            {
                db.MIASTA.Add(miasta);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(miasta);
        }

        // GET: Miasta/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Miasta miasta = db.MIASTA.Find(id);
            if (miasta == null)
            {
                return HttpNotFound();
            }
            return View(miasta);
        }

        // POST: Miasta/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID_MIASTA,NAZWA_MIASTA")] Miasta miasta)
        {
            if (ModelState.IsValid)
            {
                db.Entry(miasta).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(miasta);
        }

        // GET: Miasta/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Miasta miasta = db.MIASTA.Find(id);
            if (miasta == null)
            {
                return HttpNotFound();
            }
            return View(miasta);
        }

        // POST: Miasta/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Miasta miasta = db.MIASTA.Find(id);
            db.MIASTA.Remove(miasta);
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
