using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_ChangeText_Click(object sender, EventArgs e)
        {
            if( cb_enableChange.Checked == true )
            {
                if( label_toChange.Text == "Right")
                {
                    label_toChange.Text = "Left";
                    label_toChange.TextAlign = ContentAlignment.MiddleLeft;
                }
                else
                {
                    label_toChange.Text = "Right";
                    label_toChange.TextAlign = ContentAlignment.MiddleRight;
                }
            }
            else
            {
                label_toChange.Text = "Text changing is disabled";
                label_toChange.TextAlign = ContentAlignment.MiddleCenter;
            }
        }
    }
}
