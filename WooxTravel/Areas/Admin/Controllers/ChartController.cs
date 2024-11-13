using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WooxTravel.Context;

namespace WooxTravel.Areas.Admin.Controllers
{
    public class ChartController : Controller
    {
        private TravelContext context = new TravelContext();
        public ActionResult Index()
        {
            var destinations = context.Destinations.Select(s => new
            {
                s.Title,
                s.Country,
                s.Price,
                s.Capacity,
            }).Take(4).ToList();

            ViewBag.DestinationDatas = destinations;
            return View();
        }
    }
}