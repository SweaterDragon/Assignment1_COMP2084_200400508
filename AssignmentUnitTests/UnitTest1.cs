using Assignment1_COMP2084_200400508.Models;
using System;
using Xunit;

namespace AssignmentUnitTests
{
    public class UnitTest1
    {
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
    }
}
