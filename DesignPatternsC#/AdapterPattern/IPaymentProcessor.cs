using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsC_.AdapterPattern
{
    public interface IPaymentProcessor
    {
        void ProcessPayment(decimal amount);
    }
}
