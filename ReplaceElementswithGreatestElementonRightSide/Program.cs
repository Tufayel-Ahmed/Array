using System;

namespace ReplaceElementswithGreatestElementonRightSide
{
    class Program
    {
        public static void Main(String[] args)
        {
            int[] arr = new int[] { 1, 2, 3, 10, 5, 6, 7, 8, 9};

            Solution solution = new Solution();
            int[] result = solution.ReplaceElements(arr);
            Console.WriteLine(String.Join(",", result));

        }
    }
    public class Solution
    {
        public int[] ReplaceElements(int[] arr)
        {
            int maxRight = arr[arr.Length - 1];
            arr[arr.Length - 1] = -1;
            for (int i = arr.Length - 2; i >= 0; i--)
            {
                int temp = arr[i];
                arr[i] = maxRight;
                if (maxRight < temp)
                {
                    maxRight = temp;
                }
            }
            return arr;
        }
    }
}
