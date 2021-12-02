using System;
using System.Collections.Generic;
using System.Text;

namespace Classes_Textbox
{
    public class TextBox
    {
        public int Padding { get; set; }
        public ConsoleColor BackColor   {get;set;}
        public ConsoleColor ForeColor   {get;set;}
        public string Text        {get;set;}

        public TextBox()
        {
            Padding = 0;
            BackColor = ConsoleColor.Black;
            ForeColor = ConsoleColor.White;
            Text = string.Empty;
        }

        public void DisplayText()
        {
            //string pad = "";
            //for (int i = 1  ; i <= Padding; i++)
            //{
            //    pad += " ";
            //}
            Console.ForegroundColor = ForeColor;
            Console.BackgroundColor = BackColor;
            //Console.WriteLine($"{pad}{Text}{pad}");

            Console.WriteLine($"{Text.PadLeft(Text.Length + Padding)}{Text}{Text.PadRight(Text.Length + Padding)}");

        }

    }
}
