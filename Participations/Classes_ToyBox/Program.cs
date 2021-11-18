using System;
using System.Collections.Generic;

namespace Classes_ToyBox
{
    class Program
    {
        static void Main(string[] args)
        {
            List<ToyBox> toyboxes = new List<ToyBox>();

            do
            {
                ToyBox tb = new ToyBox();
                Console.WriteLine("Who own's the ToyBox? >>");
                tb.Owner = Console.ReadLine();
                Console.WriteLine($"Where is {tb.Owner}'s ToyBox located? >>");
                tb.Location = Console.ReadLine();

                toyboxes.Add(tb);
                Console.WriteLine("Do you want to create another ToyBox? yes or no >>");
            } while (Console.ReadLine().ToUpper()[0] == 'Y');

            for (int i = 0; i < toyboxes.Count; i++)
            {
                Console.WriteLine($"Time to fill up {toyboxes[i].Owner}'s ToyBox with Toys!");

                do
                {
                    Toy t = new Toy();

                    Console.WriteLine("What is the Toy's name? >>");
                    t.Name = Console.ReadLine();
                    Console.WriteLine($"Who is the manufacturer of {t.Name}? >>");
                    t.Manufacturer = Console.ReadLine();
                    Console.WriteLine($"What is the price of {t.Name} made by {t.Manufacturer}? >>");
                    t.Price = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Do you have any notes for this toy? yes or no");
                    while (Console.ReadLine().ToUpper()[0] == 'Y')
                    {
                        Console.WriteLine("What is your note?");
                        t.AddNote(Console.ReadLine());

                        Console.WriteLine("Do you have another note to add for this toy? yes or no >>");
                    }

                    toyboxes[i].Toys.Add(t);
                    Console.WriteLine("Do you want to create another Toy? yes or no >>");
                } while (Console.ReadLine().ToUpper()[0] == 'Y');

                foreach (ToyBox box in toyboxes)
                {
                    Console.WriteLine($"{box.Owner} ToyBox, located at {box.Location}, has {box.Toys.Count.ToString("N0")} toys! They are :");
                    foreach (var item in box.Toys)
                    {
                        Console.WriteLine(item);
                    }

                }

                Console.WriteLine("Time to get a rando from each ToyBox");
                foreach (ToyBox box in toyboxes)
                {
                    Console.WriteLine($"Random toy from {box.Owner}'s ToyBox:");
                    Console.WriteLine(box.GetRandomToy());
                }
            }

        }
    }
}
