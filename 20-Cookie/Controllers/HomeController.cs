using _20_Cookie.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _20_Cookie.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Login()
        {
            if (Request.Cookies["login"]!=null)
            {
                HttpCookie cookie = Request.Cookies["login"];
                UserVM userVM = new UserVM();
                userVM.Email = cookie["email"];
                userVM.Password = cookie["password"];
                return View(userVM);
            }

            return View();
        }
        [HttpPost]
        public ActionResult Login(UserVM user)
        {
            if (user.Remember)
            {
                HttpCookie cookie = Request.Cookies["login"];
                cookie.Values.Add("email", user.Email);
                cookie.Values.Add("password", user.Password);
                cookie.Expires = DateTime.Now.AddDays(15);
                Response.Cookies.Add(cookie);

            }
            return RedirectToAction("Index");
        }
        public ActionResult ClearCookies()
        {
            if (Request.Cookies.AllKeys.Contains("login"))
            {
                HttpCookie cookie = Request.Cookies["login"];
                cookie.Expires = DateTime.Now.AddDays(-1);
                Response.Cookies.Add(cookie);
            }
            return RedirectToAction("Login");
        }

    }
}