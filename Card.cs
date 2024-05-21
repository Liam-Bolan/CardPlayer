using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardPlayer
{
    class Card
    {
        public enum suit
        {
            hearts,
            diamonds,
            clubs,
            spades
        }

        private suit _Suit;
        protected int _Value;

        public int Value
        {
            get { return _Value; }
            set { _Value = value; }
        }
        private ConsoleColor _Colour;
        public char _SuitSymbol { get { return (char)((int)_Suit + 3); } }
        public string StrCard { get { return "A23456789TJQK"[_Value - 1].ToString() + _SuitSymbol.ToString(); } }

        public Card()
        {
        }

        public Card(suit s, int V)
        {
            _Suit = s;
            _Value = V;
            _Colour = (_Suit == suit.hearts || _Suit == suit.diamonds) ? ConsoleColor.Red : ConsoleColor.Black;
        }

        public virtual void Display(int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = _Colour;
            Console.WriteLine(StrCard + "    ");
            Console.SetCursorPosition(x, y + 1);
            Console.WriteLine("      ");
            Console.SetCursorPosition(x, y + 2);
            Console.WriteLine("      ");
            Console.SetCursorPosition(x, y + 3);
            Console.WriteLine("      ");
            Console.SetCursorPosition(x, y + 4);
            Console.WriteLine("    " + StrCard);
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
