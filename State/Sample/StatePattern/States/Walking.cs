using StatePattern.Models;

namespace StatePattern.States
{
    internal class Walking:IPlayerState
    {
        public void HandleState(Player player)
        {
            Console.WriteLine("Start Running");
            player.SetState(new Running());
        }

        public void Update(Player player)
        {
            Console.WriteLine("walking");
        }
    }
}
