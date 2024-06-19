namespace Algorithms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Basic Search Algorithms
            //int[] integerArr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //LinearSearchClass.Verify(LinearSearchClass.LinearSearch(integerArr, 11));

            //BinarySearchClass.Verify(BinarySearchClass.BinarySearch(integerArr, 1));

            //RecursiveBinarySearchClass.Verify(BinarySearchClass.BinarySearch(integerArr, 10));
            #endregion

            #region Merge Sort
            List<int> list = new List<int>{5, 4, 43, 21, 46, 75, 50, 100, 101};
            var result = MergeSortClass.MergeSort(list);

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
            #endregion
        }
    }
}
