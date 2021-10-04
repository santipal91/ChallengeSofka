
namespace Game
{
    partial class Welcome
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Jugar1 = new System.Windows.Forms.Button();
            this.Instrucciones1 = new System.Windows.Forms.Button();
            this.Bienvenido1 = new System.Windows.Forms.Label();
            this.btn_score = new System.Windows.Forms.Button();
            this.textBoxPlayerName = new System.Windows.Forms.TextBox();
            this.lblGamePlayer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Jugar1
            // 
            this.Jugar1.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Jugar1.Location = new System.Drawing.Point(773, 335);
            this.Jugar1.Name = "Jugar1";
            this.Jugar1.Size = new System.Drawing.Size(255, 66);
            this.Jugar1.TabIndex = 0;
            this.Jugar1.Text = "Jugar!";
            this.Jugar1.UseVisualStyleBackColor = true;
            this.Jugar1.Click += new System.EventHandler(this.Jugar1_Click);
            // 
            // Instrucciones1
            // 
            this.Instrucciones1.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Instrucciones1.Location = new System.Drawing.Point(773, 483);
            this.Instrucciones1.Name = "Instrucciones1";
            this.Instrucciones1.Size = new System.Drawing.Size(255, 66);
            this.Instrucciones1.TabIndex = 1;
            this.Instrucciones1.Text = "Instrucciones";
            this.Instrucciones1.UseVisualStyleBackColor = true;
            this.Instrucciones1.Click += new System.EventHandler(this.Instrucciones1_Click);
            // 
            // Bienvenido1
            // 
            this.Bienvenido1.AutoSize = true;
            this.Bienvenido1.Font = new System.Drawing.Font("Showcard Gothic", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Bienvenido1.Location = new System.Drawing.Point(228, 98);
            this.Bienvenido1.Name = "Bienvenido1";
            this.Bienvenido1.Size = new System.Drawing.Size(633, 98);
            this.Bienvenido1.TabIndex = 2;
            this.Bienvenido1.Text = "Bienvenido !!!";
            // 
            // btn_score
            // 
            this.btn_score.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_score.Location = new System.Drawing.Point(228, 483);
            this.btn_score.Name = "btn_score";
            this.btn_score.Size = new System.Drawing.Size(255, 66);
            this.btn_score.TabIndex = 3;
            this.btn_score.Text = "Puntajes";
            this.btn_score.UseVisualStyleBackColor = true;
            this.btn_score.Click += new System.EventHandler(this.btn_score_Click);
            // 
            // textBoxPlayerName
            // 
            this.textBoxPlayerName.Location = new System.Drawing.Point(228, 358);
            this.textBoxPlayerName.Name = "textBoxPlayerName";
            this.textBoxPlayerName.Size = new System.Drawing.Size(504, 27);
            this.textBoxPlayerName.TabIndex = 4;
            // 
            // lblGamePlayer
            // 
            this.lblGamePlayer.AutoSize = true;
            this.lblGamePlayer.Font = new System.Drawing.Font("MV Boli", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblGamePlayer.Location = new System.Drawing.Point(228, 321);
            this.lblGamePlayer.Name = "lblGamePlayer";
            this.lblGamePlayer.Size = new System.Drawing.Size(312, 22);
            this.lblGamePlayer.TabIndex = 5;
            this.lblGamePlayer.Text = "Ingrese su nombre y presione jugar.....";
            // 
            // Welcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1214, 699);
            this.Controls.Add(this.lblGamePlayer);
            this.Controls.Add(this.textBoxPlayerName);
            this.Controls.Add(this.btn_score);
            this.Controls.Add(this.Bienvenido1);
            this.Controls.Add(this.Instrucciones1);
            this.Controls.Add(this.Jugar1);
            this.Name = "Welcome";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Jugar1;
        private System.Windows.Forms.Button Instrucciones1;
        private System.Windows.Forms.Label Bienvenido1;
        private System.Windows.Forms.Button btn_score;
        private System.Windows.Forms.TextBox textBoxPlayerName;
        private System.Windows.Forms.Label lblGamePlayer;
    }
}