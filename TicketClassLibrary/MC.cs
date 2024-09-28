using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketClassLibrary
{
    public class MC : Vehicle
    {

        /// <summary>
        /// This is a method to get the price.
        /// </summary>
        /// <returns>Returns the price 125</returns>
        public override double Price()
        {
            return 125;
        }
        /// <summary>
        /// This is a method to get the Vehicle type
        /// </summary>
        /// <returns>Returns a string named MC</returns>
        public override string VehicleType()
        {
            return "MC";
        }
    }
}
