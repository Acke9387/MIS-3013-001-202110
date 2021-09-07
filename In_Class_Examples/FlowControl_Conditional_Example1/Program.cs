using System;

namespace FlowControl_Conditional_Example1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to my wonderful application! What is your name? >>");
            string name = Console.ReadLine();

            Console.WriteLine($"{name}, what is your monthly income? >>");
            string monthlyIncomeAsString = Console.ReadLine();
            double monthlyIncome = Convert.ToDouble(monthlyIncomeAsString);

            Console.WriteLine($"{name}, what is your monthly expenses? >>");
            double monthlyExpenses = Convert.ToDouble(Console.ReadLine());

            double monthlyNetAmount = monthlyIncome - monthlyExpenses;

            if (monthlyNetAmount >= 0)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Beep(5000, 500);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Beep(2000, 500);
            }



            Console.WriteLine(monthlyNetAmount.ToString("C2"));
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
