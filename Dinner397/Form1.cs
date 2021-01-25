using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dinner397
{
    public partial class Form1 : Form
    {
        Queue<Lumberjack> breakFastLine;
        //Lumberjack currentLumberjack;
        public Form1()
        {
            InitializeComponent();
            breakFastLine = new Queue<Lumberjack>();
            b_getNextLumberjack.Enabled = false;

        }

        private void b_addLuberjack_Click(object sender, EventArgs e)
        {

            breakFastLine.Enqueue(new Lumberjack(tb_lumberjackName.Text));
            tb_lumberjackName.Text = "";
            RedrawList();
        }

        public void RedrawList()
        {
            int i = 1;
            lb_queueOfLuberjacks.Items.Clear();
            foreach (Lumberjack lumberjack in breakFastLine)
            {
                lb_queueOfLuberjacks.Items.Add(i.ToString() + ". " + lumberjack.Name);
                i++;
            }

            if (breakFastLine.Count == 0)
            {
                gb_feedLuberjeck.Enabled = false;
                tb_currentLumberjack.Text = "";

            }
            else
            {
                gb_feedLuberjeck.Enabled = true;
                Lumberjack currentLumberjack = breakFastLine.Peek();
                tb_currentLumberjack.Text = currentLumberjack.Name + " ma " + currentLumberjack.FlapjackCount.ToString() + " naleśników";

            }
            
        }

        private void b_addFlapjacks_Click(object sender, EventArgs e)
        {
           

            Lumberjack.Flapjack food;
            if (rb_crispy.Checked)
                food = Lumberjack.Flapjack.chrupkiego;
            else if (rb_soggy.Checked)
                food = Lumberjack.Flapjack.wilgotnego;
            else if (rb_browned.Checked)
                food = Lumberjack.Flapjack.rumianego;
            else
                food = Lumberjack.Flapjack.banaowego;

            Lumberjack currentLumberjack = breakFastLine.Peek();
            currentLumberjack.TakeFlapjack(food, (int)nud_howMany.Value);
            b_getNextLumberjack.Enabled = true;
            RedrawList();
            
        }

        private void b_getNextLumberjack_Click(object sender, EventArgs e)
        {


           Lumberjack currentLumberjack=breakFastLine.Dequeue();
            currentLumberjack.EatFlapjacks();
            RedrawList();
            b_getNextLumberjack.Enabled = false;
        }
    }
}
