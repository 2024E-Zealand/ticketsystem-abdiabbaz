using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketClassLibrary;

namespace OresundbronLibrary
{
    public class OresundbronMC : Vehicle
    {

        /// <summary>
        /// This method checks if the MC has brobizz.
        /// </summary>
        /// <returns>Returns 73kr og 210kr depends on BroBizz</returns>
        public override double Price()
        {
            return HasBroBizz ? 73 : 210;
        }

        /// <summary>
        /// This methods tells the type of the Vehicle
        /// </summary>
        /// <returns>A string of the vehicle that is MC</returns>
        public override string VehicleType()
        {
            return "Oresund MC";
        }
    }
}
