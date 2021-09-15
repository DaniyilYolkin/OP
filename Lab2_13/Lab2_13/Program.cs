using System;

namespace Lab2_13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IsNumberIsInRange(Convert.ToDouble(Console.ReadLine()), Convert.ToDouble(Console.ReadLine())));
        }

        static bool IsNumberIsInRange(double x, double y)
        {
            if ((x >= -1 && x <= 1 && (Math.Pow(x - 1, 2) + Math.Pow(y, 2) <= 4))
            || (x >= 1 && x <= 3 && x - 3 <= y && - x + 3 >= y)){
                return true;
            }
            return false;
        }
    }
}
