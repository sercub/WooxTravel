using System.Linq;
using System.Web.Mvc;
using WooxTravel.Context;

namespace WooxTravel.Areas.Admin.Controllers
{
    public class StatisticController : Controller
    {
        private TravelContext context = new TravelContext();

        public ActionResult Index()
        {
            var userInfo = Session["x"];

            var email = context.Admins.Where(s=>s.Username==userInfo).Select(l=>l.Email).FirstOrDefault();

            var totalDestinations = context.Destinations.Count();
            var longestTourDuration = context.Destinations.Max(d => (int?)d.DayNight) ?? 0; 
            var mostExpensiveTour = context.Destinations.OrderByDescending(d => d.Price).FirstOrDefault()?.Title;
            var sendBoxMessageCount = context.Messages.Where(x => x.SenderMail == email) .ToList().Count();
            var receivedMessagesCount = context.Messages.Where(x => x.ReceiverMail == email).ToList().Count();

            var maxTourCapacity = context.Destinations.Max(d => d.Capacity);
            var totalCategories = context.Categories.Count();

            var thankYouMessagesCount = context.Messages.Count(m => m.Subject.Contains("Teşekkür"));
            var totalAdmins = context.Admins.Count(); 
            var internationalToursCount = context.Destinations.Count(d => d.Country != "Türkiye"); 
            var totalMessages = context.Messages.Count();
            var complaintMessagesCount = context.Messages.Count(m => m.Subject.Contains("Şikayet"));

            ViewBag.TotalDestinations = totalDestinations;
            ViewBag.MostExpensiveTour = mostExpensiveTour;
            ViewBag.SentMessagesCount = sendBoxMessageCount;
            ViewBag.ReceivedMessagesCount = receivedMessagesCount;


            ViewBag.MaxTourCapacity = maxTourCapacity;
            ViewBag.TotalCategories = totalCategories;

            ViewBag.ThankYouMessagesCount = thankYouMessagesCount;
            ViewBag.TotalAdmins = totalAdmins;
            ViewBag.InternationalToursCount = internationalToursCount;
            ViewBag.TotalMessages = totalMessages;
            ViewBag.ComplaintMessagesCount = complaintMessagesCount;
            ViewBag.DayNightCount = longestTourDuration;

            return View();
        }
    }
}
