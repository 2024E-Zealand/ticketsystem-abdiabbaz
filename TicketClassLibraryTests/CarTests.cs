using Microsoft.VisualStudio.TestTools.UnitTesting;
using TicketClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.ConstrainedExecution;

namespace TicketClassLibrary.Tests
{
    [TestClass()]
    public class CarTests
    {

        [TestMethod()]
        [DataRow("123456")]
        public void LicensePlate_Valid(string expectedResult)
        {
            var car = new Car();

            car.LicensePlate = expectedResult; 

            string actualResult = car.LicensePlate; 

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod()]
        [DataRow("12345678")]
        [DataRow(" ")]
        [DataRow(null)]
        [DataRow("   ")]
        public void LicensePlate_Not_Valid(string expectedResult)
        {
            var car = new Car();

            Assert.ThrowsException<ArgumentOutOfRangeException>(() => car.LicensePlate = expectedResult);
        }
        


            [TestMethod()]
        public void PriceTest()
        {
            var car = new Car();

            double expectedResult = 240;

            double actualResult = car.Price();
            
            Assert.AreEqual(expectedResult, actualResult);

        }

        [TestMethod()]
        public void VehicleTypeTest()
        {
            var car = new Car();

            string expectedResult = "Car";

            string actualResult = car.VehicleType();

            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}