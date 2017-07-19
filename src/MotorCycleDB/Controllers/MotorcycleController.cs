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

// Motorcycle Controller class.  Directs the app to the Create, Edit, Delete, Details, and Index (MC list) views.

namespace MotorCycleDB.Controllers
{
    public class MotorcycleController : Controller
    {
        private MotorCycleDBContext db = new MotorCycleDBContext();

        // Displays list of all Motorcycles in database
        public ActionResult Index()
        {
            return View(db.Motorcycles.ToList());
        }

        // Displays detail page of selected motorcycle
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

        // Displays the Create motorcycle form
        public ActionResult Create()
        {
            return View();
        }

        //Create new motorcycle entry
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

        // returns edit view for selected motorcycle
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

        // Saves changes to motorcycle record
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

        // Pulls up the Delete view
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

        // Actually deletes the Motorcycle record from the database

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
