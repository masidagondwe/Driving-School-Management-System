using System;
using System.ComponentModel;

namespace DrivingSchoolManagementSystem.Models
{
    public class mVehicle : INotifyPropertyChanged
    {
        private int id;
        private string vehicleRegistration;
        private string trailer1Registration;
        private string trailer2Registration;
        private string make;
        private string model;
        private string type;
        private string yearManufactured;
        private DateTime dateAcquired;
        private string totalAcquisitionCost;
        private string mileageAtAcquisition;
        private string transmissionType;
        private string engineCapacity;
        private int isBranded;
        private string brandingCost;
        private byte[] vehiclePhoto1;
        private byte[] vehiclePhoto2;
        private byte[] vehiclePhoto3;




        public int ID { get { return id; } set { id = value; OnPropertyChanged("ID"); } }
        public string VehicleRegistration { get { return vehicleRegistration; } set { vehicleRegistration = value; OnPropertyChanged("VehicleRegistration"); } }
        public string Trailer1Registration { get { return trailer1Registration; } set { trailer1Registration = value; OnPropertyChanged("Trailer1Registration"); } }
        public string Trailer2Registration { get { return trailer2Registration; } set { trailer2Registration = value; OnPropertyChanged("Trailer2Registration"); } }
        public string Make { get { return make; } set { make = value; OnPropertyChanged("Make"); } }
        public string Model { get { return model; } set { model = value; OnPropertyChanged("Model"); } }
        public string Type { get { return type; } set { type = value; OnPropertyChanged("Type"); } }
        public string YearManufactured { get { return yearManufactured; } set { yearManufactured = value; OnPropertyChanged("YearManufactured"); } }
        public DateTime DateAcquired { get { return dateAcquired; } set { dateAcquired = value; OnPropertyChanged("DateAcquired"); } }
        public string TotalAcquisitionCost { get { return totalAcquisitionCost; } set { totalAcquisitionCost = value; OnPropertyChanged("TotalAcquisitionCost"); } }
        public string MileageAtAcquisition { get { return mileageAtAcquisition; } set { mileageAtAcquisition = value; OnPropertyChanged("MileageAtAcquisition"); } }
        public string TransmissionType { get { return transmissionType; } set { transmissionType = value; OnPropertyChanged("TransmissionType"); } }
        public string EngineCapacity { get { return engineCapacity; } set { engineCapacity = value; OnPropertyChanged("EngineCapacity"); } }
        public int IsBranded { get { return isBranded; } set { isBranded = value; OnPropertyChanged("IsBranded"); } }
        public string BrandingCost { get { return brandingCost; } set { brandingCost = value; OnPropertyChanged("BrandingCost"); } }
        public byte[] VehiclePhoto1 { get { return vehiclePhoto1; } set { vehiclePhoto1 = value; OnPropertyChanged("VehiclePhoto1"); } }
        public byte[] VehiclePhoto2 { get { return vehiclePhoto2; } set { vehiclePhoto2 = value; OnPropertyChanged("VehiclePhoto2"); } }
        public byte[] VehiclePhoto3 { get { return vehiclePhoto3; } set { vehiclePhoto3 = value; OnPropertyChanged("VehiclePhoto3"); } }


        public mVehicle()
        {
            ID = 0;
            VehicleRegistration = string.Empty;
            Trailer1Registration = string.Empty;
            Trailer2Registration = string.Empty;
            Make = string.Empty;
            Model = string.Empty;
            Type = string.Empty;
            YearManufactured = string.Empty;
            DateAcquired = DateTime.Parse("2000-01-01");
            TotalAcquisitionCost = string.Empty;
            MileageAtAcquisition = string.Empty;
            TransmissionType = string.Empty;
            EngineCapacity = string.Empty;
            IsBranded = 0;
            BrandingCost = string.Empty;
            VehiclePhoto1 = new byte[] { };
            VehiclePhoto2 = new byte[] { };
            VehiclePhoto3 = new byte[] { };

        }


        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        //public mVehicle(int pID, string pVehicleRegistration, string pTrailer1Registration, string pTrailer2Registration, string pMake, string pModel, string pType, string pYearManufactured, DateTime pDateAcquired, string pTotalAcquisitionCost, string pMileageAtAcquisition, string pTransmissionType, string pEngineCapacity, int pIsBranded, string pBrandingCost, byte[] pVehiclePhoto1, byte[] pVehiclePhoto2, byte[] pVehiclePhoto3)
        //{
        //    ID = pID;
        //    VehicleRegistration = pVehicleRegistration;
        //    Trailer1Registration = pTrailer1Registration;
        //    Trailer2Registration = pTrailer2Registration;
        //    Make = pMake;
        //    Model = pModel;
        //    Type = pType;
        //    YearManufactured = pYearManufactured;
        //    DateAcquired = pDateAcquired;
        //    TotalAcquisitionCost = pTotalAcquisitionCost;
        //    MileageAtAcquisition = pMileageAtAcquisition;
        //    TransmissionType = pTransmissionType;
        //    EngineCapacity = pEngineCapacity;
        //    IsBranded = pIsBranded;
        //    BrandingCost = pBrandingCost;
        //    VehiclePhoto1 = pVehiclePhoto1;
        //    VehiclePhoto2 = pVehiclePhoto2;
        //    VehiclePhoto3 = pVehiclePhoto3;

        //}

        //public mVehicle(string pVehicleRegistration, string pTrailer1Registration, string pTrailer2Registration, string pMake, string pModel, string pType, string pYearManufactured, DateTime pDateAcquired, string pTotalAcquisitionCost, string pMileageAtAcquisition, string pTransmissionType, string pEngineCapacity, int pIsBranded, string pBrandingCost, byte[] pVehiclePhoto1, byte[] pVehiclePhoto2, byte[] pVehiclePhoto3)
        //{
        //    VehicleRegistration = pVehicleRegistration;
        //    Trailer1Registration = pTrailer1Registration;
        //    Trailer2Registration = pTrailer2Registration;
        //    Make = pMake;
        //    Model = pModel;
        //    Type = pType;
        //    YearManufactured = pYearManufactured;
        //    DateAcquired = pDateAcquired;
        //    TotalAcquisitionCost = pTotalAcquisitionCost;
        //    MileageAtAcquisition = pMileageAtAcquisition;
        //    TransmissionType = pTransmissionType;
        //    EngineCapacity = pEngineCapacity;
        //    IsBranded = pIsBranded;
        //    BrandingCost = pBrandingCost;
        //    VehiclePhoto1 = pVehiclePhoto1;
        //    VehiclePhoto2 = pVehiclePhoto2;
        //    VehiclePhoto3 = pVehiclePhoto3;
        //}


    }
}
