using Newtonsoft.Json;
using System;
using System.IO;
using System.Windows.Forms;

namespace Game
{
    public partial class ScoreView : Form
    {
        ScoreData scoreData;
        public ScoreView()
        {
            InitializeComponent();
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sofka --- Challenge";
            LoadScoreJson();
            printScores();
        }
        void LoadScoreJson()
        {
            string filePath = @"scores.json";
            using (StreamReader r = new StreamReader(filePath))
            {
                string json = r.ReadToEnd();
                scoreData = JsonConvert.DeserializeObject<ScoreData>(json);
            }

        }

        void printScores()
        {
            scoreData.scores.Reverse();
            for (int i = 0; i < scoreData.scores.Count; i++)
            {
                string playerScoreText;
                playerScoreText = $"{scoreData.scores[i].playerName } ---  {scoreData.scores[i].scoreValue}\n";
                labelList.Text = labelList.Text + playerScoreText;
            }
        }
        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form gamePlay = new Welcome();
            gamePlay.Show();
        }
    }
}
