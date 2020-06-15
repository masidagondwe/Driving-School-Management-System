using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrivingSchoolManagementSystem.AppHelpers
{
    public enum DropDownDefs { SalaryCycle }

    public class PublicDropDown
    {
        public ObservableCollection<BaseDropDown> OCVehiclesSearchMethods { get; set; }
        public ObservableCollection<BaseDropDown> OCInstructorsSearchMethods { get; set; }
        public ObservableCollection<BaseDropDown> OCStudentsSearchMethods { get; set; }


        public PublicDropDown()
        {
            PrepVehicleSearchMethods();

            PrepInstructorSearchMethods();

            PrepStudentSearchMethods();

        }


        private void PrepVehicleSearchMethods()
        {
            OCVehiclesSearchMethods = new ObservableCollection<BaseDropDown> { };

            OCVehiclesSearchMethods.Add(new BaseDropDown("Vehicle Registration", "VehicleRegistration"));
            OCVehiclesSearchMethods.Add(new BaseDropDown("Vehicle Make", "Make"));
            OCVehiclesSearchMethods.Add(new BaseDropDown("Vehicle Type", "Type"));
        }

        private void PrepInstructorSearchMethods()
        {
            OCInstructorsSearchMethods = new ObservableCollection<BaseDropDown> { };

            OCInstructorsSearchMethods.Add(new BaseDropDown("Enter Identification Number", "IdentificationNumber"));
            OCInstructorsSearchMethods.Add(new BaseDropDown("Job Title", "JobTitle"));
            OCInstructorsSearchMethods.Add(new BaseDropDown("First and/or Last Name", "FirstLastName"));
        }


        private void PrepStudentSearchMethods()
        {
            OCStudentsSearchMethods = new ObservableCollection<BaseDropDown> { };

            OCStudentsSearchMethods.Add(new BaseDropDown("Enter Identification Number", "IdentificationNumber"));
            OCStudentsSearchMethods.Add(new BaseDropDown("Occupation", "Occupation"));
            OCStudentsSearchMethods.Add(new BaseDropDown("First and/or Last Name", "FirstLastName"));
        }

    }
}
