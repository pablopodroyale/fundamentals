using Challenges.ArraysAndStrings.TwoPointers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests.Challenges.ArraysAndStrings.TwoPointers
{
    public class FindBestSubArrayTests
    {
        private FindBestSubArray _underTest;

        public FindBestSubArrayTests()
        {
            _underTest = new FindBestSubArray();
        }

        [Test]
        [TestCase(new int[] { 3, -1, 4, 12, -8, 5, 6 }, 4, 18)]
        public void FindBestSubArray(int[] nums, int k, int expected)
        {
            int result = _underTest.FindBestSubarray(nums, k);
            Assert.That(result, Is.EqualTo(expected));
        }
    }
}
