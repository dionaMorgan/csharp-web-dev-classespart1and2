using System;
using System.Collections.Generic;

namespace SchoolPractice
{
    class Program
    {
        public static void Main(string[] args)
        {
            // TODO: Instantiate your objects and test your exercise solutions with print statements here.
            List<Student> students = new List<Student>();
            students.Add(new Student("Diona Morgan", 1, 3.8));
            students.Add(new Student("Darice Morgan", 1, 3.95));

            foreach (Student student in students)
            {
                Console.WriteLine($"ID: {student.StudentID} Name: {student.Name} Number of Credit: {student.NumberOfCredits} GPA: {student.Gpa} ");
            }

            Console.ReadLine();
            
        }
    }
}
