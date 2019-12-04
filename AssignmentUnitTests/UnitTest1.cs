using Assignment1_COMP2084_200400508.Models;
using Assignment1_COMP2084_200400508.Controllers;
using Assignment1_COMP2084_200400508.Data;
using System;
using Xunit;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace AssignmentUnitTests
{
    public class UnitTest1
    {
        /*
        [Fact]
        public void Test()
        {
            var options = new DbContextOptionsBuilder<ApplicationDbContext>().UseInMemoryDatabase(databaseName: "Test1").Options;

            using (var context = new ApplicationDbContext(options))
            {
                var tomes = new List<Tome>
                {
                    new Tome { TomeId = 1 }
                }
            }
                
        }
        */


        // Invalid value testers
        [Fact]
        public void Test1()
        {
            Assert.Throws<InvalidOperationException>(
                () =>
                {
                    Tome t = new Tome();
                    t.Pages = -1;
                }
                );

        }

        [Fact]
        public void Test2()
        {
            Assert.Throws<InvalidOperationException>(
                () =>
                {
                    Tome t = new Tome();
                    t.TomeId = -1;
                }
                );

        }

        [Fact]
        public void Test3()
        {
            Assert.Throws<InvalidOperationException>(
                () =>
                {
                    Tome t = new Tome();
                    t.Name = null;
                }
                );

        }

        [Fact]
        public void Test4()
        {
            Assert.Throws<InvalidOperationException>(
                () =>
                {
                    Tome t = new Tome();
                    t.Name = "";
                }
                );

        }

        [Fact]
        public void Test5()
        {
            Assert.Throws<InvalidOperationException>(
                () =>
                {
                    Tome t = new Tome();
                    t.Description = null;
                }
                );

        }

        [Fact]
        public void Test6()
        {
            Assert.Throws<InvalidOperationException>(
                () =>
                {
                    Tome t = new Tome();
                    t.Name = null;
                }
                );

        }

       
    }
}
