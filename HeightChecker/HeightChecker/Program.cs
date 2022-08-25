using System;

namespace HeightChecker
{
    class Program
    {
        public static void Main(String[] args)
        {
            int[] heights = new int[] { 4, 2, 4, 3, 7, 1, 2, 9, 10};

            Solution solution = new Solution();
            int result = solution.HeightChecker(heights);
            Console.WriteLine(result);

        }
    }

    public class Solution
    {
        public int HeightChecker(int[] heights)
        {
            int count = 0;
            int[] expected = new int[heights.Length];
            Array.Copy(heights, expected, heights.Length);
            Array.Sort(expected);
            for (int i = 0; i < heights.Length; i++)
            {
                if (expected[i] != heights[i])
                {
                    count++;
                }
            }
            return count;
        }
    }
}
