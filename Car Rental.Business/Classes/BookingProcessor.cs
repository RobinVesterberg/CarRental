using Car_Rental.Common.Enums;
using Car_Rental.Common.Classes;
using Car_Rental.Common.Interfaces;
using Car_Rental.Data.Interfaces;
using Car_Rental.Data.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Cache;
using System.Security.Cryptography.X509Certificates;
using System.Reflection.Metadata.Ecma335;
using System.ComponentModel.Design;
using System.Runtime.ConstrainedExecution;


namespace Car_Rental.Business.Classes;

public class BookingProcessor 
{
    private readonly IData _db;

    public BookingProcessor(IData db) => _db = db;

    public double CalculateTotalPrice(IBooking booking, IVehicle vehicle)
    {
        double totalPrice = 0.0;

        double costKm = vehicle.costKm;
        double costDay = vehicle.costDay;
        double kmRented = booking.kmRented;
        double kmReturned = booking.kmReturned;
        double daysRented = booking.daysRented;

        double costBasedOnKm = (kmReturned - kmRented) * costKm;
        double costBasedOnDays = (daysRented > 0 ? daysRented : 1) * costDay;

        totalPrice = costBasedOnKm + costBasedOnDays;

        return totalPrice;
    }
   
    public double CalculateTotalPrice(Booking booking, Car car)
    {
        double totalPrice = booking.CalculateTotalPrice(car);
        return totalPrice;
    }
    public IEnumerable<Customer> GetCustomers()
    {
        return _db.GetPersons().Where(person => person is Customer).Cast<Customer>();
    }

    public IEnumerable<IVehicle> GetVehicles(VehicleStatuses status = default)
    {
        return _db.GetVehicles(status);
    }
    public IEnumerable<IBooking> GetBookings()
    {
        return _db.GetBookings();
    }

}
