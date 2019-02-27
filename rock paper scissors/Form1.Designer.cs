namespace rock_paper_scissors
{
    partial class Form1
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
            this.player2 = new System.Windows.Forms.PictureBox();
            this.player1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.player1ScoreLabel = new System.Windows.Forms.Label();
            this.Player2ScoreLabel = new System.Windows.Forms.Label();
            this.playButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.dfdfd = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.player1HighScore = new System.Windows.Forms.Label();
            this.player2HighScore = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.player2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player1)).BeginInit();
            this.SuspendLayout();
            // 
            // player2
            // 
            this.player2.Location = new System.Drawing.Point(477, 55);
            this.player2.Name = "player2";
            this.player2.Size = new System.Drawing.Size(200, 229);
            this.player2.TabIndex = 0;
            this.player2.TabStop = false;
            // 
            // player1
            // 
            this.player1.Location = new System.Drawing.Point(78, 55);
            this.player1.Name = "player1";
            this.player1.Size = new System.Drawing.Size(200, 229);
            this.player1.TabIndex = 1;
            this.player1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Player 1: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(474, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Player 2: ";
            // 
            // player1ScoreLabel
            // 
            this.player1ScoreLabel.AutoSize = true;
            this.player1ScoreLabel.Location = new System.Drawing.Point(142, 24);
            this.player1ScoreLabel.Name = "player1ScoreLabel";
            this.player1ScoreLabel.Size = new System.Drawing.Size(16, 17);
            this.player1ScoreLabel.TabIndex = 4;
            this.player1ScoreLabel.Text = "0";
            // 
            // Player2ScoreLabel
            // 
            this.Player2ScoreLabel.AutoSize = true;
            this.Player2ScoreLabel.Location = new System.Drawing.Point(541, 24);
            this.Player2ScoreLabel.Name = "Player2ScoreLabel";
            this.Player2ScoreLabel.Size = new System.Drawing.Size(16, 17);
            this.Player2ScoreLabel.TabIndex = 5;
            this.Player2ScoreLabel.Text = "0";
            // 
            // playButton
            // 
            this.playButton.Location = new System.Drawing.Point(78, 327);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(286, 41);
            this.playButton.TabIndex = 6;
            this.playButton.Text = "Play";
            this.playButton.UseVisualStyleBackColor = true;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(391, 327);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(286, 41);
            this.resetButton.TabIndex = 7;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // dfdfd
            // 
            this.dfdfd.AutoSize = true;
            this.dfdfd.Location = new System.Drawing.Point(78, 401);
            this.dfdfd.Name = "dfdfd";
            this.dfdfd.Size = new System.Drawing.Size(134, 17);
            this.dfdfd.TabIndex = 8;
            this.dfdfd.Text = "Player 1 HighScore:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(474, 401);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Player 2 HighScore:";
            // 
            // player1HighScore
            // 
            this.player1HighScore.AutoSize = true;
            this.player1HighScore.Location = new System.Drawing.Point(214, 401);
            this.player1HighScore.Name = "player1HighScore";
            this.player1HighScore.Size = new System.Drawing.Size(16, 17);
            this.player1HighScore.TabIndex = 10;
            this.player1HighScore.Text = "0";
            // 
            // player2HighScore
            // 
            this.player2HighScore.AutoSize = true;
            this.player2HighScore.Location = new System.Drawing.Point(610, 401);
            this.player2HighScore.Name = "player2HighScore";
            this.player2HighScore.Size = new System.Drawing.Size(46, 17);
            this.player2HighScore.TabIndex = 11;
            this.player2HighScore.Text = "label5";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.player2HighScore);
            this.Controls.Add(this.player1HighScore);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dfdfd);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.playButton);
            this.Controls.Add(this.Player2ScoreLabel);
            this.Controls.Add(this.player1ScoreLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.player1);
            this.Controls.Add(this.player2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.player2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox player2;
        private System.Windows.Forms.PictureBox player1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label player1ScoreLabel;
        private System.Windows.Forms.Label Player2ScoreLabel;
        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Label dfdfd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label player1HighScore;
        private System.Windows.Forms.Label player2HighScore;
    }
}

