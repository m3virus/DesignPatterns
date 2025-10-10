namespace StatePattern.Models
{
    internal class Player
    {
        private IPlayerState _state;

        public Player(IPlayerState initializer)
        {
            _state = initializer;
        }

        public void SetState(IPlayerState state)
        {
            _state = state;
        }

        public void HandleState()
        {
            _state.HandleState(this);
        }

        public void Update()
        {
            _state.Update(this);
        }
    }
}
