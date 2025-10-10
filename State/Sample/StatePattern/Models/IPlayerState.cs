namespace StatePattern.Models
{
    internal interface IPlayerState
    {
        void HandleState(Player player);
        void Update(Player player);
    }
}
