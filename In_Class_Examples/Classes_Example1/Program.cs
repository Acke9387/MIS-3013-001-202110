using System;
using System.Collections.Generic;

namespace Classes_Example1
{
    class Program
    {
        static void Main(string[] args)
        {

            Student stud1 = new Student();
            Student stud2 = new Student();
            Student stud3 = new Student();
            Student stud4 = new Student();
            Student stud5 = new Student();

            stud1.Name = "Bob";
            stud1.Id = 10;
            stud1.Grades.Add(45.5);
            stud1.Grades.Add(95.5);
            stud1.Grades.Add(75.5);

            stud1.CalculateAverage();
            Console.WriteLine(stud1);

            List<Student> students = new List<Student>();
            students.Add(stud1);
            //StudentInformation(stud1);
            //StudentInformation(stud2);
        }

        static void StudentInformation(Student stud)
        {
            double sum = 0;

            foreach (var grade in stud.Grades)
            {
                sum += grade;
            }

            double avg = sum / stud.Grades.Count;

            Console.WriteLine($"{stud.Name} ({stud.Id}) has {stud.Grades.Count} grades and an average of {avg}!");
        }
    }
}
