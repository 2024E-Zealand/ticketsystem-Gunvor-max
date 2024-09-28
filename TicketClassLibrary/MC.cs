using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketClassLibrary
{
    /// <summary>
    /// MotorCycle class
    /// </summary>
    public class MC : Vehicle
    {
        #region Contructor
        /// <summary>
        /// Create an instance of the class with the following properties
        /// </summary>
        /// <param name="licenseplate"> Licensplate for the</param>
        /// <param name="date">date for buying the ticket</param>
        /// <param name="hasBrobizz">determines if the mc has a brobizz</param>
        public MC(string licenseplate, DateTime date, bool hasBrobizz) : base(licenseplate, date, hasBrobizz)
        {
        }

        /// <summary>
        /// Default constructor that create an instance of the object with the following properties if no specifik properties is given
        /// </summary>
        public MC() : this("0", DateTime.Now, false)
        {

        }
        #endregion

        #region Methods
        /// <summary>
        /// Generate the ticket price for a motercycle
        /// </summary>
        /// <returns>the price</returns>
        public override double Price()
        {
            var price = 125;
            if (HasBrobizz)
            {
                return price * 0.95;
            }
            return price;
        }

        /// <summary>
        /// Gets the vehicletype
        /// </summary>
        /// <returns>The type</returns>
        public override string VehicleType()
        {
            return "MC";
        }
        #endregion
    }
}
