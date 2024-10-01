using TicketClassLibrary;

namespace StoreBaeltTicketLibrary
{
    public interface IStorebaeltRepo
    {
        Vehicle Add(Vehicle vehicle);
        IEnumerable<Vehicle> GetAll();
        Vehicle? GetLicensePlate(string licensePlate);
    }
}