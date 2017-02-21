using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uno1
{
    class Player
    {
        private List<Card> hand;
        public Player()
        {
			hand = new List<Card>();
        }

        /// <summary>
        /// adds card to players hand
        /// </summary>
        /// <param name="card"></param>
        public void AddCardToHand(Card card){
            hand.Add(card);
        }

        /// <summary>
        /// prints out the list of valid cards that you can play,
        /// returns true if a valid card is found to play
        /// </summary>
        /// <param name="TopOfDiscard"></param>
        public bool PrintValidMoves(Card TopOfDiscard)
        {
            bool validCard = false;
            for (int i = 0; i < hand.Count; i++)
            {
                if (TopOfDiscard.GetSuit() == hand[i].GetSuit() || TopOfDiscard.GetValue() == hand[i].GetValue() || hand[i].GetValue() >= 13)
                {
                    Console.WriteLine(hand[i].GetCardName());
                    validCard = true;
                }
            }
            return validCard;
        }

        /// <summary>
        /// removes card from players hand and returns the card,
        /// if card is not found return null
        /// </summary>
        /// <param name="cardName"></param>
        /// <returns></returns>
        public Card GetCardByName(string cardName)
        {
            for (int i = 0; i < hand.Count; i++)
            {
                if (cardName.ToLower() == hand[i].GetCardName().ToLower())
                {
                    Card playCard = hand[i];
                    hand.Remove(playCard);
                    return playCard;
                }
            }
            return null;
        }

        /// <summary>
        /// returns the number of cards the player has left in his hand.
        /// </summary>
        /// <returns></returns>
        public int GetNumCards()
        {
            return hand.Count;
        }
    }
}
