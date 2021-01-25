using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;

namespace SerializeCarts
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random rnd = new Random();
        private Deck RandomDeck(int Number)
        {
            Deck myDeck = new Deck(new Card[] { });
            for (int i = 0; i < Number; i++)
            {
                myDeck.Add(new Card(
                    (Card.Suit)rnd.Next(4),
                    (Card.Value)rnd.Next(1, 14)));
            }
            return myDeck;
        }

        

        private void DealCards(Deck DeckToDeal, string Title)
        {
            Console.WriteLine(Title);
            while(DeckToDeal.Count>0)
            {
                Card nextCard = DeckToDeal.Deal(0);
                Console.WriteLine(nextCard.Name);
            }
            Console.WriteLine("-------------------------");
        }

        private void b_saveDeck_Click(object sender, EventArgs e)
        {

            Deck deckToWrite = RandomDeck(5);

            using (Stream output = File.Create("Zestaw.dat"))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(output, deckToWrite);
            }
            DealCards(deckToWrite, "To zapisałem do pliku:");

        }

        private void b_readDeck_Click(object sender, EventArgs e)
        {
            Deck deckFromFile;
            using(Stream input = File.OpenRead("Zestaw.dat"))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                deckFromFile = (Deck)formatter.Deserialize(input);
            }
            DealCards(deckFromFile, "To odczytałem z pliku:");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using(Stream output = File.Create("Zestaw1.dat"))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                for (int i = 0; i < 5; i++)
                {
                    Deck deckToWrite = RandomDeck(rnd.Next(10));
                    formatter.Serialize(output, deckToWrite);
                    DealCards(deckToWrite, "Zapisane karty to:");
                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (Stream input = File.OpenRead("Zestaw1.dat")) 
            {
                BinaryFormatter formatter = new BinaryFormatter();
                for (int i = 0; i < 5; i++)
                {
                    Deck deckToRead = (Deck)formatter.Deserialize(input);
                    DealCards(deckToRead, "Odczytane karty z pliku to:");
                }
            }
        }

        private void b_saveCard_Click(object sender, EventArgs e)
        {
            Card card = Card.ReadCard(cb_card.Text);
            using (Stream output = File.Create(card.value.ToString() + "_" + card.suit.ToString() + ".dat"))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(output, card);

                Console.WriteLine("Card {0} {1} is saved", card.value, card.suit);
            }
        }

        private void b_readCard_Click(object sender, EventArgs e)
        {
            string[] cardName = cb_card.Text.Split(' ');
            string cardFileName = cardName[0] + "_" + cardName[1] + ".dat";

            using(Stream input = File.OpenRead(cardFileName))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                Card card = (Card)formatter.Deserialize(input);

                Console.WriteLine("Card {0} {1} was read", card.value, card.suit);
            }
        }

        private void b_compareBytesInCardsFiles_Click(object sender, EventArgs e)
        {

            string[] firstCardName = cb_firstCardToCompare.Text.Split(' ');
            string[] secondCardName = cb_secondCardToCompare.Text.Split(' ');
            string firstCardFile = firstCardName[0] + "_" + firstCardName[1] + ".dat";
            string secondCardFile = secondCardName[0] + "_" + secondCardName[1] + ".dat";

            byte[] firstCardBytesArray = File.ReadAllBytes(firstCardFile);
            byte[] secondCardBytesArray = File.ReadAllBytes(secondCardFile);


            Console.WriteLine("Changes betwenn card {0} {1} and {2} {3} in bytes:", firstCardName[0], firstCardName[1], secondCardName[0], secondCardName[1]);
            for (int i = 0; i < firstCardBytesArray.Length; i++)
                if (firstCardBytesArray[i] != secondCardBytesArray[i])
                    Console.WriteLine("Bajt nr {0}: {1} i {2}", i, firstCardBytesArray[i], secondCardBytesArray[i]);
        }

        private void cb_cardToChange_SelectedIndexChanged(object sender, EventArgs e)
        {
            b_changeCardInBytesFile.Text = "Zmień karę " + cb_cardToChange.Text + " na " + cb_cardToObtain.Text + " za pomocą zmian w pliku bajtów pierwszej z nich";
        }

        private void cb_cardToObtain_SelectedIndexChanged(object sender, EventArgs e)
        {
            b_changeCardInBytesFile.Text = "Zmień karę " + cb_cardToChange.Text + " na " + cb_cardToObtain.Text + " za pomocą zmian w pliku bajtów pierwszej z nich";
        }

        private void b_changeCardInBytesFile_Click(object sender, EventArgs e)
        {
            string[] cardToChangeName = cb_cardToChange.Text.Split(' ');
            string cardToChangeFile = cardToChangeName[0] + "_" + cardToChangeName[1] + ".dat";

            Card cardToObtain = Card.ReadCard(cb_cardToObtain.Text);
            int cardToObtainValueIndex = (int)cardToObtain.value;
            int cardToObtainSuitIndex = (int)cardToObtain.suit;

            byte[] cardToChangeBytesArray = File.ReadAllBytes(cardToChangeFile);
            cardToChangeBytesArray[246] = (byte)cardToObtainValueIndex;
            cardToChangeBytesArray[298] = (byte)cardToObtainSuitIndex;

            File.WriteAllBytes(cardToChangeFile, cardToChangeBytesArray);



        }

        private void b_createHexFile_Click(object sender, EventArgs e)
        {
            string[] cardName = cb_BinaryfileName.Text.Split(' ');
            string fileName = cardName[0] + "_" + cardName[1];

            using(StreamReader reader = new StreamReader(fileName + ".dat"))
            using(StreamWriter writer= new StreamWriter(fileName + "_hex.txt", false))
            {
                int position = 0;
                while(!reader.EndOfStream)
                {
                    char[] buffer = new char[16];
                    int characterRead = reader.ReadBlock(buffer, 0, 16);
                    writer.Write("{0}: ", String.Format("{0:x4}", position));
                    position += characterRead;
                    for (int i = 0; i < 16; i++)
                    {
                        if (i<characterRead)
                        {
                            string hex = String.Format("{0:x2}", (byte)buffer[i]);
                            writer.Write(hex + " ");
                        }
                        else
                        {
                            writer.Write("   ");
                        }

                        if (i == 7)
                            writer.Write("-- ");
                        if (buffer[i] < 32 || buffer[i] > 250)
                            buffer[i] = '.';

                    }

                    string bufferContents = new string(buffer);
                    writer.WriteLine("   " + bufferContents.Substring(0, characterRead));

                }
            }
        }
    }
}



