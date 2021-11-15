using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.Logging;

namespace Logging
{
    public interface IAlgorithm : IMeasuringTool
    {
        int Calculate(int first, int second);
    }
}
