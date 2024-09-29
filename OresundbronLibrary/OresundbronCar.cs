using TicketClassLibrary;

namespace OresundbronLibrary
{
    public class OresundbronCar : Vehicle
    {


        /// <summary>
        /// This method checks if the Car has brobizz.
        /// </summary>
        /// <returns>Returns 161kr og 410kr depends on BroBizz</returns>
        public override double Price()
        {
            return HasBroBizz ? 161 : 410;
        }

        /// <summary>
        /// This methods tells the type of the Vehicle
        /// </summary>
        /// <returns>A string of the vehicle that is Car</returns>
        public override string VehicleType()
        {
            return "Oresund Car";
        }
    }
}
