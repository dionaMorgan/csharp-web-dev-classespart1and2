using System;
using System.Collections.Generic;

namespace SchoolPractice
{
    class Program
    {
        public static void Main(string[] args)
        {
            // TODO: Instantiate your objects and test your exercise solutions with print statements here.
            //List<Student> students = new List<Student>();
            //students.Add(new Student("Diona Morgan", 1, 3.8));
            //students.Add(new Student("Darice Morgan", 1, 3.95));

            
            Student diona = new Student("Diona Morgan", 3, 3.54);
            Student darice = new Student("Darice Morgan", 6, 3.69);
            Student dominique = new Student("Dominiquw Morgan", 12, 3.75);

            //foreach (Student student in )
            //{
            //    Console.WriteLine($"ID: {student.StudentID} Name: {student.Name} Number of Credit: {student.NumberOfCredits} GPA: {student.Gpa} ");
            //}

            Console.WriteLine(diona.GetGradeLevel(54));
            Console.WriteLine(diona.AddGrade(3, 3.0));

            Console.ReadLine();
            
        }
    }
}
