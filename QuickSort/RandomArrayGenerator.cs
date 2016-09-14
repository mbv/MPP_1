using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSort
{
    public class RandomArrayGenerator
    {
        public int StartValue { get; set; } = -10000;
        public int EndValue { get; set; } = 10000;

        private void FillArray(int[] values, int count)
        {
            Random random = new Random();
            for (int i = 0; i < count; i++)
                values[i] = random.Next(StartValue, EndValue);
        }

        public int[] Generate(int count)
        {
            var randomArray = new int[count];
            FillArray(randomArray, count);
            return randomArray;
        }
    }
}