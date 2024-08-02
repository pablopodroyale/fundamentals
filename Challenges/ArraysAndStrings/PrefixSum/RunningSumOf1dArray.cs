using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenges.ArraysAndStrings.PrefixSum
{
    public class RunningSumOf1dArray
    {
        /// <summary>
        /// Given an array nums. We define a running sum of an array as runningSum[i] = sum(nums[0]…nums[i]).
        /// Return the running sum of nums.
        /// Example 1:
        /// Input: nums = [1,2,3,4]}
        /// Output: [1,3,6,10]
        /// Explanation: Running sum is obtained as follows: [1, 1+2, 1+2+3, 1+2+3+4].
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public int[] RunningSum(int[] nums)
        {
            int[] prefix = new int[nums.Length];
            prefix[0] = nums[0];

            for (int i = 1; i < nums.Length; i++)
            {
                prefix[i] = prefix[i - 1] + nums[i];
            }

            return prefix;
        }
    }
}
