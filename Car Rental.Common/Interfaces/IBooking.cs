using Car_Rental.Common.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Rental.Common.Interfaces
{
    public interface IBooking
    {
        public string fullName { get; set; }
        public string regNo { get; set; }
        public double kmRented { get; set; }
        public double kmReturned { get; set; }
        public string dateRented { get; set; }
        public string dateReturned { get; set; }
        public double daysRented { get; set; }
        public VehicleStatuses vehicleStatus { get; set; }
    }
}
