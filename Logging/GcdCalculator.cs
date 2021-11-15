using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Logging
{
    public class GcdCalculator : IAlgorithm
    {
        public int Calculate(int first, int second)
        {
            int gcdFactor = 1;
            while (first != 0 && second != 0)
            {
                if ((first & 1) == 0 && (second & 1) == 0)
                {
                    first >>= 1;
                    second >>= 1;
                    gcdFactor <<= 1;
                    continue;
                }

                if ((first & 1) == 0)
                {
                    first >>= 1;
                    continue;
                }

                if ((second & 1) == 0)
                {
                    second >>= 1;
                    continue;
                }

                if (first >= second)
                {
                    first -= second;
                }
                else
                {
                    second -= first;
                }
            }

            return second * gcdFactor;
        }       

        public long MeasurePerformance(int first, int second)
        {
            Stopwatch stopwatch = Stopwatch.StartNew();
            Calculate(first, second);
            stopwatch.Stop();
            return stopwatch.ElapsedTicks;
        }
    }
}
