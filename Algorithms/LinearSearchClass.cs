namespace Algorithms
{
    internal class LinearSearchClass
    {
        internal static int LinearSearch(int[] integerArr, int target)
        {
            for (int i = 0; i < integerArr.Length; i++)
            {
                if (integerArr[i] == target) return i;
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
