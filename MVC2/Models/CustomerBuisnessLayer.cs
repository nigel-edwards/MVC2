using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC2.Models
{
    public class CustomerBuisnessLayer
    {
        public List<Customer> GetCustomers()
        {
            List<Customer> customers = new List<Customer>();
            Customer cus = new Customer();
            cus.FirstName = "Johnson";
            cus.LastName = " Fernandes";
            cus.Salary = 14000;
            customers.Add(cus);

            cus = new Customer();
            cus.FirstName = "Deborah";
            cus.LastName = " Edwards";
            cus.Salary = 54000;
            customers.Add(cus);

            cus = new Customer();
            cus.FirstName = "Nigel";
            cus.LastName = " Edwards";
            cus.Salary = 34000;
            customers.Add(cus);

            return customers;
        }
    }
}