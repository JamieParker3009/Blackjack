using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack_Project
{
    enum Rank //Create an enum for card values (Value is taken as a name, so Rank is used instead)
    {
        A,
        _2,
        _3,
        _4,
        _5,
        _6, //The "_" is used to allow numbers in the enum
        _7,
        _8,
        _9,
        _10,
        J,
        Q,
        K,
    };

    enum Suit //Create an enum for Suits
    {
        C,
        D,
        S,
        H,
    };

    class Card //Create a "card" with the following properties
    {
        public Rank rank;
        public Suit suit;
        public string imagename;
        public string rankstring;
        public string suitstring;

        public Card(int Rank, int Suit)
        {
            suit = (Suit)Suit;
            rank = (Rank)Rank;
            rankstring = Convert.ToString(rank);
            rankstring = rankstring.Replace("_", "");
            suitstring = Convert.ToString(suit);
            imagename = (rankstring + suitstring + ".png"); //Combine the suit and rank and add ".png" in order to get the card's appropriate image
        }
    }
}
