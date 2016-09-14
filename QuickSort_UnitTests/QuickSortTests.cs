using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QuickSort;
using BenchmarkDotNet.Running;

namespace QuickSort_UnitTests
{
    [TestClass]
    public class QuickSortTests
    {
        [TestMethod]
        public void WhenArrayIsSorted()
        {
            int[] inputArray = {0, 1, 2, 3, 4};
            int[] resultArray = {0, 1, 2, 3, 4};
            PerformEqualityTest(inputArray, resultArray);
        }

        [TestMethod]
        public void WhenArrayIsEmpty()
        {
            int[] inputArray = {};
            int[] resultArray = {};
            PerformEqualityTest(inputArray, resultArray);
        }

        [TestMethod]
        public void WhenArrayContainsNullValue()
        {
            string[] inputArray = {"abc", "xcd", null, "asd"};
            string[] resultArray = {null, "abc", "asd", "xcd"};
            PerformEqualityTest(inputArray, resultArray);
        }

        [TestMethod]
        public void WhenArrayIsNullValue()
        {
            string[] inputArray = null;
            string[] resultArray = null;
            PerformEqualityTest(inputArray, resultArray);
        }

        [TestMethod]
        public void WhenArrayIsReversedSorted()
        {
            int[] inputArray = {4, 3, 2, 1, 0};
            int[] resultArray = {0, 1, 2, 3, 4};
            PerformEqualityTest(inputArray, resultArray);
        }

        [TestMethod]
        public void WhenArrayContainsOnlyEqualsValues()
        {
            int[] inputArray = {1, 1, 1, 1, 1};
            int[] resultArray = {1, 1, 1, 1, 1};
            PerformEqualityTest(inputArray, resultArray);
        }

        [TestMethod]
        public void WhenArrayContainsOneElement()
        {
            int[] inputArray = {42};
            int[] resultArray = {42};
            PerformEqualityTest(inputArray, resultArray);
        }

        [TestMethod]
        public void DefaultArray()
        {
            int[] inputArray = {77, 55, 32, 1, 100, 99, 443};
            int[] resultArray = {1, 32, 55, 77, 99, 100, 443};
            PerformEqualityTest(inputArray, resultArray);
        }


        [TestMethod]
        public void DefaultArrayReversedSort()
        {
            int[] inputArray = {77, 55, 32, 1, 100, 99, 443};
            int[] resultArray = {443, 100, 99, 77, 55, 32, 1};
            PerformEqualityTest(inputArray, resultArray, ReverseComparer<int>.Default);
        }

        private static void PerformEqualityTest<T>(T[] inputArray, T[] resultArray, IComparer<T> comparer = null)
            where T : IComparable<T>
        {
            ISort<T> sort = new QuickSort<T>();
            if (comparer == null)
            {
                comparer = Comparer<T>.Default;
            }
            sort.Sort(inputArray, comparer);

            CollectionAssert.AreEqual(inputArray, resultArray);
        }

        [TestMethod]
        public void BenchMark()
        {
            BenchmarkRunner.Run<QuickSortBenchmark>();
        }
    }
}