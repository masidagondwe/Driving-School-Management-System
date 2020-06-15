using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrivingSchoolManagementSystem.Models
{
    public class mFuelCost : INotifyPropertyChanged
    {
        private int id;
        private string fuelCost;
        private string reason;
        private int vehicleID;

        public int ID { get { return id; } set { id = value; OnPropertyChanged("ID"); } }
        public string FuelCost { get { return fuelCost; } set { fuelCost = value; OnPropertyChanged("FuelCost"); } }
        public string Reason { get { return reason; } set { reason = value; OnPropertyChanged("Reason"); } }
        public int VehicleID { get { return vehicleID; } set { vehicleID = value; OnPropertyChanged("VehicleID"); } }

        public mFuelCost()
        {
            //ID = 0;
            //FuelCost = string.Empty;
            //Reason = string.Empty;
            //VehicleID = 0;
        }


        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        //public mFuelCost(int pID, string pFuelCost, string pReason, int pVehicleID)
        //{
        //    ID = pID;
        //    FuelCost = pFuelCost;
        //    Reason = pReason;
        //    VehicleID = pVehicleID;
        //}

        //public mFuelCost(string pFuelCost, string pReason, int pVehicleID)
        //{
        //    FuelCost = pFuelCost;
        //    Reason = pReason;
        //    VehicleID = pVehicleID;
        //}
    }
}
