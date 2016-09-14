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
            throw new NotImplementedException();
        }
    }
}
