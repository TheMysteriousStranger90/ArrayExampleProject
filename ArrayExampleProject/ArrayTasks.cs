using System;

namespace ArrayExampleProject
{
    public static class ArrayTasks
    {
        public static void ChangeElementsInArray(int[] nums)
        {
            for (int i = 0; i < nums.Length / 2; i++)
            {
                if (nums[i] % 2 == 0 && nums[nums.Length - i - 1] % 2 == 0)
                {
                    int tmp = nums[i];
                    nums[i] = nums[nums.Length - i - 1];
                    nums[nums.Length - i - 1] = tmp;
                }
            }
        }

        public static int DistanceBetweenFirstAndLastOccurrenceOfMaxValue(int[] nums)
        {
            if (nums.Length == 0)
            {
                return 0;
            }
            else
            {
                int max = nums[0];
                int index = 0;
                for (int i = 0; i < nums.Length; i++)
                {
                    if (max < nums[i])
                    {
                        max = nums[i];
                        index = i;
                    }
                }

                int indexTwo = 0;
                for (int j = nums.Length - 1; j >= 0; j--)
                {
                    if (nums[j] == max)
                    {
                        indexTwo = j;
                        break;
                    }
                }

                return indexTwo - index;
            }
        }

        public static void ChangeMatrixDiagonally(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            for (int j = 0; j < matrix.GetLength(1); j++)
                if (i == j)
                {
                    continue;
                }
                else if (j > i)
                {
                    matrix[i, j] = 1;
                }
                else
                {
                    matrix[i, j] = 0;
                }
        }
    }
}