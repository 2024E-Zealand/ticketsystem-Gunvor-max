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
    public class OresundMCTests
    {
        [TestMethod()]
        public void PriceTestWithBrobizzOK()
        {
            //Arrange
            OresundMC mc = new OresundMC("DL12345", DateTime.Now, true);

            //Act
            var expectedresult = 73;
            var actualresult = mc.Price();

            //Assert
            Assert.AreEqual(expectedresult, actualresult);
        }

        [TestMethod()]
        public void PriceTestWitouthBrobizzOK()
        {
            //Arrange
            OresundMC mc = new OresundMC("DL12345", DateTime.Now, false);

            //Act
            var expectedresult = 210;
            var actualresult = mc.Price();

            //Assert
            Assert.AreEqual(expectedresult, actualresult);
        }

        [TestMethod()]
        public void VehicleTypeTest()
        {
            //Arrange
            OresundMC mc = new OresundMC("DL12345", DateTime.Now, true);

            //Act
            var expectedresult = "Oresund MC";
            var actualresult = mc.VehicleType();

            //Assert
            Assert.AreEqual(expectedresult, actualresult);
        }
    }
}