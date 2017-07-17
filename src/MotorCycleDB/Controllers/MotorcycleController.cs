using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MotorCycleDB.Models;
using MotorCycleDB.Data;

namespace MotorCycleDB.Controllers
{
    public class MotorcycleController : Controller
    {
        private MotorCycleDBContext db = new MotorCycleDBContext();

        // GET: Motorcycle
        public ActionResult Index()
        {
            return View(db.Motorcycles.ToList());
        }

        // GET: Motorcycle/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Motorcycle motorcycle = db.Motorcycles.Find(id);
            if (motorcycle == null)
            {
                return HttpNotFound();
            }
            return View(motorcycle);
        }

        // GET: Motorcycle/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Motorcycle/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Mfg,ModelId,ModelYear,Engine,Horsepower,Torque,Weight,Style,Description")] Motorcycle motorcycle)
        {
            if (ModelState.IsValid)
            {
                db.Motorcycles.Add(motorcycle);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(motorcycle);
        }

        // GET: Motorcycle/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Motorcycle motorcycle = db.Motorcycles.Find(id);
            if (motorcycle == null)
            {
                return HttpNotFound();
            }
            return View(motorcycle);
        }

        // POST: Motorcycle/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Mfg,ModelId,ModelYear,Engine,Horsepower,Torque,Weight,Style,Description")] Motorcycle motorcycle)
        {
            if (ModelState.IsValid)
            {
                db.Entry(motorcycle).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(motorcycle);
        }

        // GET: Motorcycle/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Motorcycle motorcycle = db.Motorcycles.Find(id);
            if (motorcycle == null)
            {
                return HttpNotFound();
            }
            return View(motorcycle);
        }

        // POST: Motorcycle/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Motorcycle motorcycle = db.Motorcycles.Find(id);
            db.Motorcycles.Remove(motorcycle);
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
