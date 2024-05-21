using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardPlayer
{
    class Joker : Card
    {
        public Joker()
        {
            Value = 0;
        }

        public override void Display(int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Joker ");
            Console.SetCursorPosition(x, y + 1);
            Console.WriteLine(" O  O ");
            Console.SetCursorPosition(x, y + 2);
            Console.WriteLine("      ");
            Console.SetCursorPosition(x, y + 3);
            Console.WriteLine(@" \--/ ");
            Console.SetCursorPosition(x, y + 4);
            Console.WriteLine(" Joker");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
