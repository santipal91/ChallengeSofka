using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Game
{
    public partial class Logo : Form
    {
        public Logo()
        {
            InitializeComponent();
            timer1.Enabled = true;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Hide();
            Form gamePlay = new Welcome();
            gamePlay.Show();
            timer1.Enabled = false;



        }
    }
}
