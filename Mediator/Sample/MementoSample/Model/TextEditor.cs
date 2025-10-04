namespace MementoSample.Model
{
    internal class TextEditor
    {
        public string content { get; set; } = "";

        public TextMemento Save()
        {
            return new TextMemento(content);
        }

        public void Restore(TextMemento memento)
        {
            content = memento.content;
        }
    }
}
