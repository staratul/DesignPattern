using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsC_.StrategyPattern
{
    public class USATaxStrategy : ITaxStrategy
    {
        public decimal CalculateTax(decimal amount)
        {
            return amount * 0.10m;
        }
    }
}
