using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrivingSchoolManagementSystem.Models
{
    public class mEmergencyContact : INotifyPropertyChanged
    {
        private int id;
        private string firstName;
        private string lastName;
        private string phoneNumber;
        private string relationship;


        public int ID { get { return id; } set { id = value; OnPropertyChanged("ID"); } }
        public string FirstName { get { return firstName; } set { firstName = value; OnPropertyChanged("FirstName"); } }
        public string LastName { get { return lastName; } set { lastName = value; OnPropertyChanged("LastName"); } }
        public string PhoneNumber { get { return phoneNumber; } set { phoneNumber = value; OnPropertyChanged("PhoneNumber"); } }
        public string Relationship { get { return relationship; } set { relationship = value; OnPropertyChanged("Relationship"); } }

        public mEmergencyContact() { }

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        //public mEmergencyContact(int pID, string pFirstName, string pLastName, string pPhoneNumber, string pRelationship)
        //{
        //    ID = pID;
        //    FirstName = pFirstName;
        //    LastName = pLastName;
        //    PhoneNumber = pPhoneNumber;
        //    Relationship = pRelationship;
        //}

        //public mEmergencyContact(string pFirstName, string pLastName, string pPhoneNumber, string pRelationship)
        //{
        //    FirstName = pFirstName;
        //    LastName = pLastName;
        //    PhoneNumber = pPhoneNumber;
        //    Relationship = pRelationship;
        //}
    }
}
