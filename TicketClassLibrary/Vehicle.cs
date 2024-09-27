using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketClassLibrary
{
    /// <summary>
    /// Baseclass Vehicle
    /// </summary>
    public abstract class Vehicle
    {
        #region Properties

        /// <summary>
        /// Licensplate for the vehicle
        /// </summary>
        public string Licenseplate { get; protected set; }

        /// <summary>
        /// Date for buying the ticket
        /// </summary>
        public DateTime Date { get; protected set; }
        #endregion

        #region Conctructor 
        /// <summary>
        /// Subclasses must implement the following properties in their contructor
        /// </summary>
        /// <param name="licenseplate">License plate for the vehicle</param>
        /// <param name="date">date for buying the ticket</param>
        public Vehicle(string licenseplate, DateTime date)
        {
            Licenseplate = licenseplate;
            Date = date;
        }
        #endregion

        #region Methods
        /// <summary>
        /// Generate the ticket price for the vehicle
        /// </summary>
        /// <returns>the price</returns>
        public abstract double Price();

        /// <summary>
        /// Gets the vehicletype
        /// </summary>
        /// <returns>The type</returns>
        public abstract string VehicleType();
        #endregion
    }
}