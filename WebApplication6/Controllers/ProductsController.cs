using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication6.Controllers
{
    public class ProductsController : Controller
    {
        // GET: Products
        public ActionResult Index()
        {
            return View();

        }
        public ActionResult Index1B()
        {
            return View("indexHello");

        }

        public string Index1A()
        {
            return "傳回字串<h3>string</h3>";

        }
        public ActionResult Index1AA()
        {
            return Content("傳回字串2222");

        }
        public ActionResult Index1E()
        {
            return Redirect("http://www.google.com");

        }
        protected override void HandleUnknownAction(string actionName)
        {
            Response.Redirect("http://www.google.com");
            base.HandleUnknownAction(actionName);
        }
        public ActionResult Index1F()
        {
            string[] EmpsList = new string[] { "123","456"};
            ViewData["A"] = "字串A 我是ViewData";
            ViewBag.B = "我是字串B 我是ViewBag";
            TempData["C"] = "我是tempDate";
            ViewData["AA"] = 12;
            ViewBag.BB = true;
            TempData["CC"] = EmpsList;
            return View();
        }


    }
}