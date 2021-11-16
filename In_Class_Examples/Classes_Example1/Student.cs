using System;
using System.Collections.Generic;
using System.Text;

namespace Classes_Example1
{
    public class Student
    {

       public  List<double> Grades { get; set; }

        public string Name { get; set; }

        public int Id { get; set; }

        


        public Student()
        {
            Id = 0;
            Name = string.Empty;
            Grades = new List<double>();
        }

        public double CalculateAverage()
        {
            double sum = 0;

            foreach (var grade in Grades)
            {
                sum += grade;
            }
            double avg = sum / Grades.Count;
            return avg;
        }

        public override string ToString()
        {
            

            
            string result = $"{Name} ({Id}) has {Grades.Count} grades and an average of {CalculateAverage()}!";


            return result;
        }

    }
}
