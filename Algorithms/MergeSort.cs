using System.Collections;

namespace Algorithms
{
    public static class MergeSortClass
    {
        //1.Devide
        //2.Conquer
        //3.Merge

        public static List<int> MergeSort(List<int> theList)
        {
            //need to have a base case since we are dealing this recursively
            if (theList.Count <= 1)
            {
                return theList;
            }

            int midPoint = theList.Count / 2;

            List<int> left = new List<int>(theList[..midPoint]);
            List<int> right = new List<int>(theList[(midPoint)..]);

            List<int> sortedLeft = MergeSort(left);
            List<int> sortedRight = MergeSort(right);

            return Merge(sortedLeft, sortedRight);
        }

        private static List<int> Merge(List<int> left, List<int> right)
        {
            List<int> sortedList = new List<int>();
            int i = 0, j = 0;

            while (i < left.Count && j < right.Count)
            {
                if (left[i] < right[j])
                {
                    sortedList.Add(left[i]);
                    i++;
                }
                else
                {
                    sortedList.Add(right[j]);
                    j++;
                }
            }

            while (i < left.Count)
            {
                sortedList.Add(left[i]);
                i++;
            }

            while (j < right.Count)
            {
                sortedList.Add(right[j]);
                j++;
            }

            return sortedList;
        }
    }
}
