using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WooxTravel.Context;

namespace WooxTravel.Areas.Admin.Controllers
{
    public class AdminLayoutController : Controller
    {
        TravelContext context = new TravelContext();
        public ActionResult Index()
        {
            return View();
        }
        public PartialViewResult PartialHead()
        {
            return PartialView();
        }
        public PartialViewResult PartialSidebar()
        {
            return PartialView();
        }
        public PartialViewResult PartialNavbar()
        {
            return PartialView();
        }
        public PartialViewResult PartialFooter()
        {
            return PartialView();
        }
        public PartialViewResult PartialScript()
        {
            return PartialView();
        }

        public PartialViewResult NavbarMessages()
        {
            var userInfo = Session["userInfo"];
            var email = context.Admins.Where(s=>s.Username==userInfo).Select(s=>s.Email).FirstOrDefault();
            var valueofIncomingMessages = context.Messages.Where(s=>s.ReceiverMail==email).ToList();
            var numberofIncomingMessages = context.Messages.Where(s=>s.ReceiverMail==email).Count();
            ViewBag.MessageCount = numberofIncomingMessages;
            return PartialView(valueofIncomingMessages);
        }
        public PartialViewResult NavbarNotificationsForDestination()
        {
            var recentDestinations = context.Destinations.OrderByDescending(s=>s.DestinationId).Take(4).ToList();
            return PartialView(recentDestinations);
        }
    }
}