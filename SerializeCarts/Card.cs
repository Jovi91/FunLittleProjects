using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerializeCarts
{
    [Serializable]
    public class Card
    {
        public enum Suit
        {
            pik,
            trefl,
            karo,
            kier
        }
        public enum Value
        {
            As = 1,
            Dwójka = 2,
            Trójka = 3,
            Czwórka = 4,
            Piątka = 5,
            Szóstka = 6,
            Siódemka = 7,
            Ósemka = 8,
            Dziewiątka = 9,
            Dziesiątka = 10,
            Walet = 11,
            Dama = 12,
            Król = 13
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

        public static Card ReadCard(string cardName)
        {
            bool invalidCard = false;
            string[] cardParts = cardName.Split(new char[] { ' ' });

            Card.Value value = Card.Value.As;
            switch (cardParts[0])
            {
                case "As": value = Card.Value.As; break;
                case "Dwójka": value = Card.Value.Dwójka; break;
                case "Trójka": value = Card.Value.Trójka; break;
                case "Czwórka": value = Card.Value.Czwórka; break;
                case "Piątka": value = Card.Value.Piątka; break;
                case "Szóstka": value = Card.Value.Szóstka; break;
                case "Siódemka": value = Card.Value.Siódemka; break;
                case "Ósemka": value = Card.Value.Ósemka; break;
                case "Dziewiątka": value = Card.Value.Dziewiątka; break;
                case "Dziesiątka": value = Card.Value.Dziesiątka; break;
                case "Walet": value = Card.Value.Walet; break;
                case "Dama": value = Card.Value.Dama; break;
                case "Król": value = Card.Value.Król; break;
                default: invalidCard = true; break;
            }

            Card.Suit suit = Card.Suit.kier ;
            switch (cardParts[1])
            {
                case "pik":
                    suit = Card.Suit.pik;
                    break;
                case "trefl":
                    suit = Card.Suit.trefl;
                    break;
                case "karo":
                    suit = Card.Suit.karo;
                    break;
                case "kier":
                    suit = Card.Suit.kier;
                    break;
                default: invalidCard = true; break;
            }

            if (!invalidCard)
                return new Card(suit, value);
            else
                return null;
        }
            
    }
}
