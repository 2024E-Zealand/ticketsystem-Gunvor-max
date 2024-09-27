﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
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
    }
}