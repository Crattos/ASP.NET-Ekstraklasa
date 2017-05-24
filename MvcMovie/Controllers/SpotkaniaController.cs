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
    public class SpotkaniaController : Controller
    {
        private MovieDBContext db = new MovieDBContext();

        // GET: Spotkania
        public ActionResult Index()
        {
            return View(db.SPOTKANIA.ToList());
        }

        // GET: Spotkania/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Spotkania spotkania = db.SPOTKANIA.Find(id);
            if (spotkania == null)
            {
                return HttpNotFound();
            }
            return View(spotkania);
        }

        // GET: Spotkania/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Spotkania/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID_SPOTKANIA,ID_DRUZYNY,ID_MIASTA,DRU_ID_DRUZYNY,BRAMKI_D1,BRAMKI_D2,DATA_SPOTKANIA")] Spotkania spotkania)
        {
            if (ModelState.IsValid)
            {
                db.SPOTKANIA.Add(spotkania);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(spotkania);
        }

        // GET: Spotkania/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Spotkania spotkania = db.SPOTKANIA.Find(id);
            if (spotkania == null)
            {
                return HttpNotFound();
            }
            return View(spotkania);
        }

        // POST: Spotkania/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID_SPOTKANIA,ID_DRUZYNY,ID_MIASTA,DRU_ID_DRUZYNY,BRAMKI_D1,BRAMKI_D2,DATA_SPOTKANIA")] Spotkania spotkania)
        {
            if (ModelState.IsValid)
            {
                db.Entry(spotkania).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(spotkania);
        }

        // GET: Spotkania/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Spotkania spotkania = db.SPOTKANIA.Find(id);
            if (spotkania == null)
            {
                return HttpNotFound();
            }
            return View(spotkania);
        }

        // POST: Spotkania/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Spotkania spotkania = db.SPOTKANIA.Find(id);
            db.SPOTKANIA.Remove(spotkania);
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
