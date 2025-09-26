namespace FacadeSample.Model
{
    public class HomeTheater
    {
        private Projector _projector = new();
        private Lights _lights = new();
        private SoundSystem _soundSystem = new();
        public void On()
        {
            _lights.On();
            _soundSystem.On();
            _projector.On();
        }

        public void Off()
        {
            _lights.Off();
            _soundSystem.Off();
            _projector.Off();
        }
    }
}
