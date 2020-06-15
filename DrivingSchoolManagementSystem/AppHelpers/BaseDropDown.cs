using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrivingSchoolManagementSystem.AppHelpers
{
    public class BaseDropDown : INotifyPropertyChanged
    {
        private bool _IsSelected;
        public bool IsSelected { get { return _IsSelected; } set { if (_IsSelected != value) { _IsSelected = value; NotifyPropertyChanged("IsSelected"); } } }

        private string _DisplayText;
        public string DisplayText { get { return _DisplayText; } set { if (_DisplayText != value) { _DisplayText = value; NotifyPropertyChanged("DisplayText"); } } }

        private string _ValueText;
        public string ValueText { get { return _ValueText; } set { if (_ValueText != value) { _ValueText = value; NotifyPropertyChanged("ValueText"); } } }


        public string CollectionName { get; set; }


        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged(string propertyname)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyname));
        }


        public BaseDropDown()
        {
            IsSelected = false;
            DisplayText = string.Empty;
            ValueText = string.Empty;
        }

        public BaseDropDown(string displayText, string valueText, string propertyToRaiseOnSelect = "")
        {
            IsSelected = false;
            DisplayText = displayText;
            ValueText = valueText;
        }
    }

}
