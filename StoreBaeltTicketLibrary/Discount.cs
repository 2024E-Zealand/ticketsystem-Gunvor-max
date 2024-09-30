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
    public static class Discount
    {
        /// <summary>
        /// Extending method to the car class that Determines if a car object gets a discount based upon the weekend
        /// </summary>
        /// <param name="car">The car class</param>
        /// <returns>The total price for the car</returns>
        public static double weekendDiscount(this Car car)
        {
            Car carWithNoBrobizz = new Car();
            double price = carWithNoBrobizz.Price();
            if (car.Date.DayOfWeek == DayOfWeek.Saturday || car.Date.DayOfWeek == DayOfWeek.Sunday)
            { 
                price = (price *= 0.80) * 0.95;
                return price;
            }
            else if (car.HasBrobizz) 
            {
                return car.Price();
            }
            return price;
        }
    }
}
