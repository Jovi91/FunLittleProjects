using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DogRace
{
    [Serializable]
    public class Guy
    {
        public string Name { set; get; }
        public Bet MyBet { set; get; }
        public int Cash { set; get; }
        public RadioButton MyRadioButton { get; set; }
        public Label MyLabel { set; get; }


        public Guy(string name, int cash, RadioButton myRadioButton, Label myLabel)
        {
            this.Name = name;
            this.Cash = cash;
            this.MyRadioButton = myRadioButton;
            this.MyLabel = myLabel;
        }
        public void UpdateLabel()
        {
            if(MyBet!=null)
                MyLabel.Text = MyBet.GetDescription();
            else
                MyLabel.Text= Name + " nie postawił zakładu.";



            MyRadioButton.Text = Name + " ma " + Cash + "zł.";
        }

        public bool PlaceBet(int Amount, int Dog)
        {
            bool guyHasMoney = false;
            if (Cash >= Amount)
            {
                MyBet = new Bet(Amount, Dog, this);
                guyHasMoney = true;
            }
            return guyHasMoney;
        }

        public void ClearBet()
        {
            MyBet = null;
        }

        public void Collect(int winner)
        {
            Cash += MyBet.PayOut(winner);
        }
    }
}
