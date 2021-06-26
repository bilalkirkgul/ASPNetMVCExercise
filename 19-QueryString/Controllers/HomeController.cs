using _19_QueryString.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _19_QueryString.Controllers
{
    public class HomeController : Controller
    {
        NorthwindEntities context;
        public HomeController()
        {
            context = new NorthwindEntities();
        }

        public ActionResult Index()
        {
            List<Category> categories = context.Categories.ToList();
            return View(categories);
        }

        public ActionResult Index2()
        {
        }
    }
}