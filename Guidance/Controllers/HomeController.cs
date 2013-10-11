using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Guidance.Models;
using Guidance.Data;



namespace Guidance.Controllers
{
    public class HomeController : Controller
    {
        private MasonicEntities db = new MasonicEntities();

        public ActionResult Index()
        {
            ViewBag.Message = "Travel, Travel, Travel.";

            ViewBag.Longitude = "28.839862";
            ViewBag.Latitude = "-81.120847";
            
            ViewBag.LodgeType = "SquareAndCompasses.png";
            return View(db.Dinners.ToList());
           // return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your quintessential app description page.";

            return View();
        }

        public ActionResult WhereAmI()
        {
            
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your quintessential contact page.";

            return View();
        }

        public ActionResult FindRoute(string waypointString)
        {
            BingRoutes route = new BingRoutes();
            //waypointString = "28.839862,-81.120847; 28.671791,-81.217450";
            ViewBag.Message = route.CreateRoute(waypointString);

            return View();
        }
    }
}
