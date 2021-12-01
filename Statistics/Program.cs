// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Statistics
{
    internal class Program
    {
        static int[] data = { 40, 38, 37, 36, 34, 33, 32, 31, 30, 30, 30, 29, 26, 26, 19 };

        static void Main(String[] args)
        {
            var m1 = new StatsProcessor();
            m1.Numbers = data;
            var mn = m1.Mean();
            Console.WriteLine($"Mean: {mn}");
            var md = m1.Median();
            Console.WriteLine($"Median: {md}");
            var mo = m1.Mode();
            Console.WriteLine($"Mode: {mo}");
            Console.ReadLine();
        }
    }
}