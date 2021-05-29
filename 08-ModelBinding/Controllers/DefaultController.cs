using _08_ModelBinding.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _08_ModelBinding.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(Category category)
        {
            return View();
        }
    }
}