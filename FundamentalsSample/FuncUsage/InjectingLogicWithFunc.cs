using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentalsSample.FuncUsage.InjectingLogicWithFunc
{
    internal class PaymentProcessor
    {
        private readonly Func<decimal, bool> _validate;

        public PaymentProcessor(Func<decimal, bool> validateStrategy)
        {
            _validate = validateStrategy;
        }

        public void Pay(decimal amount)
        {
            if (_validate(amount))
                Console.WriteLine("Payment accepted.");
            else
                Console.WriteLine("Payment rejected");
        }
    }
}
