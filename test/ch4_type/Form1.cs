using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ch4_type
{
    public partial class Form1 : Form
    {
        double dRatio = 0.39;
        double dAmountOwed = 0;

        Elephant lloyd;
        Elephant lucinda;

        public Form1()
        {
            InitializeComponent();

            //
            lloyd = new Elephant() { name = "lloyd", dEarSize = 33.0 } ;
            lucinda = new Elephant() { name = "lucinda", dEarSize = 40.0 };



            //
            MenuMaker menu = new MenuMaker() { m_randomizer = new Random() };

            label_menu_1.Text = menu.GetMenuItem();
            label_menu_2.Text = menu.GetMenuItem();
            label_menu_3.Text = menu.GetMenuItem();
            label_menu_4.Text = menu.GetMenuItem();
            label_menu_5.Text = menu.GetMenuItem();
            label_menu_6.Text = menu.GetMenuItem();
        }

        private void btn_set_Click(object sender, EventArgs e)
        {
            decimal decVal = 10;
            int iVal = (int)decVal;
            MessageBox.Show("The my int val is " + iVal);
        }

        private void btn_calculate_Click(object sender, EventArgs e)
        {
            int iStart = (int)nud_start.Value;
            int iEnd = (int)nud_end.Value;

            if(iEnd > iStart)
            {
                int iTravel = iEnd - iStart;
                dAmountOwed = dRatio * iTravel;

                label_own.Text = "$" + dAmountOwed;
            }
        }

        private void btn_lloyd_Click(object sender, EventArgs e)
        {
            lloyd.WhoAmI();
        }

        private void btn_lucinda_Click(object sender, EventArgs e)
        {
            lucinda.WhoAmI();
        }

        private void btn_swap_Click(object sender, EventArgs e)
        {
            Elephant holder;
            holder = lloyd;
            lloyd = lucinda;
            lucinda = holder;

            MessageBox.Show("Swap!");
        }
    }
}
