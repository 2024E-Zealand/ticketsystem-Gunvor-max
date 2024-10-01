using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StoreBaeltTicketLibrary;

namespace StoreBaeltTicketLibrary
{
    /// <summary>
    /// Repository class that contains Create and Read operations for managing tickets
    /// </summary>
    public class Repository : IRepository
    {
        /// <summary>
        /// Static ticketlist
        /// </summary>
        private static List<Vehicle> TicketList { get; set; }

        /// <summary>
        /// Creates an instance of the class with an empty list
        /// </summary>
        public Repository()
        {
            TicketList = new List<Vehicle>();
        }

        StoreBaeltTicketLibrary.

        /// <summary>
        /// Create method for adding a ticket to the ticketlist
        /// </summary>
        /// <param name="vehicle">takes a vehicle object</param>
        /// <returns>returns the added vehicle object</returns>
        public Vehicle AddTicket(Vehicle vehicle)
        {
            TicketList.Add(vehicle);

            return vehicle;
        }

        /// <summary>
        /// Read method for seeing the ticketlist
        /// </summary>
        /// <returns>the ticketlist</returns>
        public List<Vehicle> GetAll()
        {
            return TicketList;
        }

        /// <summary>
        /// Read method for getting a specifik ticket from a given licenseplate
        /// </summary>
        /// <param name="licenseplate">specifik licenseplate provided</param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException">Throws a null exception if parametervalue is null or empty</exception>
        /// <exception cref="ArgumentOutOfRangeException">Throws a out of range exception of parametervalue is under 7 chars</exception>
        public Vehicle? GetByLicenseplate(string licenseplate)
        {
            if (string.IsNullOrEmpty(licenseplate))
            {
                throw new ArgumentNullException("A licenseplate must be specified");
            }
            else if (licenseplate.Length < 7)
            {
                throw new ArgumentOutOfRangeException("Licenseplate cannot be under 7 chars");
            }
            return TicketList.FirstOrDefault(v => v.Licenseplate == licenseplate);
        }
    }
}
