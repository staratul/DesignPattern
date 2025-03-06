using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsC_.StrategyPatternEX2
{
    public class Logger
    {
        private readonly ILogStrategy _logger;

        public Logger(ILogStrategy logger)
        {
            _logger = logger;
        }

        public void Log(string message)
        {
            _logger.Log(message);
        }
    }
}
