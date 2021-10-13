using System;

namespace Lab3_13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CountSum(Console.ReadLine()));
        }
        static double CountSum(string x)
        {
            double sum = 0;
            double convertedX = Convert.ToDouble(x);
            double e = 0.0001;
            int n = 0;
            if(convertedX >= 1 && convertedX <= 5)
            {
                while(true){
                    double expression = Math.Pow(-1, n) * (Math.Pow(convertedX, 2 * n) / Factorial(2 * n));
                    if(Math.Abs(expression) <= e)
                    {
                        break;
                    }
                    sum += expression;
                    n += 1;
                }
                return Math.Round(sum, 4);
            }
            throw new ArgumentException("Your x must be in range [1,5]");
        }
        static double Factorial(int num)
        {
            double factorial = 1;
            for(int i = 1; i <= num; i++)
            {
                factorial *= i;
            }
            return factorial;
        }
    }
}
