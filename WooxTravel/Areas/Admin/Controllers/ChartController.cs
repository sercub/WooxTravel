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
            return View();
        }
        public JsonResult ChartData()
        {
            var capacityCounts = context.Destinations
                .GroupBy(s => s.City)
                .Select(l => new { City = l.Key, Capacity = l.Sum(n=>n.Capacity) })
                .ToList();

            return Json(capacityCounts, JsonRequestBehavior.AllowGet);

        }
        public JsonResult RadarChartData()
        {
            var radarData = context.Destinations
                .Select(d => new { d.City, d.Capacity }) 
                .ToList();
            var labels = radarData.Select(d => d.City).ToArray(); 
            var data = radarData.Select(d => d.Capacity).ToArray(); 

            return Json(new { labels, data }, JsonRequestBehavior.AllowGet);
        }
        public JsonResult LineChartData()
        {
            var lineData = context.Destinations
                .Select(d => new { d.City, d.Capacity }) // Şehir ve kapasite değerlerini direkt alıyoruz
                .ToList();

            var labels = lineData.Select(d => d.City).ToArray(); // Şehir isimleri
            var data = lineData.Select(d => d.Capacity).ToArray(); // Kapasiteler

            return Json(new { labels, data }, JsonRequestBehavior.AllowGet);
        }
        public JsonResult PieChartData()
        {
            var priceCounts = context.Destinations
            .GroupBy(s => s.City)
            .Select(l => new { City = l.Key, Price = l.Sum(n => n.Price) })
            .ToList();

            return Json(priceCounts, JsonRequestBehavior.AllowGet);
        }

    }
}