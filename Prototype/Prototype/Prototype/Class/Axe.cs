using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype.Class
{
    internal class Axe:Entity
    {
        public string Ulti { get; set; }
        public override Entity ClonEntity()
        {
            //return (Entity)this.MemberwiseClone();
            return new Axe
            {
                Name = this.Name,
                Power = this.Power,
                Ulti = this.Ulti
            };

        }

        public override string ToString()
        {
            return $"{Ulti},, {Name} ,, {Power}";
        }
    }
}
