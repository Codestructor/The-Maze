namespace Maze_v1._0
{
    partial class MazeMap
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
            this.components = new System.ComponentModel.Container();
            this.moveLbl = new System.Windows.Forms.Label();
            this.characterTmer = new System.Windows.Forms.Timer(this.components);
            this.minimizePB = new System.Windows.Forms.PictureBox();
            this.closePB = new System.Windows.Forms.PictureBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.timeSpanTimer = new System.Windows.Forms.Timer(this.components);
            this.lblTimeSpan = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblPlayingAs = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.lblScoreVal = new System.Windows.Forms.Label();
            this.lblShowSol = new System.Windows.Forms.Label();
            this.checkForPauseTimer = new System.Windows.Forms.Timer(this.components);
            this.lblPaused = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.minimizePB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closePB)).BeginInit();
            this.SuspendLayout();
            // 
            // moveLbl
            // 
            this.moveLbl.BackColor = System.Drawing.Color.RoyalBlue;
            this.moveLbl.Font = new System.Drawing.Font("Monotype Corsiva", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.moveLbl.Location = new System.Drawing.Point(-1, 0);
            this.moveLbl.Name = "moveLbl";
            this.moveLbl.Size = new System.Drawing.Size(800, 40);
            this.moveLbl.TabIndex = 0;
            this.moveLbl.Text = "The Star Maze";
            this.moveLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.moveLbl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.moveLbl_MouseDown);
            // 
            // characterTmer
            // 
            this.characterTmer.Enabled = true;
            this.characterTmer.Interval = 30;
            this.characterTmer.Tick += new System.EventHandler(this.characterTmer_Tick);
            // 
            // minimizePB
            // 
            this.minimizePB.BackColor = System.Drawing.Color.RoyalBlue;
            this.minimizePB.Image = global::Maze_v1._0.Properties.Resources.MinimizeBtn;
            this.minimizePB.Location = new System.Drawing.Point(713, 0);
            this.minimizePB.Name = "minimizePB";
            this.minimizePB.Size = new System.Drawing.Size(40, 40);
            this.minimizePB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.minimizePB.TabIndex = 2;
            this.minimizePB.TabStop = false;
            this.minimizePB.Click += new System.EventHandler(this.minimizePB_Click);
            // 
            // closePB
            // 
            this.closePB.BackColor = System.Drawing.Color.RoyalBlue;
            this.closePB.Image = global::Maze_v1._0.Properties.Resources.CloseBtnFinal;
            this.closePB.Location = new System.Drawing.Point(759, 0);
            this.closePB.Name = "closePB";
            this.closePB.Size = new System.Drawing.Size(40, 40);
            this.closePB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.closePB.TabIndex = 1;
            this.closePB.TabStop = false;
            this.closePB.Click += new System.EventHandler(this.closePB_Click);
            // 
            // timeSpanTimer
            // 
            this.timeSpanTimer.Tick += new System.EventHandler(this.timeSpanTimer_Tick);
            // 
            // lblTimeSpan
            // 
            this.lblTimeSpan.AutoSize = true;
            this.lblTimeSpan.Font = new System.Drawing.Font("Monotype Corsiva", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimeSpan.Location = new System.Drawing.Point(892, 198);
            this.lblTimeSpan.Name = "lblTimeSpan";
            this.lblTimeSpan.Size = new System.Drawing.Size(56, 24);
            this.lblTimeSpan.TabIndex = 11;
            this.lblTimeSpan.Text = "00:00";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(866, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 24);
            this.label2.TabIndex = 12;
            this.label2.Text = "Time Elapsed:";
            // 
            // lblPlayingAs
            // 
            this.lblPlayingAs.AutoSize = true;
            this.lblPlayingAs.Font = new System.Drawing.Font("Monotype Corsiva", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayingAs.ForeColor = System.Drawing.Color.Gray;
            this.lblPlayingAs.Location = new System.Drawing.Point(882, 235);
            this.lblPlayingAs.Name = "lblPlayingAs";
            this.lblPlayingAs.Size = new System.Drawing.Size(98, 24);
            this.lblPlayingAs.TabIndex = 13;
            this.lblPlayingAs.Text = "Playing as:";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Monotype Corsiva", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(893, 270);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(55, 24);
            this.lblUsername.TabIndex = 14;
            this.lblUsername.Text = "Guest";
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Monotype Corsiva", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.ForeColor = System.Drawing.Color.Gray;
            this.lblScore.Location = new System.Drawing.Point(893, 310);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(58, 24);
            this.lblScore.TabIndex = 15;
            this.lblScore.Text = "Score:";
            // 
            // lblScoreVal
            // 
            this.lblScoreVal.AutoSize = true;
            this.lblScoreVal.Font = new System.Drawing.Font("Monotype Corsiva", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScoreVal.Location = new System.Drawing.Point(905, 349);
            this.lblScoreVal.Name = "lblScoreVal";
            this.lblScoreVal.Size = new System.Drawing.Size(50, 24);
            this.lblScoreVal.TabIndex = 16;
            this.lblScoreVal.Text = "0000";
            // 
            // lblShowSol
            // 
            this.lblShowSol.BackColor = System.Drawing.Color.RoyalBlue;
            this.lblShowSol.Font = new System.Drawing.Font("Monotype Corsiva", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblShowSol.Location = new System.Drawing.Point(404, 450);
            this.lblShowSol.Name = "lblShowSol";
            this.lblShowSol.Size = new System.Drawing.Size(159, 27);
            this.lblShowSol.TabIndex = 17;
            this.lblShowSol.Text = "Show Solution";
            this.lblShowSol.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblShowSol.Click += new System.EventHandler(this.lblShowSol_Click);
            // 
            // checkForPauseTimer
            // 
            this.checkForPauseTimer.Interval = 30;
            this.checkForPauseTimer.Tick += new System.EventHandler(this.checkForPauseTimer_Tick);
            // 
            // lblPaused
            // 
            this.lblPaused.BackColor = System.Drawing.Color.RoyalBlue;
            this.lblPaused.Font = new System.Drawing.Font("Monotype Corsiva", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblPaused.Location = new System.Drawing.Point(287, 131);
            this.lblPaused.Name = "lblPaused";
            this.lblPaused.Size = new System.Drawing.Size(256, 163);
            this.lblPaused.TabIndex = 18;
            this.lblPaused.Text = "Game Paused";
            this.lblPaused.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MazeMap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1000, 550);
            this.Controls.Add(this.lblPaused);
            this.Controls.Add(this.lblShowSol);
            this.Controls.Add(this.lblScoreVal);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.lblPlayingAs);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblTimeSpan);
            this.Controls.Add(this.minimizePB);
            this.Controls.Add(this.closePB);
            this.Controls.Add(this.moveLbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MazeMap";
            this.Text = "MazeMap";
            this.Load += new System.EventHandler(this.MazeMap_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MazeMap_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.MazeMap_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.minimizePB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closePB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label moveLbl;
        private System.Windows.Forms.PictureBox closePB;
        private System.Windows.Forms.PictureBox minimizePB;
        private System.Windows.Forms.Timer characterTmer;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Timer timeSpanTimer;
        private System.Windows.Forms.Label lblTimeSpan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblPlayingAs;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblScoreVal;
        private System.Windows.Forms.Label lblShowSol;
        private System.Windows.Forms.Timer checkForPauseTimer;
        private System.Windows.Forms.Label lblPaused;
    }
}