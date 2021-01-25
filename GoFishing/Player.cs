using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoFishing
{
    public class Player
    {
        string name;
        public string Name { get { return name; } }
        Random rnd;
        Deck cards;
        TextBox textBoxOnForm;

        public Player(String name, Random rnd, TextBox textBoxOnForm)
        {
            this.name = name;
            this.rnd = rnd;
            this.textBoxOnForm = textBoxOnForm;
            this.textBoxOnForm.Text += name + " dołączylł do gry \r\n";
            cards = new Deck(new Card[] { });
        }

        public List<Card.Value> PullOutBooks()
        {
            List<Card.Value> Books = new List<Card.Value>();
            for (int i = 1; i <= 13; i++)
            {
                Card.Value value = (Card.Value)i;
                int howMany = 0;
                for (int card = 0; card < cards.Count; card++)
                {
                    if (cards.Peek(card).value == value)
                        howMany++;
                }
                if (howMany == 4)
                {
                    Books.Add(value);
                    for (int card = cards.Count-1; card >= 0; card--)
                        if(cards.Peek(card).value==value)
                            cards.Deal(card);
                }
            }
            return Books;
        }

        public Card.Value GetRandomValue()
        {
            //                                 For not Random
            //Card.Value mostNumerousValue;
            //int numberOfCards = 0;
            //int maxNumberOfCards = 0;
            //for (int i = 0; i < cards.Count; i++)
            //{
            //    for (int j = 0; j < cards.Count; j++)
            //    {
            //        //if (i == j)
            //        //    continue;

            //        if ((Card.Value)i == (Card.Value)j)
            //            numberOfCards++;
            //    }

            //    if (numberOfCards > maxNumberOfCards)
            //        mostNumerousValue = (Card.Value)i;
            //}

            Card.Value randomCard = cards.Peek(rnd.Next(cards.Count)).value;

            return randomCard;
        }

        public Deck DoYouHaveAny(Card.Value value)
        {
            Deck cardsToGive = new Deck(new Card[] { });
            if (cards.ContainsValue(value))
                cardsToGive = cards.PullOutValues(value);

            textBoxOnForm.Text += Name + " ma " + cardsToGive.Count + " " + Card.Plural(value, cardsToGive.Count) + "\r\n";
           return cardsToGive;
        }

        public void AskForACard(List<Player> players, int myIndex, Deck stock)
        {
            AskForACard(players, myIndex, stock, GetRandomValue());
        }

        public void AskForACard(List<Player> players, int myIndex, Deck stock, Card.Value value)
        {
            int cartsToRecive=0;
            textBoxOnForm.Text += Name + " pyta, czy ktoś ma " + Card.Plural(value,1) + "\r\n";
            for (int i = 0; i < players.Count; i++)
            {
                cartsToRecive = 0;
                if (i == myIndex) continue;
                
                Deck deckToRecive = players[i].DoYouHaveAny(value);

                for (int j = 0; j < deckToRecive.Count; j++)
                {
                       
                    cards.Add(deckToRecive.Peek(j));
                    cartsToRecive++;
                }
            }
            if (cartsToRecive == 0 && stock.Count>0)
            {
                cards.Add(stock.Deal());
                textBoxOnForm.Text += Name + " pobrał kartę z kupki\r\n";
            }
        }

        public int CardCount { get { return cards.Count; } }
        public void TakeCard(Card card) { cards.Add(card); }
        public string[] GetCardNames(){return cards.GetCardNames();}
        public Card Peek(int cardNumber) { return cards.Peek(cardNumber); }
        public void SortHand() { cards.SortByValue(); }
        public void WriteCardsNamesToFile(string FilePath){ cards.WriteCardsNamesToFile(FilePath); }



    }
}
