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

        List<Card> Cards = new List<Card>();
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
        
        public void Shuffle()
        {

        }

        public Card DrawCard()
        {
            var card = Cards.FirstOrDefault();
            Cards.Remove(card); 
            return card;
        }
    }
}
