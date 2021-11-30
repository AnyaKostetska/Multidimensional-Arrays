using System;
using MultidimensionalArraysLibrary;

namespace ConsoleApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[,] array = new int[3, 4];
            Random random = new Random();
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = random.Next(1, 20);
                    Console.Write(array[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
