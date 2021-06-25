using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _16_RouteConfig.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        //localhost645u7:Anasayfa Navbar 
        //localhost645u7:Iletisim
        //localhost645u7:Blog
        //localhost645u7:Galeri
        // GET: Home
        public ActionResult Anasayfa()
        {
            return View();
        }
        public ActionResult Iletisim()
        {
            return View();
        }
        public ActionResult Blog()
        {
            return View();
        }
        public ActionResult Galeri()
        {
            return View();
        }


    }
}