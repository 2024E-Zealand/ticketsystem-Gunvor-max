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
            Car car = new Car("DT12345", DateTime.Now, true);
            Car cardefault = new Car();
            Discount discount = new Discount(DateTime.Now);

            //Act 
            double expectedresult = (cardefault.Price() * 0.80) * 0.95;
            double actualresult = discount.weekendDiscount(car);

            //Assert
            Assert.AreEqual(expectedresult, actualresult, 0.1);
        }

        [TestMethod()]
        public void weekendDiscountTestInWeekDaysOK()
        {
            //Arrange
            Car car = new Car("DT12345", DateTime.Now, true);
            Car cardefault = new Car();
            Discount discount = new Discount(DateTime.Now);

            if (discount.Date.DayOfWeek == DayOfWeek.Saturday || discount.Date.DayOfWeek == DayOfWeek.Sunday) 
            {
                discount.Date = discount.Date.AddDays(2);   
            }
            //Act 
            double expectedresult = car.Price();
            double actualresult = discount.weekendDiscount(car);

            //Assert
            Assert.AreEqual(expectedresult, actualresult, 0.1);
        }
    }
}