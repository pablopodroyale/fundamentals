using Challenges.Recursive;
using Challenges.RomanNumbers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests.Challenges.Recursive
{
    public class FibonacciTests
    {
        private Fibonacci _underTest;

        [SetUp]
        public void SetUp()
        {
            _underTest = new Fibonacci();
        }

        [Test]
        public void FibonacciTest()
        {
            int result = _underTest.FibonacciRecursive(5);
        }

        [Test]
        public void FibonacciDPTest()
        {
            int result = _underTest.FibonacciDP(10);
        }

        [Test]
        public void Test() 
        {
            
        }
    }
}
