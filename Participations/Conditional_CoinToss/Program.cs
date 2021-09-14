using System;

namespace Conditional_CoinToss
{
    class Program
    {

        const int HEADS = 1;
        const int TAILS = 2;
        const string DEVELOPER = "Instructor Ackerman";

        static void Main(string[] args)
        {
            Console.WriteLine("Call it in the air, Heads or Tails? >>");
            string answer = Console.ReadLine();

            Random rand = new Random();
            int coin = rand.Next(1, 3);
            // this is for testing purposes
            //coin = HEADS;
            int answerAsNumber = 0;

            if (answer == "Heads")
            {
                answerAsNumber = HEADS;
            }
            else if (answer == "Tails")
            {
                answerAsNumber = TAILS;
            }
            else
            {
                Console.WriteLine("Invalid guess.  Goodbye.");
                Environment.Exit(-5);
                //return;
            }

            if (coin == HEADS)
            {
                Console.WriteLine("It came up Heads.");
            }
            else
            {
                Console.WriteLine("It came up Tails.");
            }

            if (answerAsNumber == coin)
            {
                Console.WriteLine("You guessed correctly, congratulations!");
            }
            else
            {
                Console.WriteLine("Sorry, better luck next time.");
            }

            Console.WriteLine($"This game was brought to you by {DEVELOPER}");
        }
    }
}
