using System;

namespace Lab6_13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Calculate(Console.ReadLine(), Console.ReadLine()));
        }
        static double Calculate(string a, string n)
        { 
            double convertedA = Convert.ToDouble(a);
            int convertedN = Convert.ToInt32(n);
            if (convertedN >= 0 && convertedA > 0)
            {
                return (FindY(convertedA, 3, convertedN) - FindY((Math.Pow(convertedA, 2) + 1.0), 6.0, convertedN)) / (1 + FindY((3.0 + convertedA), '7', convertedN));
            }
            return Calculate(Console.ReadLine(), Console.ReadLine());
        }
        static double FindY(double a, double k, int n)
        {
            if(n == 0)
            {
                return a;
            }
            return (1 / k) * ((a / (Math.Pow(FindY(a, k, n - 1), k - 1)) + (k - 1) * (FindY(a, k, n - 1))));
        }
    }
}
