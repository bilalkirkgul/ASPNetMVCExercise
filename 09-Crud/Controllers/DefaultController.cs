using _09_Crud.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _09_Crud.Controllers
{
    public class DefaultController : Controller
    {
        NorthwindEntities context;
        public DefaultController()
        {
            context = DbTools.DbInstance.NorthwindInstance;
        }


        // GET: Default
        public ActionResult Index()
        {
            return View();
        }

        public PartialViewResult CategoryListPartial()
        {
            var model = context.Categories.ToList();
            return PartialView(model);
        }



    }
}