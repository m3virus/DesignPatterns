using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StrategyPattern.Model;

namespace StrategyPattern.DifferentStrategy
{
    internal class PaypalPayment:IPaymentStrategy
    {
        public void Pay(decimal amount)
        {
            Console.WriteLine($"Paypal : {amount}");

        }
    }
}
