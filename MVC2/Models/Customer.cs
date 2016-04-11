using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MVC2.Models
{
    public class Customer
    {
        [Key]
        public int CustID { get; set; }
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public int Salary { get; set; }
    }
}