using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorPattern.Model
{
    internal class Book:IItemElement
    {
        public string Title { get; }
        public int Price { get; }

        public Book(string title, int price)
        {
            Title = title;
            Price = price;
        }

        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
