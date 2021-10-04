using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Game
{
    public partial class ScoreView : Form
    {
        ScoreData scoreData;
        public ScoreView()
        {
            InitializeComponent();
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

        private void labelList_Click(object sender, EventArgs e)
        {

        }

        private void labelTitle_Click(object sender, EventArgs e)
        {

        }
    }
}
