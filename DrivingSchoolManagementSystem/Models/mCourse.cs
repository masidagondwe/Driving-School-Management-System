using System.ComponentModel;

namespace DrivingSchoolManagementSystem.Models
{
    public class mCourse : INotifyPropertyChanged
    {
        private string courseID;
        private string courseType;

        public string CourseID { get { return courseID; } set { courseID = value; OnPropertyChanged("CourseID"); } }
        public string CourseType { get { return courseType; } set { courseType = value; OnPropertyChanged("CourseType"); } }

        public mCourse() { }

        //public mCourse(string pCourseID, string pCourseType)
        //{
        //    CourseID = pCourseID;
        //    CourseType = pCourseType;
        //}

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
