using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Overload
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Card cardToCheck = new Card(Card.Suit.Clubs, Card.Value.Ace);
            bool doesCardsMatch = Card.DoesCardsMatch(cardToCheck, Card.Value.Ace);
        }
    }
}
