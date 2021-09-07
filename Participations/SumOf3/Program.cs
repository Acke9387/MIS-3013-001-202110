using System;

namespace SumOf3
{
    class Program
    {
        static void Main(string[] args)
        {
            double val1, val2, val3;
            string val1AsString;

            //Output the text to the user so they know what to enter
            Console.WriteLine("Please enter your first number >>");
            //Get what the user typed on the Console and store it in a variable that is also a string named val1AsString
            val1AsString = Console.ReadLine();
            //Convert the string into a double (so we can do math!)
            val1 = Convert.ToDouble(val1AsString);

            Console.WriteLine("Please enter your second number >>");
            val2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please enter your third number >>");
            val3 = Convert.ToDouble(Console.ReadLine());

            // Add up all 3 numbers from the user
            double sum = val1 + val2 + val3;

            const double MAGIC_NUMBER = 7.777;

            //Console.WriteLine(val1 + " + " + val2 + " + " + val3 + " = " + sum.ToString("n3"));
            Console.WriteLine($"{val1} + {val2} + {val3} = {sum.ToString("n3")}");

            double sumMultipliedByMagicNumber = sum * MAGIC_NUMBER;
            Console.WriteLine($"{sum.ToString("N3")} * {MAGIC_NUMBER.ToString("N3")} = {sumMultipliedByMagicNumber.ToString("N3")}");

        }
    }
}
