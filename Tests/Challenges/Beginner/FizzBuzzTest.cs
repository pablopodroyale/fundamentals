using Challenges.Beginner;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests.Challenges.Beginner
{
    public class FizzBuzzTest
    {
        private FizzBuzz _underTest;

        [SetUp]
        public void SetUp()
        {
            _underTest = new FizzBuzz();
        }

        [Test]
        [TestCase(3, new string[] { "1", "2", "Fizz" })]
        [TestCase(5, new string[] { "1", "2", "Fizz", "4", "Buzz" })]
        [TestCase(15, new string[] { "1", "2", "Fizz", "4", "Buzz", "Fizz", "7", "8", "Fizz", "Buzz", "11", "Fizz", "13", "14", "FizzBuzz" })]    
        public void RunningSum(int num, string[] expected)
        {
            IList<string> result = _underTest.FizzBuzzSolution(num);
            Assert.That(expected, Is.EqualTo(result));
        }
    }
}
