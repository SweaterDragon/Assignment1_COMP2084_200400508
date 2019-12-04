using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Assignment1_COMP2084_200400508.Controllers
{
    public class StoreManagerController : Controller
    {
        public IActionResult Index()
        {
            if (User.Identity.IsAuthenticated && User.IsInRole("Administrator"))
            {
                return Ok("This should only be visible to LOGGED IN administrators");
            }
            else if (User.Identity.IsAuthenticated)
            {
                return Redirect("/");
            }
            else
            {
                return Redirect("/Identity/Account/Login");
            }
        }
    }
}