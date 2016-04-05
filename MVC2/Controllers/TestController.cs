using MVC2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC2.Controllers
{
    public class TestController : Controller
    {
        //
        // GET: /Test/
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult NewStuff()
        {
            return View("NewStuff");
        }

        public ActionResult GetView()
        {
            Customer cust = new Customer();
            cust.FirstName = "Debbie";
            cust.LastName = "Edwards";
            cust.Salary = 200000;

            ViewData["Customer"] = cust;
            ViewBag.Customer = cust;
            return View("GetView");
        }
	}
}