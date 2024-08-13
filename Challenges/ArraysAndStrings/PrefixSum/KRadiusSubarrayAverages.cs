using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Challenges.ArraysAndStrings.PrefixSum
{
    public class KRadiusSubarrayAverages
    {
        /// <summary>
        /// You are given a 0-indexed array nums of n integers, and an integer k.
        /// The k-radius average for a subarray of nums centered at some index i with the radius k is the average of all elements in nums between the indices i - k and i + k(inclusive). 
        /// If there are less than k elements before or after the index i, 
        /// then the k-radius average is -1. 
        /// Build and return an array avgs of length n where avgs[i] is the k-radius average 
        /// for the subarray centered at index i.
        /// The average of x elements is the sum of the x elements divided by x, using integer division.
        /// The integer division truncates toward zero, which means losing its fractional part. 
        /// For example, the average of four elements 2, 3, 1, and 5 is (2 + 3 + 1 + 5) / 4 = 11 / 4 = 2.75, which truncates to 2.
        /// </summary>
        /// <returns></returns>
        public int[] GetAverages(int[] nums, int k)
        {
            long size = nums.Length;
            int[] result = new int[size];
            long[] prefix = new long[size + 1];
            prefix[0] = 0;
            prefix[1] = nums[0];
            int cantNums = (k * 2) + 1;
            
            for (int i = 2; i < prefix.Length; i++)
            {
                prefix[i] = nums[i - 1] + prefix[i - 1];
            }

            for (int i = 0; i < result.Length; i++)
            {
                if (isCenter(i, result.Length, k))
                {
                    long prefixSumRight = prefix[i + k + 1];
                    long prefixSumLeft = prefix[i - k];
                    int avg =(int) Math.Ceiling(double.Parse(((prefixSumRight - prefixSumLeft) / cantNums).ToString(), CultureInfo.InvariantCulture));
                    result[i] = avg;
                }
                else 
                {
                    result[i] = -1;
                }
            }

            return result;
        }

        private bool isCenter(int i, int length, int k)
        {
            return i + k <= length - 1 && i - k >= 0;
        }
    }
}
