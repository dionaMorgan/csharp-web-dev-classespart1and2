using System;

// Start working here with your Student class.
// To instantiate the Student class, add your code to the Main method in Program

namespace SchoolPractice
{
    public class Student
    {
        public string Name { get; set; }

        public int StudentID { get; }
        private static int nextID = 1;

        public int NumberOfCredits { get; set; }

        public double Gpa{ get; set; }

        //private string Name;
        //private int StudentId;
        //private int NumberOfCredits;
        //private double Gpa;

        public Student(string name, int studentID, int numberOfCredits, double gpa)
        {
            Name = name;
            StudentID = studentID;
            NumberOfCredits = numberOfCredits;
            Gpa = gpa;
        } 

        public Student()
        {
            StudentID = nextID;
            nextID++;
        }

        public Student(string name, int numberOfCredits, double gpa) : this()
        {
            Name = name;
            NumberOfCredits = numberOfCredits;
            Gpa = gpa;
        }

        public void AddGrade(int courseCredits, double grade)
        {
            // Update the appropriate fields: NumberOfCredits, Gpa
            //takes in number of credits and the numerical grade
            //gpa * NumberOfCredits / total credits = new gpa

            double totalQualityScore = Gpa * NumberOfCredits;
            totalQualityScore += courseCredits * grade;
            NumberOfCredits += courseCredits;
            Gpa = totalQualityScore / NumberOfCredits;
    
            
        }

        public string GetGradeLevel(int credits)
        {
            // Determine the grade level of the student based on NumberOfCredits
            if (credits <= 29)
            {
                return ("Freshman");
            }
            else if (credits <= 59)
            {
                return ("Sophomore");
            }
            else if (credits <= 89)
            {
                return ("Junior");
            }
            else
            {
                return ("Senior");
            }
        }


    }

}
