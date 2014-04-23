using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CoderCampsExample.Models;

namespace CoderCampsExample.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            Point a;
            a.X = 0;
            a.Y = 3;
            Point b = new Point(3,5);
            Rectangle myRectangle = new Rectangle(a, b);
            int area = myRectangle.Area();

            Days day = Days.Sun;
            int dayNum = (int)Days.Sun;
            day++;

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}