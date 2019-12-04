using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment1_COMP2084_200400508.Models
{
    public class ApplicationRole : IdentityRole<string>
    {
        public string RoleDescription { get; set; }
    }
}
