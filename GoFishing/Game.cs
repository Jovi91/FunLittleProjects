using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoFishing
{
    class Game
    {
        List<Player> players;
        Dictionary<Card.Value, Player> books;
        Deck stock;
        TextBox textBoxOnForm;
        Dictionary<string, int> winners;
        public Game(string playerName, string[] opponentNames, TextBox textBoxOnForm)
        {
            Random rnd = new Random();
            this.textBoxOnForm = textBoxOnForm;
            players = new List<Player>();
            players.Add(new Player(playerName, rnd, textBoxOnForm));
            foreach (string player in opponentNames)
                players.Add(new Player(player, rnd, textBoxOnForm));
            books = new Dictionary<Card.Value, Player>();
            stock = new Deck();
            Deal();
            players[0].SortHand();
        }
        
        void Deal()
        {
            stock.Shuffle();
            foreach(Player player in players)
            {
                for (int i = 0; i < 5; i++)
                {
                    player.TakeCard(stock.Deal()) ;
                }

                player.PullOutBooks();

            }

        }

        public bool PlayOneRound(int selectedPlayerCard)
        {
            bool isGameOver = false;
            Card.Value  cardValueToPlay = players[0].Peek(selectedPlayerCard).value;
            for (int i = 0; i < players.Count; i++)
            {
                int numberOfCardsBeforAsk = players[i].CardCount;

                if(numberOfCardsBeforAsk>0)
                {

                    if(i==0)
                        players[i].AskForACard(players, i, stock, cardValueToPlay);
                    else
                        players[i].AskForACard(players, i, stock);

                    if (players[i].CardCount<1)
                    {
                        MessageBox.Show(players[i].Name + " ma " + players[i].CardCount + " kart.");
                    }
                }
            }
            for (int i = 0; i < players.Count; i++)
            {
                if (PullOutBooks(players[i]))
                    for (int j = Math.Min(5, stock.Count); j>0; j--)
                    {
                        players[i].TakeCard(stock.Deal());
                    }
            }


            players[0].SortHand();

            if (stock.Count==0)
            {
                textBoxOnForm.Text = "Na kupce nie ma żadnych kart. Gra skończona!\r\n\n";
                isGameOver = true;
            }

            return isGameOver;
        }

        public bool PullOutBooks(Player player)
        {
            //MessageBox.Show(player.Name + " ma " + player.CardCount.ToString() + " kartz PRZED");
            
            List<Card.Value> booksValues = player.PullOutBooks();
            foreach (Card.Value bookValue in booksValues)
            {
                books.Add(bookValue,player);
            }
            //MessageBox.Show(player.Name + " ma " + player.CardCount.ToString() + " kart POOOOO");
            if (player.CardCount == 0)
                return true;
            else
                return false;
            
        }

        public string DescribeBooks()
        {
            string booksInfo="";
            foreach (KeyValuePair<Card.Value, Player> book in books)
            {
                booksInfo += book.Value.Name + " ma grupę " + Card.Plural(book.Key,0) + "\r\n";
            }
            return booksInfo;
        }

        public string GetWinnerName()
        {
            List<string> winnersNames = new List<string>();
            int maxNumberOfBooks=0;
            string winningText;
            //Dictionary<string, int> winners = new Dictionary<string, int>();
            winners = new Dictionary<string, int>();

            foreach (Card.Value value in books.Keys)
            {

                if (winners.ContainsKey(books[value].Name))
                    winners[books[value].Name] += 1;
                else
                    winners.Add(books[value].Name, 1);

                //MessageBox.Show("Test");
            }

            //foreach (string name in winners.Keys)
            //{
            //    if (winners[name] >= maxNumberOfBooks)
            //    {
            //        maxNumberOfBooks = winners[name]; 
            //        winnersNames.Add(name);
            //    }

            //}

            foreach (string name in winners.Keys)
            {
                if (winners[name] >= maxNumberOfBooks)
                {
                    maxNumberOfBooks = winners[name];
                 
                }

            }

            foreach (string name in winners.Keys)
            {
                if (winners[name]==maxNumberOfBooks)
                {
                    winnersNames.Add(name);

                }

            }

            if (winnersNames.Count>1)
            {
                winningText = "Remis pomiędzy ";

                for (int i = 0; i < winnersNames.Count; i++)
                {
                    if (i == 0)
                        winningText += winnersNames[i];
                    else
                        winningText += " i " + winnersNames[i];
                }

                winningText += ": " + winners[winnersNames[0]].ToString() + " grupy.";
            }
            else
            {
                winningText=winnersNames[0] + ": " + winners[winnersNames[0]].ToString() + " grupy.";
            }

            return winningText;

        }

        public string[] GetPlayerCardNames()
        {
            return players[0].GetCardNames();
        }

        public string DescribePlayerHands()
        {
            string description = "";
            for (int i = 0; i < players.Count; i++)
            {
                description += players[i].Name + " ma " + players[i].CardCount;
                if (players[i].CardCount == 1)
                    description += " kartę.\r\n";
                else if (players[i].CardCount == 3 || players[i].CardCount == 4)
                    description += " karty.\r\n";
                else
                    description += " kart.\r\n";
            }
            description += "Na kupce pozostało kart: " + stock.Count + "\r\n";
            return description;
        }


        public string showPlayersCards()
        {
            string playersCards = "Zawodnikom pozostały w ręku następujące karty:\r\n\n";
            for (int i = 0; i < players.Count; i++)
            {
                string[] cartsInHandArray = players[i].GetCardNames();
                string cartsInHand = "";

                for (int j = 0; j < cartsInHandArray.Length; j++)
                {
                    cartsInHand += cartsInHandArray[j] + ", ";
                }
                playersCards += players[i].Name + ": " + winners[players[i].Name] + " grupy; carty: " + cartsInHand + "\r\n";

            }

            return playersCards;
        }

        public void WriteCardsNamesToFile(string FilePath){ players[0].WriteCardsNamesToFile(FilePath); }
    }
}
