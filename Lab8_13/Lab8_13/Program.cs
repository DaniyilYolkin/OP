using System;

namespace Lab8_13
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 4, 5 };
            int counter = array.Length;
            FormatMatrix(CreateMatrix(array), counter);
        }
        static void FormatMatrix(int[,] matrix, int counter)
        {
            for (int i = 0; i < counter; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < counter; j++)
                {
                    Console.Write(matrix[i, j]);
                }
            }
        }
        static int[,] CreateMatrix(int[] array)
        {
            int[,] matrix = new int[array.Length, array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length; j++)
                {
                    matrix[i, j] = array[j];
                }
                Swap(array);
            }
            return matrix;
        }
        // 1 <- 2, 2 <- 3, 3 <- 4, 4 <- 5, 5 <- 1
        static void Swap(int[] array)
        {
            int savedElement = array[0];
            for(int i = 0; i < array.Length; i++)
            {
                if(i == array.Length-1)
                {
                    array[i] = savedElement;
                    break;
                }
                array[i] = array[i+1];
            }
        }
    }
}
