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
    public class MCTests
    {

        [TestMethod()]
        public void PriceTest()
        {
            //Arrange
            MC mcDefault = new MC();

            //Act 
            double expectedresult = 125;
            double actualresult = mcDefault.Price();

            //Assert
            Assert.AreEqual(expectedresult, actualresult);
        }

        [TestMethod()]
        public void VehicleTest()
        {
            //Arrange
            MC mcDefault = new MC();

            //Act 
            var expectedresult = "MC";
            var actualresult = mcDefault.VehicleType();

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
            Vehicle mc = new MC(licenseplate, DateTime.Now);
            var actualresult = mc.Licenseplate.Length;

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
            new MC(licenseplate, DateTime.Now);

            //Assert
            Assert.Fail();
        }
    }
}