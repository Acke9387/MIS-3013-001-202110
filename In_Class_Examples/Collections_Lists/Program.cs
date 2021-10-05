using System;
using System.Collections.Generic;

namespace Collections_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> favoriteThings = new List<string>();

            do
            {
                Console.WriteLine("Tell me your favorite thing to add to my list >>");
                string favoriteThing = Console.ReadLine();

                favoriteThings.Add(favoriteThing);

                Console.WriteLine("Do you have another favorite thing to add? yes or no >>");
            } while (Console.ReadLine().ToLower() == "yes");

            Random rand = new Random();
            int randomIndex = rand.Next(0, favoriteThings.Count);

            Console.WriteLine($"A random thing from your list is {favoriteThings[randomIndex]}");

        }
    }
}
