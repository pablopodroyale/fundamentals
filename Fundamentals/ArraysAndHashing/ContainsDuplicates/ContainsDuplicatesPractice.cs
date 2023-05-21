using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Fundamentals.Fundamentals.ArraysAndHashing.ContainsDuplicates
{
    public class ContainsDuplicatesPractice
    {
        public bool ContainsDuplicate(int[] nums)
        {
            bool containsDuplicates = false;
            //Reference pointer
            int current = 0;
            //Next reference pointer of the sub array
            int next = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (containsDuplicates)
                {
                    break;
                }

                current = nums[i];
                for (int j = i + 1; j < nums.Length; j++)
                {
                    next = nums[j];
                    if (next == current)
                    {
                        containsDuplicates = true;
                        break;
                    }
                }
            }

            return containsDuplicates;
        }

        public bool ContainsDuplicateWithWhileAndBinarySearch(int[] nums)
        {
            bool containsDuplicates = false;
            
            if (nums.Length == 2)
            {
                if (nums[0] == nums[1])
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            //Sort in order
            nums = nums.OrderBy(x => x).ToArray();
          
            //Reference pointer
            int key = 0;
            //Next reference pointer of the sub array
            int indexI = 0;
           
            int right = nums.Length - 1;

            while (indexI < nums.Length && !containsDuplicates)
            {
                key = nums[indexI];
                int length = nums.Length - indexI;
                int[] subArray = nums.Skip(indexI + 1).Take(length).ToArray();
                
                containsDuplicates = ContainsDuplicateBinarySearch(key, subArray, indexI);
                indexI++;
            }

            return containsDuplicates;
        }

        public bool ContainsDuplicateLinq(int[] nums)
        { 
            bool containsDuplicates = nums.GroupBy(x => x)
                                          .Where(x => x.Count() > 1)
                                          .Any();   
            return containsDuplicates;
        }

        public bool ContainsDuplicatesHashSet(int[] nums)
        {
            HashSet<int> set = new HashSet<int>(nums);
            bool containsDuplicates = false;
            
            if (set.Count() < nums.Length)
            {
                containsDuplicates = true;
            }

            return containsDuplicates;
        }

        public bool ContainsDuplicateCompareNext(int[] nums)
        {
            nums = nums.OrderBy(x => x).ToArray();

            for (int i = 0; i < nums.Length - 1; i++)
            {
                if (nums[i] == nums[i + 1])
                {
                    return true;
                }
            }
            return false;
        }

        private bool ContainsDuplicateBinarySearch(int key, int[] subArray, int index)
        {
            bool containsDuplicates = false;
            int left = 0;
            
            int right = subArray.Length - 1;

            while (left <= right && !containsDuplicates)
            {
                //left = index + 1;
                int middle = (right - left) / 2;

                if (key == subArray[middle])
                {
                    containsDuplicates = true;
                }
                else if (key < subArray[middle])
                {
                    right = middle - 1;
                }
                else
                {
                    left = middle + 1;
                }
            }
          
            return containsDuplicates;
        }
    }
}
