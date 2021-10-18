using _12_PartialView.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _12_PartialView.Controllers
{
    public class HomeController : Controller
    {
     
        List<Product> GetProducts()
        {
            List<Product> products = new List<Product>()
            {
                new Product{ProductId=1,Name="elma", UnitInStock=100,UnitPrice=5 },
                 new Product{ProductId=1,Name="armut", UnitInStock=100,UnitPrice=8 },
                  new Product{ProductId=1,Name="karpuz", UnitInStock=100,UnitPrice=4 },

            };
            return products;
        }

        public ActionResult Index()
        {
            return View(GetProducts());
        }

        public ActionResult Index2()
        {
            return View();
        }
      
    }
}