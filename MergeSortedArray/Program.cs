using System;

namespace MergeSortedArray
{
    class Program
    {
        public static void Main(String[] args)
        {
            int[] nums1 = new int[] { 1, 4, 3, 5 };
            int[] nums2 = new int[] { 2, 6, 8, 7, 9 };
            
            Solution solution = new Solution();
            solution.Merge(nums1, 3, nums2, 2);

        }
    }

    public class Solution
    {
        public void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            int j = 0;
            for (int i = m; i < nums1.Length; i++)
            {
                nums1[i] = nums2[j];
                j++;
            }
            Array.Sort(nums1);
            Console.WriteLine(String.Join(",", nums1));
        }
    }
}
