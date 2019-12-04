using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Assignment1_COMP2084_200400508.Models;

namespace Assignment1_COMP2084_200400508.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser, ApplicationRole, string>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Assignment1_COMP2084_200400508.Models.Spell> Spell { get; set; }
        public DbSet<Assignment1_COMP2084_200400508.Models.Tome> Tome { get; set; }
    }
}
