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
    }
}