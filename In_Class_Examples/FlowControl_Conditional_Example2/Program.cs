using System;

namespace FlowControl_Conditional_Example2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int randValue = rand.Next(1, 101);

            if (randValue % 3 == 0 && randValue % 5 == 0)
            {
                Console.WriteLine("Fizzbuzz");
            }
            else if (randValue % 5 == 0)
            {
                Console.WriteLine("Buzz");
            }
            else if (randValue % 3 == 0)
            {
                Console.WriteLine("Fizz");
            }
            else
            {
                Console.WriteLine(randValue);
            }


        }
    }
}
