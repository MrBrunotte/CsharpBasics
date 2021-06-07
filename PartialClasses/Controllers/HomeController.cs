using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PartialClasses.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace PartialClasses.Controllers
{
    public class HomeController : Controller
    {
        // Create an instance of a Customer class 
        Customer C1 = new Customer();
        PartialCustomer C2 = new PartialCustomer();

        private readonly ILogger<HomeController> _logger;
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            C1.FirstName = "Stefan";
            C1.LastName = "Brunotte";
            string fullNameOne = C1.FullName();

            C2.FirstName = "Viggo";
            C2.LastName = "Brunotte";
            string fullNameTwo = C2.FullName();

            return View(fullNameOne, fullNameTwo);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
