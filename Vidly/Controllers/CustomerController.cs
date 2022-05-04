using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        public ActionResult Index()
        {
            var customers = new List<Customer>
            {
                new Customer { Id = 1, Name ="Subham"},
                new Customer { Id = 2, Name ="Sohini"},
                new Customer { Id = 3, Name ="Avantika"},
            };

            var customerView = new CustomerViewModel
            {
                Customets = customers,
            };
            return View(customerView);
        }

        public ActionResult Details(int id)
        {
           
            if (id == 1)
            {
                return Content("Subham");
            }
            else if (id == 2)
            {
                return Content("Sohini");
            }else
            {
                return Content("Avantika");
            }
            
        }
    }
}