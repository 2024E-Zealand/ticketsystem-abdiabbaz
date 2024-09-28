﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketClassLibrary
{
    public class MC
    {
        /// <summary>
        /// This is a instance field called LisencePlate. It is used for property.
        /// </summary>
		private string _licensePlate;

        /// This is a instance field called Date. It is used for property.

        private DateTime _date;


        /// <summary>
        /// This is a property that gets the "LicensePlate and can be set to whatever LicensePlate number."
        /// </summary>
		public string LicensePlate
        {
            get { return _licensePlate; }
            set { _licensePlate = value; }
        }

        /// <summary>
        /// This is a property that gets and sets the Date
        /// </summary>
        public DateTime Date
        {
            get { return _date; }
            set { _date = value; }
        }


        /// <summary>
        /// This is a method to get the price.
        /// </summary>
        /// <returns>Returns the price 125</returns>
        public double Price()
        {
            return 125;
        }
        /// <summary>
        /// This is a method to get the Vehicle type
        /// </summary>
        /// <returns>Returns a string named MC</returns>
        public string VehicleType()
        {
            return "MC";
        }
    }
}
