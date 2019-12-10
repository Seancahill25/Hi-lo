using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hi_lo
{
    class Program
    {
        static void Main(string[] args)
        {
            int score = 1;
            Deck deck = new Deck();
           
            deck.Shuffle();
           
            var card1 = deck.DrawCard();
            Console.WriteLine("{0} of {1}", card1.Value, card1.Suit);

            while(score > 0)
            {
                Console.WriteLine("Is the next card Higher or Lower");
                string guess = Console.ReadLine();
                Console.WriteLine();

                var card2 = deck.DrawCard();
                Console.WriteLine("{0} of {1}", card2.Value, card2.Suit);

                while (GameLogic.CheckMatch(card1, card2) == true)
                {
                    card1 = card2;
                    card2 = deck.DrawCard();
                }

                if (guess == "hi")
                {
                    if (GameLogic.CheckHi(card1, card2) == true)
                    {
                        score++;
                        Console.WriteLine("Good guess");
                        Console.WriteLine((score - 1) + " Points");
                        Console.WriteLine();
                    }


                    else
                    {
                        Console.WriteLine("Final Score is " + (score - 1));
                        score = 0;
                        Console.WriteLine("you lose");
                    }
                        
                }
                if (guess == "low")
                {
                    if (GameLogic.CheckLow(card1, card2) == true)
                    {
                        score++;
                        Console.WriteLine("Good guess");
                        Console.WriteLine((score - 1) + " Points");
                        Console.WriteLine();
                    }
                    else
                    {
                        Console.WriteLine("Final Score is " + (score - 1));
                        score = 0;
                        Console.WriteLine("you lose");
                    }
                }
                card1 = card2;
            }
           
        }
    }
}
