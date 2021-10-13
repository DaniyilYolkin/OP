using System;

namespace Lab5_13
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(string.Join(" ", FindPolyndroms()));
        }
        public static string[] FindPolyndroms()
        {
            string[] doublePolyndroms = new string[100];
            for(int i = 1; i <= 100; i++)
            {
                string convertedI = Convert.ToString(i);
                string convertedISquared = Convert.ToString(i * i);
                if (convertedI == Reverse(convertedI))
                {
                    if (convertedISquared == Reverse(convertedISquared))
                    {
                        doublePolyndroms[i] = convertedI;
                    }
                }
            }
            doublePolyndroms = Filter(doublePolyndroms);
            return doublePolyndroms;
        }
        public static string Reverse(string str)
        {
            char[] chars = new char[str.Length];
            for (int i = 0, j = str.Length - 1; i <= j; i++, j--)
            {
                chars[i] = str[j];
                chars[j] = str[i];
            }
            return new string(chars);
        }
        public static string[] Filter(string[] array)
        {
            int counter = 0;
            for(int i = 0; i < array.Length; i++)
            {
                if(array[i] != null)
                {
                    counter++;
                }
            }
            string[] newArray = new string[counter + 1];
            counter = 0;
            for(int i = 0; i < array.Length; i++)
            {
                if(array[i] != null)
                {
                    newArray[counter] = array[i];
                    counter++;
                }
            }
            return newArray;
        }
    }
}
