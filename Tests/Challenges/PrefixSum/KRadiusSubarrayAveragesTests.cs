using Challenges.ArraysAndStrings.PrefixSum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests.Challenges.PrefixSum
{
    public class KRadiusSubarrayAveragesTests
    {
        private KRadiusSubarrayAverages _underTest;

        public KRadiusSubarrayAveragesTests()
        {
            _underTest = new KRadiusSubarrayAverages();
        }

        [Test]
        [TestCase(new int[] { 7, 4, 3, 9, 1, 8, 5, 2, 6 }, 3, new int[] { -1, -1, -1, 5, 4, 4, -1, -1, -1 })]
        public void GetAverages(int[] nums, int k, int[] expected)
        {
            int[] result = _underTest.GetAverages(nums, k);
            Assert.That(result, Is.EqualTo(expected));
        }
    }
}
