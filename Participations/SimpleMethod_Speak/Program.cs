using System;
using System.Collections.Generic;

namespace SimpleMethod_Speak
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine("Enter an animal >>");
                string animal = Console.ReadLine();

                if (animal.ToLower() == "bye")
                {
                    Environment.Exit(-5);
                }

                string sound = Speak(animal);
                Console.WriteLine($"{animal} makes the sound of {sound}");
            } while (true);
            
        }

        static string Speak(string input)
        {
            string output = "";

            switch (input.ToLower())
            {
                case "dog":
                    //output = "bark bark";
                    Sounds.Dog();
                    break;

                case "monkey":
                    //output = "ooo ahhh eee ";
                    Sounds.Monkey();
                    break;

                case "goat":
                    //output = "AHHHH";
                    Sounds.Goat();
                    break;

                default:
                    //output = "squeek squeek";
                    Sounds.Default();
                    break;
            }


            return output;
        }

    }
}
