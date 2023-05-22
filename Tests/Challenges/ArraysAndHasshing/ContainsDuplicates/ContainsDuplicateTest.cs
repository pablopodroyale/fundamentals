
using Fundamentals.Fundamentals.ArraysAndHashing.ContainsDuplicates;
using System.Linq.Expressions;

namespace Tests.Challenges.ArraysAndHasshing.ContainsDuplicates
{
    public class ContainsDuplicateTest
    {
        private ContainsDuplicatesPractice _underTest;

        [SetUp]
        public void SetUp()
        {
            _underTest = new ContainsDuplicatesPractice();
        }

        [Test]
        [TestCase(1, 2, 3, 1, true)]
        [TestCase(3, 3, 0, 0, true)]
        public void ContainsDuplicatesTest(int num1, int num2, int num3, int num4, bool expected)
        {
            int[] nums = new int[4] { num1, num2, num3, num4 };

            bool containDuplicate = _underTest.ContainsDuplicate(nums);

            Assert.That(containDuplicate, Is.EqualTo(expected));
        }

        [Test]
        [TestCase(1, 2, 3, 1, 0, true)]
        [TestCase(3, 3, 0, 0, 0, true)]
        [TestCase(3, 1, 0, 0, 0, false)]
        [TestCase(2, 14, 18, 22, 22, true)]
        [TestCase(1, 2, 3, 4, 5, false)]
        public void ContainsDuplicatesWithWhileTest(int num1, int num2, int num3, int num4, int num5, bool expected)
        {
            List<int> nums = new List<int>();

            if (num1 != 0)
            {
                nums.Add(num1);
            }
            if (num2 != 0)
            {
                nums.Add(num2);
            }
            if (num3 != 0)
            {
                nums.Add(num3);
            }
            if (num4 != 0)
            {
                nums.Add(num4);
            }
            if (num5 != 0)
            {
                nums.Add(num5);
            }

            bool result = _underTest.ContainsDuplicate(nums.ToArray());
            Assert.That(result, Is.EqualTo(expected));

            result = _underTest.ContainsDuplicateWithWhileAndBinarySearch(nums.ToArray());
            Assert.That(result, Is.EqualTo(expected));

            result = _underTest.ContainsDuplicateLinq(nums.ToArray());
            Assert.That(result, Is.EqualTo(expected));

            result = _underTest.ContainsDuplicatesHashSet(nums.ToArray());
            Assert.That(result, Is.EqualTo(expected));

            result = _underTest.ContainsDuplicateCompareNext(nums.ToArray());
            Assert.That(result, Is.EqualTo(expected));
        }
    }
}
