using _25_PartialView.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _25_PartialView.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        public ActionResult Index()
        {
            
            return View();
        }

      List<Category> CategoryList()
        {
            List<Category> categories = new List<Category>()
            {
                new Category{CategoryID=1,CategoryName="Sağlık"},
                new Category{CategoryID=2,CategoryName="Hizmet"},
                new Category{CategoryID=3,CategoryName="Spor"},
                new Category{CategoryID=4,CategoryName="Ekonomi"},
            };
            return categories;
        }


        public PartialViewResult CategoryListPartial()
        {
            return PartialView(CategoryList());
        }



    }
}