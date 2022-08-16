using System;

namespace DuplicateZeros
{
    class Program
    {
        public static void Main(String[] args)
        {
            Solution solution = new Solution();

            int[] arr = new int[] { 1, 0, 5, 4, 0 };
            solution.DuplicateZeros(arr);
        }
    }
    public class Solution
    {
        public void DuplicateZeros(int[] arr)
        {
            if (!arr.Contains(0) || arr.Length < 2)
            {
                return;
            }
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == 0)
                {
                    int j;
                    for (j = arr.Length - 1; j > i + 1; j--)
                    {
                        arr[j] = arr[j - 1];
                    }
                    arr[j] = 0;
                    i++;
                }
            }
            Console.WriteLine(String.Join(",", arr));
        }
    }
}