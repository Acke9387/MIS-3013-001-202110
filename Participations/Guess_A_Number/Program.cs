using System;

namespace Guess_A_Number
{
    class Program
    {
        static void Main(string[] args)
        {

            int number;

            string usersAnswer = "5";

            bool isAValidNumber = int.TryParse(usersAnswer, out number);

            if (isAValidNumber == false)
            {
                //The number is invalid
                Environment.Exit(-10);
            }
            else
            {
                //The number is valid
            }

        }
    }
}
