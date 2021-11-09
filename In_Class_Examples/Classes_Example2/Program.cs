using System;

namespace Classes_Example2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Rectangle r = new Rectangle(5,5);
            Rectangle r2 = new Rectangle();

            Console.WriteLine(r.area() ); 
        }
    }
}
