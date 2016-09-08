using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSort
{
    public interface ISort<T>
    {
        void Sort(T[] array, IComparer<T> comparer);

    }
}
