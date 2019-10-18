using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Assignment1_COMP2084_200400508.Models;

namespace Assignment1_COMP2084_200400508.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Hello and welcome to the wizard library! Browse through our selection of tomes and discover the many spells within!";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Adam Stephens 200400508.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Tome()
        {
            return View();
        }

        public IActionResult Spell()
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
