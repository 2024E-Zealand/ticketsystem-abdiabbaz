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
    [ExcludeFromCodeCoverage]
    [TestClass()]
    public class MCTests
    {

        [TestMethod()]
        [DataRow("123456")]
        public void LicensePlate_Valid(string expectedResult)
        {
            var mc = new MC();

            mc.LicensePlate = expectedResult;

            string actualResult = mc.LicensePlate;

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod()]
        [DataRow("12345678")]
        [DataRow(" ")]
        [DataRow(null)]
        [DataRow("   ")]
        public void LicensePlate_Not_Valid(string expectedResult)
        {
            var mc = new Car();

            Assert.ThrowsException<ArgumentOutOfRangeException>(() => mc.LicensePlate = expectedResult);
        }


        [TestMethod()]
        public void PriceTest()
        {
            var mc = new MC();

            double expectedResult = 125;

            double actualResult = mc.Price();

            Assert.AreEqual(expectedResult, actualResult);
        }


        [TestMethod()]
        public void Price_With_BroBizz_Valid()
        {
            var mc = new MC();

            mc.HasBroBizz = true;

            double priceWithBroBizz = mc.Price();

            double expectedPrice = 125 * 0.95;

            double delta = 0.01;

            Assert.AreEqual(expectedPrice, priceWithBroBizz, delta);

        }

        [TestMethod()]
        public void Price_Without_BroBizz_Valid()
        {
            var mc = new MC();

            mc.HasBroBizz = false;

            double priceWithBroBizz = mc.Price();

            double expectedPrice = 125;

            double delta = 0.01;

            Assert.AreEqual(expectedPrice, priceWithBroBizz, delta);

        }

        [TestMethod()]
        public void VehicleTypeTest()
        {
            var mc = new MC();

            string expectedResult = "MC";

            string actualResult = mc.VehicleType();

            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}