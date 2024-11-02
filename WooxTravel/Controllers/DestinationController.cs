using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WooxTravel.Context;

namespace WooxTravel.Controllers
{
    public class DestinationController : Controller
    {
        TravelContext context = new TravelContext();
        public ActionResult DestinationList()
        {
            var values = context.Destinations.ToList();
            return View(values);
        }
        public ActionResult DestinationDetail(int id)
        {
            var value = context.Destinations.Where(s=>s.DestinationId == id).FirstOrDefault();
            return View(value);
        }
    }
}