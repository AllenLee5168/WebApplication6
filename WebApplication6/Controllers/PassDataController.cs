using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication6.Controllers
{
    public class PassDataController : Controller
    {
        // GET: PassData
        public ActionResult Index()
        {

            return View();
        }
        public ActionResult petShop()
        {
            ViewData["Company"]= "寵物店";
            ViewBag.Address = "天龍國";
            List<string> petList = new List<string>();
            petList.Add("A");
            petList.Add("B");
            petList.Add("C");
            ViewData.Model = petList;

            return View();

        }
    }
}