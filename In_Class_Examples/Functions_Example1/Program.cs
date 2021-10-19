using System;

namespace Functions_Example1
{
    class Program
    {
        static void Main(string[] args)
        {
            double gpa = AskQuestionAndValidateAnswerIsADouble("Please enter your GPA >>");
            string bankMessage = "Please enter your Bank Account Balance >>";
            
            double bankAccountBalance = AskQuestionAndValidateAnswerIsADouble(bankMessage);


            Console.WriteLine($"Your gpa is {gpa.ToString("N")}");
            Console.WriteLine($"Your bank account balance is {bankAccountBalance.ToString("N")}");

        }

        static double AskQuestionAndValidateAnswerIsADouble(string message)
        {
            double answer = 0;
            string response;
            do
            {
                Console.WriteLine(message);
                response = Console.ReadLine();

            } while (double.TryParse(response, out answer) == false);

            return answer;
        }

    }
}
