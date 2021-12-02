// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewResult
{
    internal class Program
    {
        static int[] data = { 40, 38, 37, 36, 34, 33, 32, 31, 30, 30, 30, 29, 26, 26, 19, 42 };

        static void Main(string[] args)
        {
            var spObject = new StatsProcessor();


            spObject.Numbers = data;

            var result = spObject.GetStatsProcessorResult();


            Console.WriteLine($"Average: {result.Mean}");
            Console.WriteLine($"Median: {result.Median}");
            Console.WriteLine($"Mode: {result.Mode}");
        }
    }
}
