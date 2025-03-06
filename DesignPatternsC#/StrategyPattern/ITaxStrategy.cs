using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsC_.StrategyPattern
{
    public interface ITaxStrategy
    {
        decimal CalculateTax(decimal amount);
    }
}
