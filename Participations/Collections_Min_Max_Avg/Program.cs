using System;
using System.Collections.Generic;

namespace Collections_Min_Max_Avg
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> grades = new List<double>();
            Dictionary<double, int> gradeCount = new Dictionary<double, int>();
            do
            {
                Console.WriteLine("Please enter a grade >>");
                double grade = Convert.ToDouble(Console.ReadLine());
                grades.Add(grade);

                if (gradeCount.ContainsKey(grade) == false)
                {
                    gradeCount.Add(grade, 1);
                }
                else
                {
                    gradeCount[grade] = gradeCount[grade] + 1; ;
                }

                Console.WriteLine("Do you have another grade to enter? yes or no >>");

            } while (Console.ReadLine().ToLower() == "yes");

            double min = grades[0];
            double max = grades[0];
            double sum = 0;

            int mode = 0;

            foreach (double grade in gradeCount.Keys)
            {
                if (mode < gradeCount[grade])
                {
                    mode = gradeCount[grade];
                }
            }

            //for (int i = 0; i < grades.Count; i++)
            //{
            //    double grade = grades[i];
            //    if (grade < min)
            //    {
            //        min = grade;
            //    }

            //    if (grade > max)
            //    {
            //        max = grade;
            //    }

            //    sum += grade;
            //}

            foreach (double grade in grades)
            {

                if (grade < min)
                {
                    min = grade;
                }

                if (grade > max)
                {
                    max = grade;
                }

                sum += grade;
            }

            double average = sum / grades.Count;

        }
    }
}
