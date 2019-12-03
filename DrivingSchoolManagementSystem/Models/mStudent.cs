using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrivingSchoolManagementSystem.Models
{
    public class mStudent
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string EmailAddress { get; set; }
        public string Occupation { get; set; }
        public string PlaceOfWork { get; set; }
        public string HomeAddress { get; set; }
        public string Nationality { get; set; }
        public DateTime DateOfBirth { get; set; }
        public char MaritalStatus { get; set; }
        public string Gender { get; set; }
        public string IndetificationType { get; set; }
        public string IdentificationNumber { get; set; }
        public byte[] ProfilePhoto { get; set; }

        public mStudent() { }

        public mStudent(int pID, string pFirstName, string pMiddeleName, string pLastName, string pPhoneNumber, string pEmailAddress, string pOccupation, string pPlaceOfWork, string pHomeAddress, string pNationality, DateTime pDateOfBirth, char pMaritalStatus, string pGender, string pIndetificationType, string pIdentificationNumber, byte[] pProfilePhoto)
        {
            ID = pID;
            FirstName = pFirstName;
            MiddleName = pMiddeleName;
            LastName = pLastName;
            PhoneNumber = pPhoneNumber;
            EmailAddress = pEmailAddress;
            Occupation = pOccupation;
            PlaceOfWork = pPlaceOfWork;
            HomeAddress = pHomeAddress;
            Nationality = pNationality;
            DateOfBirth = pDateOfBirth;
            MaritalStatus = pMaritalStatus;
            Gender = pGender;
            IdentificationNumber = pIndetificationType;
            IdentificationNumber = pIdentificationNumber;
            ProfilePhoto = pProfilePhoto;
        }

        public mStudent(string pFirstName, string pMiddeleName, string pLastName, string pPhoneNumber, string pEmailAddress, string pOccupation, string pPlaceOfWork, string pHomeAddress, string pNationality, DateTime pDateOfBirth, char pMaritalStatus, string pGender, string pIndetificationType, string pIdentificationNumber, byte[] pProfilePhoto)
        {
            FirstName = pFirstName;
            MiddleName = pMiddeleName;
            LastName = pLastName;
            PhoneNumber = pPhoneNumber;
            EmailAddress = pEmailAddress;
            Occupation = pOccupation;
            PlaceOfWork = pPlaceOfWork;
            HomeAddress = pHomeAddress;
            Nationality = pNationality;
            DateOfBirth = pDateOfBirth;
            MaritalStatus = pMaritalStatus;
            Gender = pGender;
            IdentificationNumber = pIndetificationType;
            IdentificationNumber = pIdentificationNumber;
            ProfilePhoto = pProfilePhoto;
        }
    }
}
