using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SerializeCarts
{
    public partial class Form1 : Form
    {
        Random rnd = new Random();
        Deck deck1;
        Deck deck2;
        public Form1()
        {
            InitializeComponent();

            ResetDeck(2);
            RedrawDeck(2);


            ResetDeck(1);
            RedrawDeck(1);

        }

        private void b_resetFirstDeck_Click(object sender, EventArgs e)
        {            
            ResetDeck(1);
            RedrawDeck(1);
        }

        private void b_resetSecondDeck_Click(object sender, EventArgs e)
        {
            ResetDeck(2);
            RedrawDeck(2);
        }

        private void b_shuffleFirstDeck_Click(object sender, EventArgs e)
        {
            deck1.Shuffle();
            RedrawDeck(1);
        }

        private void b_shuffleSecondDeck_Click(object sender, EventArgs e)
        {
            deck2.Shuffle();
            RedrawDeck(2);
        }

        private void b_moveToSecondDeck_Click(object sender, EventArgs e)
        {
            if (lb_FirstDeck.SelectedIndex>=0)
            {
                if (deck1.Count > 0)
                    deck2.Add(deck1.Deal(lb_FirstDeck.SelectedIndex));

                RedrawDeck(1);
                RedrawDeck(2);
            }

        }        
        
        private void b_moveToFirstDeck_Click(object sender, EventArgs e)
        {
            if (lb_SecondDeck.SelectedIndex>=0)
            {
                if(deck2.Count>0)
                    deck1.Add(deck2.Deal(lb_SecondDeck.SelectedIndex));
                
                RedrawDeck(1);
                RedrawDeck(2);
            }


        }        
        
        public Card[] CreateCardsArray(int numberOfCards)
        {
            List<string> cardsNames = new List<string>();
            Card[] cards = new Card[numberOfCards];
            Card card;
            for (int i = 0; i < numberOfCards; i++)
            {
                do
                {
                    card = new Card((Card.Suit)rnd.Next(4), (Card.Value)rnd.Next(1, 14));

                } while (cardsNames.Contains(card.Name));
                //while (cardsNames.Contains(card.Name));

                cardsNames.Add(card.Name);
                cards[i] = card;
            }
            
            return cards;
        }
        public void RedrawDeck(int deckNumber)
        {
            if(deckNumber==1)
            {
                lb_FirstDeck.Items.Clear();
                foreach(string cardName in deck1.GetCardNames())
                {
                    lb_FirstDeck.Items.Add(cardName);
                }
                l_FirstDeck.Text = "Talia 1 zawiera " + deck1.Count + " karty";
            }else
            {
                lb_SecondDeck.Items.Clear();
                foreach (string cardName in deck2.GetCardNames())
                {
                    lb_SecondDeck.Items.Add(cardName);
                }
                l_secondDeck.Text = "Talia 2 zawiera " + deck2.Count + " karty";
            }
        }



        public void ResetDeck(int deckNumber)
        {
            if (deckNumber == 1)
            {
                deck1 = new Deck(CreateCardsArray(10));
                deck1.Sort();
            }
            else
            {
                deck2 = new Deck();
                //deck2.Sort();
            }
        }


    }
}
