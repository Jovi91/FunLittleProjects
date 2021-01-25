using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace DogRace
{
  [Serializable]  
    public partial class Form1 : Form
    {
        Guy[] Guys = new Guy[3];
        Greyhound[] Greyhounds = new Greyhound[4];
        int checkedGuyIndex;

        public Form1()
        {
            InitializeComponent();

            checkedGuyIndex = 2;
            UpdateForm(); 

            Guys[0] = new Guy("Arek", 45, rb_Arek, l_ArekInfo);
            Guys[1] = new Guy("Bartek", 75, rb_Bartek, l_BartekInfo);
            Guys[2] = new Guy("Janek", 50, rb_Janek, l_JanekInfo);

            for (int i = 0; i < Guys.Length; i++)
            {
                    Guys[i].UpdateLabel();         
            }
            l_BettorName.Text = "Janek";    

            Greyhounds[0] = new Greyhound(1, pb_DogNo1);
            Greyhounds[1] = new Greyhound(2, pb_DogNo2);
            Greyhounds[2] = new Greyhound(3, pb_DogNo3);
            Greyhounds[3] = new Greyhound(4, pb_DogNo4);
            }

        //serializacja








        private void b_PaceTheBet_Click(object sender, EventArgs e)
        {
           

            l_BettorName.Text = Guys[checkedGuyIndex].Name;
            
            if(!Guys[checkedGuyIndex].PlaceBet((int)nud_BetMoney.Value, (int)nud_DogsNumber.Value))
                MessageBox.Show(Guys[checkedGuyIndex].Name + " ma niewystarczającą ilość gotówki by postawić zakład.");
            Guys[checkedGuyIndex].UpdateLabel();
        }

        private void b_StartRace_Click(object sender, EventArgs e)
        {
            gb_BetPlaceArea.Enabled = false;
            int i=0;
            bool winner = false;
            while (!winner)
            {
                for (i = 0; i < 4; i++)
                {
                    winner=Greyhounds[i].Run();
                    if (winner)
                        break;
                }
                Thread.Sleep(30);
                
            }

            int dogNumber = i+1;

            MessageBox.Show("Wygrał pies numer " + dogNumber);

            for (int j = 0; j < Guys.Length; j++)
            {
                if (Guys[j].MyBet != null)
                {
                    Guys[j].Collect(dogNumber);
                    Guys[j].ClearBet();
                    Guys[j].UpdateLabel();
                }


            }

            for (int k = 0; k < Greyhounds.Length; k++)
            {
                Greyhounds[k].TakeStartingPosition();

            }

            gb_BetPlaceArea.Enabled = true;



        }


        private void rb_Bartek_Click(object sender, EventArgs e)
        {
            l_BettorName.Text = "Bartek";

        }

        private void rb_Arek_Click(object sender, EventArgs e)
        {
            l_BettorName.Text = "Arek";
        }

        private void b_savePlayerResult_Click(object sender, EventArgs e)
        {
            using (Stream output = File.Create(@"C:\Users\jowit\source\repos\HeadFirstProjects\DogRace\GuysResults\wyniki" + Guys[checkedGuyIndex].Name + ".dat"))
            {
                BinaryFormatter formatter = new BinaryFormatter();       
                
                //wYWALA MI TU BŁĄd. chyba z powodu kontrolek jako pola klasy, która ma być serializowana (Guy). Bo nie są oznaczone jako do serializacji
                //ehh 
                //formatter.Serialize(output, Guys[checkedGuyIndex]);
            }

        }

        public void UpdateForm()
        {
            string name="Janka";
            switch(checkedGuyIndex)
            {
                case 0: name = "Arka"; break;
                case 1: name = "Bartka"; break;
                case 2: name = "Janka"; break;
            }

            b_loadPlayeerResult.Text = "Załaduj wynik " + name;
            b_savePlayerResult.Text = "Zapisz wynik " + name;
        }

        private void rb_Janek_CheckedChanged(object sender, EventArgs e)
        {
            if(rb_Janek.Checked)
                checkedGuyIndex = 2;
            UpdateForm();
        }

        private void rb_Bartek_CheckedChanged(object sender, EventArgs e)
        {
            if(rb_Bartek.Checked)
                checkedGuyIndex = 1;
            UpdateForm();
        }

        private void rb_Arek_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_Arek.Checked)
                checkedGuyIndex = 0;
            UpdateForm();
        }
    }
}
