using Microsoft.VisualStudio.TestTools.UnitTesting;
using StoreBaeltTicketLibrary;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreBaeltTicketLibrary.Tests
{
    //[ExcludeFromCodeCoverage]
    [TestClass()]
    public class StoreBaeltCarTests
    {
        [TestMethod()]
        public void PriceTest_With_WeekendDiscount_And_BroBizz_Valid()
        {
            var car = new StoreBaeltCar();

            car.HasBroBizz = true;
            car.Date = new DateTime(2024, 09, 28);

            double actualPrice = car.Price();

            double expectedPrice = 240 * 0.80 * 0.95;

            double delta = 0.01;

            Assert.AreEqual(expectedPrice, actualPrice, delta);
            
        }

        [TestMethod()]
        public void PriceTest_With_WeekendDiscount_And_Without_BroBizz_Valid()
        {
            var car = new StoreBaeltCar();

            car.HasBroBizz = false;
            car.Date = new DateTime(2024, 09, 29);

            double actualPrice = car.Price();

            double expectedPrice = 240 * 0.80;

            double delta = 0.01;

            Assert.AreEqual(expectedPrice, actualPrice, delta);

        }

        [TestMethod()]
        public void PriceTest_Full_Price()
        {
            var car = new StoreBaeltCar();
            car.HasBroBizz = false;
            car.Date = new DateTime(2024,09,30);

            double actualPrice = car.Price();

            double expectedPrice = 240;

            Assert.AreEqual(expectedPrice,actualPrice);
        }

        [TestMethod()]
        public void VehicleType()
        {
            var car = new StoreBaeltCar();

            string actualResult = car.VehicleType();

            string expectedResult = "StoreBaelt";

            Assert.AreEqual(expectedResult,actualResult);
        }
    }
}