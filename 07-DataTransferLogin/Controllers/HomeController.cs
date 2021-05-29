using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _07_DataTransferLogin.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(string userName,string password)
        {
            if (userName=="admin")
            {
                if (password=="qwert")
                {
                    ViewBag.Message = $"{userName} Hoşgeldiniz";
                }
                else
                {
                    ViewBag.Message = "Hatalı şifre girişi, Şifrenizi kontrol ediniz";
                }
            }
            else
            {
                if (password=="qwert")
                {
                    ViewBag.Message = "Kulanıcı adınızı kontrol ediniz";
                }
                else
                {
                    ViewBag.Message = "Kullanıcı adı ve şifre hatalı";
                }
            }

            return View();
        }
        
        [HttpGet]
        public ActionResult Index1()
        {
            return View();
        }
        [HttpPost]
        [ActionName("Index1")]
        public ActionResult Index1Post()
        {
            var userName = Request.Form["userName"];
            var password = Request.Form["password"];
            if (userName == "admin")
            {
                if (password == "qwert")
                {
                    ViewBag.Message = $"{userName} Hoşgeldiniz";
                }
                else
                {
                    ViewBag.Message = "Hatalı şifre girişi, Şifrenizi kontrol ediniz";
                }
            }
            else
            {
                if (password == "qwert")
                {
                    ViewBag.Message = "Kulanıcı adınızı kontrol ediniz";
                }
                else
                {
                    ViewBag.Message = "Kullanıcı adı ve şifre hatalı";
                }
            }

            return View();
        }

        [HttpGet]
        public ActionResult Index2()
        {
            return View();
        }
      
        [HttpPost]
        public ActionResult Index2(FormCollection collection) 
        {
            var userName = collection.Get("userName");
            var password = collection.Get("password");
            if (userName == "admin")
            {
                if (password == "qwert")
                {
                    ViewBag.Message = $"{userName} Hoşgeldiniz";
                }
                else
                {
                    ViewBag.Message = "Hatalı şifre girişi, Şifrenizi kontrol ediniz";
                }
            }
            else
            {
                if (password == "qwert")
                {
                    ViewBag.Message = "Kulanıcı adınızı kontrol ediniz";
                }
                else
                {
                    ViewBag.Message = "Kullanıcı adı ve şifre hatalı";
                }
            }
            return View();
        }
    }
}