using System;

namespace FlowControl_Example1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What do you want to count by? >>");
            int countBy = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("What do you want to count up to? >>");
            int ceiling = Convert.ToInt32(Console.ReadLine());

            for (int i = countBy; i < ceiling; i = i + countBy)
            {
                if ((i + countBy) >= ceiling)
                {
                    Console.Write(i.ToString("N0"));
                }
                else
                {
                    Console.Write(i.ToString("N0") + ",");
                }
            }

            Console.WriteLine("\nNow with a while loop!");
            
            int j = countBy;
            while (j < ceiling) 
            {
                if ((j + countBy) >= ceiling)
                {
                    Console.Write(j.ToString("N0"));
                }
                else
                {
                    Console.Write(j.ToString("N0") + ",");
                }
                j += countBy;
            }

        }
    }
}
