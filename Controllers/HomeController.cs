using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcMusic.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.NewBandImg = "http://www.sbs.com.au/popasia/sites/sbs.com.au.popasia/files/black-pink.jpg";
            ViewBag.NewBandHeader = "Black Pink";
            ViewBag.NewBandType = "Girlsband";
            ViewBag.NewBandDate = "08.08.2016";
            ViewBag.NewBandSex = ViewBag.NewBandType == "Girlsband" ? "członkiń" : "członków";
            ViewBag.NewBandMembers = "4";

            ViewBag.NewSongImg = "http://scontent.cdninstagram.com/t51.2885-15/s750x750/sh0.08/e35/12784053_1578386632482075_5357907_n.jpg?ig_cache_key=MTIwMTE2MzU0MDgyNjM5MjgyMw%3D%3D.2";
            ViewBag.NewSongArtist = "4minute";
            ViewBag.NewSongName = "Hate";
            ViewBag.NewSongDate = "31.01.2016";

            ViewBag.NewArtistImg = "https://1.soompi.io/wp-content/uploads/2014/09/B-A-P-Zelo-bap-best-absolute-perfect-33202402-800-1200-e1432334377803.jpg";
            ViewBag.NewArtistHeader = "Zelo";
            ViewBag.NewArtistType = "Raper w grupie B.A.P";
            ViewBag.NewArtistName = "Choi Jun-hong (최준홍)";
                int day = 15;
                int month = 11;
                int year = 1996;
            ViewBag.NewArtistDate = "15.11." + year;
            ViewBag.NewArtistAge = DateTime.Now.Year - year;

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