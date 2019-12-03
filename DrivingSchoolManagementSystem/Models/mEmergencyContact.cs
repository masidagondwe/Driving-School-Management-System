using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrivingSchoolManagementSystem.Models
{
    public class mEmergencyContact
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Relationship { get; set; }

        public mEmergencyContact() { }

        public mEmergencyContact(int pID, string pFirstName, string pLastName, string pPhoneNumber, string pRelationship)
        {
            ID = pID;
            FirstName = pFirstName;
            LastName = pLastName;
            PhoneNumber = pPhoneNumber;
            Relationship = pRelationship;
        }

        public mEmergencyContact(string pFirstName, string pLastName, string pPhoneNumber, string pRelationship)
        {
            FirstName = pFirstName;
            LastName = pLastName;
            PhoneNumber = pPhoneNumber;
            Relationship = pRelationship;
        }
    }
}
