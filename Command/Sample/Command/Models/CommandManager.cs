namespace Command.Models
{
    internal class CommandManager
    {
        private Stack<ICommand> _commands = new Stack<ICommand>();

        public void ExecuteCommand(ICommand command)
        {
            command.Execute();
            _commands.Push(command);
        }

        public void Undo()
        {
            if (_commands.Count > 0)
            {
                _commands.Pop().Undo();
            }
        }
    }
}
