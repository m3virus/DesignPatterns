using MementoSample.Model;

var editor = new TextEditor();
var history = new History();

editor.content = "Hello";
history.Push(editor.Save());

editor.content = "Hello World";
history.Push(editor.Save());

editor.content = "Hello World!!!";

Console.WriteLine(editor.content); // Hello World!!!

editor.Restore(history.Pop());
Console.WriteLine(editor.content); // Hello World

editor.Restore(history.Pop());
Console.WriteLine(editor.content); // Hello