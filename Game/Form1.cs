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
            
            int randomNumber = 0; /*buscar funcion que devuelva un numero random entre dos limites*/
            return data.levels[level].questions[randomNumber];
        
        }

        void displayQuestionToUser(Question question)
        {
            label2.Text = question.description;
            button1.Text = question.options[0].description;
        }

        void updateProgressBar(int progress)
        {
            progressBar1.Value = progress;
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
    }
}
