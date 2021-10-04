using Newtonsoft.Json;
using System;
using System.IO;
using System.Windows.Forms;

namespace Game
{
    public partial class GamePlay : Form
    {
        Data data;
        int scoreValue;
        int currentLevel;
        int levelsCount;
        Question currentQuestion;
        ScoreData scoreData;
        string player;
        public GamePlay(string playerName)
        {
            InitializeComponent();
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sofka --- Challenge";
            LoadJson();
            LoadScoreJson();
            startGame();
            player = playerName;

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
            scoreValue = 0;
            currentLevel = 0;
            levelsCount = data.levels.Count;
            updateProgress();
            nextQuestion();

        }

        void nextQuestion()
        {
            if (currentLevel < levelsCount)
            {
                currentQuestion = getQuestionForLevel(currentLevel);
                displayQuestionToUser(currentQuestion);
            }
            else
            {
                savePlayerScore();
                this.Hide();
                Form scoreView = new ScoreView();
                scoreView.Show();
            }
        }

        void checkAnswer(int answer)
        {
            if (currentQuestion.options[answer].isCorrect)
            {
                scoreValue = scoreValue + ((currentLevel + 1) * 100);
                currentLevel++;
                nextQuestion();
                updateProgress();
            }
            else
            {
                gameOver();
            }

        }

        void gameOver()
        {
            scoreValue = 0;
            savePlayerScore();
            this.Hide();
            Form scoreView = new ScoreView();
            scoreView.Show();
        }

        Question getQuestionForLevel(int level)
        {
            Random random = new Random();
            int randomNumber = random.Next(0, 5);
            return data.levels[level].questions[randomNumber];

        }

        void savePlayerScore()
        {
            Score score = new Score(); ;
            score.playerName = player;
            score.scoreValue = scoreValue;
            scoreData.scores.Add(score);
            JsonSerializer serializer = new JsonSerializer();
            serializer.NullValueHandling = NullValueHandling.Ignore;

            using (StreamWriter sw = new StreamWriter(@"scores.json"))
            using (JsonWriter writer = new JsonTextWriter(sw))
            {
                serializer.Serialize(writer, scoreData);

            }
        }

        void displayQuestionToUser(Question question)
        {
            Quest1.Text = question.description;
            Ans1.Text = question.options[0].description;
            Ans2.Text = question.options[1].description;
            Ans3.Text = question.options[2].description;
            Ans4.Text = question.options[3].description;

        }
        void updateProgress()
        {
            if (currentLevel <= levelsCount)
            {
                scoreValue1.Text = scoreValue.ToString();
                progressBar1.Value = currentLevel;
            }
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

        private void Ans1_Click(object sender, EventArgs e)
        {
            checkAnswer(0);
        }
        private void Ans2_Click(object sender, EventArgs e)
        {
            checkAnswer(1);
        }

        private void Ans3_Click(object sender, EventArgs e)
        {
            checkAnswer(2);
        }
        private void Ans4_Click(object sender, EventArgs e)
        {
            checkAnswer(3);
        }
        private void button5_Click(object sender, EventArgs e)
        {
            savePlayerScore();
            this.Hide();
            Form scoreView = new ScoreView();
            scoreView.Show();
        }
    }
}
