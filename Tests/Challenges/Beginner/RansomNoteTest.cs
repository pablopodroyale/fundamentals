using Challenges.Beginner;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests.Challenges.Beginner
{
    public class RansomNoteTest
    {
        private RansomNote _underTest;

        [SetUp]
        public void SetUp()
        {
            _underTest = new RansomNote();
        }

        [Test]
        //[TestCase("a", "b", false)]
        [TestCase("aa", "ab", false)]
        [TestCase("aa", "aab", true)]
        public void RunningSum(string ransomNote, string magazine, bool canConstruct)
        {
            bool result = _underTest.CanConstruct(ransomNote, magazine);
            Assert.That(canConstruct, Is.EqualTo(result));
        }
    }
}
