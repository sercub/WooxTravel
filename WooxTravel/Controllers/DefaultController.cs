using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WooxTravel.Context;
using PagedList;

namespace WooxTravel.Controllers
{
    public class DefaultController : Controller
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
        public PartialViewResult PartialScript()
        {
            return PartialView();
        }
        public PartialViewResult PartialNavbar()
        {
            return PartialView();
        }
        public PartialViewResult PartialBanner()
        {
            var values = context.Destinations.ToList();
            return PartialView(values);
        }
        public PartialViewResult PartialCountry(int page = 1)
        {
            var values = context.Destinations.ToList().ToPagedList(page,2);
            return PartialView(values);
        }
        public ActionResult DestinationDetail(int id)
        {
            var value = context.Destinations.FirstOrDefault(s=>s.DestinationId==id);
            if(value.City=="Viyana")
            {
                ViewBag.SliderImages = new List<SliderImage>
            {
                new SliderImage{ Title="Schönbrunn Sarayı", ImageUrl="https://www.peyzax.com/wp-content/uploads/2021/04/Ehrenhof_Brunnen_West.jpeg"},
                new SliderImage{ Title="St. Stephen Katedrali", ImageUrl="https://media.istockphoto.com/id/1431999430/photo/st-stephens-cathedral-on-stephansplatz-square-at-sunrise-vienna-austria.jpg?s=612x612&w=0&k=20&c=6FsSIzq8FZtKUsk5FgfNaGRVFqkQ12WhEmvaLR3AD_0="},
                new SliderImage{ Title="Belvedere Sarayı ve Bahçeleri", ImageUrl="https://www.peyzax.com/wp-content/uploads/2021/04/thumb-1920-595628.jpeg"},
                new SliderImage{ Title="Viyana Opera Binası", ImageUrl="https://www.interbustur.com/wp-content/uploads/2016/06/viyana-opera-binas%C4%B1.jpg"}
            };
            }
            else if(value.City=="Stockholm")
            {
                ViewBag.SliderImages = new List<SliderImage>
            {
                new SliderImage{ Title="Gamla Stan", ImageUrl="https://cdn.getyourguide.com/img/tour/2b4d69dac5f0f3ed6d7ebb5bc7714a54796bfd102b5eb91a77ff60ddacd2a1d9.jpg/146.jpg"},
                new SliderImage{ Title="Vasa Müzesi", ImageUrl="https://dynamic-media-cdn.tripadvisor.com/media/photo-o/18/2e/17/99/smtm.jpg?w=1200&h=-1&s=1"},
                new SliderImage{ Title="Djurgården Adası", ImageUrl="https://gezimanya.com/sites/default/files/styles/800x600_/public/gezilecek-yerler/2020-01/djurgarden-adasi.jpg"},
                new SliderImage{ Title="Stockholm Kraliyet Sarayı", ImageUrl="https://cdn.ytur.net/fit-in/697x465/filters:quality(100)/filters:format(webp)/post/stockholm-sarayi-1-220403-215818-0968.jpg"}
            };
            }
            else if(value.City=="Münih")
            {
                ViewBag.SliderImages = new List<SliderImage>
                {
                  new SliderImage { Title = "Marienplatz Meydanı", ImageUrl = "https://cdn.ytur.net/post/marien-meydani-220316-144438-1170.jpg" },
                  new SliderImage { Title = "Englischer Garten", ImageUrl = "https://www.abendzeitung-muenchen.de/storage/image/2/1/0/7/1337012_default_1ACZQZ_5wuGG0.jpg" },
                  new SliderImage { Title = "Nymphenburg Sarayı", ImageUrl = "https://dynamic-media-cdn.tripadvisor.com/media/photo-o/0f/8a/e0/fa/the-palace-outside-view.jpg?w=1200&h=-1&s=1" },
                  new SliderImage { Title = "Deutsches Museum", ImageUrl = "https://dynamic-media-cdn.tripadvisor.com/media/photo-o/0a/59/13/07/deutsches-museum.jpg?w=1200&h=-1&s=1" }
                };
            }
            else
            {
                ViewBag.SliderImages = new List<SliderImage>
                {
                  new SliderImage { Title = "Göreme Milli Parkı", ImageUrl = "https://www.pandaalu.com.tr/uploads/images/haberler/1671460093_goreme-kapadokya.jpg?1671460094" },
                  new SliderImage { Title = "Uçhisar Kalesi", ImageUrl = "https://gezginkolik.com/wp-content/uploads/2022/07/uchisar-kalesi-nerede.jpeg" },
                  new SliderImage { Title = "Çavuşin Köyü", ImageUrl = "https://cappadocia4u.com/tr/wp-content/uploads/cavusin2.jpg" },
                  new SliderImage { Title = "Avanos Çömlek Atölyeleri", ImageUrl = "https://www.cappadociaceramic.com/uploads/3a3d174168a2fa6883e0674b2a6c196e.jpg" }
                };
            }

            return View(value);
        }
        public PartialViewResult PartialFooter()
        {
            return PartialView();
        }
    }
    public class SliderImage
    {
        public string ImageUrl { get; set; }
        public string Title { get; set; }
    }
}