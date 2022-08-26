using System;

namespace ThirdMaximumNumber
{
    class Program
    {
        public static void Main(String[] args)
        {
            int[] nums = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
            Array.Sort(nums);
            Console.WriteLine(String.Join(",", nums));
        }
    }
}