using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplatePattern.Model
{
    internal class Tea:CoffeinBeverage
    {
        public override void AddCondiments()
        {
            Console.WriteLine("Adding Lemon");
        }

        public override void Brew()
        {
            Console.WriteLine("Tea ready");
        }
    }
}
