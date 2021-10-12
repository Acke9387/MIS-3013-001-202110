using System;
using System.Collections.Generic;

namespace Collections_Min_Max_Avg
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> grades = new List<double>();

            do
            {
                Console.WriteLine("Please enter a grade >>");
                double grade = Convert.ToDouble(Console.ReadLine());
                grades.Add(grade);

                Console.WriteLine("Do you have another grade to enter? yes or no >>");

            } while (Console.ReadLine().ToLower() == "yes");

            double min = grades[0];

            foreach (double grade in grades)
            {

                if (SOME_CONDITION)
                {
                    min = ?;
                }


            }

        }
    }
}
