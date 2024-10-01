using TicketClassLibrary;

namespace StoreBaeltTicketLibrary
{
    /// <summary>
    /// Interface for ticketrepository
    /// </summary>
    public interface IRepository
    {
        /// <summary>
        /// Create method for adding a ticket to the ticketlist
        /// </summary>
        /// <param name="vehicle">takes a vehicle object</param>
        /// <returns>returns the added vehicle object</returns>
        Vehicle AddTicket(Vehicle vehicle);

        /// <summary>
        /// Read method for seeing the ticketlist
        /// </summary>
        /// <returns>the ticketlist</returns>
        List<Vehicle> GetAll();

        /// <summary>
        /// Read method for getting a specifik ticket from a given licenseplate
        /// </summary>
        /// <param name="licenseplate">specifik licenseplate provided</param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException">Throws a null exception if parametervalue is null or empty</exception>
        /// <exception cref="ArgumentOutOfRangeException">Throws a out of range exception of parametervalue is under 7 chars</exception>
        Vehicle? GetByLicenseplate(string licenseplate);
    }
}