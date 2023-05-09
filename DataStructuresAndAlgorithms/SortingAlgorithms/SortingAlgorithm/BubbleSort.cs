using MathNet.Numerics;

namespace SortingAlgorithm
{
    public class BubbleSort
    {
        public static class Sorting
    {
        public static void Swap<T>(T[] arr, int i, int j)
        {
            T temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }
    }
        public static void Sort<T>(T[] arr)
            where T : IComparable<T>
        {
            int n = arr.Length;
            for (int i = 0; i <n -1; i++)
                for (int j = 0; j < n-1; j++)
                {
                    if (arr[j].CompareTo(arr[j + 1]) >= 1)
                        Sorting.Swap(arr, j, j + 1);
                  
                }
            
        }
        
    }
}