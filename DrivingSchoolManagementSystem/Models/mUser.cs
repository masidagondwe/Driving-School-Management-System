using DrivingSchoolManagementSystem.AppHelpers;
using System.ComponentModel;

namespace DrivingSchoolManagementSystem.Models
{
    public class mUser : INotifyPropertyChanged
    {
        private int _ID;
        public int ID { get { return _ID; } set { if (_ID != value) { _ID = value; NotifyPropertyChanged("ID"); } } }

        private string _Username;
        public string Username { get { return _Username; } set { if (_Username != value) { _Username = value; NotifyPropertyChanged("Username"); } } }

        private string _Password;
        public string Password { get { return _Password; } set { if (_Password != value) { _Password = value; NotifyPropertyChanged("PupilRegID"); } } }

        private string _FirstName;
        public string FirstName { get { return _FirstName; } set { if (_FirstName != value) { _FirstName = value; NotifyPropertyChanged("FirstName"); } } }

        private string _LastName;
        public string LastName { get { return _LastName; } set { if (_LastName != value) { _LastName = value; NotifyPropertyChanged("LastName"); } } }

        private AccessLevel _AccessLevel;
        public AccessLevel AccessLevel { get { return _AccessLevel; } set { if (_AccessLevel != value) { _AccessLevel = value; NotifyPropertyChanged("AccessLevel"); } } }


        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged(string propertyname)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyname));
            }
        }
    }
}
