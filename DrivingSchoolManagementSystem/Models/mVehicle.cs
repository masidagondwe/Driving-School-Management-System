using System;

namespace DrivingSchoolManagementSystem.Models
{
    public class mVehicle
    {
        public int ID { get; set; }
        public string VehicleRegistration { get; set; }
        public string Trailer1Registration { get; set; }
        public string Trailer2Registration { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string Type { get; set; }
        public string YearManufactured { get; set; }
        public DateTime DateAcquired { get; set; }
        public string TotalAcquisitionCost { get; set; }
        public string MileageAtAcquisition { get; set; }
        public string TransmissionType { get; set; }
        public string EngineCapacity { get; set; }
        public int IsBranded { get; set; }
        public string BrandingCost { get; set; }
        public byte[] VehiclePhoto1 { get; set; }
        public byte[] VehiclePhoto2 { get; set; }
        public byte[] VehiclePhoto3 { get; set; }


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


        public mVehicle(int pID, string pVehicleRegistration, string pTrailer1Registration, string pTrailer2Registration, string pMake, string pModel, string pType, string pYearManufactured, DateTime pDateAcquired, string pTotalAcquisitionCost, string pMileageAtAcquisition, string pTransmissionType, string pEngineCapacity, int pIsBranded, string pBrandingCost, byte[] pVehiclePhoto1, byte[] pVehiclePhoto2, byte[] pVehiclePhoto3)
        {
            ID = pID;
            VehicleRegistration = pVehicleRegistration;
            Trailer1Registration = pTrailer1Registration;
            Trailer2Registration = pTrailer2Registration;
            Make = pMake;
            Model = pModel;
            Type = pType;
            YearManufactured = pYearManufactured;
            DateAcquired = pDateAcquired;
            TotalAcquisitionCost = pTotalAcquisitionCost;
            MileageAtAcquisition = pMileageAtAcquisition;
            TransmissionType = pTransmissionType;
            EngineCapacity = pEngineCapacity;
            IsBranded = pIsBranded;
            BrandingCost = pBrandingCost;
            VehiclePhoto1 = pVehiclePhoto1;
            VehiclePhoto2 = pVehiclePhoto2;
            VehiclePhoto3 = pVehiclePhoto3;

        }

        public mVehicle(string pVehicleRegistration, string pTrailer1Registration, string pTrailer2Registration, string pMake, string pModel, string pType, string pYearManufactured, DateTime pDateAcquired, string pTotalAcquisitionCost, string pMileageAtAcquisition, string pTransmissionType, string pEngineCapacity, int pIsBranded, string pBrandingCost, byte[] pVehiclePhoto1, byte[] pVehiclePhoto2, byte[] pVehiclePhoto3)
        {
            VehicleRegistration = pVehicleRegistration;
            Trailer1Registration = pTrailer1Registration;
            Trailer2Registration = pTrailer2Registration;
            Make = pMake;
            Model = pModel;
            Type = pType;
            YearManufactured = pYearManufactured;
            DateAcquired = pDateAcquired;
            TotalAcquisitionCost = pTotalAcquisitionCost;
            MileageAtAcquisition = pMileageAtAcquisition;
            TransmissionType = pTransmissionType;
            EngineCapacity = pEngineCapacity;
            IsBranded = pIsBranded;
            BrandingCost = pBrandingCost;
            VehiclePhoto1 = pVehiclePhoto1;
            VehiclePhoto2 = pVehiclePhoto2;
            VehiclePhoto3 = pVehiclePhoto3;
        }
    }
}
