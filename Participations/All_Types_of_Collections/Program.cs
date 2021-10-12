using System;
using System.Collections.Generic;

namespace All_Types_of_Collections
{
    class Program
    {
        /*
        Create parallel arrays, one will have the course subject (e.g. MIS, MATH, etc.) and the other will hold course numbers (e.g. 3033, 3013, etc.).  Ask the user to input 3 for each, store them in the array.  Then use a different loop to output the results to the user concatenated together (e.g. MIS3033, MATH3013).
        
        Create a list that will hold all of the users grades.  Keep prompting the user if they have another grade to enter until they say 'no'.  Once you have all of the inputs, use a for each loop to iterate through the list and calculate the average.  Output the users grade average.
        Create a dictionary that will hold multiple values.  The key will be the course code (e.g. MIS3013, MIS3383, etc.) and the values will be all of the students final grades (e.g. 0.95, 0.8, etc.).  Add at least 3 courses codes and at least 3 grades in each one.  Calculate the average for each course code and output it to the user, make sure to format it as a percent.
        If you have time, convert #3 to getting input from the user and making sure the key doesn't exist prior to adding it
        */

        static void Main(string[] args)
        {
            ParallelArrays();

            ListExample();

            DictionaryExample();

        }

        private static void DictionaryExample()
        {
            Dictionary<string, List<double>> courseGrades = new Dictionary<string, List<double>>();
            courseGrades.Add("MIS3013", new List<double>());
            courseGrades["MIS3013"].Add(0.90);
            courseGrades["MIS3013"].Add(0.80);
            courseGrades["MIS3013"].Add(0.85);

            List<double> mis3033 = new List<double>();
            mis3033.Add(.5);
            mis3033.Add(.75);
            mis3033.Add(1.0);
            courseGrades.Add("MIS3033", mis3033);

            courseGrades.Add("MIS3353", new List<double>() { 0, .25, .50 });

            foreach (string course in courseGrades.Keys)
            {
                Console.WriteLine(course);

                double sum = 0;
                foreach (double grade in courseGrades[course])
                {
                    sum += grade;
                }
                Console.WriteLine($"The average is {(sum / courseGrades[course].Count).ToString("P")}");
            }
        }

        private static void ListExample()
        {
            List<double> grades = new List<double>();

            do
            {
                Console.WriteLine("Please enter a grade >>");
                double grade = Convert.ToDouble(Console.ReadLine());
                grades.Add(grade);

                Console.WriteLine("Do you have another grade to enter? yes or no >>");

            } while (Console.ReadLine().ToLower() == "yes");

            double sum = 0;

            //for (int i = 0; i < grades.Count; i++)
            //{
            //    double grade = grades[i];
            //    sum += grade;
            //}

            foreach (double grade in grades)
            {
                sum += grade;
            }

            Console.WriteLine($"The exam average is {(sum / grades.Count).ToString("P")}");
        }

        private static void ParallelArrays()
        {
            string[] subjects = new string[3];
            int[] crns = new int[3];

            for (int i = 0; i < subjects.Length; i++)
            {
                Console.WriteLine("Please enter the subject >>");
                subjects[i] = Console.ReadLine();

                Console.WriteLine("Please enter the course number >>");
                int crn = Convert.ToInt32(Console.ReadLine());
                crns[i] = crn;

            }

            //....

            for (int i = 0; i < subjects.Length; i++)
            {
                string course = subjects[i] + crns[i];
                Console.WriteLine(course);
            }
        }
    }
}
