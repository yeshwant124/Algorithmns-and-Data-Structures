namespace ADT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Array Insertions and Deletions
            // Inserting at the end of an array
            //int[] intArray = new int[7];

            //for (int i = 0; i < 6; i++)
            //{
            //    intArray[i] = i + 1;
            //}

            //intArray[6] = 8;

            // Inserting at the beginning of an array
            //for (int i = 5; i >= 0; i--)
            //{
            //    intArray[i + 1] = intArray[i];
            //}
            //intArray[0] = 10;

            // Inserting anywhere in the array
            //for (int i = 5; i >= 2; i--)
            //{
            //    intArray[i + 1] = intArray[i];
            //}
            //intArray[2] = 90;



            //int[] intArray = new int[9];
            //int length = 0;

            //for (int i = 0; i < 6; i++)
            //{
            //    intArray[length] = i;
            //    length++;
            //}

            // Deleting at the end of an array
            //length--;

            // Deleting at the beginning of an array            
            //for (int i = 1; i < length; i++)
            //{
            //    intArray[i - 1] = intArray[i];
            //}
            //length--;

            //Deleting anywhere in an array
            //for (int i = 3; i < length; i++)
            //{
            //    intArray[i] = intArray[i + 1];
            //}
            //length--;

            //for (int i = 0; i < length; i++)
            //{
            //    Console.WriteLine(intArray[i]);
            //}


            //Linear Search Array

            //int[] array = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //Console.WriteLine(LinearSearch(array,8));

            // Binary Search
            //int[] array = new int[10] { -20, 15, 3, 8, 16, 25, 40, 56, 67, 80 };

            //int midIndex = BinarySearch(array, 8);

            //Console.WriteLine(midIndex);

            // Binary Search Tree
            BinarySearchTree.BinarySearchTree binarySearchTree = new BinarySearchTree.BinarySearchTree();
        }

        static bool LinearSearch(int[] array, int key)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == key)
                {
                    return true;
                }
            }
            return false;
        }

        static int BinarySearch(int[] array, int value)
        {
            // The Array/List should be sorted
            // Find out the middle (start + end)/2
            // Compare the value with the middle value
            // If it is greater, search in the upper half
            // If it is lesser, search in the lower half
            // Continue the above steps changing the middle index each time      

            int start = 0;
            int end = array.Length - 1;

            while (start < end)
            {
                //Find out the middle index
                int midpoint = (start + end) / 2;

                //search the middle
                if (array[midpoint] == value)
                {
                    return midpoint;
                }
                else if (array[midpoint] < value)
                {
                    start = midpoint + 1;
                }
                else if (array[midpoint] > value)
                {                    
                    end = midpoint;
                }
            }
            return -1;
        }
    }
}