using System;

namespace Collections_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] studentIds = { 1, 2, 3 };

            double[] gpas = new double[3];
            gpas[0] = 2.5;
            gpas[1] = 3.5;
            gpas[2] = 4.0;
            //gpas[3] = 4.6; results in an IndexOutOfBounds Exception

            Console.WriteLine("Which student do you want to see the gpa of? >>");
            int studentID = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < studentIds.Length; i++)
            {
                int id = studentIds[i];
                double gpa = gpas[i];

                if (id == studentID)
                {
                    Console.WriteLine($"{gpa.ToString("N")}");
                }
            }

        }
    }
}
