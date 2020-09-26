using RnReddyITSchools.Training.Web.Presentation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RnReddyITSchools.Training.Web.Presentation.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        public ActionResult Index()
        {
            Customer cust = new Customer ();
            return View();
        }
    }
}