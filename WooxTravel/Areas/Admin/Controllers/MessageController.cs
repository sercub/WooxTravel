using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WooxTravel.Context;
using WooxTravel.Entities;

namespace WooxTravel.Areas.Admin.Controllers
{
    public class MessageController : Controller
    {
        TravelContext context = new TravelContext();
        public ActionResult Inbox()
        {
            var a = Session["userInfo"]; //giriş yapan kişinin kullanıcı adı
            var email = context.Admins.Where(s=>s.Username==a).Select(s=>s.Email).FirstOrDefault(); //bu kullanıcının emaili
            var values = context.Messages.Where(s => s.ReceiverMail == email).ToList(); //bu emaile ait gelen kutusu 
            return View(values);
        }
        public ActionResult SendBox()
        {
            var a = Session["userInfo"]; //giriş yapan kişinin kullanıcı adı
            var email = context.Admins.Where(s => s.Username == a).Select(s => s.Email).FirstOrDefault(); //bu kullanıcının emaili
            var values = context.Messages.Where(s => s.SenderMail == email).ToList(); //bu emailden gönderilen mesajlara ait mailler
            return View(values);
        }
        public ActionResult SendMessage()
        {
            return View();
        }

        [HttpPost]
        public ActionResult SendMessage(Message message)
        {
            var a = Session["userInfo"]; 
            var email = context.Admins.Where(s => s.Username == a).Select(s => s.Email).FirstOrDefault();
            message.SenderMail = email; //mesajın göndericisi login olan kullanıcı olur.
            message.SendDate = DateTime.Now;
            message.IsRead = false;
            context.Messages.Add(message);
            context.SaveChanges();  
            return RedirectToAction("SendBox", "Message", new { area = "Admin" });
        }
    }
}