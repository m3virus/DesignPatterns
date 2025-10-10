using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StatePattern.Models;

namespace StatePattern.States
{
    internal class Standing:IPlayerState
    {
        public void HandleState(Player player)
        {
            Console.WriteLine("Start walking");
            player.SetState(new Walking());
        }

        public void Update(Player player)
        {
            Console.WriteLine("standing");
        }
    }
}
