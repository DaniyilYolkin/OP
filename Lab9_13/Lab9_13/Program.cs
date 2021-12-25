using System;

namespace Lab9_13
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputString = "adcasdadc asdasdas adc adadasf adad dada fs adcd"; // Console.ReadLine();
            string inputWord = "adc"; // Console.ReadLine();
            Solve(inputString, inputWord);
        }
        static void Solve(string str, string word)
        {
            string[] arrayOfString = str.Split(" ");
            foreach (string item in arrayOfString)
            {
                int counter = 0;
                bool contains = true;
                char[] arrayOfItem = item.ToCharArray();
                char[] arrayOfWord = word.ToCharArray();
                foreach (char character in arrayOfWord)
                {
                    if (character != arrayOfItem[counter] || character != arrayOfItem[arrayOfItem.Length - arrayOfWord.Length + counter])
                    {
                        contains = false;
                        break;
                    }
                    counter++;
                }
                if (contains)
                {
                    Console.WriteLine(item);
                }
            }
            // return arrayOfString;
        }
    }
}
