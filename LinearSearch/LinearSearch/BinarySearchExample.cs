using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinearSearch
{
    public class IterativeBinarySearch
    {
        public static int binarySearch(int[] input, int target)
        {
            int first = 0;
            int last = input.Length - 1;

            while (first <= last)
            {
                int mid = (first + last) / 2;

                if (input[mid] == target)
                {
                    return mid;
                }
                else if (input[mid] < target)
                {
                    first = mid + 1;
                }
                else
                {
                    last = mid - 1;
                }
            }

            return -1;
        }
    }

    public class RecursiveBinarySearch
    {
        public static int binarySearch(int[] input, int target, int start, int end)
        {
            if (start >= end)
            {
                return -1;
            }
            else
            {
                int mid = start + (end - start) / 2;

                if (target < input[mid])
                {
                    return binarySearch(input, target, start, mid - 1);
                }
                else if (target > input[mid])
                {
                    return binarySearch(input, target, mid + 1, end);
                }
                else
                {
                    return mid;
                }
            }
        }
    }
}
