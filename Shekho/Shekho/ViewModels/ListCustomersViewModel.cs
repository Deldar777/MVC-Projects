using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Shekho.Models;

namespace Shekho.ViewModels
{
    public class ListCustomersViewModel
    {
        public int id { get; set; }
        public List<Customer> Customers { get; set; }
    }
}