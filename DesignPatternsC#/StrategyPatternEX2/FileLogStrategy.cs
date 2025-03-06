using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsC_.StrategyPatternEX2
{
    public class FileLogStrategy : ILogStrategy
    {
        public void Log(string message)
        {
            Console.WriteLine($"File Log {message}");
        }
    }
}
