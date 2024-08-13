using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Challenges.ArraysAndStrings.TwoPointers
{
    public class MinimumCommonValue
    {
        /// <summary>
        /// Given two integer arrays nums1 and nums2, sorted in non-decreasing order, return the minimum integer common to both arrays. If there is no common integer amongst nums1 and nums2, return -1.
        /// Note that an integer is said to be common to nums1 and nums2 if both arrays have at least one occurrence of that integer.
        /// Example 1:
        /// Input: nums1 = [1, 2, 3], nums2 = [2, 4]
        /// Output: 2
        /// Explanation: The smallest element common to both arrays is 2, so we return 2.
        /// Example 2:
        /// Input: nums1 = [1, 2, 3, 6], nums2 = [2, 3, 4, 5]
        /// Output: 2
        /// Explanation: There are two common elements in the array 2 and 3 out of which 2 is the smallest, so 2 is returned.
        /// </summary>
        /// <param name="nums1"></param>
        /// <param name="nums2"></param>
        /// <returns></returns>
        public int GetCommon(int[] nums1, int[] nums2)
        {
            int nums1Len = nums1.Length;
            int minCommon = -1;
            int index = 0;
            int aux;

            while (minCommon == -1 && index < nums1Len)
            {
                aux = nums1[index];
                bool isCommon = Array.IndexOf(nums2, aux) != -1;

                if (isCommon)
                {
                    minCommon = aux;
                }
                else
                {
                    index++;
                }
            }

            return minCommon;
        }

        public int GetCommonLinq(int[] nums1, int[] nums2)
        {
            int minCommon = nums1.Intersect(nums2).FirstOrDefault();
            return minCommon != 0 ? minCommon : -1;
        }

        public int GetCommonTwoPointers(int[] nums1, int[] nums2)
        {
            int minCommon = -1;
            int index = 0;
            int index2 = 0;
            int pointer1, pointer2 = 0;
            
            do
            {
                pointer1 = nums1[index];
                if (pointer1 == pointer2)
                {
                    minCommon = pointer1;
                }

                while (minCommon == -1 &&index2 < nums2.Length && pointer1 > pointer2)
                {
                    pointer2 = nums2[index2];
                    if (pointer1 == pointer2)
                    {
                        minCommon = pointer1;
                    }
                    else
                    {
                        index2++;
                    }
                }

                index++;

            } while (minCommon == -1 && index < nums1.Length);

            return minCommon;
        }
    }
}
