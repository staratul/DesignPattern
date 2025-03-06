using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsC_.StrategyPatternEX2
{
    public class DatabaseLogStrategy : ILogStrategy
    {
        public void Log(string message)
        {
            Console.WriteLine($"Database Log: {message} (Saved to database)");
        }
    }
}
