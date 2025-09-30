namespace Command.Models
{
    internal class AddTextCommand:ICommand
    {
        private TextEditor editor;
        private string textToAdd;

        public AddTextCommand(TextEditor editor, string text)
        {
            this.editor = editor;
            this.textToAdd = text;
        }

        public void Execute()
        {
            editor.Text += textToAdd;
        }

        public void Undo()
        {
            editor.Text = editor.Text.Replace(textToAdd, "");
        }
    }
}
