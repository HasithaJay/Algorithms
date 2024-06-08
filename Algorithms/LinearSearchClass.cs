namespace Algorithms
{
    internal class LinearSearchClass
    {
        static int LinearSearch(int[] integerArr, int target)
        {
            for (int i = 0; i < integerArr.Length; i++)
            {
                if (integerArr[i] == target) return i;
            }
            return -1; 
        }
    }
}
