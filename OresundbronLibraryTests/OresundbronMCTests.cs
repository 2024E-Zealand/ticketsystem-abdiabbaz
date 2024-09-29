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
    public class OresundbronMCTests
    {
        [TestMethod()]
        public void PriceTest_With_BroBizz()
        {
            var oresundbronMC = new OresundbronMC();

            oresundbronMC.HasBroBizz = true;

            double actualPrice = oresundbronMC.Price();

            double expectedPrice = 73;

            Assert.AreEqual(actualPrice, expectedPrice);
        }


        [TestMethod()]
        public void PriceTest_Without_BroBizz()
        {
            var oresundbronMC = new OresundbronMC();

            oresundbronMC.HasBroBizz = false;

            double actualPrice = oresundbronMC.Price();

            double expectedPrice = 210;

            Assert.AreEqual(actualPrice, expectedPrice);
        }

        [TestMethod()]
        public void VehicleTypeTest()
        {
            var oresundbronMC = new OresundbronMC();

            string actualVehicleType = oresundbronMC.VehicleType();

            string expectedVehicleType = "Oresund MC";

            Assert.AreEqual(actualVehicleType, expectedVehicleType);
        }
    }
}