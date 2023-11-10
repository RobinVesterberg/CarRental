using Car_Rental.Common.Enums;
using Car_Rental.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Rental.Common.Classes
{
    public class Motorcycle : IVehicle
    {
        public String regNo { get; set; }
        public String make { get; set; }
        public int odo { get; set; }
        public double costKm { get; set; }
        public double costDay { get; set; }
        public VehicleTypes vehicleType { get; set; }
        public VehicleStatuses vehicleStatus { get; set; }

        public Motorcycle(string RegNo, string Make, int Odo, double CostKm, double CostDay, VehicleTypes VehicleType, VehicleStatuses VehicleStatus)
        {
            this.regNo = RegNo;
            this.make = Make;
            this.odo = Odo;
            this.costKm = CostKm;
            this.costDay = CostDay;
            this.vehicleType = VehicleType;
            this.vehicleStatus = VehicleStatus;
        }
    }
}

 

