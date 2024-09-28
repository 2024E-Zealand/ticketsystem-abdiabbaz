using System.Numerics;

namespace TicketClassLibrary
{
    public class Car : Vehicle
    {

        /// <summary>
        /// This is a method to get the price.
        /// </summary>
        /// <returns>Returns the price 240</returns>
        public override double Price()
        {
            return 240;
        }
        /// <summary>
        /// This is a method to get the Vehicle type
        /// </summary>
        /// <returns>Returns a string named Car</returns>
        public override string VehicleType()
        {
            return "Car";
        }
    }
}
