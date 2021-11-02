using System;

namespace Functions_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string today = "11/2/2021";
            DeveloperInformation("Instructor Ackerman", "MIS 3013", today);
            bool goAgain = true;
            double result = 0;
            bool shouldIUsePreviousResult = false;
            do
            {
                Console.WriteLine("What type of calculation do you want to perform? +, -, *, / >>");
                string operation = Console.ReadLine();
                double first;
                // ctrl + k, ctrl + s
                if (shouldIUsePreviousResult == false)
                {
                    Console.WriteLine("What is the first operand? >>");
                    first = Convert.ToDouble(Console.ReadLine());
                }
                else
                {
                    first = result;
                }

                Console.WriteLine("What is the second operand? >>");
                double second = Convert.ToDouble(Console.ReadLine());

                switch (operation)
                {
                    case "+":
                        result = Add(first, second);
                        break;
                    case "-":
                        result = Subtract(first, second);
                        break;
                    case "*":
                        result = Multiply(first, second);
                        break;
                    case "/":
                        result = Divide(first, second);
                        break;
                    default:
                        result = 0;
                        Console.WriteLine("Invalid operation.  Goodbye.");
                        Environment.Exit(-1);
                        break;
                }
                Console.WriteLine($"{first.ToString("N")} {operation} { second.ToString("N")} = {result.ToString("N")}");

                Console.WriteLine("Do you want to perform another calculation? yes or no >>");
                string answer = Console.ReadLine();

                if (answer.ToLower() == "yes")
                {
                    goAgain = true;
                    Console.WriteLine($"Do you want to use {result.ToString("N")} as the first operand? yes or no >>");
                    answer = Console.ReadLine();
                    if (answer.ToLower() == "yes")
                    {
                        shouldIUsePreviousResult = true;
                    }
                    else
                    {
                        shouldIUsePreviousResult = false;
                    }
                }
                else
                {
                    goAgain = false;
                }

            } while (goAgain);

            Console.WriteLine("Thanks for calculating! Goodbye.");
        }

        static double Add(double val1, double rightHand)
        {
            //double sum = 0;
            //sum = val1 + rightHand;

            //return sum;

            return val1 + rightHand;
        }

        static double Subtract(double val1, double val2)
        {
            return val1 - val2;
        }

        static double Multiply(double val1, double val2)
        {
            return val1 * val2;
        }

        static double Divide(double val1, double val2)
        {
            return val1 / val2;
        }

        static void DeveloperInformation(string name, string className, string dateOfWriting)
        {
            Console.WriteLine($"{name} wrote this application for {className} on {dateOfWriting}.");
        }

    }
}
