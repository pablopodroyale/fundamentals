using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenges.Beginner
{
    public class FizzBuzz
    {
        public IList<string> FizzBuzzSolution(int n)
        {
            const string FIZZ = "Fizz";
            const string BUZZ = "Buzz";
            bool divisibleBy3 = false;
            bool divisibleBy5 = false;

            List<string> result = new List<string>();
            for (int i = 1; i <= n; i++)
            {
                divisibleBy3 = i % 3 == 0;
                divisibleBy5 = i % 5 == 0;

                if (divisibleBy3 && divisibleBy5)
                {
                    result.Add(FIZZ + BUZZ);
                }
                else if (divisibleBy5)
                {
                    result.Add(BUZZ);
                }
                else if (divisibleBy3)
                {
                    result.Add(FIZZ);
                }
                else
                {
                    result.Add(i.ToString());
                }
            }

            return result;
        }
    }
}
