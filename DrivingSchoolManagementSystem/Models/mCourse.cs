namespace DrivingSchoolManagementSystem.Models
{
    public class mCourse
    {
        public string CourseID { get; set; }
        public string CourseType { get; set; }

        public mCourse() { }

        public mCourse(string pCourseID, string pCourseType)
        {
            CourseID = pCourseID;
            CourseType = pCourseType;
        }
    }
}
