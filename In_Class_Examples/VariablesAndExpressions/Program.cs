using System;

namespace VariablesAndExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = "Instructor";
            string lastName = "Ackerman";
            Console.WriteLine("Boomer Sooner!");

            Console.WriteLine("What is your first name? >>");
            firstName = Console.ReadLine();

            Console.WriteLine("What is your last name? >>");
            lastName = Console.ReadLine();

            int luckyNumber = 3;

            System.Console.WriteLine("What is your favorite number? >>");
            string answer = Console.ReadLine();
            luckyNumber = Convert.ToInt32(answer);

            double evenLuckierNumber = 7 * luckyNumber;

            Console.WriteLine(firstName + " " + lastName + " " + evenLuckierNumber);
        }
    }
}
