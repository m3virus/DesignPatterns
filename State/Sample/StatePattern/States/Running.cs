using StatePattern.Models;

namespace StatePattern.States
{
    internal class Running:IPlayerState
    {
        public void HandleState(Player player)
        {
            Console.WriteLine("Stoped running");
            player.SetState(new Standing());
        }

        public void Update(Player player)
        {
            Console.WriteLine("Running");
        }
    }
}
