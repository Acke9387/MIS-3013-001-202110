using System;
using System.IO;

namespace ReadingInAFile_Part1
{
    class Program
    {
        static void Main(string[] args)
        {
            string file = @"The Proof of The Pudding.txt";

            string book = File.ReadAllText(file);

            Console.WriteLine(book);
        }
    }
}
