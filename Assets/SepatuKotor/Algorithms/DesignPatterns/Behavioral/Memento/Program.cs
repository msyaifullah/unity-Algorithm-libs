using System;
using DesignPatterns.Memento;

namespace DesignPatterns
{
    public partial class Program
    {
        public static void Memento()
        {
            var textBox = new TextBox();
            var caretaker = new Caretaker(textBox);
           DPDebug.Log("························ Initialize");
            textBox.Text = "Hello world!";
           DPDebug.Log("························ Selection 3 -> 3");
            textBox.Select(new Selection(3, 3));
            textBox.MoveCaretBy(2);
           DPDebug.Log(textBox);
            caretaker.Snapshot();
           DPDebug.Log("························ Snapshot");

           DPDebug.Log("························ Edit");
            textBox.Text = "Good bye world!";
           DPDebug.Log("························ Selection 4 -> 4");
            textBox.Select(new Selection(4, 5));
            textBox.MoveCaretBy(8);
           DPDebug.Log(textBox);
            caretaker.Snapshot();
           DPDebug.Log("························ Snapshot");

           DPDebug.Log("························ Edit");
            textBox.Text = "Foo";
           DPDebug.Log(textBox);
            caretaker.Undo();
           DPDebug.Log("························ Undo");
           DPDebug.Log(textBox);
            caretaker.Undo();
           DPDebug.Log("························ Undo");
           DPDebug.Log(textBox);
        }
    }
}