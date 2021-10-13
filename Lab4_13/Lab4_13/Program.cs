using System;

namespace Lab4_13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(FindResultOfReccursion(
                Convert.ToInt32(Console.ReadLine()),
                Convert.ToDouble(Console.ReadLine()),
                Convert.ToDouble(Console.ReadLine()))
                );
        }

        static double FindResultOfReccursion(int n, double x, double a)
        {
            if (n == 0)
            {
                return a;
            }
            return 0.5 * (FindResultOfReccursion(n - 1, x, a) + (x / FindResultOfReccursion(n - 1, x, a)));
        }
    }
}
