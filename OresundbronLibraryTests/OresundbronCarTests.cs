using Microsoft.VisualStudio.TestTools.UnitTesting;
using OresundbronLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OresundbronLibrary.Tests
{
    [TestClass()]
    public class OresundbronCarTests
    {
        [TestMethod()]
        public void PriceTest_With_BroBizz()
        {
            var oresundbronCar = new OresundbronCar();

            oresundbronCar.HasBroBizz = true;

            double actualPrice = oresundbronCar.Price();

            double expectedPrice = 161;

            Assert.AreEqual(actualPrice, expectedPrice);
        }


        [TestMethod()]
        public void PriceTest_Without_BroBizz()
        {
            var oresundbronCar = new OresundbronCar();

            oresundbronCar.HasBroBizz = false;

            double actualPrice = oresundbronCar.Price();

            double expectedPrice = 410;

            Assert.AreEqual(actualPrice, expectedPrice);
        }

        [TestMethod()]
        public void VehicleTypeTest()
        {
            var oresundbronCar = new OresundbronCar();

            string actualVehicleType = oresundbronCar.VehicleType();

            string expectedVehicleType = "Oresund Car";

            Assert.AreEqual(actualVehicleType, expectedVehicleType);
        }
    }
}