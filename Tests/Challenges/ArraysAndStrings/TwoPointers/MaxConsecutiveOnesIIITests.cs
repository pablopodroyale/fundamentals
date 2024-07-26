using Challenges.ArraysAndStrings.TwoPointers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests.Challenges.ArraysAndStrings.TwoPointers
{
    public class MaxConsecutiveOnesIIITests
    {
        private MaxConsecutiveOnesIII _underTest;

        public MaxConsecutiveOnesIIITests()
        {
            _underTest = new MaxConsecutiveOnesIII();
        }

        [Test]
        [TestCase(new int[] { 1, 1, 1, 0, 0, 0, 1, 1, 1, 1, 0 }, 2, 6)]
        [TestCase(new int[] { 0, 0, 1, 1, 0, 0, 1, 1, 1, 0, 1, 1, 0, 0, 0, 1, 1, 1, 1 }, 3, 10)]
        [TestCase(new int[] { 0, 0, 0, 1 }, 1, 2)]
        public void MaxConsecutiveOnesTest(int[] nums, int k, int expected)
        {
            int result = _underTest.MaxConsecutiveOnes(nums, k);
            Assert.That(expected, Is.EqualTo(result));
        }
    }
}
