using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hi_lo
{
    class GameLogic
    {  
        public static bool CheckHi(Card card1, Card card2)
        {
            if (card1.Value < card2.Value)
                return true;
                    
            return false;
        }

        public static bool CheckLow(Card card1, Card card2)
        {
            if (card1.Value > card2.Value)
                return true;
            
            return false;
        }

        public static bool CheckMatch(Card card1, Card card2)
        {
            if (card1.Value == card2.Value)
                return true;

            return false;
        }
    }
}
