using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerializeCarts
{
    public class Card
    {
        public enum Suit
        {
            Spades,
            Clubs,
            Dimonds,
            Hearts
        }
        public enum Value
        {
            Ace = 1,
            Two = 2,
            Three = 3,
            Four = 4,
            Five = 5,
            Six = 6,
            Seven = 7,
            Eight = 8,
            Nine = 9,
            Ten = 10,
            Jack = 11,
            Queen = 12,
            King = 13
        }

        public Value value;
        public Suit suit;

        public string Name
        {
            get
            {
                return value.ToString() + " of " + suit.ToString();
            }
        }

        public Card(Suit suit, Value value)
        {
            this.suit = suit;
            this.value = value;

        }
    }
}
