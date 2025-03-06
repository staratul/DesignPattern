using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsC_.AdapterPattern
{
    public class ThirdPartyPaymentService
    {
        public void MakePayment(double amount)
        {
            Console.WriteLine($"Processing payment of {amount} using Third-Party Payment Service.");
        }
    }
}
