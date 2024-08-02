using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenges.ArraysAndStrings.PrefixSum
{
    public class MinimumValueToGetPositiveStepByStepSum
    {
        /// <summary>
        /// Given an array of integers nums, you start with an initial positive value startValue.
        /// In each iteration, you calculate the step by step sum of startValue plus elements in nums(from left to right).
        /// Return the minimum positive value of startValue such that the step by step sum is never less than 1.
        /// Example 1:
        /// Input: nums = [-3,2,-3,4,2]
        /// Output: 5
        /// Explanation: If you choose startValue = 4, in the third iteration your step by step sum is less than 1.
        /// step by step sum
        /// startValue = 4 | startValue = 5 | nums
        /// (4 -3 ) = 1  | (5 -3 ) = 2    |  -3
        /// (1 +2 ) = 3  | (2 +2 ) = 4    |   2
        /// (3 -3 ) = 0  | (4 -3 ) = 1    |  -3
        /// (0 +4 ) = 4  | (1 +4 ) = 5    |   4
        /// (4 +2 ) = 6  | (5 +2 ) = 7    |   2
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public int MinStartValue(int[] nums)
        {
            const int MIN = 1;
            int minStartValue = 1;
            int minimumPrefixSum;

            do
            {
                minimumPrefixSum = int.MaxValue;
                int[] prefix = new int[nums.Length];
                prefix[0] = nums[0] + minStartValue;

                for (int i = 1; i < nums.Length; i++)
                {
                    prefix[i] = prefix[i - 1] + nums[i];
                }

                for (int i = 0; i < prefix.Length; i++)
                {
                    if (prefix[i] < minimumPrefixSum)
                    {
                        minimumPrefixSum = prefix[i];
                    }
                }

                if (minimumPrefixSum < MIN)
                {
                    minStartValue++;
                }
            } while (minimumPrefixSum < MIN);

            return minStartValue;
        }
    }
}
