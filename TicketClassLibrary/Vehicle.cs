using System;
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
		public string LicensePlate
        {
            get { return _licensePlate; }
            set 
            { 
                if (string.IsNullOrWhiteSpace(value) || value.Length > 7)
                {
                    throw new ArgumentOutOfRangeException("Licenseplate must be under 7 characters.");
                }

                _licensePlate = value; 
            }
        }

        /// <summary>
        /// This propery can be used to see if the vehicle has Brobizz
        /// </summary>
        public bool HasBroBizz { get; set; }

        /// <summary>
        /// This is a property that gets and sets the Date
        /// </summary>
        public DateTime Date
        {
            get { return _date; }
            set { _date = value; }
        }

        /// <summary>
        /// This method is not implented. But is used as a template for the subclasses
        /// </summary>
        /// <returns>Nothing</returns>
        public abstract double Price();

        /// <summary>
        /// This method is not implented. But is used as a template for the subclasses
        /// </summary>
        /// <returns>Nothing</returns>
        public abstract string VehicleType();

    }
}
