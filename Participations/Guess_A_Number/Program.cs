using System;

namespace Guess_A_Number
{
    class Program
    {
        static void Main(string[] args)
        {

            int usersGuess, min, max, randomNbr;
            string answer;
            
            Console.WriteLine("Time to play guess a number!\nPlease enter the lower bound for the number >>");
            answer = Console.ReadLine();

            bool isAValidNumber = int.TryParse(answer, out min);

            if (isAValidNumber == false)
            {
                //The number is invalid
                Console.WriteLine("Invalid lower bound entry.  Goodbye.");
                Environment.Exit(-10);
            }

            Console.WriteLine("Please enter the upper bound for the number >>");
            answer = Console.ReadLine();

            isAValidNumber = int.TryParse(answer, out max);

            if (isAValidNumber == false)
            {
                //The number is invalid
                Console.WriteLine("Invalid upper bound entry.  Goodbye.");
                Environment.Exit(-10);
            }

            Random rand = new Random();
            randomNbr = rand.Next(min, max + 1);

            // Here for testing purposes, will remove later or comment out
            Console.WriteLine(randomNbr);

            do
            {
                Console.WriteLine($"Please guess the random number between {min.ToString("N0")} - {max.ToString("N0")} >>");
                answer = Console.ReadLine();

                isAValidNumber = int.TryParse(answer, out usersGuess);

                while (isAValidNumber == false)
                {
                    //The number is invalid
                    Console.WriteLine("Invalid guess.  Please input a valid number >>");
                    answer = Console.ReadLine();
                    isAValidNumber = int.TryParse(answer, out usersGuess);
                }

                if (usersGuess != randomNbr)
                {
                    if (usersGuess > randomNbr)
                    {
                        Console.WriteLine("You guessed too high, try again.");
                    }
                    else
                    {
                        Console.WriteLine("You guessed too low, try again.");
                    }

                } 
            } while (usersGuess != randomNbr);
            

            Console.WriteLine("Congratulations, you guessed correctly!");
        }
    }
}
