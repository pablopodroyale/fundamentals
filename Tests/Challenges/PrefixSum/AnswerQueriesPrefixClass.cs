using Challenges.ArraysAndStrings.PrefixSum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests.Challenges.PrefixSum
{
    public class AnswerQueriesPrefixClass
    {
        private AnswerQueriesPrefix _underTest;

        public AnswerQueriesPrefixClass()
        {
            _underTest = new AnswerQueriesPrefix();
        }

        public static IEnumerable<object[]> TestCases
        {
            get
            {
                yield return new object[]
                {
                new int[] { 10, 5, 2, 6 },
                new int[][] { new int[] { 0, 1 }, new int[] {2 , 3 } },
                8,
                new bool[] { false }
                };
            }
        }

        [Test]
        [TestCaseSource(nameof(TestCases))]
        public void PrefixSum(int[] nums,int[][] queries, int limit, bool[] expected) 
        {
            var result = _underTest.AnswerQueries(nums, queries, limit);
    
        }
    }
}
