using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace durak_final
{
    public class Deck : Card
    {
        
        private int cards;
        private int trumpCard;
        
        // for later use in case of wanting various deck sizes, possibly an array of 36 and 52. 
        public int deckSize = 52;

        public const int HAND_SIZE = 5;
        
        

        // layout for the intial deck setup, need to inquire about syntax
        public void deck()
        {
            playingDeck = new List<Card>;

            for (int suitValue = 0, SuitValue < 4, suitValue++)
            {
                for (int rankValue = 0, rankValue < 13, rankValue++ )
                {
                    playingDeck.add(new Card(rank = rankValue, suit = suit(suitValue)));
                }
            }
        }

        public void getCard()
        {
            // draw the first card on the deck
            playingDeck card = DrawCard[0];
            Card.remove(card);
            //playingDeck.length - 1;

            return card;
        }

        public void Shuffle()
        {
            // shuffle the list of cards randomly for the deck

            //random number variable for later
            Random randomNumber = new Random();
            throw new System.NotImplementedException();
        }

        public void Clone()
        {
            throw new System.NotImplementedException();
        }

        public void getTrump()
        {
            //draw the card and than move it to the last spot in the deck index, keep it on display for user
            //a
            throw new System.NotImplementedException();
        }

        public void DealCard()
        {
            
            //draw 5 cards for each player from the top of the deck or use a "handSize" variable in case of later revisions
            throw new System.NotImplementedException();
        }
    }
}