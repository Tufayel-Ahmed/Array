using System;

namespace SortArrayByParity
{
    class Program
    {
        public static void Main(String[] args)
        {
            int[] nums = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 11, 12};

            Solution solution = new Solution();
            int[] result = solution.SortArrayByParity(nums);
            Console.WriteLine(String.Join(", ", result));
        }
    }

    public class Solution
    {
        public int[] SortArrayByParity(int[] nums)
        {
            int k = 0, temp = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] % 2 == 0)
                {
                    (nums[k], nums[i]) = (nums[i], nums[k]);
                    k++;
                }
            }
            return nums;
        }
    }
}