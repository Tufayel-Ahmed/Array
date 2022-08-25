using System;

namespace MoveZeres
{
    class Program
    {
        public static void Main(String[] args)
        {
            int[] nums = new int[] { 1, 5, 0, 8, 0, 0, 0, 7, 2};

            Solution solution = new Solution();
            solution.MoveZeroes(nums);
        }
    }
    public class Solution
    {
        public void MoveZeroes(int[] nums)
        {
            int k = 0, temp;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != 0)
                {
                    temp = nums[k];
                    nums[k] = nums[i];
                    nums[i] = temp;
                    k++;
                }
            }
            Console.WriteLine(String.Join(", ", nums));
        }
    }
}
