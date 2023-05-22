using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenges.Beginner
{
    public class SumOf1dArray
    {
        public int[] RunningSum(int[] nums)
        {
            int[] arrayResult = new int[nums.Length];
            int acum = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                acum = acum + nums[i];
                arrayResult[i] = acum;
            }

            return arrayResult;
        }
    }
}
