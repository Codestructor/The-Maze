namespace Maze_v1._0
{
    partial class Login
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
            this.lblPlayAs = new System.Windows.Forms.Label();
            this.lblGuest = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblBlack = new System.Windows.Forms.Label();
            this.lblSignIn = new System.Windows.Forms.Label();
            this.lblSignUp = new System.Windows.Forms.Label();
            this.lblBack = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPassW = new System.Windows.Forms.TextBox();
            this.txtPassWConfirm = new System.Windows.Forms.TextBox();
            this.lblEnterUsername = new System.Windows.Forms.Label();
            this.lblEnterPassword = new System.Windows.Forms.Label();
            this.lblConfirmPassword = new System.Windows.Forms.Label();
            this.lblSignInTitle = new System.Windows.Forms.Label();
            this.btnSignIn = new System.Windows.Forms.Button();
            this.btnSignUp = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblDebug = new System.Windows.Forms.Label();
            this.minimizePB = new System.Windows.Forms.PictureBox();
            this.closePB = new System.Windows.Forms.PictureBox();
            this.lblSignUpTitle = new System.Windows.Forms.Label();
            this.lblRanking = new System.Windows.Forms.Label();
            this.txtBoxRanking = new System.Windows.Forms.RichTextBox();
            this.btnBackRanking = new System.Windows.Forms.Button();
            this.lblCredentials = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.minimizePB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closePB)).BeginInit();
            this.SuspendLayout();
            // 
            // moveLbl
            // 
            this.moveLbl.BackColor = System.Drawing.Color.RoyalBlue;
            this.moveLbl.Font = new System.Drawing.Font("Monotype Corsiva", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.moveLbl.Location = new System.Drawing.Point(-154, 9);
            this.moveLbl.Name = "moveLbl";
            this.moveLbl.Size = new System.Drawing.Size(594, 40);
            this.moveLbl.TabIndex = 1;
            this.moveLbl.Text = "The Star Maze";
            this.moveLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.moveLbl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.moveLbl_MouseDown);
            // 
            // lblPlayAs
            // 
            this.lblPlayAs.BackColor = System.Drawing.Color.RoyalBlue;
            this.lblPlayAs.Font = new System.Drawing.Font("Monotype Corsiva", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblPlayAs.Location = new System.Drawing.Point(12, 159);
            this.lblPlayAs.Name = "lblPlayAs";
            this.lblPlayAs.Size = new System.Drawing.Size(245, 40);
            this.lblPlayAs.TabIndex = 5;
            this.lblPlayAs.Text = "Play as";
            this.lblPlayAs.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblGuest
            // 
            this.lblGuest.BackColor = System.Drawing.Color.RoyalBlue;
            this.lblGuest.Font = new System.Drawing.Font("Monotype Corsiva", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblGuest.Location = new System.Drawing.Point(12, 209);
            this.lblGuest.Name = "lblGuest";
            this.lblGuest.Size = new System.Drawing.Size(126, 40);
            this.lblGuest.TabIndex = 6;
            this.lblGuest.Text = "Guest";
            this.lblGuest.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblGuest.Click += new System.EventHandler(this.lblGuest_Click);
            // 
            // lblUser
            // 
            this.lblUser.BackColor = System.Drawing.Color.RoyalBlue;
            this.lblUser.Font = new System.Drawing.Font("Monotype Corsiva", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblUser.Location = new System.Drawing.Point(12, 255);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(126, 40);
            this.lblUser.TabIndex = 7;
            this.lblUser.Text = "User";
            this.lblUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblUser.Click += new System.EventHandler(this.lblUser_Click);
            // 
            // lblBlack
            // 
            this.lblBlack.BackColor = System.Drawing.Color.Black;
            this.lblBlack.Font = new System.Drawing.Font("Monotype Corsiva", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblBlack.Location = new System.Drawing.Point(12, 301);
            this.lblBlack.Name = "lblBlack";
            this.lblBlack.Size = new System.Drawing.Size(126, 40);
            this.lblBlack.TabIndex = 8;
            this.lblBlack.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSignIn
            // 
            this.lblSignIn.BackColor = System.Drawing.Color.RoyalBlue;
            this.lblSignIn.Font = new System.Drawing.Font("Monotype Corsiva", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblSignIn.Location = new System.Drawing.Point(131, 56);
            this.lblSignIn.Name = "lblSignIn";
            this.lblSignIn.Size = new System.Drawing.Size(126, 40);
            this.lblSignIn.TabIndex = 9;
            this.lblSignIn.Text = "Sign in";
            this.lblSignIn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblSignIn.Click += new System.EventHandler(this.lblSignIn_Click);
            // 
            // lblSignUp
            // 
            this.lblSignUp.BackColor = System.Drawing.Color.RoyalBlue;
            this.lblSignUp.Font = new System.Drawing.Font("Monotype Corsiva", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblSignUp.Location = new System.Drawing.Point(131, 106);
            this.lblSignUp.Name = "lblSignUp";
            this.lblSignUp.Size = new System.Drawing.Size(126, 40);
            this.lblSignUp.TabIndex = 10;
            this.lblSignUp.Text = "Sign up";
            this.lblSignUp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblSignUp.Click += new System.EventHandler(this.lblSignUp_Click);
            // 
            // lblBack
            // 
            this.lblBack.BackColor = System.Drawing.Color.RoyalBlue;
            this.lblBack.Font = new System.Drawing.Font("Monotype Corsiva", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblBack.Location = new System.Drawing.Point(12, 56);
            this.lblBack.Name = "lblBack";
            this.lblBack.Size = new System.Drawing.Size(126, 40);
            this.lblBack.TabIndex = 11;
            this.lblBack.Text = "Back";
            this.lblBack.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblBack.Click += new System.EventHandler(this.lblBack_Click);
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(365, 216);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(202, 27);
            this.txtName.TabIndex = 12;
            // 
            // txtPassW
            // 
            this.txtPassW.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassW.Location = new System.Drawing.Point(365, 242);
            this.txtPassW.Name = "txtPassW";
            this.txtPassW.Size = new System.Drawing.Size(202, 27);
            this.txtPassW.TabIndex = 13;
            // 
            // txtPassWConfirm
            // 
            this.txtPassWConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassWConfirm.Location = new System.Drawing.Point(365, 268);
            this.txtPassWConfirm.Name = "txtPassWConfirm";
            this.txtPassWConfirm.Size = new System.Drawing.Size(202, 27);
            this.txtPassWConfirm.TabIndex = 14;
            // 
            // lblEnterUsername
            // 
            this.lblEnterUsername.BackColor = System.Drawing.Color.RoyalBlue;
            this.lblEnterUsername.Font = new System.Drawing.Font("Monotype Corsiva", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblEnterUsername.Location = new System.Drawing.Point(390, 62);
            this.lblEnterUsername.Name = "lblEnterUsername";
            this.lblEnterUsername.Size = new System.Drawing.Size(170, 40);
            this.lblEnterUsername.TabIndex = 15;
            this.lblEnterUsername.Text = "Enter Username:";
            this.lblEnterUsername.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblEnterPassword
            // 
            this.lblEnterPassword.BackColor = System.Drawing.Color.RoyalBlue;
            this.lblEnterPassword.Font = new System.Drawing.Font("Monotype Corsiva", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblEnterPassword.Location = new System.Drawing.Point(390, 102);
            this.lblEnterPassword.Name = "lblEnterPassword";
            this.lblEnterPassword.Size = new System.Drawing.Size(170, 40);
            this.lblEnterPassword.TabIndex = 16;
            this.lblEnterPassword.Text = "Enter Password:";
            this.lblEnterPassword.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblConfirmPassword
            // 
            this.lblConfirmPassword.BackColor = System.Drawing.Color.RoyalBlue;
            this.lblConfirmPassword.Font = new System.Drawing.Font("Monotype Corsiva", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblConfirmPassword.Location = new System.Drawing.Point(390, 142);
            this.lblConfirmPassword.Name = "lblConfirmPassword";
            this.lblConfirmPassword.Size = new System.Drawing.Size(170, 31);
            this.lblConfirmPassword.TabIndex = 17;
            this.lblConfirmPassword.Text = "Confirm Password:";
            this.lblConfirmPassword.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblSignInTitle
            // 
            this.lblSignInTitle.BackColor = System.Drawing.Color.RoyalBlue;
            this.lblSignInTitle.Font = new System.Drawing.Font("Monotype Corsiva", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblSignInTitle.Location = new System.Drawing.Point(178, 256);
            this.lblSignInTitle.Name = "lblSignInTitle";
            this.lblSignInTitle.Size = new System.Drawing.Size(170, 40);
            this.lblSignInTitle.TabIndex = 18;
            this.lblSignInTitle.Text = "Sign in";
            this.lblSignInTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSignIn
            // 
            this.btnSignIn.Location = new System.Drawing.Point(390, 301);
            this.btnSignIn.Name = "btnSignIn";
            this.btnSignIn.Size = new System.Drawing.Size(75, 23);
            this.btnSignIn.TabIndex = 19;
            this.btnSignIn.Text = "Sign in";
            this.btnSignIn.UseVisualStyleBackColor = true;
            this.btnSignIn.Click += new System.EventHandler(this.btnSignIn_Click);
            // 
            // btnSignUp
            // 
            this.btnSignUp.Location = new System.Drawing.Point(471, 301);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(75, 23);
            this.btnSignUp.TabIndex = 20;
            this.btnSignUp.Text = "Sign up";
            this.btnSignUp.UseVisualStyleBackColor = true;
            this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(431, 330);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 21;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblDebug
            // 
            this.lblDebug.BackColor = System.Drawing.Color.RoyalBlue;
            this.lblDebug.Font = new System.Drawing.Font("Monotype Corsiva", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblDebug.Location = new System.Drawing.Point(178, 216);
            this.lblDebug.Name = "lblDebug";
            this.lblDebug.Size = new System.Drawing.Size(170, 40);
            this.lblDebug.TabIndex = 22;
            this.lblDebug.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // minimizePB
            // 
            this.minimizePB.BackColor = System.Drawing.Color.RoyalBlue;
            this.minimizePB.Image = global::Maze_v1._0.Properties.Resources.MinimizeBtn;
            this.minimizePB.Location = new System.Drawing.Point(344, 9);
            this.minimizePB.Name = "minimizePB";
            this.minimizePB.Size = new System.Drawing.Size(40, 40);
            this.minimizePB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.minimizePB.TabIndex = 4;
            this.minimizePB.TabStop = false;
            this.minimizePB.Click += new System.EventHandler(this.minimizePB_Click);
            // 
            // closePB
            // 
            this.closePB.BackColor = System.Drawing.Color.RoyalBlue;
            this.closePB.Image = global::Maze_v1._0.Properties.Resources.CloseBtnFinal;
            this.closePB.Location = new System.Drawing.Point(390, 9);
            this.closePB.Name = "closePB";
            this.closePB.Size = new System.Drawing.Size(40, 40);
            this.closePB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.closePB.TabIndex = 3;
            this.closePB.TabStop = false;
            this.closePB.Click += new System.EventHandler(this.closePB_Click);
            // 
            // lblSignUpTitle
            // 
            this.lblSignUpTitle.BackColor = System.Drawing.Color.RoyalBlue;
            this.lblSignUpTitle.Font = new System.Drawing.Font("Monotype Corsiva", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblSignUpTitle.Location = new System.Drawing.Point(178, 296);
            this.lblSignUpTitle.Name = "lblSignUpTitle";
            this.lblSignUpTitle.Size = new System.Drawing.Size(170, 40);
            this.lblSignUpTitle.TabIndex = 24;
            this.lblSignUpTitle.Text = "Sign up";
            this.lblSignUpTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRanking
            // 
            this.lblRanking.BackColor = System.Drawing.Color.RoyalBlue;
            this.lblRanking.Font = new System.Drawing.Font("Monotype Corsiva", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblRanking.Location = new System.Drawing.Point(178, 176);
            this.lblRanking.Name = "lblRanking";
            this.lblRanking.Size = new System.Drawing.Size(170, 40);
            this.lblRanking.TabIndex = 25;
            this.lblRanking.Text = "World Ranking";
            this.lblRanking.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblRanking.Click += new System.EventHandler(this.lblRanking_Click);
            // 
            // txtBoxRanking
            // 
            this.txtBoxRanking.BackColor = System.Drawing.Color.White;
            this.txtBoxRanking.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtBoxRanking.Location = new System.Drawing.Point(263, 56);
            this.txtBoxRanking.Name = "txtBoxRanking";
            this.txtBoxRanking.ReadOnly = true;
            this.txtBoxRanking.Size = new System.Drawing.Size(112, 51);
            this.txtBoxRanking.TabIndex = 26;
            this.txtBoxRanking.Text = "";
            // 
            // btnBackRanking
            // 
            this.btnBackRanking.Location = new System.Drawing.Point(263, 119);
            this.btnBackRanking.Name = "btnBackRanking";
            this.btnBackRanking.Size = new System.Drawing.Size(75, 23);
            this.btnBackRanking.TabIndex = 27;
            this.btnBackRanking.Text = "Back";
            this.btnBackRanking.UseVisualStyleBackColor = true;
            this.btnBackRanking.Click += new System.EventHandler(this.btnBackRanking_Click);
            // 
            // lblCredentials
            // 
            this.lblCredentials.BackColor = System.Drawing.Color.Transparent;
            this.lblCredentials.Font = new System.Drawing.Font("Monotype Corsiva", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblCredentials.Location = new System.Drawing.Point(354, 176);
            this.lblCredentials.Name = "lblCredentials";
            this.lblCredentials.Size = new System.Drawing.Size(213, 28);
            this.lblCredentials.TabIndex = 28;
            this.lblCredentials.Text = "Copyright (c) Gherman Mihai 2016";
            this.lblCredentials.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 355);
            this.Controls.Add(this.lblCredentials);
            this.Controls.Add(this.btnBackRanking);
            this.Controls.Add(this.txtBoxRanking);
            this.Controls.Add(this.lblRanking);
            this.Controls.Add(this.lblSignUpTitle);
            this.Controls.Add(this.lblDebug);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnSignUp);
            this.Controls.Add(this.btnSignIn);
            this.Controls.Add(this.lblSignInTitle);
            this.Controls.Add(this.lblConfirmPassword);
            this.Controls.Add(this.lblEnterPassword);
            this.Controls.Add(this.lblEnterUsername);
            this.Controls.Add(this.txtPassWConfirm);
            this.Controls.Add(this.txtPassW);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblBack);
            this.Controls.Add(this.lblSignUp);
            this.Controls.Add(this.lblSignIn);
            this.Controls.Add(this.lblBlack);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.lblGuest);
            this.Controls.Add(this.lblPlayAs);
            this.Controls.Add(this.minimizePB);
            this.Controls.Add(this.closePB);
            this.Controls.Add(this.moveLbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.minimizePB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closePB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label moveLbl;
        private System.Windows.Forms.PictureBox minimizePB;
        private System.Windows.Forms.PictureBox closePB;
        private System.Windows.Forms.Label lblPlayAs;
        private System.Windows.Forms.Label lblGuest;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblBlack;
        private System.Windows.Forms.Label lblSignIn;
        private System.Windows.Forms.Label lblSignUp;
        private System.Windows.Forms.Label lblBack;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPassW;
        private System.Windows.Forms.TextBox txtPassWConfirm;
        private System.Windows.Forms.Label lblEnterUsername;
        private System.Windows.Forms.Label lblEnterPassword;
        private System.Windows.Forms.Label lblConfirmPassword;
        private System.Windows.Forms.Label lblSignInTitle;
        private System.Windows.Forms.Button btnSignIn;
        private System.Windows.Forms.Button btnSignUp;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblDebug;
        private System.Windows.Forms.Label lblSignUpTitle;
        private System.Windows.Forms.Label lblRanking;
        private System.Windows.Forms.RichTextBox txtBoxRanking;
        private System.Windows.Forms.Button btnBackRanking;
        private System.Windows.Forms.Label lblCredentials;
    }
}