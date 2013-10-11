using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Guidance.Data;
using Guidance.Models;

namespace Guidance.Controllers
{
    public class LodgeController : Controller
    {
        private MasonicEntities db = new MasonicEntities();

        //
        // GET: /Lodge/

        public ActionResult Index()
        {
            return View(db.Dinners.ToList());
        }


        public ActionResult FindRoute(string waypointString)
        {
            BingRoutes route = new BingRoutes();
            //waypointString = "28.839862,-81.120847; 28.671791,-81.217450";
            ViewBag.Message = route.CreateRoute(waypointString);

            return View();
        }

        public ActionResult FindLodge(string searchString)
        {
            BingRoutes route = new BingRoutes();
            //searchString = "Masonic;Lodge;Osteen;FL";
            ViewBag.Message = route.SearchKeywordLocation(searchString);
            
            return View();
        }

        public ActionResult showLodge(string waypointString)
        {
            BingRoutes route = new BingRoutes();
            ViewBag.Message = route.GetImagery(waypointString);
            return View();
        }

        public ActionResult ShowMap()
        {
            return View();
        }

        //
        // GET: /Lodge/Details/5

        public ActionResult Details(int id = 0)
        {
            Dinner dinner = db.Dinners.Single(d => d.DinnerID == id);
            if (dinner == null)
            {
                return HttpNotFound();
            }
            return View(dinner);
        }

        //
        // GET: /Lodge/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Lodge/Create

        [HttpPost]
        public ActionResult Create(Dinner dinner)
        {
            if (ModelState.IsValid)
            {
                db.Dinners.AddObject(dinner);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(dinner);
        }

        //
        // GET: /Lodge/Edit/5

        public ActionResult Edit(int id = 0)
        {
            Dinner dinner = db.Dinners.Single(d => d.DinnerID == id);
            if (dinner == null)
            {
                return HttpNotFound();
            }
            return View(dinner);
        }

        //
        // POST: /Lodge/Edit/5

        [HttpPost]
        public ActionResult Edit(Dinner dinner)
        {
            if (ModelState.IsValid)
            {
                db.Dinners.Attach(dinner);
                db.ObjectStateManager.ChangeObjectState(dinner, EntityState.Modified);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(dinner);
        }

        //
        // GET: /Lodge/Delete/5

        public ActionResult Delete(int id = 0)
        {
            Dinner dinner = db.Dinners.Single(d => d.DinnerID == id);
            if (dinner == null)
            {
                return HttpNotFound();
            }
            return View(dinner);
        }

        //
        // POST: /Lodge/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            Dinner dinner = db.Dinners.Single(d => d.DinnerID == id);
            db.Dinners.DeleteObject(dinner);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}