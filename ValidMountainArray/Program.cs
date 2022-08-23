using System;

namespace ValidMountainArray
{
    class Program
    {
        public static void Main(String[] args)
        {
            int[] nums = new int[] { 9, 8, 7, 6, 5, 4, 3, 2, 1, 0 };

            Solution solution = new Solution();
            bool result = solution.ValidMountainArray(nums);
            Console.WriteLine(result);
        }
    }

    public class Solution
    {
        public bool ValidMountainArray(int[] arr)
        {
            if (arr.Length < 3)
            {
                return false;
            }
            if (arr[0] > arr[1] || arr[arr.Length - 1] > arr[arr.Length - 2])
            {
                return false;
            }
            int temp = 0;
            while (arr[temp + 1] > arr[temp])
            {
                temp++;
            }
            while (temp < arr.Length - 1)
            {
                if (arr[temp + 1] >= arr[temp])
                {
                    return false;
                }
                temp++;
            }
            return true;
        }
    }
}