using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CoderCampsExample.Models;

namespace CoderCampsExample.Controllers
{
    public class CampController : Controller
    {
        //
        // GET: /Camp/
        public ActionResult Index()
        {
            CampIndexVM model = new CampIndexVM();
            model.Title = "Welcome to Coder Camps";
            model.Troops = new List<Troop>()
            {
                new Troop(){ Id=1, LocationId=1, StartDate= DateTime.Today},
                new Troop(){ Id=2, LocationId=1, StartDate= DateTime.Today.AddDays(30)},
                new Troop(){ Id=3, LocationId=2, StartDate= DateTime.Today.AddDays(60)}
            };
            model.Locations = new List<Location>()
            {
                new Location(){Id=1, Address="1234", ClassRoom="2", Picture="http://4.bp.blogspot.com/-aveBBBgPDI4/U0_66V4rA8I/AAAAAAAAAX8/YPv-yuPZoNk/s1600/javascript_logo_unofficial-300x300.png"},
                new Location(){Id=2, Address="3456", ClassRoom="4", Picture="http://4.bp.blogspot.com/-aveBBBgPDI4/U0_66V4rA8I/AAAAAAAAAX8/YPv-yuPZoNk/s1600/javascript_logo_unofficial-300x300.png"}
            };
            model.Campers = new List<Camper>(){
                new Camper(){ TroopId=1, Email="camper@mail", Gender='M', isActive=true, Name="John"},
                new Camper(){ TroopId=2, Email="camper@mail", Gender='M', isActive=true, Name="Jack"},
                new Camper(){ TroopId=3, Email="camper@mail", Gender='F', isActive=true, Name="Jane"},
                new Camper(){ TroopId=2, Email="camper@mail", Gender='F', isActive=true, Name="Joan"},
                new Camper(){ TroopId=1, Email="camper@mail", Gender='M', isActive=true, Name="Jeff"}
            };

            return View(model);
        }
	}
}