using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCSample.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index(int? id)
        {
            TempData["id"] = id;
            TempData.Keep("Id");

            return View();
        }


       
        public ActionResult Thankyou()
        {
            return View();
        }
    }
}