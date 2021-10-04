using System;
using System.Windows.Forms;

namespace Game
{
    public partial class Welcome : Form
    {
        public Welcome()
        {
            InitializeComponent();
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sofka --- Challenge";
        }

        private void Jugar1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form formulario = new GamePlay(textBoxPlayerName.Text);
            formulario.Show();
        }

        private void Instrucciones1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form formulario = new Instructions();
            formulario.Show();
        }

        private void btn_score_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form formulario = new ScoreView();
            formulario.Show();
        }
    }
}
