using System;
using System.ComponentModel;

namespace DrivingSchoolManagementSystem.Models
{
    public class mInstructor : INotifyPropertyChanged
    {
        private int id;
        private string firstName;
        private string middleName;
        private string lastName;
        private string phoneNumber;
        private string emailAddress;
        private string jobTitle;
        private DateTime dateOfHire;
        private string homeAddress;
        private string nationality;
        private DateTime dateOfBirth;
        private char maritalStatus;
        private string gender;
        private string idetificationType;
        private string identificationNumber;
        private byte[] profilePhoto;
        private int licenseID;
        private int emergencyContactID;
        private int disabiltyID;


        public int ID { get { return id; } set { id = value; OnPropertyChanged("ID"); } }
        public string FirstName { get { return firstName; } set { firstName = value; OnPropertyChanged("FirstName"); } }
        public string MiddleName { get { return middleName; } set { middleName = value; OnPropertyChanged("MiddleName"); } }
        public string LastName { get { return lastName; } set { lastName = value; OnPropertyChanged("LastName"); } }
        public string PhoneNumber { get { return phoneNumber; } set { phoneNumber = value; OnPropertyChanged("PhoneNumber"); } }
        public string EmailAddress { get { return emailAddress; } set { emailAddress = value; OnPropertyChanged("EmailAddress"); } }
        public string JobTitle { get { return jobTitle; } set { jobTitle = value; OnPropertyChanged("JobTitle"); } }
        public DateTime DateOfHire { get { return dateOfHire; } set { dateOfHire = value; OnPropertyChanged("DateOfHire"); } }
        public string HomeAddress { get { return homeAddress; } set { homeAddress = value; OnPropertyChanged("HomeAddress"); } }
        public string Nationality { get { return nationality; } set { nationality = value; OnPropertyChanged("Nationality"); } }
        public DateTime DateOfBirth { get { return dateOfBirth; } set { dateOfBirth = value; OnPropertyChanged("DateOfBirth"); } }
        public char MaritalStatus { get { return maritalStatus; } set { maritalStatus = value; OnPropertyChanged("MaritalStatus"); } }
        public string Gender { get { return gender; } set { gender = value; OnPropertyChanged("Gender"); } }
        public string IndetificationType { get { return idetificationType; } set { idetificationType = value; OnPropertyChanged("IndetificationType"); } }
        public string IdentificationNumber { get { return identificationNumber; } set { identificationNumber = value; OnPropertyChanged("IdentificationNumber"); } }
        public byte[] ProfilePhoto { get { return profilePhoto; } set { profilePhoto = value; OnPropertyChanged("ProfilePhoto"); } }
        public int LicenseID { get { return licenseID; } set { licenseID = value; OnPropertyChanged("LicenseID"); } }
        public int EmergencyContactID { get { return emergencyContactID; } set { emergencyContactID = value; OnPropertyChanged("EmergencyContactID"); } }
        public int DisabiltyID { get { return disabiltyID; } set { disabiltyID = value; OnPropertyChanged("DisabiltyID"); } }

        public mInstructor()
        {
            //ID = 0;
            //FirstName = string.Empty;
            //MiddleName = string.Empty;
            //LastName = string.Empty;
            //PhoneNumber = string.Empty;
            //EmailAddress = string.Empty;
            //JobTitle = string.Empty;
            //DateOfHire = DateTime.Parse("2000-01-01");
            //HomeAddress = string.Empty;
            //Nationality = string.Empty;
            //DateOfBirth = DateTime.Parse("2000-01-01");
            //MaritalStatus = 'N';
            //Gender = string.Empty;
            //IdentificationNumber = string.Empty;
            //IdentificationNumber = string.Empty;
            //ProfilePhoto = new byte[] { };

            //LicenseID = 0;
            //EmergencyContactID = 0;
            //DisabiltyID = 0;
        }



        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }


        //public mInstructor(int pID, string pFirstName, string pMiddeleName, string pLastName, string pPhoneNumber, string pEmailAddress, string pJobTitle, DateTime pDateOfHire, string pHomeAddress, string pNationality, DateTime pDateOfBirth, char pMaritalStatus, string pGender, string pIndetificationType, string pIdentificationNumber, byte[] pProfilePhoto, int pLicenseID, int pEmergencyContactID, int pDisabilityID) 
        //{
        //    ID = pID;
        //    FirstName = pFirstName;
        //    MiddleName = pMiddeleName;
        //    LastName = pLastName;
        //    PhoneNumber = pPhoneNumber;
        //    EmailAddress = pEmailAddress;
        //    JobTitle = pJobTitle;
        //    DateOfHire = pDateOfHire;
        //    HomeAddress = pHomeAddress;
        //    Nationality = pNationality;
        //    DateOfBirth = pDateOfBirth;
        //    MaritalStatus = pMaritalStatus;
        //    Gender = pGender;
        //    IdentificationNumber = pIndetificationType;
        //    IdentificationNumber = pIdentificationNumber;
        //    ProfilePhoto = pProfilePhoto;

        //    LicenseID = pLicenseID;
        //    EmergencyContactID = pEmergencyContactID;
        //    DisabiltyID = pDisabilityID;
        //}


        //public mInstructor(string pFirstName, string pMiddeleName, string pLastName, string pPhoneNumber, string pEmailAddress, string pJobTitle, DateTime pDateOfHire, string pHomeAddress, string pNationality, DateTime pDateOfBirth, char pMaritalStatus, string pGender, string pIndetificationType, string pIdentificationNumber, byte[] pProfilePhoto, int pLicenseID, int pEmergencyContactID, int pDisabilityID)
        //{
        //    FirstName = pFirstName;
        //    MiddleName = pMiddeleName;
        //    LastName = pLastName;
        //    PhoneNumber = pPhoneNumber;
        //    EmailAddress = pEmailAddress;
        //    JobTitle = pJobTitle;
        //    DateOfHire = pDateOfHire;
        //    HomeAddress = pHomeAddress;
        //    Nationality = pNationality;
        //    DateOfBirth = pDateOfBirth;
        //    MaritalStatus = pMaritalStatus;
        //    Gender = pGender;
        //    IdentificationNumber = pIndetificationType;
        //    IdentificationNumber = pIdentificationNumber;
        //    ProfilePhoto = pProfilePhoto;

        //    LicenseID = pLicenseID;
        //    EmergencyContactID = pEmergencyContactID;
        //    DisabiltyID = pDisabilityID;
        //}

    }
}
