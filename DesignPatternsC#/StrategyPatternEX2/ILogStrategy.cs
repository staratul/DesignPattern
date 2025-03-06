using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsC_.StrategyPatternEX2
{
    public interface ILogStrategy
    {
        void Log(string message);
    }
}
