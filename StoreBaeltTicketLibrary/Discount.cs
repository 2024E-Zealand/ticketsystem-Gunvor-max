using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketClassLibrary;

namespace StoreBaeltTicketLibrary
{
    /// <summary>
    /// Discount class for managing discounts
    /// </summary>
    public class Discount
    {
        /// <summary>
        /// Get and set the datetime
        /// </summary>
        public DateTime Date {  get; set; }

        /// <summary>
        /// Creates an instance of the class with the following properties
        /// </summary>
        /// <param name="dateTime">Set the datetime</param>
        public Discount(DateTime dateTime)
        {
            Date = dateTime;
        }

        /// <summary>
        /// Determines if a car object gets a discount based upon the weekend
        /// </summary>
        /// <param name="car">the car object</param>
        /// <returns>the total price for the car </returns>
        public double weekendDiscount(Car car)
        {
            Car testcar = new Car();
            var price = testcar.Price();
            double totalprice = 0;
            if (Date.DayOfWeek == DayOfWeek.Saturday || Date.DayOfWeek == DayOfWeek.Sunday)
            {
                totalprice = (price *= 0.80) * 0.95;
                return totalprice;
            }
            else if (car.HasBrobizz) 
            {
                return car.Price();
            }
            return price;
        }
    }
}
