using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Tests.Challenges.ArraysAndStrings.TwoPointers
{
    public class ReverseOnlyLetters
    {
        /// <summary>
        /// Given a string s, reverse the string according to the following rules:
        /// All the characters that are not English letters remain in the same position.
        /// All the English letters(lowercase or uppercase) should be reversed.
        /// Return s after reversing it.
        /// Example 1:
        ///Input: s = "ab-cd"
        /// Example 2:
        /// Input: s = "a-bC-dEf-ghIj"
        /// Output: "j-Ih-gfE-dCba"
        /// Example 3:
        /// Input: s = "Test1ng-Leet=code-Q!"
        /// Output: "Qedo1ct-eeLg=ntse-T!"
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public string ReverseOnlyLettersSolution(string s)
        {
            char[] chars = new char[s.Length];
            string pattern = @"[a-zA-Z]";
            int right = s.Length - 1;
            int left = 0;

            do
            {
                char leftChar = s[left];
                char rightChar = s[right];
                
                if (!Regex.IsMatch(leftChar.ToString(), pattern))
                {
                    chars[left] = leftChar;
                    left++;
                } else if (!Regex.IsMatch(rightChar.ToString(), pattern))
                {
                    chars[right] = rightChar;
                    right--;
                } else if (Regex.IsMatch(leftChar.ToString(), pattern) && Regex.IsMatch(rightChar.ToString(), pattern))
                {
                    chars[right] = leftChar;
                    chars[left] = rightChar;
                    right--;
                    left++;
                }
            }while(left <= right);

            return new string(chars);
        }
    }
}
