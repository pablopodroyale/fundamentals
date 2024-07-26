using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenges.Recursive
{
    public class Fibonacci
    {
        public int FibonacciRecursive(int n)
        {
            if (n <= 1)
                return n;

            int oneBack = FibonacciRecursive(n - 1);
            int twoBack = FibonacciRecursive(n - 2);
            return oneBack + twoBack;
        }

        public int FibonacciDP(int n)
        {
            if (n <= 1)
                return n;

            int[] fib = new int[n + 1];
            fib[0] = 0;
            fib[1] = 1;

            for (int i = 2; i <= n; i++)
            {
                fib[i] = fib[i - 1] + fib[i - 2];
            }
            return fib[n];
        }
    }
}
