namespace Algorithms
{
    internal class RecursiveBinarySearchClass
    {
        internal static int BinarySearch(int[] integerArr, int target)
        {
            if (integerArr.Length == 0)
            {
                return -1;
            }

            int start = 0;
            int end = integerArr.Length - 1;
            int mid = start + end / 2;
            if (integerArr[mid] == target)
            {
                return mid;
            }else if (integerArr[mid] > target)
            {
                BinarySearch(integerArr[..(mid-1)], target);
            }
            else if (integerArr[mid] < target)
            {
                BinarySearch(integerArr[(mid + 1)..], target);
            }

            return -1;
        }

        internal static void Verify(int index)
        {
            if (index == -1)
            {
                Console.WriteLine("Item not found in the array!");
            }
            else
            {
                Console.WriteLine("Item found at index:" + index);
            }
        }
    }
}
