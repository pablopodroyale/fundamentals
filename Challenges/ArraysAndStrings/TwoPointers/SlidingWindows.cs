using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenges.ArraysAndStrings.TwoPointers
{
    public class SlidingWindows
    {
        /**
         *Example 1: Given an array of positive integers nums and an integer k, 
         *find the length of the longest subarray whose sum is less than or equal to k.
         *
        */
        public int FindLength(int[] nums, int k)
        {
            int counter = 0;
            int current = 0;
            int max = 0;
            int left = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                int right = i;

                current += nums[right];
                counter++;

                if (current > k)
                {
                    while (current > k)
                    {
                        current -= nums[left];
                        left++;
                        counter--;
                    }
                }

                max = Math.Max(max, right + 1 - left);

                if (counter > max)
                {
                    max = counter;
                }

            }

            return max;
        }
    }
}
