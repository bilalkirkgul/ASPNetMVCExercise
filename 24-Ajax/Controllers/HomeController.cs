using _24_Ajax.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _24_Ajax.Controllers
{
    public class HomeController : Controller
    {
        NorthwindEntities context;
        public HomeController()
        {
            context = new NorthwindEntities();
        }

        public ActionResult GetCategories()
        {
            List<Category> categories = context.Categories.ToList();
            return View("_categoryList", categories);
        }

        public ActionResult Index()
        {
            return View();
        }
        public JsonResult Add(Category category)
        {
            try
            {
                context.Categories.Add(category);
                context.SaveChanges();
                return Json("ok", JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                return Json(ex, JsonRequestBehavior.AllowGet);
            }

        }

        public JsonResult Delete(int id)
        {
            try
            {
                Category category = context.Categories.Find(id);
                context.Categories.Remove(category);
                context.SaveChanges();
                return Json("ok", JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {

                return Json(ex, JsonRequestBehavior.AllowGet);
            }
        }


    }
}