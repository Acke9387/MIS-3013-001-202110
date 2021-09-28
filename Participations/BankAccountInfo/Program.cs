using System;

namespace BankAccountInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many bank accounts do you have? >>");
            string answer = Console.ReadLine();

            int numberOfAccounts;
            bool isValid = int.TryParse(answer, out numberOfAccounts);
            while (isValid == false)
            {
                Console.WriteLine("Please input the number of bank accounts you have.>>");
                answer = Console.ReadLine();
                isValid = int.TryParse(answer, out numberOfAccounts);
            }

            double total=0;

            for (int i = 0; i < numberOfAccounts; i++)
            {
                Console.WriteLine($"How much money do you have in bank account {i+1}? >>");
                total = total + Convert.ToDouble(Console.ReadLine());
            }

            double avg = total / numberOfAccounts;

            Console.WriteLine($"Your total is {total.ToString("C")}!");

            if (avg > 5000)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                //Console.WriteLine($"Your average is {avg.ToString("C")}!");
            }
            else
            {
                //Console.WriteLine($"Your average is {avg.ToString("C")}!");
            }

            Console.WriteLine($"Your average is {avg.ToString("C")}!");

        }
    }
}
