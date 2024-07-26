using Challenges.ArraysAndStrings.TwoPointers;
using Challenges.Temp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests.Challenges.ArraysAndStrings.TwoPointers
{
    public class SortedSquaresTests
    {
        private SquaresOfASortedArray _underTest;

        [SetUp]
        public void SetUp()
        {
            _underTest = new SquaresOfASortedArray();
        }

        [Test]
        [TestCase(new int[] { -5, -3, -2, -1 }, new int[] { 1, 4, 9, 25 })]
        [TestCase(new int[] { -7, -3, 1, 2, 3 }, new int[] { 1, 4, 9, 9, 49 })]
        [TestCase(new int[] { -4, -1, 0, 3, 10 }, new int[] { 0, 1, 9, 16, 100 })]
        public void Test(int[] nums, int[] expected)
        {
            var result = _underTest.SortedSquares(nums);
            Assert.That(result, Is.EqualTo(expected));
        }
    }
}
