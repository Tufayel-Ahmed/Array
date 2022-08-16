using System;

namespace SquaresofaSortedArray
{
    class Program
    {
        public static void Main(String[] args)
        {
            Solution solution = new Solution();
            int[] nums = new int[] { -2, 1, 2, -5, 10 };
            int[] result = solution.SortedSquares(nums);
            
            Console.WriteLine(String.Join(",", result));
        }
    }
    public class Solution
    {
        public int[] SortedSquares(int[] nums)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = nums[i] * nums[i];
            }
            Array.Sort(nums);
            return nums;
        }
    }
}
