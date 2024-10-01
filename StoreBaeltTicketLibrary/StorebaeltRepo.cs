using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketClassLibrary;

namespace StoreBaeltTicketLibrary
{
    public class StorebaeltRepo : IStorebaeltRepo
    {

        public static List<Vehicle> Vehicles = new List<Vehicle>();

        public Vehicle Add(Vehicle vehicle)
        {
            Vehicles.Add(vehicle);

            return vehicle;
        }

        public Vehicle? GetLicensePlate(string licensePlate)
        {
            return Vehicles.Find(x => x.LicensePlate == licensePlate);
        }

        public IEnumerable<Vehicle> GetAll()
        {
            return Vehicles;
        }
    }
}
