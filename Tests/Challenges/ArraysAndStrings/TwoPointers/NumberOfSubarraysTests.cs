using Challenges.ArraysAndStrings.TwoPointers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests.Challenges.ArraysAndStrings.TwoPointers
{
    public class NumberOfSubarraysTests
    {
        private NumberOfSubarrays _underTest;

        public NumberOfSubarraysTests()
        {
            _underTest = new NumberOfSubarrays();
        }

        [Test]
        [TestCase(new int[] { 10, 5, 2, 6 }, 15, 6)]
        public void NumberOfSubarraysProductLessThanK(int[] nums, int k, int expected)
        {
            int result = _underTest.NumberOfSubarraysProductLessThanK(nums, k);
            Assert.That(expected, Is.EqualTo(result));
        }
    }
}
