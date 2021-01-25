using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerializeCarts
{
    class Deck
    {
        private List<Card> cards;
        private Random rnd = new Random();

        public Deck()
        {

            cards = new List<Card>();
            for (int suit = 0; suit <= 3; suit++)
            {
                for (int value = 1; value <= 13; value++)
                {
                    Card card = new Card((Card.Suit)suit, (Card.Value)value);
                    cards.Add(card);

                }

            }
        }

        public Deck(Card[] inintialCards)
        {
            cards = new List<Card>(inintialCards);
            
        }

        public int Count { get { return cards.Count; } }

        public void Add(Card cardToAdd)
        {
            cards.Add(cardToAdd);
        }

        public Card Deal(int index)
        {
            Card cardToGive = cards[index];
            cards.RemoveAt(index);
            return cardToGive;
        }

        public void Shuffle()
        {
            for (int i = 0; i < cards.Count; i++)
            {
                Card cardToChangePlace = cards[i];
                int newIndex = rnd.Next(0, Count);
                cards.Remove(cards[i]);
                cards.Insert(newIndex, cardToChangePlace);
            } 
        }
        public string[] GetCardNames()
        {
            string[] CardNames = new string[Count];
            for (int i = 0; i < Count; i++)
            {
                CardNames[i] = cards[i].Name;
            }

            return CardNames;
        }

        public void Sort()
        {
            CardComparer cardComparer = new CardComparer();
            cardComparer._compareBy = CardComparer.CompareBy.suitThenValue;
            cards.Sort(cardComparer);
        }
    }
}
