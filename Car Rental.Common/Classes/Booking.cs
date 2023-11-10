using Car_Rental.Common.Enums;
using Car_Rental.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Car_Rental.Common.Classes;

public class Booking : IBooking
{

    public string fullName { get; set; }
    public string regNo { get; set; }
    public double kmRented { get; set; }
    public double kmReturned { get; set; }
    public string dateRented { get; set; }
    public string dateReturned { get; set; }
    public double daysRented { get; set; }
    public VehicleStatuses vehicleStatus { get; set; }
  
    public double CalculateTotalPrice(Car car)
    {
        double costByDays = daysRented > 0 ? car.costDay * daysRented : car.costDay;
        double costByKm = (kmReturned - kmRented) * car.costKm;

        double totalPrice = costByDays + costByKm;

        return totalPrice;
    }

    public Booking(string FullName, string RegNo,double KmRented, double KmReturned, string DateRented, string DateReturned, double DaysRented, VehicleStatuses VehicleStatus)
    {
        this.fullName = FullName;
        this.regNo = RegNo;
        this.kmRented = KmRented;
        this.kmReturned = KmReturned;
        this.dateRented = DateRented;
        this.dateReturned = DateReturned;
        this.daysRented = DaysRented;
        this.vehicleStatus = VehicleStatus;
    }
}
