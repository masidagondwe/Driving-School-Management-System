namespace DrivingSchoolManagementSystem.Models
{
    public class mLessonType
    {
        public int ID { get; set; }
        public int Theory { get; set; }
        public int Practical { get; set; }
        public int Bonus { get; set; }

        public mLessonType() 
        {
            ID = 0;
            Theory = 0;
            Practical = 0;
            Bonus = 0;
        }

        public mLessonType(int pID, int pTheory, int pPractical, int pBonus)
        {
            ID = pID;
            Theory = pTheory;
            Practical = pPractical;
            Bonus = pBonus;
        }

        public mLessonType(int pTheory, int pPractical, int pBonus)
        {
            Theory = pTheory;
            Practical = pPractical;
            Bonus = pBonus;
        }
    }
}
