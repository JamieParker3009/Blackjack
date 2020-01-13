using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack_Project
{
    class Deck
    {
        private int deck_count; //Create variable to track amount of decks
        public List<Card> deck = new List<Card>(); //Create a new list using the card class
        Random rnd = new Random(); //Create a random 

        public void CreateDeck(int DeckCount)
        {
            //removes the remaining Contents of the deck, once a new deck is needed
            deck.Clear();

            deck_count = DeckCount;

            //Iterate for the given amount of Decks
            for (int i = 0; i < deck_count; i++)
            {
                //Iterate over Card Values
                for (int x = 0; x < 13; x++)
                {
                    //Iterate over Card Suites
                    for (int z = 0; z < 4; z++)
                    {
                        deck.Add(new Card(x, z));
                    }
                }
            }
        }

        public void Shuffle(int TimesToShuffle)
        {
            for (int i = 0; i < TimesToShuffle; i++)
            {
                //Shuffle
                for (int cardIndex1 = deck.Count() - 1; cardIndex1 > 0; cardIndex1--)
                {
                    int cardIndex2 = rnd.Next(cardIndex1 + 1);
                    var tmp = deck[cardIndex1];
                    deck[cardIndex1] = deck[cardIndex2];
                    deck[cardIndex2] = tmp;
                }
            }
        }
    }
}
