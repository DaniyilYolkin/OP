using System;

namespace Lab7_13
{
    class Program
    {
        static void Main(string[] args)
        {
            /* string[] arrayOfStrings = Console.ReadLine().Split();
            int[] arrayOfIntegers = new int[arrayOfStrings.Length];
            int counter = 0;
            foreach (string number in arrayOfStrings)
            {
                var convertedNumber = Convert.ToInt32(number);
                arrayOfIntegers[counter] = convertedNumber;
                counter++;
            }
            */
            int[] arrayOfIntegers = { 1, -2, 3, -4, 5 };
            int funcResult = AbsoluteOfNegativeNumbersAverage(arrayOfIntegers);
            Console.WriteLine("AbsoluteOfNegativeNumbersAverage: ");
            Console.Write(funcResult);
            Console.WriteLine();
            int[] F = FGenerator(arrayOfIntegers, funcResult);
            foreach(int element in F)
            { 
                Console.Write(element + " ");
            }
        }

        static int[] FGenerator(int[] array, int multiplier){
            int[] F = new int[array.Length];
            int counter = -1;
            foreach (int number in array)
            {
                counter++;
                if(counter % 2 == 0 && counter != 0)
                {
                    int element = number * multiplier;
                    F[counter] = element;
                }
                else F[counter] = number;
            }
            return F;
        }
        
        static int AbsoluteOfNegativeNumbersAverage(int[] arr)
        {
            int counter = 0;
            int sum = 0;
            foreach (int number in arr)
            {
                if (number < 0)
                {
                    sum += number;
                    counter++;
                }
            }
            return Math.Abs(sum/counter);
        }
    }
}
