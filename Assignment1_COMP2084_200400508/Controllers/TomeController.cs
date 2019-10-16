using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Assignment1_COMP2084_200400508.Controllers
{
    public class TomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}