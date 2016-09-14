using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSort
{
    class Program
    {
        static void WriteToConsoleArray(int[] values, string extraInformation)
        {
            StringBuilder message = new StringBuilder($"{extraInformation}\n");
            foreach (var value in values)
                message.Append($"{value} ");
            Console.WriteLine(message);
        }

        static int[] GenerateValues(int count)
        {
            int[] generatedValues = new RandomArrayGenerator().Generate(count);
            WriteToConsoleArray(generatedValues, "Generate values:");
            return generatedValues;
        }

        static void WorkSortTesting(int count)
        {
            ISort<int> sort = new QuickSort<int>();
            int[] generatedValues = GenerateValues(count);
            sort.Sort(generatedValues, Comparer<int>.Default);
            WriteToConsoleArray(generatedValues, "Sorted Values:");
        }

        static void Main(string[] args)
        {
            ArgumentsCheckResult argumentsCheckResult = CheckArguments(args);
            if (argumentsCheckResult.isCorrect)
            {
                WorkSortTesting(argumentsCheckResult.value);
            }
            else
            {
                Console.WriteLine("Uncorrect argument");
            }
        }

        private static ArgumentsCheckResult CheckArguments(string[] args)
        {
            ArgumentsCheckResult result = new ArgumentsCheckResult {isCorrect = false};
            if (args.Length > 0)
            {
                result.isCorrect = isCorrectValue(args[0], out result.value);
            }

            return result;
        }

        private static bool isCorrectValue(string checkingValue, out int value)
        {
            return (int.TryParse(checkingValue, out value) && value > 0);
        }

        private struct ArgumentsCheckResult
        {
            public int value;
            public bool isCorrect;
        }
    }
}