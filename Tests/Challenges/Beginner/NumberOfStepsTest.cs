using Challenges.Beginner;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests.Challenges.Beginner
{
    public class NumberOfStepsTest
    {
        private NumberOfSteps _underTest;

        [SetUp]
        public void SetUp()
        {
            _underTest = new NumberOfSteps();
        }

        [Test]
        [TestCase(14, 6)]
        [TestCase(8, 4)]
        [TestCase(123, 12)]
        public void RunningSum(int num, int steps)
        {
            int result = _underTest.NumberOfStepsSolution(num);
            Assert.That(steps, Is.EqualTo(result));
        }

    }
}
