namespace Command.Models
{
    internal interface ICommand
    {
        void Execute();
        void Undo();
    }
}
