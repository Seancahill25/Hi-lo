using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hi_lo
{
    class Deck
    {
        public Deck()
        {
            MakeDeck();
        }

        public List<Card> Cards = new List<Card>();
        public List<Card> MakeDeck()
        {
            
            foreach (Suit s in Enum.GetValues(typeof(Suit)))
            {
                foreach (Value c in Enum.GetValues(typeof(Value)))
                {
                    Cards.Add(new Card(s, c));
                }
            }
            return Cards;
        }

        private static Random rng = new Random();
        public void Shuffle()
        {
            int n = Cards.Count;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                Card value = Cards[k];
                Cards[k] = Cards[n];
                Cards[n] = value;
            }
        }

        public Card DrawCard()
        {
            var card = Cards.FirstOrDefault();
            Cards.Remove(card); 
            return card;
        }
    }
}
