using Challenges.ArraysAndStrings.TwoPointers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests.Challenges.ArraysAndStrings.TwoPointers
{
    public class MinimumCommonValueTests
    {
        private MinimumCommonValue _underTest;

        public MinimumCommonValueTests()
        {
            _underTest = new MinimumCommonValue();
        }

        [Test]
        [TestCase(new int[] { 1, 2, 3 }, new int[] { 2, 4 }, 2)]
        [TestCase(new int[] { 1000000000, 1000000000 }, new int[] { 1000000000 }, 1000000000)]
        public void GetCommonTest(int[] nums1, int[] nums2, int expected)
        {
            int result = _underTest.GetCommon(nums1, nums2);
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        [TestCase(new int[] { 1, 2, 3 }, new int[] { 2, 4 }, 2)]
        [TestCase(new int[] { 1000000000, 1000000000 }, new int[] { 1000000000 }, 1000000000)]
        public void GetCommonLinqTest(int[] nums1, int[] nums2, int expected)
        {
            int result = _underTest.GetCommonLinq(nums1, nums2);
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        //[TestCase(new int[] { 1, 2, 3 }, new int[] { 2, 4 }, 2)]
        //[TestCase(new int[] { 1000000000, 1000000000 }, new int[] { 1000000000 }, 1000000000)]
        [TestCase(new int[] { 3, 5 }, new int[] { 2 }, -1)]
        public void GetCommonTwoPointersTest(int[] nums1, int[] nums2, int expected)
        {
            int result = _underTest.GetCommonTwoPointers(nums1, nums2);
            Assert.That(result, Is.EqualTo(expected));
        }
    }
}
