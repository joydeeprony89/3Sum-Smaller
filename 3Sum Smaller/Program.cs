using System;

namespace _3Sum_Smaller
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = new int[] { -2, 0 , 1, 3 };
            Console.WriteLine(ThreeSumSmaller(nums,2));
        }

        static int ThreeSumSmaller(int[] nums, int target)
        {
            if (nums == null || nums.Length == 0) return 0;
            int count = 0;
            Array.Sort(nums);
            for (int i = 0; i < nums.Length - 2; i++)
            {
                int l = i + 1, r = nums.Length - 1;
                while (l < r)
                {
                    int sum = nums[i] + nums[l] + nums[r];
                    if (sum < target)
                    {
                        count += r - l;
                        l++;
                    }
                    else r--;
                }
            }

            return count;
        }
    }
}
