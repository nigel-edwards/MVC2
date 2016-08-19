using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC2.ViewModels
{
    public class CustomerViewModel
    {
        public string CustomerName { get; set; }
        public string Salary { get; set; }
        public string SalaryColor { get; set; }
    }

    public class CustomerListViewModel
    {
        public List<CustomerViewModel> Customers { get; set; }
        public string UserName { get; set; }
    }

}