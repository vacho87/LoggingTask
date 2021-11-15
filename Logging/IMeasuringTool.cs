using System;
using System.Collections.Generic;
using System.Text;

namespace Logging
{
    public interface IMeasuringTool
    {
        long MeasurePerformance(int first, int second); 
    }
}
