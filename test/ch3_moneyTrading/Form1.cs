using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ch3_moneyTrading
{
    public partial class Form1 : Form
    {
        Guy joe;
        Guy bob;
        int bank = 100;

        public Form1()
        {
            InitializeComponent();

//            joe = new Guy();
//            joe.name = "Joe";
//            joe.Cash = 50;
            joe = new Guy() { Cash = 50, name = "Joe" };

//            bob = new Guy();
//            bob.name = "Bob";
//            bob.Cash = 100;
            bob = new Guy() { Cash = 100, name = "Bob" };

            updateForm();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void updateForm()
        {
            label_moneyOfJoe.Text = joe.name + " has $" + joe.Cash;
            label_moneyOfBob.Text = bob.name + " has $" + bob.Cash;
            label_moneyOfBank.Text = "The bank" + " has $" + bank;
        }

        private void button_giveMoneyToJoe_Click(object sender, EventArgs e)
        {
            if( bank >= 10 )
            {
                bank -= joe.ReceiveCash(10);
                updateForm();
            }
            else
            {
                MessageBox.Show("The bank is out of money");
            }
        }

        private void button_getMoneyToBob_Click(object sender, EventArgs e)
        {
            bank += bob.GiveCash(5);
            updateForm();
        }

        private void btn_joeGiveToBob_Click(object sender, EventArgs e)
        {
            bob.ReceiveCash(joe.GiveCash(10));
            updateForm();
        }

        private void btn_bobGiveToJoe_Click(object sender, EventArgs e)
        {
            joe.ReceiveCash(bob.GiveCash(5));
            updateForm();
        }
    }
}
