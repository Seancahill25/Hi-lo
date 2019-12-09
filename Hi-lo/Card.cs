using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hi_lo
{
    public class Card
    {
        public Suit Suit { get; set; }
        public Value Value { get; set; }
        public Card(Suit suit, Value value) 
        {
            Suit = suit;
            Value = value;
        }
    }
}
