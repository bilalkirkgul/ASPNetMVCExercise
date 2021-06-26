using _23_Ajax.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _23_Ajax.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetPersonel()
        {
            List<Personel> personels = new List<Personel>()
            {
                new Personel{PersonelId=1,FirstName="bilal",LastName="kırkgül"},
                new Personel{PersonelId=2,FirstName="aaa",LastName="aaa" },
                 new Personel{PersonelId=3,FirstName="bbb",LastName="bbb" },
                 new Personel{PersonelId=4,FirstName="ccc",LastName="ccc" },
            };


            return Json(personels, JsonRequestBehavior.AllowGet);
        }
      
    }
}