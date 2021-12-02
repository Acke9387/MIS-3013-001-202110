using System;

namespace Classes_Textbox
{
    class Program
    {
        static void Main(string[] args)
        {
            TextBox tb = new TextBox()
            {
                BackColor = ConsoleColor.Green,
                ForeColor = ConsoleColor.Cyan,
                Padding = 5,
                Text = "Happy Holidays!"
            };

            TextBox tb1 = new TextBox()
            {
                BackColor = ConsoleColor.Red,
                ForeColor = ConsoleColor.Green,
                Padding = 15,
                Text = "Good luck on Finals"
            };

            tb.DisplayText();
            tb1.DisplayText();
        }
    }
}
