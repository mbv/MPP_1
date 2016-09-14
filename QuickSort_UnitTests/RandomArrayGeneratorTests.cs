using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QuickSort;

namespace QuickSort_UnitTests
{
    [TestClass]
    public class RandomArrayGeneratorTests
    {
        [TestMethod]
        public void TestCountElementsInArray()
        {
            const int arraySize = 100;
            RandomArrayGenerator randomArrayGenerator = new RandomArrayGenerator();
            int[] resultArray = randomArrayGenerator.Generate(arraySize);
            Assert.AreEqual(resultArray.Length, arraySize);
        }

        [TestMethod]
        public void TestCheckElementsBounds()
        {
            RandomArrayGenerator randomArrayGenerator = new RandomArrayGenerator();
            int[] resultArray = randomArrayGenerator.Generate(100000);
            foreach (var element in resultArray)
            {
                Assert.IsTrue((element >= randomArrayGenerator.StartValue) && (element < randomArrayGenerator.EndValue));
            }
        }

        [TestMethod]
        public void TestUniformDistribution()
        {
            RandomArrayGenerator randomArrayGenerator = new RandomArrayGenerator();
            randomArrayGenerator.StartValue = -100;
            randomArrayGenerator.EndValue = 100;
            int generateCount = randomArrayGenerator.EndValue - randomArrayGenerator.StartValue;
            int[] resultArray = randomArrayGenerator.Generate(generateCount * 100000);

            int[] counts = new int[generateCount];
            foreach (var element in resultArray)
            {
                counts[element - randomArrayGenerator.StartValue]++;
            }

            double averageCount = (double)resultArray.Length / generateCount;
            foreach (var count in counts)
            {
                double despersion = Math.Sqrt(Math.Pow(count - averageCount, 2) / resultArray.Length);
                Assert.IsTrue(despersion < 0.3);
            }
            

        }
    }
}
