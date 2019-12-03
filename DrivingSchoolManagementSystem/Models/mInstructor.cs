using System;

namespace DrivingSchoolManagementSystem.Models
{
    public class mInstructor
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string EmailAddress { get; set; }
        public string JobTitle { get; set; }
        public DateTime DateOfHire { get; set; }
        public string HomeAddress { get; set; }
        public string Nationality { get; set; }
        public DateTime DateOfBirth { get; set; }
        public char MaritalStatus { get; set; }
        public string Gender { get; set; }
        public string IndetificationType { get; set; }
        public string IdentificationNumber { get; set; }
        public byte[] ProfilePhoto { get; set; }
        public int LicenseID { get; set; }
        public int EmergencyContactID { get; set; }
        public int DisabiltyID { get; set; }

        public mInstructor()
        {
            ID = 0;
            FirstName = string.Empty;
            MiddleName = string.Empty;
            LastName = string.Empty;
            PhoneNumber = string.Empty;
            EmailAddress = string.Empty;
            JobTitle = string.Empty;
            DateOfHire = DateTime.Parse("2000-01-01");
            HomeAddress = string.Empty;
            Nationality = string.Empty;
            DateOfBirth = DateTime.Parse("2000-01-01");
            MaritalStatus = 'N';
            Gender = string.Empty;
            IdentificationNumber = string.Empty;
            IdentificationNumber = string.Empty;
            ProfilePhoto = new byte[] { };

            LicenseID = 0;
            EmergencyContactID = 0;
            DisabiltyID = 0;
        }

        public mInstructor(int pID, string pFirstName, string pMiddeleName, string pLastName, string pPhoneNumber, string pEmailAddress, string pJobTitle, DateTime pDateOfHire, string pHomeAddress, string pNationality, DateTime pDateOfBirth, char pMaritalStatus, string pGender, string pIndetificationType, string pIdentificationNumber, byte[] pProfilePhoto, int pLicenseID, int pEmergencyContactID, int pDisabilityID) 
        {
            ID = pID;
            FirstName = pFirstName;
            MiddleName = pMiddeleName;
            LastName = pLastName;
            PhoneNumber = pPhoneNumber;
            EmailAddress = pEmailAddress;
            JobTitle = pJobTitle;
            DateOfHire = pDateOfHire;
            HomeAddress = pHomeAddress;
            Nationality = pNationality;
            DateOfBirth = pDateOfBirth;
            MaritalStatus = pMaritalStatus;
            Gender = pGender;
            IdentificationNumber = pIndetificationType;
            IdentificationNumber = pIdentificationNumber;
            ProfilePhoto = pProfilePhoto;

            LicenseID = pLicenseID;
            EmergencyContactID = pEmergencyContactID;
            DisabiltyID = pDisabilityID;
        }


        public mInstructor(string pFirstName, string pMiddeleName, string pLastName, string pPhoneNumber, string pEmailAddress, string pJobTitle, DateTime pDateOfHire, string pHomeAddress, string pNationality, DateTime pDateOfBirth, char pMaritalStatus, string pGender, string pIndetificationType, string pIdentificationNumber, byte[] pProfilePhoto, int pLicenseID, int pEmergencyContactID, int pDisabilityID)
        {
            FirstName = pFirstName;
            MiddleName = pMiddeleName;
            LastName = pLastName;
            PhoneNumber = pPhoneNumber;
            EmailAddress = pEmailAddress;
            JobTitle = pJobTitle;
            DateOfHire = pDateOfHire;
            HomeAddress = pHomeAddress;
            Nationality = pNationality;
            DateOfBirth = pDateOfBirth;
            MaritalStatus = pMaritalStatus;
            Gender = pGender;
            IdentificationNumber = pIndetificationType;
            IdentificationNumber = pIdentificationNumber;
            ProfilePhoto = pProfilePhoto;

            LicenseID = pLicenseID;
            EmergencyContactID = pEmergencyContactID;
            DisabiltyID = pDisabilityID;
        }
    }
}
