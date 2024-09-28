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
    public class CarTests
    {
        [TestMethod()]
        public void PriceTest()
        {
            var Car = new Car();

            double expectedResult = 240;

            double actualResult = Car.Price();
            
            Assert.AreEqual(expectedResult, actualResult);

        }

        [TestMethod()]
        public void VehicleTypeTest()
        {
            var Car = new Car();

            string expectedResult = "Car";

            string actualResult = Car.VehicleType();

            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}