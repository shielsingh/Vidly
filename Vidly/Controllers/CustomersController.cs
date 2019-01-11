using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {
        IList<Customer> Customers = new List<Customer>();

        public CustomersController()
        {
            Customers.Add(new Customer {Id = 1, Name = "Jhon Snow" });
            Customers.Add(new Customer {Id = 2, Name = "Khalisee" });
        }

        // GET: Customers
        public ActionResult Index()
        {
            return View(Customers);
        }

        //GET: Customers/Details/1
        public ActionResult Details(int Id)
        {
            Customer customer = Customers.Where(c => c.Id == Id).SingleOrDefault();

            if (customer == null)
                return HttpNotFound();

            return View(customer);
        }
    }
}