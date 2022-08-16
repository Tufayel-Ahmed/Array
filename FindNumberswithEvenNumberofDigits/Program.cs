using System;

namespace FindNumberswithEvenNumberofDigits
{
    class Program
    {
        public static void Main(String[] args)
        {
            Solution solution = new Solution();
            int[] array = new int[] { 16, 556, 65646, 645564, 3256464 };
            int result = solution.FindNumbers(array);
            Console.WriteLine(result);
        }
    }
    public class Solution
    {
        public int FindNumbers(int[] nums)
        {
            int even = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                int count = 0;
                do
                {
                    count++;
                    nums[i] = nums[i] / 10;
                } while (nums[i] != 0);
                if (count % 2 == 0)
                {
                    even++;
                }
            }
            return even;
        }
    }
}
