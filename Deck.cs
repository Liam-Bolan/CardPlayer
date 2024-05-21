using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardPlayer
{
    class Deck
    {
        protected Card[] _cards = new Card[54];

        private int _PositionInPack;
        private int _DeckSize;

        public Card[] Cards
        {
            get { return _cards; }
            set { _cards = value; }
        }

        static Random r = new Random();



        public Deck(bool IncludeJokers)
        {
            // loads deck with cards ordered.
            _PositionInPack = 0;
            foreach (Card.suit s in Enum.GetValues(typeof(Card.suit)))
            {
                for (int i = 1; i <= 13; i++)
                {
                    Card C = new Card(s, i);
                    _cards[_PositionInPack] = C;
                    _PositionInPack++;
                }
            }
            // ADD jOKERS if required
            if (IncludeJokers)
            {
                Joker J1 = new Joker();
                Joker J2 = new Joker();
                Cards[52] = J1;
                Cards[53] = J2;
                _DeckSize = 54;
            }
            else
            {
                _DeckSize = 52;
            }

            _PositionInPack = 0; //return to first card position
        }



        public void Shuffle()
        {
            // shuffles deck
            for (int n = _DeckSize - 1; n > 0; n--)
            {
                int k = r.Next(n + 1);
                Card temp = _cards[n];
                _cards[n] = _cards[k];
                _cards[k] = temp;
            }
        }



        public void DisplayBackOfDeck(int x, int y, ConsoleColor PackColour)
        {
            // displays reverse of cards
            Console.SetCursorPosition(x, y);
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = PackColour;
            Console.WriteLine("|XXXX|");
            Console.SetCursorPosition(x, y + 1);
            Console.WriteLine("|XXXX|");
            Console.SetCursorPosition(x, y + 2);
            Console.WriteLine("|XXXX|");
            Console.SetCursorPosition(x, y + 3);
            Console.WriteLine("|XXXX|");
            Console.SetCursorPosition(x, y + 4);
            Console.WriteLine("|XXXX|");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
        }



        public void DisplayAllCards(int xpos, int ypos)
        {

            for (int i = 0; i < _DeckSize; i++)
            {

                if (i % 15 == 0 && i > 12)
                {
                    ypos = ypos + 6;
                }
                Cards[i].Display((i % 15) * 2 + xpos, ypos);
                System.Threading.Thread.Sleep(100);
            }
        }

        public Card DrawCard()
        {

                _PositionInPack++;
                return Cards[_PositionInPack-1];
        }
        
            
        }

    }


