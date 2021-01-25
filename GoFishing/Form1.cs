using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoFishing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Game game;

        private void b_buttonStart_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tb_textName.Text))
            {
                MessageBox.Show("Wpisz swoje imię", "Nie można jeszcze rozpocząć gry.");
                return;
            }
            game = new Game(tb_textName.Text, new string[] { "Janek", "Bartek" }, tb_textProgress);
            b_buttonStart.Enabled = false;
            b_buttonAsk.Enabled = true;
            b_saveCartsToFile.Enabled = true;
            b_displayCartsFromFile.Enabled = true;
            UpdateForm();
        }

        private void UpdateForm()
        {
            lb_listHand.Items.Clear();
            foreach (String cardName in game.GetPlayerCardNames())
            {
                lb_listHand.Items.Add(cardName);

            }
            tb_textBooks.Text = game.DescribeBooks();
            tb_textProgress.Text += game.DescribePlayerHands();
            tb_textProgress.SelectionStart = tb_textProgress.Text.Length;
            tb_textProgress.ScrollToCaret();
        }

        private void b_buttonAsk_Click(object sender, EventArgs e)
        {
            tb_textProgress.Text = "";
            if (lb_listHand.SelectedIndex<0)
            {
                MessageBox.Show("Wybierz kartę.");
                return;
            }
            if (game.PlayOneRound(lb_listHand.SelectedIndex))
            {
                lb_listHand.Items.Clear();
                foreach (String cardName in game.GetPlayerCardNames())
                {
                    lb_listHand.Items.Add(cardName);

                }
                tb_textBooks.Text =game.DescribeBooks();
                tb_textProgress.Text += "Zawodnikom pozostało na rękach:\r\n" + game.DescribePlayerHands();
                tb_textProgress.Text += "\r\n\nZwycięzcą jest..." + game.GetWinnerName();
                b_buttonAsk.Enabled = false;

                MessageBox.Show(game.showPlayersCards());

            }
            else
                UpdateForm();
        }

        private void b_saveCartsToFile_Click(object sender, EventArgs e)
        {
            string FilePath = @"C:\Users\jowit\source\repos\HeadFirstProjects092020\GoFishing\CurrentDeck\deck_" + DateTime.Now.ToString("dd_MM_yyyy_HH^mm") + ".txt";
            game.WriteCardsNamesToFile(FilePath);
        }

        private void b_displayCartsFromFile_Click(object sender, EventArgs e)
        {
            lb_cardsFromFile.Items.Clear();
            openFileDialog1.InitialDirectory = @"C:\Users\jowit\source\repos\HeadFirstProjects092020\GoFishing\CurrentDeck\";
            openFileDialog1.Filter = @"pliki tekstowe (*.txt)|*.txt";
            if(openFileDialog1.ShowDialog()==DialogResult.OK)
            {
                Deck deck = new Deck(openFileDialog1.FileName);
                String[] cardsName = deck.GetCardNames();
                for (int i = 0; i < cardsName.Length; i++)
                {
                    lb_cardsFromFile.Items.Add(cardsName[i]);
                }
               
            }
            

           
        }
    }
}
