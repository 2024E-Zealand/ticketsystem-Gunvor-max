using Microsoft.VisualStudio.TestTools.UnitTesting;
using TicketClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketClassLibrary.Tests
{
    [TestClass()]
    public class CarTests
    {
        [TestMethod()]
        public void PriceTestOK()
        {
            //Arrange
            Car carDefault = new Car();

            //Act 
            double expectedresult = 240;
            double actualresult = carDefault.Price();

            //Assert
            Assert.AreEqual(expectedresult,actualresult);
        }

        [TestMethod()]
        public void VehicleTypeTestOK()
        {

            //Arrange
            Car carDefault = new Car();

            //Act 
            var expectedresult = "Car";
            var actualresult = carDefault.VehicleType();

            //Assert
            Assert.AreEqual(expectedresult, actualresult);
        }

        [TestMethod()]
        [DataRow("1")]
        [DataRow("12345")]
        [DataRow("1234567")]
        public void TestLicenseplateOK(string licenseplate)
        {

            //Arrange + Act
            Vehicle car = new Car(licenseplate, DateTime.Now);
            var actualresult = car.Licenseplate.Length;

            //Assert
            Assert.AreEqual(licenseplate.Length, actualresult);
        }

        [TestMethod()]
        [DataRow("12345678")]
        [DataRow("1234567891114161820")]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestLicenseplateNotOK(string licenseplate)
        {

            //Arrange + Act
            new Car(licenseplate, DateTime.Now);

            //Assert
            Assert.Fail();
        }
    }
}