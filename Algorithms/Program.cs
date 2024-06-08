namespace Algorithms
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] integerArr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //LinearSearchClass.Verify(LinearSearchClass.LinearSearch(integerArr, 11));

            BinarySearchClass.Verify(BinarySearchClass.BinarySearch(integerArr, 1));
        }
    }
}
