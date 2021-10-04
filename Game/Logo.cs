using System;
using System.Windows.Forms;

namespace Game
{
    public partial class Logo : Form
    {
        public Logo()
        {
            InitializeComponent();
            timer1.Enabled = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sofka --- Challenge";
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
