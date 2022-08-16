using System;

namespace MaxConsecutiveOnes
{
    class Program
    {
        public static void Main(String[] args)
        {
            Solution solution = new Solution();
            int[] array = new int[] {1, 0, 1, 1, 0 };

            int result = solution.FindMaxConsecutiveOnes(array);
            Console.WriteLine(result);
        }
    }
    public class Solution
    {
        public int FindMaxConsecutiveOnes(int[] nums)
        {
            int count = 0;
            int max = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 1)
                {
                    count++;
                    max = Math.Max(max, count);
                }
                else
                {
                    count = 0;
                }
            }
            return max;
        }
    }
}