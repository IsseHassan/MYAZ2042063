using System.Collections.Generic;

namespace SortingAlgorithm
{
    public class InsertionSort
    {
        public enum SortDirection
        {
            Ascending,
            Descending
        }

        public static T[] Sort<T>(T[] array,
            SortDirection sortDirection = SortDirection.Ascending)
            where T : IComparable
        {
            var comparer = new CustomComparer<T>(sortDirection, Comparer<T>.Default);
            for (int i = 0; i < array.Length -1; i++)
            {
                for (int j = i+1; j < array.Length; j++)
                {
                    if (comparer.Compare(array[i], array[j - 1]) < 0)
                    {
                        Sorting.Swap<T>(array, j - 1, j);
                    }
                    else
                    {
                        break;
                    }
                }
            }
            return array;
        }
    }
}
