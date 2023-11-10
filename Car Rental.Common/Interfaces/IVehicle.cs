using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Car_Rental.Common.Classes;
using Car_Rental.Common.Enums;

namespace Car_Rental.Common.Interfaces;

public interface IVehicle
{

    public string regNo { get; set; }
    public string make { get; set; }
    public int odo { get; set; }
    public double costKm { get; set; }
    public double costDay { get; set; }
    public VehicleTypes vehicleType { get; set; }
    public VehicleStatuses vehicleStatus { get; set; }

}
