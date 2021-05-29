using _06_DataTransfer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _06_DataTransfer.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            List<Product> products = new List<Product>()
          {
              new Product{ProductId=1,Name="Klavye"},
              new Product{ProductId=2,Name="Mause"},
              new Product{ProductId=3,Name="Monitör"},
              new Product{ProductId=4,Name="Mausepad"}
          };

            List<Product> newProducts = new List<Product>()
            {
                new Product{ProductId=5,Name="Elma"},
                new Product{ProductId=6,Name="Kiraz"},
                new Product{ProductId=7,Name="Karpuz"}
            };

            products.AddRange(newProducts);

            ViewBag.products = products;
            ViewData["urunler"] = products;
            TempData["products"] = products;

            //ViewBag Ve ViewData aynı alanı veri saklamak için kullanır ve key aynı olduğunda en son hangi veri okunursa iki yapıda da o gelir.
            //Viewbag ve Tempdatanın tek canı vardır.
            return View();
        }
        public ActionResult Index2()
        {
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