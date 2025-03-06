using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsC_.AdapterPattern
{
    public class PaymentAdapter : IPaymentProcessor
    {
        private readonly ThirdPartyPaymentService _thirdPartyService;

        public PaymentAdapter(ThirdPartyPaymentService thirdPartyService)
        {
            _thirdPartyService = thirdPartyService;
        }

        public void ProcessPayment(decimal amount)
        {
            _thirdPartyService.MakePayment((double)amount);
        }
    }
}
