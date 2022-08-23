using System;

namespace CheckIfNAndItsDoubleExist
{
    class Program
    {
        public static void Main(String[] args)
        {
            int[] nums = new int[] { 1, 1, 1, 2, 2, 3, 4, 4, 5 };

            Solution solution = new Solution();
            bool result = solution.CheckIfExist(nums);
            Console.WriteLine(result);

        }
    }

    public class Solution
    {
        public bool CheckIfExist(int[] arr)
        {
            if (arr == null || arr.Length == 0)
            {
                return false;
            }
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if ((arr[i] == (arr[j] * 2)) || ((arr[i] * 2) == arr[j]))
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }

    
}
