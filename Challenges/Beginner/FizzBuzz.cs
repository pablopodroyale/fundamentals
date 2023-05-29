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
            
            Dictionary<int, string> map = new Dictionary<int, string>
            {
                { 5, BUZZ },
                { 3, FIZZ },
                //{ 3 * 5, FIZZ + BUZZ }
            };

            map.Add(map.Keys.Aggregate(1, (x,y) => x * y), map.Values.Reverse()
                                                                     .Aggregate((x, y) => x + y));

            List<string> result = new List<string>();
            for (int i = 1; i <= n; i++)
            {
                var divider = map.Where(x => i % x.Key == 0).OrderByDescending(y => y.Key).FirstOrDefault();
                if (divider.Key == 0)
                {
                    result.Add(i.ToString());
                }
                else 
                {
                    var value = map[divider.Key];
                    result.Add(value);
                }
            }

            return result;
        }
    }
}
