using Challenges.ArraysAndStrings.PrefixSum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests.Challenges.PrefixSum
{
    public class MinimumValueToGetPositiveStepByStepSumTests
    {
        private MinimumValueToGetPositiveStepByStepSum _underTest;

        public MinimumValueToGetPositiveStepByStepSumTests()
        {
            _underTest = new MinimumValueToGetPositiveStepByStepSum();
        }

        [Test]
        //[TestCase(new int[] { -3, 2, -3, 4, 2 }, 5)]
        [TestCase(new int[] { 2, 3, 5, -5, -1 }, 1)]
        public void MinStartValueTest(int[]nums, int expected)
        { 
            var result = _underTest.MinStartValue(nums);
            Assert.That(result, Is.EqualTo(expected));
        }
    }
}
