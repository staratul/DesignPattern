using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsC_.StrategyPattern
{
    public class TaxCalculator
    {
        private readonly ITaxStrategy _taxStrategy;

        public TaxCalculator(ITaxStrategy taxStrategy)
        {
            this._taxStrategy = taxStrategy;
        }

        public decimal Calculate(decimal amount)
        {
            return _taxStrategy.CalculateTax(amount);
        }
    }
}
