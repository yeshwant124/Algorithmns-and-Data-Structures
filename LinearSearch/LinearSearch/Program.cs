using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinearSearch
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrNumbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
            /*int i = IterativeBinarySearch.binarySearch(arrNumbers, 14);
            
            if (i > -1)
            {
                Console.WriteLine("Number located at index {0}", i);
            }
            else
            {
                Console.WriteLine("Number not found in the list");
            }*/

            Array.Resize(ref arrNumbers, 21);
            arrNumbers[20]=29;
            //Console.WriteLine(arrNumbers.Length);
            
            for(int i = 0; i < arrNumbers.Length;i++)
            {
                Console.Write(arrNumbers[i] + " ");
            }
            Console.WriteLine();
            
        }
    }
}
