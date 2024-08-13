using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests.Challenges.ArraysAndStrings.TwoPointers
{
    public class ReverseOnlyLettersTests
    {
        private ReverseOnlyLetters _underTest;

        public ReverseOnlyLettersTests()
        {
            _underTest = new ReverseOnlyLetters();
        }

        [Test]
        [TestCase("ab-cd", "dc-ba")]
        [TestCase("a-bC-dEf-ghIj", "j-Ih-gfE-dCba")]

        public void ReverseOnlyLettersTest(string s, string expected)
        {
            string result = _underTest.ReverseOnlyLettersSolution(s);
            Assert.That(result, Is.EqualTo(expected));
        }
    }
}
