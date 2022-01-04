using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _21_Application.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //online işlemleri görmek için global.asax.cs'de method tanımlaması yapıldı
            return View();
        }

     
    }
}