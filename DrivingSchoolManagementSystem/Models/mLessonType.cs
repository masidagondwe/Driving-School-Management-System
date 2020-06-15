using System.ComponentModel;

namespace DrivingSchoolManagementSystem.Models
{
    public class mLessonType : INotifyPropertyChanged
    {
        private int id;
        private int theory;
        private int practical;
        private int bonus;

        public int ID { get { return id; } set { id = value; OnPropertyChanged("ID"); } }
        public int Theory { get { return theory; } set { theory = value; OnPropertyChanged("Theory"); } }
        public int Practical { get { return practical; } set { practical = value; OnPropertyChanged("Practical"); } }
        public int Bonus { get { return bonus; } set { bonus = value; OnPropertyChanged("Bonus"); } }

        public mLessonType() 
        {
            ID = 0;
            Theory = 0;
            Practical = 0;
            Bonus = 0;
        }


        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }


        //public mLessonType(int pID, int pTheory, int pPractical, int pBonus)
        //{
        //    ID = pID;
        //    Theory = pTheory;
        //    Practical = pPractical;
        //    Bonus = pBonus;
        //}

        //public mLessonType(int pTheory, int pPractical, int pBonus)
        //{
        //    Theory = pTheory;
        //    Practical = pPractical;
        //    Bonus = pBonus;
        //}
    }
}
