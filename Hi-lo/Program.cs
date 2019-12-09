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
            Deck deck = new Deck();
           
            foreach(var i in deck.MakeDeck())
            {
                Console.WriteLine("{0} {1}", i.Suit, i.Value);
            }

            Console.WriteLine();

            var card = deck.DrawCard();
            var card2 = deck.DrawCard();
            Console.WriteLine("{0} {1}", card.Suit, card.Value);
            Console.WriteLine("{0} {1}", card2.Suit, card2.Value);


        }
    }
}
