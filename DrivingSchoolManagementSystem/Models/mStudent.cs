using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrivingSchoolManagementSystem.Models
{
    public class mStudent : INotifyPropertyChanged
    {
        private int id;
        private string firstName;
        private string middleName;
        private string lastName;
        private string phoneNumber;
        private string emailAddress;
        private string occupation;
        private string placeOfWork;
        private string homeAddress;
        private string nationality;
        private DateTime dateOfBirth;
        private char maritalStatus;
        private string gender;
        private string idetificationType;
        private string identificationNumber;
        private byte[] profilePhoto;


        public int ID { get { return id; } set { id = value; OnPropertyChanged("ID"); } }
        public string FirstName { get { return firstName; } set { firstName = value; OnPropertyChanged("FirstName"); } }
        public string MiddleName { get { return middleName; } set { middleName = value; OnPropertyChanged("MiddleName"); } }
        public string LastName { get { return lastName; } set { lastName = value; OnPropertyChanged("LastName"); } }
        public string PhoneNumber { get { return phoneNumber; } set { phoneNumber = value; OnPropertyChanged("PhoneNumber"); } }
        public string EmailAddress { get { return emailAddress; } set { emailAddress = value; OnPropertyChanged("EmailAddress"); } }
        public string Occupation { get { return occupation; } set { occupation = value; OnPropertyChanged("Occupation"); } }
        public string PlaceOfWork { get { return placeOfWork; } set { placeOfWork = value; OnPropertyChanged("PlaceOfWork"); } }
        public string HomeAddress { get { return homeAddress; } set { homeAddress = value; OnPropertyChanged("HomeAddress"); } }
        public string Nationality { get { return nationality; } set { nationality = value; OnPropertyChanged("Nationality"); } }
        public DateTime DateOfBirth { get { return dateOfBirth; } set { dateOfBirth = value; OnPropertyChanged("DateOfBirth"); } }
        public char MaritalStatus { get { return maritalStatus; } set { maritalStatus = value; OnPropertyChanged("MaritalStatus"); } }
        public string Gender { get { return gender; } set { gender = value; OnPropertyChanged("Gender"); } }
        public string IndetificationType { get { return idetificationType; } set { idetificationType = value; OnPropertyChanged("IndetificationType"); } }
        public string IdentificationNumber { get { return identificationNumber; } set { identificationNumber = value; OnPropertyChanged("IdentificationNumber"); } }
        public byte[] ProfilePhoto { get { return profilePhoto; } set { profilePhoto = value; OnPropertyChanged("ProfilePhoto"); } }

        public mStudent() { }


        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }



        //public mStudent(int pID, string pFirstName, string pMiddeleName, string pLastName, string pPhoneNumber, string pEmailAddress, string pOccupation, string pPlaceOfWork, string pHomeAddress, string pNationality, DateTime pDateOfBirth, char pMaritalStatus, string pGender, string pIndetificationType, string pIdentificationNumber, byte[] pProfilePhoto)
        //{
        //    ID = pID;
        //    FirstName = pFirstName;
        //    MiddleName = pMiddeleName;
        //    LastName = pLastName;
        //    PhoneNumber = pPhoneNumber;
        //    EmailAddress = pEmailAddress;
        //    Occupation = pOccupation;
        //    PlaceOfWork = pPlaceOfWork;
        //    HomeAddress = pHomeAddress;
        //    Nationality = pNationality;
        //    DateOfBirth = pDateOfBirth;
        //    MaritalStatus = pMaritalStatus;
        //    Gender = pGender;
        //    IdentificationNumber = pIndetificationType;
        //    IdentificationNumber = pIdentificationNumber;
        //    ProfilePhoto = pProfilePhoto;
        //}

        //public mStudent(string pFirstName, string pMiddeleName, string pLastName, string pPhoneNumber, string pEmailAddress, string pOccupation, string pPlaceOfWork, string pHomeAddress, string pNationality, DateTime pDateOfBirth, char pMaritalStatus, string pGender, string pIndetificationType, string pIdentificationNumber, byte[] pProfilePhoto)
        //{
        //    FirstName = pFirstName;
        //    MiddleName = pMiddeleName;
        //    LastName = pLastName;
        //    PhoneNumber = pPhoneNumber;
        //    EmailAddress = pEmailAddress;
        //    Occupation = pOccupation;
        //    PlaceOfWork = pPlaceOfWork;
        //    HomeAddress = pHomeAddress;
        //    Nationality = pNationality;
        //    DateOfBirth = pDateOfBirth;
        //    MaritalStatus = pMaritalStatus;
        //    Gender = pGender;
        //    IdentificationNumber = pIndetificationType;
        //    IdentificationNumber = pIdentificationNumber;
        //    ProfilePhoto = pProfilePhoto;
        //}

    }
}
