namespace Maze_v1._0
{
    partial class ResultForm
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
            this.moveLbl = new System.Windows.Forms.Label();
            this.nextLvl = new System.Windows.Forms.Label();
            this.exit = new System.Windows.Forms.Label();
            this.lblDebug = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // moveLbl
            // 
            this.moveLbl.BackColor = System.Drawing.Color.RoyalBlue;
            this.moveLbl.Font = new System.Drawing.Font("Monotype Corsiva", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.moveLbl.Location = new System.Drawing.Point(12, 9);
            this.moveLbl.Name = "moveLbl";
            this.moveLbl.Size = new System.Drawing.Size(390, 40);
            this.moveLbl.TabIndex = 2;
            this.moveLbl.Text = "The Star Maze";
            this.moveLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.moveLbl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.moveLbl_MouseDown);
            // 
            // nextLvl
            // 
            this.nextLvl.BackColor = System.Drawing.Color.RoyalBlue;
            this.nextLvl.Font = new System.Drawing.Font("Monotype Corsiva", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.nextLvl.Location = new System.Drawing.Point(276, 184);
            this.nextLvl.Name = "nextLvl";
            this.nextLvl.Size = new System.Drawing.Size(126, 40);
            this.nextLvl.TabIndex = 8;
            this.nextLvl.Text = "Next Level";
            this.nextLvl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.nextLvl.Click += new System.EventHandler(this.nextLvl_Click);
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.RoyalBlue;
            this.exit.Font = new System.Drawing.Font("Monotype Corsiva", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.exit.Location = new System.Drawing.Point(12, 184);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(126, 40);
            this.exit.TabIndex = 9;
            this.exit.Text = "Exit";
            this.exit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // lblDebug
            // 
            this.lblDebug.BackColor = System.Drawing.Color.RoyalBlue;
            this.lblDebug.Font = new System.Drawing.Font("Monotype Corsiva", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblDebug.Location = new System.Drawing.Point(122, 96);
            this.lblDebug.Name = "lblDebug";
            this.lblDebug.Size = new System.Drawing.Size(170, 40);
            this.lblDebug.TabIndex = 23;
            this.lblDebug.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ResultForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 233);
            this.Controls.Add(this.lblDebug);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.nextLvl);
            this.Controls.Add(this.moveLbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ResultForm";
            this.Text = "ResultForm";
            this.Load += new System.EventHandler(this.ResultForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label moveLbl;
        private System.Windows.Forms.Label nextLvl;
        private System.Windows.Forms.Label exit;
        private System.Windows.Forms.Label lblDebug;
    }
}