using Microsoft.VisualStudio.TestTools.UnitTesting;
using TicketClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics.CodeAnalysis;

namespace TicketClassLibrary.Tests
{
    [TestClass()]
    public class MCTests
    {
        [TestMethod()]
        public void PriceTest()
        {
            var MC = new MC();

            double expectedResult = 125;

            double actualResult = MC.Price();

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod()]
        public void VehicleTypeTest()
        {
            var MC = new MC();

            string expectedResult = "MC";

            string actualResult = MC.VehicleType();

            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}