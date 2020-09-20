using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Shekho.Models;
using Shekho.ViewModels;

namespace Shekho.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer

        public ActionResult Customers()
        {
            var Customers = new List<Customer>
            {
                new Customer{Id = 1,Name = "Jack"},
                new Customer{Id = 2,Name = "Roze"},
                new Customer{Id = 3,Name = "Piet"}
            };

            var Viewmodel = new ListCustomersViewModel
            {
                Customers = Customers,
            };

            return View(Viewmodel);
        }

    }
}