using System;

namespace Lab1_13
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = Console.ReadLine();
            var d = Console.ReadLine();
            var n = Console.ReadLine();
            double convertedA = Convert.ToDouble(a);
            double convertedD = Convert.ToDouble(d);
            int convertedN = Convert.ToInt32(n);
            if(convertedN <= 0)
            {
                throw new Exception("ValueError");
            }
            Console.WriteLine("Result is " + FindTheValueOfArithmeticProgression(convertedA, convertedD,convertedN));
        }

        static double FindTheValueOfArithmeticProgression(double a, double d, int n)
        {
            return a + (n - 1) * d;
        }
    }
}
