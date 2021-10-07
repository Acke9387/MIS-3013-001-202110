using System;

namespace StringManipulation
{
    class Program
    {
        static string message = "Programming today is a race between software engineers striving to build bigger and better idiot-proof programs, and the universe trying to build bigger and better idiots. So far, the universe is winning.";
        static void Main(string[] args)
        {
            Console.WriteLine(message);
            Console.WriteLine("What word would you like to look for? >>");
            string search = Console.ReadLine();

            Console.WriteLine($"What would you like to change {search} to? >>");
            string replace = Console.ReadLine();

            bool containsSearchWord = message.Contains(search);
            Console.WriteLine(containsSearchWord);
            if (containsSearchWord == true)
            {
                string newMessage = message.Replace(search, replace);

                Console.WriteLine(newMessage);
            }
            else
            {
                Console.WriteLine($"Sorry, I could not find your word {search}.");
                string reverse = "";
                for (int i = search.Length - 1; i >= 0; i--)
                {
                    reverse += search[i];
                }
                
                Console.WriteLine(reverse);
            }

        }
    }
}
