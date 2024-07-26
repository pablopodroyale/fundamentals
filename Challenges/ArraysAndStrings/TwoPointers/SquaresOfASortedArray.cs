using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenges.ArraysAndStrings.TwoPointers
{
    public class SquaresOfASortedArray
    {
        public int[] SortedSquares(int[] nums)
        {
            int[] aux = new int[nums.Length];
            int leftPointer = 0;
            int rightPointer = nums.Length - 1;
            int length = nums.Length;
            int square = 0;

            for (int i = nums.Length - 1; i >= 0; i--)
            {
                int left = Math.Abs(nums[leftPointer]);
                int right = Math.Abs(nums[rightPointer]);

                if (left > right)
                {
                    square = left * left;
                    leftPointer += 1;
                }
                else
                {
                    square = right * right;
                    rightPointer -= 1;
                }

                aux[i] = square;
            }

            return aux;
        }
    }
}
