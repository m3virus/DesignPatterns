namespace MementoSample.Model
{
    internal class History
    {
        private Stack<TextMemento> _state = new();

        public void Push(TextMemento memento) => _state.Push(memento);
        public TextMemento Pop() => _state.Pop();
    }
}
