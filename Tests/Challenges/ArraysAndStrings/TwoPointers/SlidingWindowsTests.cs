using Challenges.ArraysAndStrings.TwoPointers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests.Challenges.ArraysAndStrings.TwoPointers
{
    public class SlidingWindowsTests
    {
        private SlidingWindows _underTest;

        public SlidingWindowsTests()
        {
            _underTest = new SlidingWindows();
        }

        [Test]
        [TestCase(new int[] { 1, 2, 3, 4 }, 6, 3)]
        public void FindLengthTest(int[] nums, int k, int expected)
        {
            var result = _underTest.FindLength(nums, k);
            Assert.That(expected, Is.EqualTo(result));
        }
    }
}
