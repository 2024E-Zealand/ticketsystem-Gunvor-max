using Microsoft.VisualStudio.TestTools.UnitTesting;
using StoreBaeltTicketLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketClassLibrary;

namespace StoreBaeltTicketLibrary.Tests
{
    [TestClass()]
    public class DiscountTests
    {
        [TestMethod()]
        public void weekendDiscountTestInWeekendsOK()
        {
            //Arrange
            Car carWithBrobizz = new Car("DT12345", new DateTime(2024, 9, 29), true);
            Car cardefault = new Car();

            //Act 
            double expectedresult = (cardefault.Price() * 0.80) * 0.95;
            double actualresult = carWithBrobizz.weekendDiscount();

            //Assert
            Assert.AreEqual(expectedresult, actualresult, 0.1);
        }

        [TestMethod()]
        public void weekendDiscountTestInWeekDaysOK()
        {
            //Arrange
            Car carWithBrobizz = new Car("DT12345", new DateTime(2024, 9, 30), true);
            Car carNoBrobizz = new Car();

            //Act 
            double expectedresult = 240 * 0.95;
            double actualresult = carWithBrobizz.weekendDiscount();

            //Assert
            Assert.AreEqual(expectedresult, actualresult, 0.1);
        }
    }
}