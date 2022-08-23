using System;

namespace RemoveDuplicateFromSortedArray
{
    class Program
    {
        public static void Main(String[] args)
        {
            int[] nums = new int[] { 1, 1, 1, 2, 2, 3, 4, 4, 5 };

            Solution solution = new Solution();
            int result = solution.RemoveDuplicates(nums);
            Console.WriteLine(result);

        }
    }

    public class Solution
    {
        public int RemoveDuplicates(int[] nums)
        {
            if (nums.Length == 0)
            {
                return 0;
            }
            int k = 0;
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[k] != nums[i])
                {
                    k++;
                    nums[k] = nums[i];
                }
            }
            return k + 1;
        }
    }
}
