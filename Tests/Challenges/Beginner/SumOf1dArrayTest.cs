using Challenges.Beginner;

namespace Tests.Challenges.Beginner
{
    public class SumOf1dArrayTest
    {
        private SumOf1dArray _underTest;

        [SetUp]
        public void SetUp()
        {
            _underTest = new SumOf1dArray();
        }

        [Test]
        [TestCase(new int[4] { 1, 2, 3, 4 }, new int[4] { 1, 3, 6, 10 })]
        [TestCase(new int[5] { 1, 1, 1, 1, 1 }, new int[5] { 1, 2, 3, 4, 5 })]
        [TestCase(new int[5] { 3, 1, 2, 10, 1 }, new int[5] { 3, 4, 6, 16, 17 })]
        public void RunningSum(int[] nums, int[] expected)
        {
            int[] result = _underTest.RunningSum(nums);
            Assert.That(expected, Is.EqualTo(result));
        }
    }
}
