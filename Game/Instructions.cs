using System;
using System.Windows.Forms;

namespace Game
{
    public partial class Instructions : Form
    {
        public Instructions()
        {
            InitializeComponent();
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sofka --- Challenge";
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form gamePlay = new Welcome();
            gamePlay.Show();
        }
    }
}
