using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrivingSchoolManagementSystem.Models
{
    public class mDisability
    {
        public int ID { get; set; }
        public string NameOfDisability { get; set; }
        public string AffectedBodyPart { get; set; }

        public mDisability() { }

        public mDisability(int pID, string pNameOfDisability, string pAffectedBodyPart)
        {
            ID = pID;
            NameOfDisability = pNameOfDisability;
            AffectedBodyPart = pAffectedBodyPart;
        }

        public mDisability(string pNameOfDisability, string pAffectedBodyPart)
        {
            NameOfDisability = pNameOfDisability;
            AffectedBodyPart = pAffectedBodyPart;
        }
    }
}
