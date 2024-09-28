﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketClassLibrary
{
    public abstract class Vehicle
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
		protected string LicensePlate
        {
            get { return _licensePlate; }
            set { _licensePlate = value; }
        }

        /// <summary>
        /// This is a property that gets and sets the Date
        /// </summary>
        protected DateTime Date
        {
            get { return _date; }
            set { _date = value; }
        }

        public abstract double Price();

        public abstract string VehicleType();

    }
}
