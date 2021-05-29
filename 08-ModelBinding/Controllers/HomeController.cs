using _08_ModelBinding.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _08_ModelBinding.Controllers
{
    public class HomeController : Controller
    {
        

        public ActionResult Index()
        {
            List<Category> categories = new List<Category>()
            {
                new Category{CategoryID=1,CategoryName="Gıda"},
               new Category{CategoryID=2,CategoryName="Hizmet"},
               new Category{CategoryID=3,CategoryName="İmalat"},
               new Category{CategoryID=4,CategoryName="Teknoloji"}
            };


            return View(categories);
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