using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ch4_hitTheKey
{
    public partial class Form1 : Form
    {
        Random m_random = new Random();
        Stats m_stator = new Stats();

        public Form1()
        {
            InitializeComponent();
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            listBox_string.Items.Add((Keys)m_random.Next(65, 90));

            if(listBox_string.Items.Count > 700 )
            {
                listBox_string.Items.Clear();
                listBox_string.Items.Add("Game overe");
                timer1.Stop();
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {

            if( listBox_string.Items.Contains( e.KeyCode) )
            {
                listBox_string.Items.Remove(e.KeyCode);
                listBox_string.Refresh();

                if( timer1.Interval > 400 )
                {
                    timer1.Interval -= 10;
                }
                else if (timer1.Interval > 250)
                {
                    timer1.Interval -= 7;
                }
                else if (timer1.Interval > 100)
                {
                    timer1.Interval -= 2;
                }

                difficultyProgressBar.Value = 800 - timer1.Interval;

                m_stator.Update(true);
            }
            else
            {
                m_stator.Update(false);
            }

            correctLabel.Text = "Correct : " + m_stator.Correct;
            missedLabel.Text = "Missed : " + m_stator.Missed;
            totalLabel.Text = "Total : " + m_stator.Total;
            accuracyLabel.Text = "Accuracy : " + m_stator.Accuracy + " %";
        }

        private void listBox_string_KeyUp(object sender, KeyEventArgs e)
        {

        }
    }
}
