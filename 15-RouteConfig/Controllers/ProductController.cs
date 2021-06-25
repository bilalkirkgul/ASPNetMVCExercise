using _15_RouteConfig.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _15_RouteConfig.Controllers
{
    public class ProductController : Controller
    {
        List<Product> GetProductList()
        {
            List<Product> products = new List<Product>()
            {
                new Product{ProductID=1,ProductName="Notebook",Description="Lenovo"},
                new Product{ProductID=2,ProductName="Hamburger",Description="Tavuk"},
                new Product{ProductID=3,ProductName="Telefon",Description="Kameralı" }
            };
            return products;
        }

        // GET: Product
        public ActionResult Index()
        {
            return View(GetProductList());
        }
        public ActionResult Details(string ProductName, string ProductID)
        {
            List<Product> products = GetProductList();
            Product p = products.Where(a => a.ProductID == int.Parse(ProductID)).Single();
            return View(p);
        }
    }
}