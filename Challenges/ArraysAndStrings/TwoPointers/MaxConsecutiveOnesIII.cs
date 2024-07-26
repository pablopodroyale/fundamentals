using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenges.ArraysAndStrings.TwoPointers
{
    public class MaxConsecutiveOnesIII
    {
        /**
         * Given a binary array nums and an integer k, 
         * return the maximum number of consecutive 
         * 1's in the array if you can flip at most k 0's
         * 
        */
        public int MaxConsecutiveOnes(int[] nums, int k)
        {
            int zeroCounter = k;
            int left = 0;
            int max = 0;
            for (int right = 0; right < nums.Length; right++)
            {
                if (nums[right] == 0)
                {
                    zeroCounter--;
                }

                if (zeroCounter < 0)
                {
                    if (nums[left] == 0)
                    {
                        zeroCounter++;
                    }

                    left++;
                }
                else
                {
                    max = Math.Max(max, right - left + 1);
                }

            }

            return max;
        }
    }
}
