using Challenges.RomanNumbers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests.Challenges.RomanNumbers
{
    public class RomanNumbersTest
    {
        private RomanNumbersCalculator _underTest;
        
        [SetUp] 
        public void SetUp() 
        {
            _underTest = new RomanNumbersCalculator();
        }

        [Test]
        [TestCase("I", 1)]
        [TestCase("II", 2)]
        [TestCase("III", 3)]
        [TestCase("IV", 4)]
        [TestCase("V", 5)]
        [TestCase("VI", 6)]
        [TestCase("VII", 7)]
        [TestCase("VIII", 8)]
        [TestCase("IX", 9)]
        [TestCase("X", 10)]
        [TestCase("XX", 20)]
        [TestCase("L", 50)]
        [TestCase("C", 100)]
        [TestCase("D", 500)]
        [TestCase("M", 1000)]
        [TestCase("XCI", 91)]
        [TestCase("LX", 60)]
        [TestCase("CCXXXI", 231)]
        [TestCase("DI", 501)]
        [TestCase("DLXI", 561)]
        public void GetNumberTestSuccess(string romanNumber, int expected)
        {
            int result = _underTest.GetNumber(romanNumber);
            Assert.That(result, Is.EqualTo(expected: expected));
        }

        [Test]
        [TestCase("Q", "Error, roman number not found")]
        public void GetNumberTestException(string romanNumber, string errorMessage)
        {
            Exception exception = null;

            try
            {
                _underTest.GetNumber(romanNumber);
            }
            catch (Exception ex)
            {

                exception = ex;
            }

            Assert.IsNotNull(exception);
            Assert.That(exception.Message, Is.EqualTo(errorMessage));
        }
    }
}
