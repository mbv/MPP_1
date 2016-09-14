using System;
using System.Collections.Generic;
using BenchmarkDotNet.Attributes;
using QuickSort;

namespace QuickSort_UnitTests
{
    public class QuickSortBenchmark
    {
        [Benchmark(Description = "DefaultQuickSort")]
        public void DefaultQuickSort()
        {
            ISort<int> sort = new QuickSort<int>();
            sort.Sort(RandomArray(), Comparer<int>.Default);
        }

        [Benchmark(Description = "OptimizedQuickSort")]
        public void OptimizedQuickSort()
        {
            ISort<int> sort = new QuickSortOptimized<int>();
            sort.Sort(RandomArray(), Comparer<int>.Default);
        }

        private int[] RandomArray()
        {
            return new RandomArrayGenerator().Generate(10000);
        }
    }
}