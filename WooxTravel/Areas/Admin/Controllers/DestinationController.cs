using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WooxTravel.Context;
using WooxTravel.Entities;

namespace WooxTravel.Areas.Admin.Controllers
{
    [Authorize] 
    public class DestinationController : Controller
    {
        TravelContext context = new TravelContext();
        public ActionResult DestinationList()
        {
            var values = context.Destinations.ToList();
            return View(values);
        }

        [HttpGet]
        public ActionResult CreateDestination()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateDestination(Destination destination)
        {
            context.Destinations.Add(destination);
            context.SaveChanges();
            return RedirectToAction("DestinationList", "Destination", "Admin");//Area olduğu için area ismini de eklemem gerekiyor.
        }
        public ActionResult DeleteDestination(int id)
        {
            var value = context.Destinations.Find(id);
            context.Destinations.Remove(value);
            context.SaveChanges();
            return RedirectToAction("DestinationList", "Destination", "Admin");
        }

        [HttpGet]
        public ActionResult UpdateDestination(int id)
        {
            var value = context.Destinations.Find(id);
            return View(value);
        }

        [HttpPost]
        public ActionResult UpdateDestination(Destination destination)
        {
            var value = context.Destinations.Find(destination.DestinationId);
            value.Description = destination.Description;
            value.City = destination.City;
            value.Country = destination.Country;
            value.DayNight = destination.DayNight;
            value.ImageUrl = destination.ImageUrl;
            value.Price = destination.Price;
            value.Title = destination.Title;
            context.SaveChanges();
            return RedirectToAction("DestinationList", "Destination", "Admin");
        }
    }
}