using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack_Project
{
    class Hand
    {
        public int hand_total = 0; //Declare important hand variables (such as a bool for draw and the total hand value)
        public string name;
        public List<Card> hand = new List<Card>();

        public Hand(string Name)
        {
            name = Name;
        }

        public void GetCards(List<Card> Deck)
        {
            hand.Add(Deck[0]);
            Deck.RemoveAt(0);
            CalcHandTotal();
        }

        private void CalcHandTotal()
        {
            hand_total = 0;
            int aceCount = 0;
            foreach (var card in hand)
            {
                if (card.rank == 0)
                {
                    aceCount++;
                }
                else if ((int)card.rank < 10)
                {
                    hand_total += (int)card.rank + 1;
                }
                else
                {
                    hand_total += 10;
                }

            }

            if (aceCount > 0)
            {
                if (hand_total <= (11 - aceCount))
                {
                    hand_total += (aceCount - 1) + 11;
                }
                else
                {
                    hand_total += aceCount;
                }
            }

        }

    }
}