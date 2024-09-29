using TicketClassLibrary;

namespace StoreBaeltTicketLibrary
{
    public class StoreBaeltCar : Car
    {

        public override double Price()
        {
            double finalPrice = 240;

            if (Date.DayOfWeek == DayOfWeek.Saturday || Date.DayOfWeek == DayOfWeek.Sunday)
            {
                finalPrice *= 0.80;
            }

            if (HasBroBizz)
            {
              finalPrice *= 0.95;
            }

            return finalPrice;
        }

        public override string VehicleType()
        {
            return "StoreBaelt";
        }

    }
}
