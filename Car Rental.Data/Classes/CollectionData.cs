using Car_Rental.Common.Enums;
using Car_Rental.Data.Interfaces;
using Car_Rental.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.NetworkInformation;
using Car_Rental.Common.Classes;
using System.Security.Cryptography.X509Certificates;
using System.Runtime.ConstrainedExecution;

namespace Car_Rental.Data.Classes;

public class CollectionData : IData 
{
   
    readonly List<IPerson> _persons = new List<IPerson>();
    readonly List<IVehicle> _vehicles = new List<IVehicle>();
    readonly List<IBooking> _bookings = new List<IBooking>();

    public CollectionData() => SeedData();

    void SeedData()
    {
        _persons.Add(new Customer("Janne", "Svensson", "19375"));
        _persons.Add(new Customer("Jane", "Greene", "97531"));
        _persons.Add(new Customer("John", "Smith", "13579"));

        _vehicles.Add(new Car("COM123", "Volvo", 30000, 2, 150, VehicleTypes.Combi, VehicleStatuses.Available));
        _vehicles.Add(new Car("SED123", "Tesla", 7000, 2, 200, VehicleTypes.Sedan, VehicleStatuses.Available));
        _vehicles.Add(new Car("SED456", "Mercedes", 14000, 2, 200, VehicleTypes.Sedan, VehicleStatuses.Available));
        _vehicles.Add(new Car("VAN123", "Volkswagen", 40000, 2, 200, VehicleTypes.Van, VehicleStatuses.Booked));
        _vehicles.Add(new Motorcycle("BIK123", "Suzuki", 1400, 1, 70, VehicleTypes.Motorcycle, VehicleStatuses.Available));

        _bookings.Add(new Booking("Jane Greene", "BIK123", 1400, 1700, "15/6/2023", "16/6/2023", 1, VehicleStatuses.Closed));
        _bookings.Add(new Booking("John Smith", "SED123", 7000, 7000, "16/6/2023", "16/6/2023", 0, VehicleStatuses.Closed));
        _bookings.Add(new Booking("Janne Svensson", "VAN123", 40000, 40000, "16/6/2023", "", 0, VehicleStatuses.Open));
    }
    
    public IEnumerable<IPerson> GetPersons() => _persons;
    
   
    public IEnumerable<IBooking> GetBookings() => _bookings;
    
    public IEnumerable<IVehicle> GetVehicles(VehicleStatuses status = default)
    {
        if (status == default)
        {
            return _vehicles;
        }
        else
        {
            return _vehicles.Where(v => v.vehicleStatus == VehicleStatuses.Booked);
        }
    }
    
}






















