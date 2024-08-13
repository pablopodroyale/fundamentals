using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace Challenges.ArraysAndStrings.TwoPointers
{
    public class ReverseWords
    {
        /// <summary>
        /// Given a string s, reverse the order of characters in each word within a sentence while still preserving whitespace and initial word order.
        /// Example 1:
        /// Input: s = "Let's take LeetCode contest"
        /// Output: "s'teL ekat edoCteeL tsetnoc"
        /// Example 2:
        /// Input: s = "Mr Ding"
        /// Output: "rM gniD"
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public string ReverseWordsSolution(string s)
        {
            StringBuilder result = new StringBuilder();
            int left = 0;
            
            for (int right = 0; right < s.Length; right++)
            {
                char current = s[right];
                if (current == ' ' || right == s.Length - 1)
                {
                    int auxPointer = right == s.Length - 1 ? right : right - 1;
                    while (auxPointer >= left)
                    {
                        current = s[auxPointer];
                        result.Append(current);
                        auxPointer--;
                    }

                    if (right != s.Length - 1)
                    {
                        result.Append(" ");
                    }

                    left = right + 1;
                }

            }

            return result.ToString();
        }

        public string ReverseWordsSolutionV2(string s)
        {
            int left = 0;
            char[] result = new char[s.Length];

            for (int right = 0; right < s.Length; right++)
            {
                char current = s[right];
                if (current == ' ' || right == s.Length - 1)
                {
                    int rightAux = right == s.Length - 1 ? right : right - 1;
                    int leftAux = left;
                    int currWordSize = (rightAux + leftAux) / 2 ;

                    while (leftAux <= currWordSize)
                    {
                        result[leftAux] = s[rightAux];
                        result[rightAux] = s[leftAux];
                        rightAux--;
                        leftAux++;
                    }

                    if (right != s.Length - 1)
                    {
                        result[right] = ' ';
                        left = right + 1;
                    }
                }

            }

            return new String(result);
        }
    }

}
