using System;

namespace Functions_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double answer = Add(5, 72.3);

            Console.WriteLine(answer);
        }

        static double Add(double val1, double rightHand)
        {
            //double sum = 0;
            //sum = val1 + rightHand;

            //return sum;

            return val1 + rightHand;
        }

    }
}
