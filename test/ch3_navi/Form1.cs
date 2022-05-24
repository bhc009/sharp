using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ch3_navi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_speak_Click(object sender, EventArgs e)
        {
            int len = Talker.BlahBlahBlah(tb_saying.Text, (int)(nud_iteration.Value));

            MessageBox.Show("The message length is " + len);
        }
    }
}
