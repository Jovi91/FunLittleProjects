using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoFishing
{
    public class Deck
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

        public Card Peek(int cardNumber)
        {
            return cards[cardNumber];
        }

        public Card Deal()
        {
            return Deal(0);
        }

        public bool ContainsValue(Card.Value value)
        {
            foreach (Card card in cards)
            {
                if (card.value == value)
                    return true;  
            }
            return false;
        }

        public Deck PullOutValues(Card.Value value)
        {
            Deck deckToReturn = new Deck(new Card[] { });
            for(int i = cards.Count-1; i >=0; i--)
            {
                if (cards[i].value==value)
                {
                    //if(deckToReturn.Count>1)
                     //   System.Windows.Forms.MessageBox.Show(" PullOutValues deckToReturn.Count:" + deckToReturn.Count.ToString() +" i:" + i.ToString() + " kart: " + cards.Count.ToString());

                    deckToReturn.Add(Deal(i));
                }
            }
            return deckToReturn;
        }

        public bool HasBook(Card.Value value)
        {
            int numberOfCards = 0;
            foreach (Card card in cards)
            {
                if (card.value==value)
                {
                    numberOfCards++;
                }
            }

            if (numberOfCards == 4)
                return true;
            else
                return false;
        }

        public void SortByValue()
        {
            cards.Sort(new CardComparer());
        }


        public void WriteCardsNamesToFile(string FileName)
        {
            
            using (StreamWriter writer = new StreamWriter(FileName))
            {
                for (int i = 0; i < cards.Count; i++)
                {
                    writer.WriteLine(cards[i].Name);
                }

            }
        }
        
        public Deck(string FileName)
        {
            cards = new List<Card>();
            string cardName;
            bool invalidCard = false;
            
            StreamReader reader = new StreamReader(FileName);
            while (!reader.EndOfStream)
            {
                cardName = reader.ReadLine();
                string[] cardParts = cardName.Split(new char[] { ' ' });

                Card.Value value = Card.Value.Ace;
                switch(cardParts[0])
                {
                    case "As": value = Card.Value.Ace; break;
                    case "Dwójka": value = Card.Value.Two; break;
                    case "Trójka": value = Card.Value.Three; break;
                    case "Czwórka": value = Card.Value.Four; break;
                    case "Piątka": value = Card.Value.Five; break;
                    case "Szóstka": value = Card.Value.Six; break;
                    case "Siódemka": value = Card.Value.Seven; break;
                    case "Ósemka": value = Card.Value.Eight; break;
                    case "Dziewiątka": value = Card.Value.Nine; break;
                    case "Dziesiątka": value = Card.Value.Ten; break;
                    case "Walet": value = Card.Value.Jack; break;
                    case "Dama": value = Card.Value.Queen; break;
                    case "Król": value = Card.Value.King; break;
                    default: invalidCard = true; break;
                }

                Card.Suit suit = Card.Suit.Hearts;               
                switch (cardParts[1])
                {
                    case "pik":
                        suit = Card.Suit.Spades;
                        break;
                    case "trefl":
                        suit = Card.Suit.Clubs;
                        break;
                    case "karo":
                        suit = Card.Suit.Dimonds;
                        break;
                    case "kier":
                        suit = Card.Suit.Hearts;
                        break;
                    default: invalidCard = true;break;
                }

                if(!invalidCard)
                    cards.Add(new Card(suit, value));
            }


        }


    }
}
