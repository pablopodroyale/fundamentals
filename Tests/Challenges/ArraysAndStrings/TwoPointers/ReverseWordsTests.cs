using Challenges.ArraysAndStrings.TwoPointers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests.Challenges.ArraysAndStrings.TwoPointers
{
    public class ReverseWordsTests
    {
        private ReverseWords _underTests;

        public ReverseWordsTests()
        {
            _underTests = new ReverseWords();
        }

        [Test]
        [TestCase("Hello world", "olleH dlrow")]
        public void ReverseWordsTest(string s, string expected)
        {
            string result = _underTests.ReverseWordsSolution(s);
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        [TestCase("Hello world", "olleH dlrow")]
        public void ReverseWordsV2Test(string s, string expected)
        {
            string result = _underTests.ReverseWordsSolutionV2(s);
            Assert.That(result, Is.EqualTo(expected));
        }

    }
}
