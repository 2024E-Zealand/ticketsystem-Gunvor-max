﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketClassLibrary
{
    /// <summary>
    /// Car class
    /// </summary>
    public class Car
    {

        #region Properties

        /// <summary>
        /// Licensplate for the car
        /// </summary>
        public string Licenseplate { get; set; }

        /// <summary>
        /// Date for buying the ticket
        /// </summary>
        public DateTime Date { get; set; }
        #endregion

        #region Contructor
        /// <summary>
        /// Create an instance of the class with the following properties
        /// </summary>
        /// <param name="licenseplate"> Licensplate for the car</param>
        /// <param name="date">date for buying the ticket</param>
        public Car(string licenseplate, DateTime date)
        {
            Licenseplate = licenseplate;
            Date = date;
        }

        /// <summary>
        /// Default constructor that create an instance of the object with the following properties if no specifik properties is given
        /// </summary>
        public Car() : this("0",DateTime.Now)
        {
            
        }
        #endregion

        #region Methods
        /// <summary>
        /// Generate the ticket price for a car
        /// </summary>
        /// <returns>the price</returns>
        public double Price()
        {
        return 240; 
        }

        /// <summary>
        /// Gets the vehicletype
        /// </summary>
        /// <returns>The type</returns>
        public string VehicleType()
        {
            return "Car";
        }
        #endregion
    }
}
