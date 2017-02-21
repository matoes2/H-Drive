using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntoToObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck player1 = new Deck();
            Deck player2 = new Deck();
            List<Card> cardsInPlay = new List<Card>();
            player1.ShuffleRemaining();
            player2.ClearDeck();
            int i = 0;
            while (i < 26)
            {
                Card removedCard = player1.DrawCard();
                player2.AddCardToDeck(removedCard);
            }
            i = 0;
            while (player1.GetNumCardsTotal() > 0 || player2.GetNumCardsTotal() > 0)
            {
                Card drawnCard = player1.DrawCard();
                cardsInPlay.Add(drawnCard);
                Card drawnCard2 = player2.DrawCard();
                if(drawnCard == drawnCard2)
                {
                    cardsInPlay.Add(player1.DrawCard());
                    cardsInPlay.Add(player1.DrawCard());
                }
                if(drawnCard.GetValue() > drawnCard2.GetValue())
                {
                    while (i < cardsInPlay.Count)
                    {
                        player1.DiscardCard(cardsInPlay[i]);
                        i++;
                    }
                }
                else if (drawnCard2.GetValue() > drawnCard.GetValue())
                {
                    while (i < cardsInPlay.Count)
                    {
                        player2.DiscardCard(cardsInPlay[i]);
                        i++;
                    }
                }
            }

            //create 2 new objects of the Deck Class- Call One Player1 and the other Player2
            //create a list of Cards called cardsInPlay
            //shuffle player1's deck
            //clear player2's deck
            //remove 26 cards from player1's deck and add them to player2's deck
            //Do the following until one of the players have 0 cards in Discard pile or deck
            //draw card from player1 add to cardsInPlay list
            //draw card from player2
            //while last card drawn values match 
            // draw 4 more cards(or as many that the player has) from player1 and player2 and add to cardsInPlay
            //Add all cards in the cardsInPlay list to the player's discard pile who had the higher value card
        }
    }
}
