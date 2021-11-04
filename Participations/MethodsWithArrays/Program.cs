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
