using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StrategyPattern.Model;

namespace StrategyPattern.DifferentStrategy
{
    internal class CardPayment:IPaymentStrategy
    {
        public void Pay(decimal amount)
        {
            Console.WriteLine($"card : {amount}");

        }
    }
}
