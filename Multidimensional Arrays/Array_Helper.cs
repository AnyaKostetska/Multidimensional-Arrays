using System;

namespace MultidimensionalArraysLibrary
{
    public class Array_Helper
    {
        public static int FindMinimumValueInArray(int[,] array)
        {
            int min = array[0, 0];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i, j] < min)
                    {
                        min = array[i, j];
                    }
                }
            }

            return min;
        }

        public static int FindMaximumValueInArray(int[,] array)
        {
            int max = array[0, 0];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i, j] > max)
                    {
                        max = array[i, j];
                    }
                }
            }

            return max;
        }

        public static (int, int) ToFindIndexOfMaxElement(int[,] array)
        {
            int max = array[0, 0];
            int maxi = 0;
            int maxj = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; 0 < array.GetLength(1); j++)
                {
                    if (array[i, j] > max)
                    {
                        maxi = i;
                        maxj = j;
                    }
                }
            }

            return (maxi, maxj);

        public static (int, int) ToFindIndexOfMinElement(int[,] array)
        {
            int min = array[0, 0];
            int mini = 0;
            int minj = 0;
            for (int i = 0; i < array.GetLength(0); i++)
                {
                    for (int j = 0; 0 < array.GetLength(1); j++)
                    {
                        if (array[i, j] < min)
                        {
                            mini = i;
                            minj = j;
                        }
                    }
                }

                return (mini, minj);
            }
    }
}
