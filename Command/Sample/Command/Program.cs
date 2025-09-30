using Command.Models;

var Editor = new TextEditor();

var manager = new CommandManager();

manager.ExecuteCommand(new AddTextCommand(Editor,"hello"));
manager.ExecuteCommand(new AddTextCommand(Editor," How Are You?"));

Console.WriteLine(Editor.Text);

manager.Undo();

Console.WriteLine(Editor.Text);