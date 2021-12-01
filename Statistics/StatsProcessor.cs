using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Statistics
{
    internal class StatsProcessor
    {
       
        internal int[] Numbers { private get; set; }
        
        
        internal decimal Mean()
        {
            int sum = 0;
            decimal mean = 0;
            {
                foreach (int test in Numbers)
                {
                    sum = sum + test;
                }
                mean =(decimal) sum / Numbers.Length;
                return mean;
            }
        }

        internal int Median()
        {
            int x = (Numbers.Length) / 2;
            int y = Numbers[x];
            return y;
        }

        internal int Mode()
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
