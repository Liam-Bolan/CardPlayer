using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardPlayer
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck d = new Deck(true);
            int Choice = 0;

            while (Choice!=6)
            {
                Console.Clear();
                Choice=Menu();
                switch (Choice)
                {
                    case 1:
                        Console.Clear();
                        d.DisplayBackOfDeck(0, 0, ConsoleColor.DarkRed);
                        d.DisplayAllCards(7, 0);                      
                        break;
                    case 2:
                        ShufflePack(d);
                        break;
                    case 3:
                        DrawACard(d,0,10);
                        break;
                    case 4:
                        Console.WriteLine();
                        Console.Write("Enter Number of cards to draw >");
                        int noc=int.Parse(Console.ReadLine());
                        for (int i = 0; i < noc; i++)
			                    {
			                    DrawACard(d, i,13);
			                    }
                        break;
                    case 5:
                        HigherLower(d,0,10);
                        break;
                    case 6:
                        Console.WriteLine("Goodbye! ");
                        break;
                    default: 
                        Console.WriteLine("Not recognised ");

                        break;
                }
                Console.WriteLine(" Press Return");
                Console.ReadLine();
                
            }
            
        }

        static int Menu()
        {
            Console.WriteLine("MENU");
            Console.WriteLine("----");
            Console.WriteLine("1. View Pack");
            Console.WriteLine("2. Shufflepack");
            Console.WriteLine("3. Draw Card");
            Console.WriteLine("4. Draw Several Cards");
            Console.WriteLine("5. Play Higher or Lower");
            Console.WriteLine("6. Quit");
            Console.Write("Choice >");
            int c = int.Parse(Console.ReadLine());
            return c;
        }

        static void ShufflePack(Deck D)
        {
            D.Shuffle(); 

        }

        static void DrawACard(Deck D, int xpos, int ypos)
        {
            D.DisplayBackOfDeck(xpos, ypos, ConsoleColor.DarkRed);
           Card c = D.DrawCard();
            c.Display(xpos, ypos);
        }

        static void HigherLower(Deck D, int xpos, int ypos)
        {
            D.DisplayBackOfDeck(xpos, ypos, ConsoleColor.DarkRed);
            Card c = D.DrawCard();
            c.Display(xpos, ypos);
            Card c2 = D.DrawCard();
            c2.Display(xpos + 10, ypos);
            
            Console.Write("\nHigher or lower? ");
            string response = Console.ReadLine();
            response = response.ToUpper();
            if (c.Value > c2.Value && response == "HIGHER")
            {
                Console.WriteLine("Correct!");
                return;
            }
            if(c.Value < c2.Value && response == "LOWER")
            {
                Console.WriteLine("Correct!");
                return;
            }
            else
            {
                Console.WriteLine("Incorrect!");
                return;
            }


        }
    }


   
    
       
}
