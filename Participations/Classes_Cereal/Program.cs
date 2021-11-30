using System;
using System.Collections.Generic;
using System.IO;

namespace Classes_Cereal
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] linesOfFile = File.ReadAllLines("Cereal_Data.txt");
            //[0] = name | manufacturer | calories | cups
            //[1] = 100 % Bran | Nabisco | 70 | 0.33

            List<Cereal> cereals = new List<Cereal>();

            for (int i = 1; i < linesOfFile.Length; i++)
            {
                string[] piecesOfLine = linesOfFile[i].Split('|');
                //[0] = 100 % Bran 
                //[1] =  Nabisco 
                //[2] =  70 
                //[3] =  0.33
                //Cereal temp = new Cereal();
                //temp.Calories = Convert.ToDouble(piecesOfLine[2]);
                //temp.Cups = Convert.ToDouble(piecesOfLine[3]);
                //temp.Manufacturer = piecesOfLine[1];
                //temp.Name = piecesOfLine[0];

                Cereal temp = new Cereal(piecesOfLine[0], piecesOfLine[1], Convert.ToDouble(piecesOfLine[2]), Convert.ToDouble(piecesOfLine[3]));

                cereals.Add(temp);
            }
            Console.WriteLine("\nCereals with 1 cup or more");
            foreach (Cereal cereal in cereals)
            {
                if (cereal.Cups >= 1)
                {
                    Console.WriteLine(cereal);
                }
            }
            Console.WriteLine("\nCereals with 100 calories or less");
            foreach (Cereal c in cereals)
            {
                if (c.Calories <= 100)
                {
                    Console.WriteLine(c);
                }
            }

        }
    }
}
