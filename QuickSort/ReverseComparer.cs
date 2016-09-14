using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSort
{
    public sealed class ReverseComparer<T> : IComparer<T>
    {
        public static readonly ReverseComparer<T> Default = new ReverseComparer<T>(Comparer<T>.Default);

        public static ReverseComparer<T> Reverse(IComparer<T> comparer)
        {
            return new ReverseComparer<T>(comparer);
        }

        private readonly IComparer<T> comparer = Default;

        private ReverseComparer(IComparer<T> comparer)
        {
            this.comparer = comparer;
        }

        public int Compare(T x, T y)
        {
            return comparer.Compare(y, x);
        }
    }
}
