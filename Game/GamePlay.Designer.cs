
namespace Game
{
    partial class GamePlay
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Ans1 = new System.Windows.Forms.Button();
            this.Ans2 = new System.Windows.Forms.Button();
            this.Ans3 = new System.Windows.Forms.Button();
            this.Ans4 = new System.Windows.Forms.Button();
            this.SCORE = new System.Windows.Forms.Label();
            this.Quest1 = new System.Windows.Forms.Label();
            this.scoreValue1 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.labelPlayer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Ans1
            // 
            this.Ans1.Location = new System.Drawing.Point(22, 261);
            this.Ans1.Name = "Ans1";
            this.Ans1.Size = new System.Drawing.Size(310, 53);
            this.Ans1.TabIndex = 0;
            this.Ans1.Text = "2";
            this.Ans1.UseVisualStyleBackColor = true;
            this.Ans1.Click += new System.EventHandler(this.Ans1_Click);
            // 
            // Ans2
            // 
            this.Ans2.Location = new System.Drawing.Point(393, 261);
            this.Ans2.Name = "Ans2";
            this.Ans2.Size = new System.Drawing.Size(310, 53);
            this.Ans2.TabIndex = 1;
            this.Ans2.Text = "3";
            this.Ans2.UseVisualStyleBackColor = true;
            this.Ans2.Click += new System.EventHandler(this.Ans2_Click);
            // 
            // Ans3
            // 
            this.Ans3.Location = new System.Drawing.Point(22, 344);
            this.Ans3.Name = "Ans3";
            this.Ans3.Size = new System.Drawing.Size(310, 53);
            this.Ans3.TabIndex = 2;
            this.Ans3.Text = "12";
            this.Ans3.UseVisualStyleBackColor = true;
            this.Ans3.Click += new System.EventHandler(this.Ans3_Click);
            // 
            // Ans4
            // 
            this.Ans4.Location = new System.Drawing.Point(393, 344);
            this.Ans4.Name = "Ans4";
            this.Ans4.Size = new System.Drawing.Size(310, 53);
            this.Ans4.TabIndex = 3;
            this.Ans4.Text = "6";
            this.Ans4.UseVisualStyleBackColor = true;
            this.Ans4.Click += new System.EventHandler(this.Ans4_Click);
            // 
            // SCORE
            // 
            this.SCORE.AutoSize = true;
            this.SCORE.Font = new System.Drawing.Font("Showcard Gothic", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SCORE.Location = new System.Drawing.Point(782, 9);
            this.SCORE.Name = "SCORE";
            this.SCORE.Size = new System.Drawing.Size(168, 59);
            this.SCORE.TabIndex = 4;
            this.SCORE.Text = "SCORE";
            this.SCORE.Click += new System.EventHandler(this.SCORE_Click);
            // 
            // Quest1
            // 
            this.Quest1.AutoSize = true;
            this.Quest1.Font = new System.Drawing.Font("MV Boli", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Quest1.Location = new System.Drawing.Point(40, 86);
            this.Quest1.MaximumSize = new System.Drawing.Size(700, 0);
            this.Quest1.Name = "Quest1";
            this.Quest1.Size = new System.Drawing.Size(700, 40);
            this.Quest1.TabIndex = 5;
            this.Quest1.Text = "Cuantos pistones tiene un motor de 6 cilindros";
            // 
            // scoreValue1
            // 
            this.scoreValue1.AutoSize = true;
            this.scoreValue1.Font = new System.Drawing.Font("Showcard Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.scoreValue1.Location = new System.Drawing.Point(798, 83);
            this.scoreValue1.Name = "scoreValue1";
            this.scoreValue1.Size = new System.Drawing.Size(128, 42);
            this.scoreValue1.TabIndex = 6;
            this.scoreValue1.Text = "label3";
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("MV Boli", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button5.Location = new System.Drawing.Point(798, 261);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(152, 43);
            this.button5.TabIndex = 7;
            this.button5.Text = "Retiro Seguro";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.progressBar1.Location = new System.Drawing.Point(798, 344);
            this.progressBar1.Maximum = 5;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(152, 29);
            this.progressBar1.Step = 4;
            this.progressBar1.TabIndex = 8;
            // 
            // labelPlayer
            // 
            this.labelPlayer.AutoSize = true;
            this.labelPlayer.Location = new System.Drawing.Point(843, 421);
            this.labelPlayer.Name = "labelPlayer";
            this.labelPlayer.Size = new System.Drawing.Size(50, 20);
            this.labelPlayer.TabIndex = 9;
            this.labelPlayer.Text = "label1";
            this.labelPlayer.Click += new System.EventHandler(this.labelPlayer_Click);
            // 
            // GamePlay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1001, 450);
            this.Controls.Add(this.labelPlayer);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.scoreValue1);
            this.Controls.Add(this.Quest1);
            this.Controls.Add(this.SCORE);
            this.Controls.Add(this.Ans4);
            this.Controls.Add(this.Ans3);
            this.Controls.Add(this.Ans2);
            this.Controls.Add(this.Ans1);
            this.MaximumSize = new System.Drawing.Size(1019, 497);
            this.Name = "GamePlay";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Ans1;
        private System.Windows.Forms.Button Ans2;
        private System.Windows.Forms.Button Ans3;
        private System.Windows.Forms.Button Ans4;
        private System.Windows.Forms.Label SCORE;
        private System.Windows.Forms.Label Quest1;
        private System.Windows.Forms.Label scoreValue1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.ProgressBar progressBar1;
        public System.Windows.Forms.Label labelPlayer;
    }
}

