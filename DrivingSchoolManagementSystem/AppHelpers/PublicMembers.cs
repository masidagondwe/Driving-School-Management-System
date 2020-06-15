using DrivingSchoolManagementSystem.Models;
using System.Collections.ObjectModel;

namespace DrivingSchoolManagementSystem.AppHelpers
{
    public static class PublicMembers
    {
        public static MainWindow MainInterface;


        //public static AppUser ActiveAppUser;


        //public static AppUserRepository _AppUserRepository;

        //public static ReportingRepository _ReportingRepository;

        //public static ClientRepository _ClientRepository;
        //public static CommonRepository _CommonRepository;


        public static ObservableCollection<mStudent> AllStudents;
        public static ObservableCollection<mInstructor> AllInstructors;
        public static ObservableCollection<mVehicle> AllVehicles;

        public static PublicDropDown PublicDropDownCollections;
    }
}
