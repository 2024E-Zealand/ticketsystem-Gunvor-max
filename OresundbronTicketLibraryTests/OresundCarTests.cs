using Microsoft.VisualStudio.TestTools.UnitTesting;
using OresundbronTicketLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace OresundbronTicketLibrary.Tests
{
    [TestClass()]
    public class OresundCarTests
    {
        [TestMethod()]
        public void PriceTestWithBrobizzOK()
        {
            //Arrange
            OresundCar car = new OresundCar("DL12345",DateTime.Now,true);

            //Act
            var expectedresult = 161;
            var actualresult = car.Price();

            //Assert
            Assert.AreEqual(expectedresult,actualresult);
        }

        [TestMethod()]
        public void PriceTestWitouthBrobizzOK()
        {
            //Arrange
            OresundCar car = new OresundCar("DL12345", DateTime.Now, false);

            //Act
            var expectedresult = 410;
            var actualresult = car.Price();

            //Assert
            Assert.AreEqual(expectedresult, actualresult);
        }

        [TestMethod()]
        public void VehicleTypeTest()
        {
            //Arrange
            OresundCar car = new OresundCar("DL12345", DateTime.Now, true);

            //Act
            var expectedresult = "Oresund car";
            var actualresult = car.VehicleType();

            //Assert
            Assert.AreEqual(expectedresult, actualresult);
        }
    }
}