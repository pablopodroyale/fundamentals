using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenges.ArraysAndStrings.TwoPointers
{
    public class FindMaxAverage
    {
        /**
        * You are given an integer array nums consisting of n elements, and an integer k.
        *  Find a contiguous subarray whose length is equal to k, 
        *  that has the maximum average value and return this value. 
        *  Any answer with a calculation error less than 10-5 will be accepted.
       */
        public double MaxAverage(int[] nums, int k)
        {
            if (nums.Length == 1)
            {
                return nums[0];
            }

            double result = 0;
            int left = 0;
            double acum = 0;

            for (int right = 0; right < nums.Length; right++)
            {
                acum += nums[right];
                int windowSize = right - left + 1;

                if (windowSize == k)
                {
                    double avg = acum / k;
                    if (left == 0)
                    {
                        result = avg;
                    }
                    else
                    {
                        result = Math.Max(result, avg);
                    }

                    acum -= nums[left];
                    left++;
                    windowSize = right - left + 1;
                }
            }

            return Math.Round(result, 5);
        }
    }
}
