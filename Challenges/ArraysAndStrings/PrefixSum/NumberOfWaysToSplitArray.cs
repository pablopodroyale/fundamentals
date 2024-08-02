using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Challenges.ArraysAndStrings.PrefixSum
{
    public class NumberOfWaysToSplitArray
    {
        /// <summary>
        /// Given an integer array nums, find the number of ways to split the array into two parts 
        /// so that the first section has a sum greater than or equal to the sum of the second section. 
        /// The second section should have at least one number.
        /// Input: nums = [10,4,-8,7]
        /// Output: 2
        /// Explanation: 
        /// There are three ways of splitting nums into two non-empty parts:
        /// - Split nums at index 0. Then, the first part is [10], and its sum is 10. The second part is [4,-8,7], and its sum is 3. Since 10 >= 3, i = 0 is a valid split.
        /// - Split nums at index 1. Then, the first part is [10,4], and its sum is 14. The second part is [-8,7], and its sum is -1. Since 14 >= -1, i = 1 is a valid split.
        /// - Split nums at index 2. Then, the first part is [10,4,-8], and its sum is 6. The second part is [7], and its sum is 7. Since 6 < 7, i = 2 is not a valid split.
        /// Thus, the number of valid splits in nums is 2.
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public int WaysToSplitArray(int[] nums)
        {
            int n = nums.Length;
            long[] prefix = new long[nums.Length];
            prefix[0] = nums[0];
            int counter = 0;

            for (int i = 1; i < n; i++)
            {
                prefix[i] = nums[i] + prefix[i - 1];
            }

            for (int i = 0; i < n - 1; i++)
            {
                long leftSide = prefix[i];
                long rightSide = prefix[n - 1] - prefix[i];
                if (leftSide >= rightSide)
                { 
                    counter++;
                }
            }
            
            return counter;
        }
    }

}
