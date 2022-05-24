using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ch4_type
{
    class Elephant
    {
        public string name;
        public double dEarSize;

        public void WhoAmI()
        {
            MessageBox.Show("I am " + name + ", and ear size is " + dEarSize );
        }
    }
}
