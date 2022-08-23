using System;

namespace RemoveElement
{
    class Program
    {
        public static void Main(String[] args)
        {
            int[] nums = new int[] { 1, 2, 3, 4, 1, 2, 4, 1, 5, 1};
            int val = 1;

            Solution solution = new Solution();
            int result = solution.RemoveElement(nums, val);
            Console.WriteLine(result);

        }
    }

    public class Solution
    {
        public int RemoveElement(int[] nums, int val)
        {
            int k = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == val)
                {
                    continue;
                }
                else
                {
                    nums[k] = nums[i];
                    k++;
                }
            }
            return k;
        }
    }
}
