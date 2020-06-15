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

        ////Vehicle related
        //public ObservableCollection<BaseDropDown> OCMake { get; set; }

        //public ObservableCollection<BaseDropDown> OCType { get; set; }

        //public ObservableCollection<BaseDropDown> OCYearManufactured { get; set; }


        ////InstructorRelated

        //public ObservableCollection<BaseDropDown> OCSection { get; set; }

        //public ObservableCollection<BaseDropDown> OCMealType { get; set; }

        //public ObservableCollection<BaseDropDown> OCCollectionPoint { get; set; }

        //public ObservableCollection<BaseDropDown> OCCostCode { get; set; }

        ////public ObservableCollection<ComDivDepSecCostCode> OCComDivDepSecCostCode { get; set; }


        public PublicDropDown()
        {
            PrepVehicleSearchMethods();

            PrepInstructorSearchMethods();

            PrepStudentSearchMethods();


            //_CommonRepository = new CommonRepository();

            //OCCompany = _CommonRepository.ReturnDropDownCollection(CanteenOCollections.OCCompany);

            //OCDivision = _CommonRepository.ReturnDropDownCollection(CanteenOCollections.OCDivision);

            //OCDepartment = _CommonRepository.ReturnDropDownCollection(CanteenOCollections.OCDepartment);

            //OCSection = _CommonRepository.ReturnDropDownCollection(CanteenOCollections.OCSection);

            //OCCollectionPoint = _CommonRepository.ReturnDropDownCollection(CanteenOCollections.OCCollectionPoint);

            //OCCostCode = _CommonRepository.ReturnDropDownCollection(CanteenOCollections.OCCostCode);

            //OCComDivDepSecCostCode = _CommonRepository.ReturnDropDownCollection();
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
