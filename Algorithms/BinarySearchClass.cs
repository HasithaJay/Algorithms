namespace Algorithms
{
    internal class BinarySearchClass
    {
        internal static int BinarySearch(int[] integerArr, int target)
        {
            int rangeStartingPoint = 0;
            int rangeEndingPoint = integerArr.Length - 1;
            

            while(rangeStartingPoint <= rangeEndingPoint)
            {
                int midpoint = (rangeStartingPoint + rangeEndingPoint) / 2;

                if (integerArr[midpoint] == target)
                {
                    return midpoint;
                }
                else if (integerArr[midpoint] > target)
                {
                    rangeEndingPoint = midpoint - 1;
                }
                else if (integerArr[midpoint] < target)
                {
                    rangeStartingPoint = midpoint + 1;
                }
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
