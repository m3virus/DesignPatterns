using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorPattern.Model
{
    internal class Fruit:IItemElement
    {
        public string Name { get; }
        public int PricePerKg { get; }
        public int Weight { get; }

        public Fruit(string name, int pricePerKg, int weight)
        {
            Name = name;
            PricePerKg = pricePerKg;
            Weight = weight;
        }

        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
