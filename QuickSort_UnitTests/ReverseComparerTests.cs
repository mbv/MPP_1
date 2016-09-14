using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QuickSort;

namespace QuickSort_UnitTests
{
    [TestClass]
    public class ReverseComparerTests
    {
        [TestMethod]
        public void TestGreater()
        {
            IComparer<int> comparer = ReverseComparer<int>.Default;
            Assert.IsTrue(comparer.Compare(2, 1) < 0);
        }

        [TestMethod]
        public void TestLower()
        {
            IComparer<int> comparer = ReverseComparer<int>.Default;
            Assert.IsTrue(comparer.Compare(1, 2) > 0);
        }

        [TestMethod]
        public void TestEquals()
        {
            IComparer<int> comparer = ReverseComparer<int>.Default;
            Assert.IsTrue(comparer.Compare(1, 1) == 0);
        }
    }
}