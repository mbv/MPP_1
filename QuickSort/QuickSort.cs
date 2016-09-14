using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSort
{
    public class QuickSort<T> : ISort<T> where T : IComparable<T>
    {
        public void Sort(T[] array, IComparer<T> comparer)
        {
            if (array != null && array.Length > 1 && comparer != null)
                SortArray(array, comparer, 0, array.Length - 1);
        }

        int partition(T[] array, IComparer<T> comparer, int left, int right)
        {
            int i = left;
            for (int j = left; j <= right; j++)
            {
                if (comparer.Compare(array[j], array[right]) <= 0)
                {
                    Swap(array, i, j);
                    i++;
                }
            }
            return i - 1;
        }

        void SortArray(T[] array, IComparer<T> comparer, int left, int right)
        {
            if (left >= right) return;
            int c = partition(array, comparer, left, right);
            SortArray(array, comparer, left, c - 1);
            SortArray(array, comparer, c + 1, right);
        }

        private static void Swap<T>(T[] array, int left, int right)
        {
            var temp = array[right];
            array[right] = array[left];
            array[left] = temp;
        }
    }
}