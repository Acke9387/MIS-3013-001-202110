using System;
using System.Collections.Generic;
using System.Text;

namespace Classes_Cereal
{
    public class Cereal
    {
        public string Manufacturer { get; set; }
        public string Name { get; set; }
        public double Calories { get; set; }
        public double Cups { get; set; }

        private string Secret;

        public Cereal()
        {
            Manufacturer = string.Empty;
            Name = string.Empty;
            Calories = 0;
            Cups = 0;
            Secret = string.Empty;
        }

        public Cereal(string manu, string name, double cals, double cups)
        {
            Manufacturer = manu;
            Name = name;
            Calories = cals;
            Cups = cups;
            Secret = string.Empty;
        }

        public Cereal(string manu, string name)
        {
            Manufacturer = manu;
            Name = name;
            Calories = 0;
            Cups = 0;
            Secret = string.Empty;
        }

        public override string ToString()
        {
            return $"{Name} made by {Manufacturer} has {Calories.ToString("N")} calories and a serving size of {Cups.ToString("N")}";
        }

    }
}
