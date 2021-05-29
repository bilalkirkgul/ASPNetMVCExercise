using _09_Crud.DbTools;
using _09_Crud.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _09_Crud.Controllers
{
    public class HomeController : Controller
    {

        NorthwindEntities context;
        public HomeController()
        {
            context = DbInstance.NorthwindInstance;
        }

        void GetCategories()
        {
            List<SelectListItem> selectListItems = new List<SelectListItem>();
            foreach (Category item in context.Categories)
            {
                selectListItems.Add(new SelectListItem { Text = item.CategoryName, Value = item.CategoryID.ToString() });
            }
            ViewBag.Categories = selectListItems;
        }



        public ActionResult Index(int catID = 0)
        {
            ViewBag.Categories = context.Categories.ToList();
            List<Product> products;

            if (catID == 0)
            {
                products = context.Products.ToList();
            }
            else
            {
                products = context.Products.Where(a => a.CategoryID == catID).ToList();
            }

            return View(products);
        }

        public ActionResult Add()
        {
            GetCategories();//Add ekranında get ile tüm kategori gruplarını çekiyoruz. listeleme yapıyoruz. o yüzden bu methodu buraya yazma ihtiyacı duyduk
            return View();
        }

        [HttpPost]
        public ActionResult Add(Product product)
        {
            GetCategories();
            try
            {
                if (ModelState.IsValid)//true 
                {
                    context.Products.Add(product);
                    context.SaveChanges();
                    return RedirectToAction("Index");
                }
                else
                {
                    throw new Exception();
                }

            }
            catch (Exception)
            {
                ViewBag.Message = "Kayıt İşlemi gerçekleşmedi";
                return View();
            }

        }

        [HttpGet]
        public ActionResult Update(int? productID)
        {
            GetCategories();
            if (productID.HasValue)
            {
                Product guncellenecek = context.Products.Find(productID);
                return View(guncellenecek);
            }
            return RedirectToAction("Index");
        }
        [HttpPost]
        public ActionResult Update(Product product)
        {
            GetCategories();
            Product newProduct = null;
            try
            {
                if (ModelState.IsValid)
                {
                    newProduct = context.Products.Find(product.ProductID);
                    //newProduct = context.Products.Where(a => a.ProductID == product.ProductID).SingleOrDefault();//Tek Kayıt Dönme işlemi
                    context.Entry(newProduct).CurrentValues.SetValues(product);
                    context.SaveChanges();
                    return RedirectToAction("Index");
                }
                else
                {
                    ViewBag.Message = "Güncelleme işlemi gerçekleşmedi";
                }
            }
            catch (Exception)
            {
                throw new Exception();              
            }
            return View(newProduct);
        } 
            
        public ActionResult Delete(int productID)
        {
            Product deleteProduct = context.Products.Find(productID);
            context.Products.Remove(deleteProduct);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}