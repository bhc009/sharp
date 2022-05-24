using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ch3_moneyTrading
{
    class Guy
    {
        public string name;
        public int Cash;

        public int GiveCash( int amount )
        {
            if( amount <= Cash && amount>0 )
            {
                Cash -= amount;
                return amount;
            } 
            else
            {
                MessageBox.Show("not enough money : " + amount, name + " says...");
                return 0;
            }
        }


        public int ReceiveCash( int amount )
        {
            if( amount>0)
            {
                Cash += amount;
                return amount;
            }
            else
            {
                MessageBox.Show(amount + " is not an amount.", name + " says...");
                return 0;
            }
        }
    }
}
