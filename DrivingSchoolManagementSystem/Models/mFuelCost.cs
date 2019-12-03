using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrivingSchoolManagementSystem.Models
{
    public class mFuelCost
    {
        public int ID { get; set; }
        public string FuelCost { get; set; }
        public string Reason { get; set; }
        public int VehicleID { get; set; }

        public mFuelCost()
        {
            ID = 0;
            FuelCost = string.Empty;
            Reason = string.Empty;
            VehicleID = 0;
        }

        public mFuelCost(int pID, string pFuelCost, string pReason, int pVehicleID)
        {
            ID = pID;
            FuelCost = pFuelCost;
            Reason = pReason;
            VehicleID = pVehicleID;
        }

        public mFuelCost(string pFuelCost, string pReason, int pVehicleID)
        {
            FuelCost = pFuelCost;
            Reason = pReason;
            VehicleID = pVehicleID;
        }
    }
}
