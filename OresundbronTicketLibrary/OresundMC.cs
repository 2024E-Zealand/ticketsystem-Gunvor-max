using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketClassLibrary;

namespace OresundbronTicketLibrary
{
    /// <summary>
    /// MC sub class that inherit from the vehicle baseclass in the DLL
    /// </summary>
    /// <param name="licenseplate">Licenseplate of the motorcycle</param>
    /// <param name="date">Date for buying the ticket</param>
    /// <param name="hasBrobizz">Checks if the user has a brobizz connected</param>
    public class OresundMC(string licenseplate, DateTime date, bool hasBrobizz) : Vehicle(licenseplate, date, hasBrobizz)
    {
        /// <summary>
        /// Calcultes the ticket price. If the user have a brobizz connected they get a discount
        /// </summary>
        /// <returns>the total price </returns>
        public override double Price()
        {
            if (HasBrobizz) 
            {
                return 73;
            }
            return 210;
        }

        /// <summary>
        /// Get the vehicletype
        /// </summary>
        /// <returns>The vehicletype in a string</returns>
        public override string VehicleType()
        {
            return "Oresund MC";
        }
    }
}
