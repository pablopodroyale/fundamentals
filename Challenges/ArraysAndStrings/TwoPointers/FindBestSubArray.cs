using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenges.ArraysAndStrings.TwoPointers
{
    public class FindBestSubArray
    {
        /**
         *Given an integer array nums and an integer k, 
         *find the sum of the subarray with the largest sum whose length is k
         *
        **/
        public int FindBestSubarray(int[] nums, int k)
        {
            //int max = 0;
            //int left = 0;
            //int acum = 0;

            //for (int right = 0; right < nums.Length; right++)
            //{
            //    acum += nums[right];
            //    int windowSize = right - left + 1;

            //    if (windowSize == k)
            //    {
            //        max = Math.Max(max, acum);

            //        while (windowSize >= k)
            //        {
            //            acum -= Math.Abs(nums[left]);
            //            left++;
            //            windowSize = right - left + 1;
            //        }
            //    }
            //}

            //return max;
            int curr = 0;
            for (int i = 0; i < k; i++)
            {
                curr += nums[i];
            }

            int ans = curr;
            for (int i = k; i < nums.Length; i++)
            {
                curr += nums[i] - nums[i - k];
                ans = Math.Max(ans, curr);
            }

            return ans;
        }
    }
}
