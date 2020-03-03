using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace durak_final
{
    public class Card
    {
        enum rank
        {
            Ace,
            Two,
            Three,
            Four,
            Five,
            Six,
            Seven,
            Eight,
            Nine,
            Ten,
            Jack,
            Queen,
            King,
        }
        enum suit
        {
            Diamonds,
            Hearts,
            Clubs,
            Spades
        }
        //private int suit;
        private int isTrump;

        public void ToString()
        {

            throw new System.NotImplementedException();
        }

        public void Clone()
        {
            throw new System.NotImplementedException();
        }

        public void CardRank()
        {
            throw new System.NotImplementedException();
        }

        public void CardSuit()
        {
            throw new System.NotImplementedException();
        }
    }
}