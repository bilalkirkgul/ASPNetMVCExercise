using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _17_RouteConfig.Controllers
{
    [RoutePrefix("Product")]
    public class DefaultController : Controller
    {
        // GET: Default

        [Route("~/Anasayfa")]
        public ActionResult Index()
        {
            return View();
        }
        [Route("List/Kategori")]
        public ActionResult ListCategory()
        {
            return View();
        }
        [Route("~/List/Product")]
        public ActionResult ListProduct()
        {
            return View();
        }
    }
}