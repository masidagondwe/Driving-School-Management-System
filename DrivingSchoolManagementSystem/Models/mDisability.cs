using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrivingSchoolManagementSystem.Models
{
    public class mDisability : INotifyPropertyChanged
    {
        private int id;
        private string nameOfDisability;
        private string affectedBodyPart;
        public int ID { get { return id; } set { id = value; OnPropertyChanged("ID"); } }
        public string NameOfDisability { get { return nameOfDisability; } set { nameOfDisability = value; OnPropertyChanged("NameOfDisability"); } }
        public string AffectedBodyPart { get { return affectedBodyPart; } set { affectedBodyPart = value; OnPropertyChanged("AffectedBodyPart"); } }

        public mDisability() { }

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        //public mDisability(int pID, string pNameOfDisability, string pAffectedBodyPart)
        //{
        //    ID = pID;
        //    NameOfDisability = pNameOfDisability;
        //    AffectedBodyPart = pAffectedBodyPart;
        //}

        //public mDisability(string pNameOfDisability, string pAffectedBodyPart)
        //{
        //    NameOfDisability = pNameOfDisability;
        //    AffectedBodyPart = pAffectedBodyPart;
        //}
    }
}
