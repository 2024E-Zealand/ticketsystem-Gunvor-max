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
    public class MC
    {
        #region Properties

        /// <summary>
        /// Licensplate for the motorcycle
        /// </summary>
        public string Licenseplate { get; set; }

        /// <summary>
        /// Date for buying the ticket
        /// </summary>
        public DateTime Date { get; set; }
        #endregion

        #region Conctructor 
        /// <summary>
        /// Creates an instance of the class MC
        /// </summary>
        /// <param name="licenseplate">License plate for the motorcycle</param>
        /// <param name="date">date for buying the ticket</param>
        public MC(string licenseplate, DateTime date)
        {
            Licenseplate = licenseplate;
            Date = date;
        }

        /// <summary>
        /// Creates a default instance of the class MC if with the following properties if none is specified
        /// </summary>
        public MC():this("0",DateTime.Now)
        {
            
        }
        #endregion

        #region Methods
        /// <summary>
        /// Generate the ticket price for a motorcycle
        /// </summary>
        /// <returns>the price</returns>
        public double Price()
        {
            return 125;
        }

        /// <summary>
        /// Gets the vehicle
        /// </summary>
        /// <returns>The type</returns>
        public string Vehicle()
        {
            return "MC";
        }
        #endregion
    }
}
