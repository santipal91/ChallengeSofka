using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game
{
    public partial class Form1 : Form
    {
        Data data;
        public Form1()
        {
            InitializeComponent();
            LoadJson();
            startGame();
            scoreValue();
        }


        void LoadJson()
        {
            string filePath = @"questions.json";
            using (StreamReader r = new StreamReader(filePath))
            {
                string json = r.ReadToEnd();
                data = JsonConvert.DeserializeObject<Data>(json);
            }

        }

        void startGame() 
        {
            for (int currentLevel = 0; currentLevel < data.levels.Count; currentLevel++)
            {
                Question question = getQuestionForLevel(currentLevel);
                displayQuestionToUser(question);
                updateProgressBar(currentLevel);
               
            }
            
        }

        Question getQuestionForLevel(int level)
        {
            Random random = new Random();
            int randomNumber = random.Next(0, 5);
            return data.levels[level].questions[randomNumber];
        
        }

        void displayQuestionToUser(Question question)
        {
            Quest1.Text = question.description;
            Ans1.Text = question.options[0].description;
            Ans2.Text = question.options[1].description;
            Ans3.Text = question.options[2].description;
            Ans4.Text = question.options[3].description;

        }

        void scoreValue()
        {
            int scoreValue = 0;
            scoreValue1.Text = scoreValue.ToString();
        }

        void updateProgressBar(int progress)
        {
            progressBar1.Value = progress+1;
        }


        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}
