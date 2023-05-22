using Challenges.Beginner;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests.Challenges.Beginner
{
    public class RichestCustomerWealthTest
    {
        private RichestCustomerWealth _underTest;

        [SetUp]
        public void SetUp()
        {
            _underTest = new RichestCustomerWealth();
        }

        [Test]
        [TestCase(new int[] {1, 2, 3 }, new int[] {3, 2, 1 }, new int[] { }, 6)]
        [TestCase(new int[] { 1, 5 }, new int[] { 7, 3 }, new int[] { 3, 5 }, 10)]
        [TestCase(new int[] { 2, 8, 7 }, new int[] { 7, 1, 3 }, new int[] { 1, 9, 5 }, 17)]
        public void MaximumWealthTest(int[] firstDimension, int[] secondDimension, int[] thirdDimension, int expected)
        {
            int[][] nums = new[] { firstDimension, secondDimension, thirdDimension };
            int result = _underTest.MaximumWealth(nums);
            Assert.That(expected, Is.EqualTo(result));
        }
    }
}
