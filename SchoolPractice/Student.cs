using System;

// Start working here with your Student class.
// To instantiate the Student class, add your code to the Main method in Program

namespace SchoolPractice
{
    public class Student
    {
        private string Name { get; set; }
        private int StudentId { get; set; }
       public int NumberOfCredits { get; set; }
        public double Gpa { get; set; }

        public double TotalQualityScore  { get; set; } 

        public void AddGrade(int courseCredits, double grade)
        {
            NumberOfCredits += courseCredits;
            TotalQualityScore += (grade * courseCredits);
            Gpa = (TotalQualityScore) / NumberOfCredits;
        }

        public string GetGradeLevel()
        {
            if (NumberOfCredits >=0 && NumberOfCredits <= 29)
            {
                return "Freshman";
            }
            else if (NumberOfCredits >=30 && NumberOfCredits <= 59)
            {
                return "Sophmore";
            }
            else if (NumberOfCredits >= 60 && NumberOfCredits <= 89)
            {
                return "Junior";
            }
            else if (NumberOfCredits >= 90)
            {
                return "Senior";
            }
            else
            {
                return "Invalid entry";
            }
        }

        public override string ToString()
        {
            return this.Name +" (Credits: " + this.NumberOfCredits + ", GPA "+ this.Gpa+")";
        }

        public override bool Equals(object obj)
        {
            if (obj == this)
            {
                return true;
            }
            if (obj == null)
            {
                return false;
            }
            if (obj.GetType() != this.GetType())
            {
                return false;
            }

            Student s = obj as Student;
            return s.StudentId == StudentId;
        }




    }
}
