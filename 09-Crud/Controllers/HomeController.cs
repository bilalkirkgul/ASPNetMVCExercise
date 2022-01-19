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
            //Bu yöntemle View içersine Name ve Id gönderimi sağlıyoruz. Bize bu kolaylığı selectListItem yapısı sağlıyor.
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

            //Bu yapı ise bize View tarafında   @Html.DropDownList("Suppliers", null, "Seçim Yapınız", new { @class = "form-control" }) yapıyı kullanmamızı sağlıyor. fakat Id yakalaması için parametre kısmını değişken tanımlaması yapmamız gerekiyor. View tarafından string değer dönüyor. Nesne içierisinde değer almıyor. ekstra olarak nesneye değeri bizim atmamız gerekiyor. (61.satır ve 67. satırda belirtildi) 
            ViewBag.Suppliers = new SelectList(context.Suppliers, "SupplierID", "CompanyName"); 

            return View();
        }

        [HttpPost]
        public ActionResult Add(Product product, string Suppliers)
        {           
            try
            {
                if (ModelState.IsValid)//true 
                {
                    product.SupplierID = int.Parse(Suppliers);
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

            //Bu iki yapı bize View'de Kategori ve tedarikçileri göstermeyi sağlıyor..
            GetCategories();
            ViewBag.Suppliers = new SelectList(context.Suppliers.ToList(), "SupplierID", "CompanyName");


            if (productID.HasValue)
            {
                Product guncellenecek = context.Products.Find(productID);
                return View(guncellenecek);
            }
            return RedirectToAction("Index");
        }
        [HttpPost]
        public ActionResult Update(Product product, string Suppliers)
        {            
            Product newProduct = null;
            try
            {
                if (ModelState.IsValid)
                {
                    newProduct = context.Products.Find(product.ProductID);
                    //newProduct = context.Products.Where(a => a.ProductID == product.ProductID).SingleOrDefault();//Tek Kayıt Dönme işlemi
                    newProduct.SupplierID = int.Parse(Suppliers);
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