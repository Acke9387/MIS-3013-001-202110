using System;

namespace StringManipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = "hENRY";

            Console.WriteLine(firstName);

            firstName = firstName.ToLower();

            Console.WriteLine(firstName);

            firstName = "" + firstName.ToUpper()[0] + firstName.Substring(1);
            Console.WriteLine(firstName);

            string name = "henry james";
            string fname = "" + name.ToUpper()[0] + name.Substring(1, name.IndexOf(' '));
            string lname = "" + name.ToUpper()[name.IndexOf(' ') + 1] + name.Substring(name.IndexOf(' ') + 2) ;

            Console.WriteLine($"The space is located at position {name.IndexOf(' ')}");
            Console.WriteLine(fname + lname);

        }
    }
}
