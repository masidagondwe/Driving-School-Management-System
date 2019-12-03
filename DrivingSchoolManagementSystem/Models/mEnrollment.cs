using System;

namespace DrivingSchoolManagementSystem.Models
{
    public class mEnrollment
    {
        public int ID { get; set; }
        public DateTime DateOfEnrollment { get; set; }
        public DateTime ExpectedDateOfCompletion { get; set; }
        public DateTime ActualDateOfCompletion { get; set; }
        public string Comments { get; set; }
        public int StudentID { get; set; }
        public string CourseID { get; set; }

        public mEnrollment () { }

        public mEnrollment (int pID, DateTime pDateOfEnrollment, DateTime pExpectedDateOfCompletion, DateTime pActualDateOfCompletion, string pComments, int pStudentID, string pCourseID)
        {
            ID = pID;
            DateOfEnrollment = pDateOfEnrollment;
            ExpectedDateOfCompletion = pExpectedDateOfCompletion;
            ActualDateOfCompletion = pActualDateOfCompletion;
            Comments = pComments;
            StudentID = pStudentID;
            CourseID = pCourseID;
        }

        public mEnrollment(DateTime pDateOfEnrollment, DateTime pExpectedDateOfCompletion, DateTime pActualDateOfCompletion, string pComments, int pStudentID, string pCourseID)
        {
            DateOfEnrollment = pDateOfEnrollment;
            ExpectedDateOfCompletion = pExpectedDateOfCompletion;
            ActualDateOfCompletion = pActualDateOfCompletion;
            Comments = pComments;
            StudentID = pStudentID;
            CourseID = pCourseID;
        }
    }
}
