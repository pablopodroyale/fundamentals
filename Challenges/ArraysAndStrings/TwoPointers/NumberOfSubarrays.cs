using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenges.ArraysAndStrings.TwoPointers
{
    public class NumberOfSubarrays
    {
        /// <summary>
        /// Given an array of positive integers nums and an integer k, 
        /// return the number of subarrays,
        /// where the product of all the elements in the subarray is strictly less than k
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        public int NumberOfSubarraysProductLessThanK(int[] nums, int k)
        {
            int current = 1;
            int left = 0;

            int counter = 0;

            for (int right = 0; right < nums.Length; right++)
            {
                current *= nums[right];
                counter++;
                if (current >= k)
                {
                    while (current >= k)
                    {
                        current /= nums[left];
                        left++;
                    }
                }

                counter += right - left;
            }

            return counter;
        }
    }
}
