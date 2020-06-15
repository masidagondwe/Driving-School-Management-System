using System;
using System.ComponentModel;

namespace DrivingSchoolManagementSystem.Models
{
    public class mEnrollment : INotifyPropertyChanged
    {
        private int id;
        private DateTime dateOfEnrollment;
        private DateTime expectedDateOfCompletion;
        private DateTime actualDateOfCompletion;
        private string comments;
        private int studentID;
        private string courseID;


        public int ID { get { return id; } set { id = value; OnPropertyChanged("ID"); } }
        public DateTime DateOfEnrollment { get { return dateOfEnrollment; } set { dateOfEnrollment = value; OnPropertyChanged("DateOfEnrollment"); } }
        public DateTime ExpectedDateOfCompletion { get { return expectedDateOfCompletion; } set { expectedDateOfCompletion = value; OnPropertyChanged("ExpectedDateOfCompletion"); } }
        public DateTime ActualDateOfCompletion { get { return actualDateOfCompletion; } set { actualDateOfCompletion = value; OnPropertyChanged("ActualDateOfCompletion"); } }
        public string Comments { get { return comments; } set { comments = value; OnPropertyChanged("Comments"); } }
        public int StudentID { get { return studentID; } set { studentID = value; OnPropertyChanged("StudentID"); } }
        public string CourseID { get { return courseID; } set { courseID = value; OnPropertyChanged("CourseID"); } }

        public mEnrollment () { }

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        //public mEnrollment (int pID, DateTime pDateOfEnrollment, DateTime pExpectedDateOfCompletion, DateTime pActualDateOfCompletion, string pComments, int pStudentID, string pCourseID)
        //{
        //    ID = pID;
        //    DateOfEnrollment = pDateOfEnrollment;
        //    ExpectedDateOfCompletion = pExpectedDateOfCompletion;
        //    ActualDateOfCompletion = pActualDateOfCompletion;
        //    Comments = pComments;
        //    StudentID = pStudentID;
        //    CourseID = pCourseID;
        //}

        //public mEnrollment(DateTime pDateOfEnrollment, DateTime pExpectedDateOfCompletion, DateTime pActualDateOfCompletion, string pComments, int pStudentID, string pCourseID)
        //{
        //    DateOfEnrollment = pDateOfEnrollment;
        //    ExpectedDateOfCompletion = pExpectedDateOfCompletion;
        //    ActualDateOfCompletion = pActualDateOfCompletion;
        //    Comments = pComments;
        //    StudentID = pStudentID;
        //    CourseID = pCourseID;
        //}
    }
}
