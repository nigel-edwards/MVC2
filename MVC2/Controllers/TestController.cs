using MVC2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC2.ViewModels;

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
            CustomerListViewModel customersVM = new CustomerListViewModel();

            CustomerBuisnessLayer customerBuisLayer = new CustomerBuisnessLayer();
            List<Customer> customers = customerBuisLayer.GetCustomers();
            List<CustomerViewModel> custViewModels = new List<CustomerViewModel>();

            foreach (Customer cust in customers )
            {
                CustomerViewModel vmCus = new CustomerViewModel();
                vmCus.CustomerName = cust.FirstName + " " + cust.LastName;
                vmCus.Salary = cust.Salary.ToString("C");
                if (cust.Salary > 15000)
                {
                    vmCus.SalaryColor = "yellow";
                }
                else
                {
                    vmCus.SalaryColor = "green";
                }
                custViewModels.Add(vmCus);
            }

            customersVM.UserName = "Admin";
            customersVM.Customers = custViewModels;

            return View("GetView", customersVM);
        }
	}
}