using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewResult
{
    internal class StatsProcessor
    {
        internal int[] Numbers { private get; set; }

        internal StatsResult GetStatsProcessorResult()
        {
            var result = new StatsResult();
            result.Mean = CalculateAverage();
            result.Median = CalculateMedian();
            result.Mode = CalculateMode();
            return result;
        }

        private int CalculateAverage() => Numbers.Sum() / Numbers.Length;

        private int CalculateMedian()
        {
            var sortedData = Numbers.OrderBy(i => i).ToArray();
            var n = sortedData.Length;
            var median = n % 2 == 0
                ? (sortedData[n / 2 - 1] + sortedData[n / 2]) / 2
                : sortedData[n / 2];
            return median;
        }
        private int CalculateMode()
        {
            int maxcount = 0, maxnum = 0;
            for (int i = 0; i < Numbers.Length; i++)
            {
                int count = 0;
                for (int j = 1; j < Numbers.Length - 1; j++)
                {
                    if (Numbers[i] == Numbers[j])
                    {
                        count++;
                    }
                }
                if (count > maxcount)
                {
                    maxcount = count;
                    maxnum = Numbers[i];
                }
            }
            return maxnum;
        }

    }
}
