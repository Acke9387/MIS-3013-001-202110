using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace MethodsWithArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            List<List<double>> grades = new List<List<double>>();
            grades.Add(CreateRandomSizedListWithRandomValues());
            grades.Add(CreateRandomSizedListWithRandomValues());
            grades.Add(CreateRandomSizedListWithRandomValues());
            grades.Add(CreateRandomSizedListWithRandomValues());
            grades.Add(CreateRandomSizedListWithRandomValues());

            string[] names = { "Bob", "Suzie", "Cindy", "Squirrel Face", "Swetha" };
            int[] ids = { 0, 1, 2, 3, 4 };

            //foreach (var student in grades)
            //{
            //    foreach (var grade in student)
            //    {
            //        Console.Write($"{grade.ToString("N")}\t");
            //    }
            //    Console.WriteLine();
            //}

            for (int i = 0; i < grades.Count; i++)
            {
                StudentInformation(names[i], ids[i], grades[i]);
            }

        }

        static void StudentInformation(string name, int id, List<double> grades)
        {
            double sum = 0;
            foreach (var grade in grades)
            {
                sum += grade;
            }

            double avg = sum / grades.Count;

            Console.WriteLine($"{name}({id}) has {grades.Count.ToString("n")} grades and has an average of {avg.ToString("n")}!");
        }


        static List<double> CreateRandomSizedListWithRandomValues()
        {
            List<double> randoGrades = new List<double>();
            Random rand = new Random();
            int numberOfGrades = rand.Next(3, 10);

            for (int i = 0; i < numberOfGrades; i++)
            {
                double grade = rand.NextDouble() * 100;
                randoGrades.Add(grade);
            }

            return randoGrades;
        }

    }

}
