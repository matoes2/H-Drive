using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uno1
{
    class Program
    {
        static void Main(string[] args)
        {

            // create a game similar to Uno: use the below as guidance
            //removed wilds to change to suit of card to make code simpler feel free to change to suport full wild behaivior.
            //Ace is Draw 4 Card can be played at any time and will switch suit to the suit of the Ace
            //king is Wild card that can be played at any time and will switch suit to the suit of the King
            //Queen is Draw 2 Card Next player draws 2 cards
            //Jack is skip Card

            ///////// The below is just for guidance - you do not need to do it the way outlined below/////////////

            //create a list of players 
            //ask the user to enter a number of players 2-5
            //create as many players as indicated by user and add each to  the list of players
            //create an object called gameDeck that is an instance of the deck class
            //shuffle the game deck
            //deal 7 cards to each player 
            //draw the first card
            //place card on the discard pile
            //While the game is not over (players still have cards
            // check if previous card was special card(see above) and do what it tell you to do
            // check currentPlayer's available moves
            // if no moves are available draw a card until a move is available
            // if valid move found prompt user to enter cardName
            // play the card the user selected and discard the card.
            // move to next player in the list
            int i;
            List<Player> players = new List<Player>();
            Console.WriteLine("Please enter the number of players: ");
            int numberOfPlayers = Convert.ToInt32(Console.ReadLine());
            for (i = 0; i < numberOfPlayers; i++)
            {
                Player player = new Player();
                players.Add(player);
            }
            Deck gameDeck = new Deck();
            gameDeck.ShuffleAll();
            for (i = 0; i < numberOfPlayers; i++)
            {
                while (i <= 7)
                {
                    Card drawnCard = gameDeck.DrawCard();
                    players[i].AddCardToHand(drawnCard);
                }
            }
            Card drawnCard1 = gameDeck.DrawCard();
            gameDeck.DiscardCard(drawnCard1);
            i = 0;
            int currentPlayer = 0;
           
            while (gameDeck.GetNumCardsDeck() > 0)
            {
                if (gameDeck.ReadDiscardPile().GetValue() == 11)
                {
                    currentPlayer++;
                    if (currentPlayer == players.Count)
                    {
                        currentPlayer = 0;
                    }
                }
                else if (gameDeck.ReadDiscardPile().GetValue() == 12)
                {
                    players[currentPlayer].AddCardToHand(gameDeck.DrawCard());
                    players[currentPlayer].AddCardToHand(gameDeck.DrawCard());
                    currentPlayer++;
                    players[currentPlayer].AddCardToHand(gameDeck.DrawCard());
                    players[currentPlayer].AddCardToHand(gameDeck.DrawCard());
                }
                else if (gameDeck.ReadDiscardPile().GetValue() == 14)
                {
                    players[currentPlayer].AddCardToHand(gameDeck.DrawCard());
                    players[currentPlayer].AddCardToHand(gameDeck.DrawCard());
                    players[currentPlayer].AddCardToHand(gameDeck.DrawCard());
                    players[currentPlayer].AddCardToHand(gameDeck.DrawCard());
                }
                players[currentPlayer].PrintValidMoves(gameDeck.ReadDiscardPile());
                while(players[currentPlayer].PrintValidMoves(gameDeck.ReadDiscardPile()) != true)
                {
                    players[currentPlayer].AddCardToHand(gameDeck.DrawCard());
                    
                }
                if (players[currentPlayer].PrintValidMoves(gameDeck.ReadDiscardPile()) == true)
                {
                    players[currentPlayer].PrintValidMoves(gameDeck.ReadDiscardPile());
                    Console.WriteLine("Please enter the name of the card you would like to play: ");
                    Card cardPlayed = players[currentPlayer].GetCardByName(Console.ReadLine());
                    gameDeck.DiscardCard(cardPlayed);
                    currentPlayer++;
                    break;
                }
            }
            if(gameDeck.GetNumCardsDeck() <= 0)
            {
                Console.WriteLine("Game End!! Player " + players[currentPlayer] + " wins!");
            }
        }
    }
}
