using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QuickSort;

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
            int[] inputArray = { 4, 3, 2, 1, 0 };
            int[] resultArray = { 0, 1, 2, 3, 4 };
            PerformEqualityTest(inputArray, resultArray);
        }

        [TestMethod]
        public void WhenArrayContainsOnlyEqualsValues()
        {
            int[] inputArray = { 1, 1, 1, 1, 1 };
            int[] resultArray = { 1, 1, 1, 1, 1 };
            PerformEqualityTest(inputArray, resultArray);
        }

        [TestMethod]
        public void WhenArrayContainsOneElement()
        {
            int[] inputArray = { 42 };
            int[] resultArray = { 42 };
            PerformEqualityTest(inputArray, resultArray);
        }

        private static void PerformEqualityTest<T>(T[] inputArray, T[] resultArray)
        {
            ISort<T> sort = new QuickSort.QuickSort<T>();
            IComparer<T> comparer = Comparer<T>.Default;
            sort.Sort(inputArray, comparer);
            CollectionAssert.AreEqual(inputArray, resultArray);
        }
    }
}