using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplatePattern.Model
{
    internal class Coffee:CoffeinBeverage
    {
        public override void AddCondiments()
        {
            Console.WriteLine("Milk and sugar added");
        }

        public override void Brew()
        {
            Console.WriteLine("Coffe ready");
        }
    }
}
