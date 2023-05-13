using System.Collections;
using System.Collections.Generic;

namespace SortingAlgorithm
{
    public class InsertionSort
    {
        public static T[] Sort<T>(T[] array)
            where T : IComparable<T>
        {
            for (int i = 0; i < array.Length; i++)
            {

                for (int j = 0; j > 0; j--)
                {
                    if (comparer.Compare(array[j], array[j - 1]) < 0)
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
