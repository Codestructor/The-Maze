using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Reflection;
using System.IO;
using Nemiro.OAuth;
using Nemiro.OAuth.LoginForms;
using System.Net;

namespace Maze_v1._0
{
    public partial class Login : Form
    {
        [DllImport("User32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("User32.dll")]
        public static extern int SendMessage(IntPtr Handle, int Msg, int Param1, int Param2);

        public Login()
        {
            InitializeComponent();
        }

        string AccessToken;
        string fullPath;

        private void initializeUsers()
        {
            AccessToken = "3DMBcL6GPkAAAAAAAAAAHhmmyG-_2CsQCz9yHkclX0_rXsp4471q1i9v4rSA91rn";

            var web = new WebClient();
            fullPath = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location).ToString() + "\\UserList.txt";
            try
            {
                web.DownloadFile(new Uri(string.Format("https://content.dropboxapi.com/1/files/auto/{0}?access_token={1}", "/UserList.txt", AccessToken)), fullPath);
            }
            catch(Exception exp)
            {
                MessageBox.Show("No Internet Connection!");
                return;
            }
            if (File.Exists(fullPath))
            {
                UserIO.readUsers(fullPath);
                File.Delete(fullPath);
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            lblRanking.Location = new Point(this.Width / 2 - lblRanking.Width / 2, this.Height - lblRanking.Height - 40);

            lblDebug.Visible = false;
            lblDebug.Width = txtName.Width;
            lblDebug.BackColor = Color.Transparent;
            lblDebug.ForeColor = Color.Red;
            lblDebug.Text = ""; //Please enter path for user-list

            lblDebug.Location = new Point((this.Width - lblDebug.Width) / 2, 40 * this.Height / 100);

            btnSignIn.Visible = false;
            btnSignUp.Visible = false;
            btnBack.Visible = false;

            lblSignIn.Visible = false;
            lblSignUp.Visible = false;
            lblBack.Visible = false;

            lblSignInTitle.Visible = false;
            lblSignInTitle.BackColor = Color.Transparent;
            lblSignInTitle.Width = txtName.Width;
            lblSignUpTitle.Visible = false;
            lblSignUpTitle.BackColor = Color.Transparent;
            lblSignUpTitle.Width = txtName.Width;
            lblEnterUsername.Visible = false;
            lblEnterUsername.BackColor = Color.Transparent;
            lblEnterUsername.Height = txtName.Height;
            lblEnterPassword.Visible = false;
            lblEnterPassword.BackColor = Color.Transparent;
            lblEnterPassword.Height = txtName.Height;
            lblConfirmPassword.Visible = false;
            lblConfirmPassword.BackColor = Color.Transparent;
            lblConfirmPassword.Height = txtName.Height;

            txtName.Visible = false;
            txtName.MaxLength = 20;
            //txtName.TextAlign = HorizontalAlignment.Center;

            txtPassW.Visible = false;
            txtPassW.MaxLength = 15;
            txtPassW.PasswordChar = '*';

            txtPassWConfirm.Visible = false;
            txtPassWConfirm.MaxLength = 15;
            txtPassWConfirm.PasswordChar = '*';

            moveLbl.Width = this.Width;
            moveLbl.Height = 30;
            moveLbl.Location = new Point(0, 0);

            closePB.Width = closePB.Height = moveLbl.Height;
            closePB.Location = new Point(moveLbl.Width - moveLbl.Height, 0);

            minimizePB.Width = minimizePB.Height = moveLbl.Height;
            minimizePB.Location = new Point(moveLbl.Width - 2 * moveLbl.Height, 0);

            lblBlack.Width = 60 * this.Width / 100;
            lblBlack.Height = this.Height / 3;
            lblBlack.Location = new Point((this.Width - lblBlack.Width) / 2, moveLbl.Height + (lblRanking.Top - moveLbl.Height - lblBlack.Height) / 2);
            lblBlack.SendToBack();

            lblPlayAs.Width = lblBlack.Width - 4;
            lblPlayAs.Height = lblBlack.Height / 2 - 3;
            lblPlayAs.Location = new Point(lblBlack.Left + 2, lblBlack.Top + 2);

            lblGuest.Width = lblBlack.Width / 2 - 3;
            lblGuest.Height = lblUser.Height = lblPlayAs.Height;
            lblGuest.Location = new Point(lblBlack.Left + 2, lblBlack.Top + lblBlack.Height / 2 + 1);
            lblUser.Width = lblBlack.Width / 2 - 2;
            lblUser.Location = new Point(lblBlack.Left + lblBlack.Width / 2 + 1, lblGuest.Top);

            lblBack.Width = lblBlack.Width - 4;
            lblBack.Height = lblBlack.Height / 2 - 3;
            lblBack.Location = new Point(lblBlack.Left + 2, lblBlack.Top + lblBlack.Height / 2 + 1);

            lblSignIn.Width = lblBlack.Width / 2 - 3;
            lblSignIn.Height = lblSignUp.Height = lblBack.Height;
            lblSignIn.Location = new Point(lblBlack.Left + 2, lblBlack.Top + 2);
            lblSignUp.Width = lblBlack.Width / 2 - 2;
            lblSignUp.Location = new Point(lblBlack.Left + lblBlack.Width / 2 + 1, lblSignIn.Top);

            lblBlack.Visible = true;
            lblPlayAs.Visible = true;
            lblGuest.Visible = true;
            lblUser.Visible = true;

            btnBackRanking.Location = new Point(this.Width / 2 - btnBackRanking.Width / 2, this.Height - btnBackRanking.Height - 30);
            btnBackRanking.Visible = false;

            txtBoxRanking.Size = new Size(70 * this.Width / 100, 70 * this.Height / 100);
            txtBoxRanking.Location = new Point(this.Width / 2 - txtBoxRanking.Width / 2, moveLbl.Height + (btnBackRanking.Top - moveLbl.Height - txtBoxRanking.Height) / 2);
            txtBoxRanking.Visible = false;
            txtBoxRanking.SelectionAlignment = HorizontalAlignment.Center;

            lblCredentials.Location = new Point(this.Width / 2 - lblCredentials.Width / 2, this.Height - lblCredentials.Height);

            initializeUsers();
        }

        private void moveLbl_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, 0xA1, 0x2, 0);
            }
        }

        private void closePB_Click(object sender, EventArgs e)
        {
            uploadUserList(fullPath);
            this.Close();
        }

        private void minimizePB_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void lblUser_Click(object sender, EventArgs e)
        {
            lblRanking.Visible = false;
            lblPlayAs.Visible = false;
            lblGuest.Visible = false;
            lblUser.Visible = false;

            lblSignIn.Visible = true;
            lblSignUp.Visible = true;
            lblBack.Visible = true;
        }

        private void lblBack_Click(object sender, EventArgs e)
        {
            lblRanking.Visible = true;
            lblPlayAs.Visible = true;
            lblGuest.Visible = true;
            lblUser.Visible = true;

            lblSignIn.Visible = false;
            lblSignUp.Visible = false;
            lblBack.Visible = false;
        }

        private void lblSignIn_Click(object sender, EventArgs e)
        {
            lblBlack.Visible = false;

            lblSignIn.Visible = false;
            lblSignUp.Visible = false;
            lblBack.Visible = false;

            btnSignIn.Visible = true;
            btnBack.Visible = true;

            lblSignInTitle.Visible = true;
            lblEnterPassword.Visible = true;
            lblEnterUsername.Visible = true;

            txtName.Visible = true;
            txtPassW.Visible = true;

            lblDebug.Visible = true;

            int addDist = 20;
            lblDebug.Height = addDist;

            int totalHeight = lblSignInTitle.Height + btnSignIn.Height + btnBack.Height + 2 * (lblEnterUsername.Height + txtName.Height) + 2 * addDist;
            int top = moveLbl.Height + (this.Height - moveLbl.Height - totalHeight) / 2;
            int left = (this.Width - txtName.Width) / 2;

            lblSignInTitle.Location = new Point(left, top);
            top += lblSignInTitle.Height;

            lblEnterUsername.Location = new Point(left, top);
            top += lblEnterUsername.Height;

            txtName.Location = new Point(left, top);
            top += txtName.Height;

            lblEnterPassword.Location = new Point(left, top);
            top += lblEnterPassword.Height;

            txtPassW.Location = new Point(left, top);
            top += txtPassW.Height;

            lblDebug.Location = new Point(left, top);
            top += addDist;

            btnSignIn.Location = new Point(left + (txtName.Width - btnSignIn.Width) / 2, top);
            top += btnSignIn.Height;

            btnBack.Location = new Point(left + (txtName.Width - btnSignIn.Width) / 2, top + 10);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            lblBlack.Visible = true;

            lblSignIn.Visible = true;
            lblSignUp.Visible = true;
            lblBack.Visible = true;

            btnSignIn.Visible = false;
            btnSignUp.Visible = false;

            lblSignInTitle.Visible = false;
            lblSignUpTitle.Visible = false;
            lblEnterPassword.Visible = false;
            lblEnterUsername.Visible = false;
            lblConfirmPassword.Visible = false;

            txtName.Visible = false;
            txtPassW.Visible = false;
            txtPassWConfirm.Visible = false;

            lblDebug.Visible = false;
            lblDebug.Text = "";

            btnBack.Visible = false;

            txtName.Text = "";
            txtPassW.Text = "";
            txtPassWConfirm.Text = "";
            lblEnterUsername.ForeColor = Color.Black;
            lblEnterPassword.ForeColor = Color.Black;
            lblConfirmPassword.ForeColor = Color.Black;
            lblDebug.ForeColor = Color.Red;
        }

        private void lblSignUp_Click(object sender, EventArgs e)
        {
            lblBlack.Visible = false;

            lblSignIn.Visible = false;
            lblSignUp.Visible = false;
            lblBack.Visible = false;

            btnSignUp.Visible = true;
            btnBack.Visible = true;

            lblSignUpTitle.Visible = true;
            lblEnterPassword.Visible = true;
            lblEnterUsername.Visible = true;
            lblConfirmPassword.Visible = true;

            txtName.Visible = true;
            txtPassW.Visible = true;
            txtPassWConfirm.Visible = true;

            lblDebug.Visible = true;

            int addDist = 20;
            lblDebug.Height = addDist;

            int totalHeight = lblSignUpTitle.Height + btnSignUp.Height + btnBack.Height + 3 * (lblEnterUsername.Height + txtName.Height) + 2 * addDist;
            int top = moveLbl.Height + (this.Height - moveLbl.Height - totalHeight) / 2;
            int left = (this.Width - txtName.Width) / 2;

            lblSignUpTitle.Location = new Point(left, top);
            top += lblSignUpTitle.Height;

            lblEnterUsername.Location = new Point(left, top);
            top += lblEnterUsername.Height;

            txtName.Location = new Point(left, top);
            top += txtName.Height;

            lblEnterPassword.Location = new Point(left, top);
            top += lblEnterPassword.Height;

            txtPassW.Location = new Point(left, top);
            top += txtPassW.Height;

            lblConfirmPassword.Location = new Point(left, top);
            top += lblConfirmPassword.Height;

            txtPassWConfirm.Location = new Point(left, top);
            top += txtPassWConfirm.Height;

            lblDebug.Location = new Point(left, top);
            top += addDist;

            btnSignUp.Location = new Point(left + (txtName.Width - btnSignIn.Width) / 2, top);
            top += btnSignUp.Height;

            btnBack.Location = new Point(left + (txtName.Width - btnSignIn.Width) / 2, top + 10);
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            int result = UserIO.checkSignInDetails(txtName.Text, txtPassW.Text);

            if (txtName.Text == "")
                lblEnterUsername.ForeColor = Color.Red;
            else
                lblEnterUsername.ForeColor = Color.Black;
            if (txtPassW.Text == "")
                lblEnterPassword.ForeColor = Color.Red;
            else
                lblEnterPassword.ForeColor = Color.Black;
            if (txtName.Text == "")
            {

                if (txtPassW.Text == "")
                {
                    lblDebug.Text = "Please enter account details";
                }
                else
                {
                    lblDebug.Text = "Please enter username";
                }
            }
            else
            {
                if (txtPassW.Text == "")
                {
                    lblDebug.Text = "Please enter password";
                }
            }
            switch (result)
            {
                case 1:
                    {
                        MazeMap mazeMap = new MazeMap(UserIO.users[UserIO.currentPlayer].name, UserIO.users[UserIO.currentPlayer].score, UserIO.users[UserIO.currentPlayer].levelNr);
                        this.Hide();
                        mazeMap.ShowDialog();
                        this.Show();
                        break;
                    }
                case 2:
                    {
                        lblEnterPassword.ForeColor = Color.Red;
                        lblDebug.Text = "Invalid password";
                        break;
                    }
                case 0:
                    {
                        lblEnterUsername.ForeColor = Color.Red;
                        lblDebug.Text = "Invalid username";
                        break;
                    }
                default:
                    break;
            }
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            int result = UserIO.checkSignUpDetails(txtName.Text, txtPassW.Text, txtPassWConfirm.Text);
            if (txtName.Text == "")
                lblEnterUsername.ForeColor = Color.Red;
            else
                lblEnterUsername.ForeColor = Color.Black;
            if (txtPassW.Text == "")
                lblEnterPassword.ForeColor = Color.Red;
            else
                lblEnterPassword.ForeColor = Color.Black;
            if (txtPassWConfirm.Text == "")
                lblConfirmPassword.ForeColor = Color.Red;
            else
                lblConfirmPassword.ForeColor = Color.Black;
            if (txtName.Text == "")
            {
                if (txtPassW.Text == "")
                {
                    lblDebug.Text = "Please enter account details";
                }
                else
                {
                    lblDebug.Text = "Please enter username";
                }
            }
            else
            {
                if (txtPassW.Text == "")
                {
                    lblDebug.Text = "Please enter password";
                }
            }
            switch (result)
            {
                case 1:
                    {
                        lblDebug.Text = "Username already exists.";
                        break;
                    }
                case 2:
                    {
                        lblDebug.Text = "Confirmation not the same";
                        lblConfirmPassword.ForeColor = Color.Red;
                        break;
                    }
                case 3:
                    {
                        lblDebug.Text = "Password must be at least 8 ch.";
                        break;
                    }
                case 0:
                    {
                        lblDebug.Text = "";
                        UserIO.addUser(txtName.Text, txtPassW.Text);
                        uploadUserList(fullPath);

                        MazeMap mazeMap = new MazeMap(UserIO.users[UserIO.currentPlayer].name, UserIO.users[UserIO.currentPlayer].score, UserIO.users[UserIO.currentPlayer].levelNr);
                        this.Hide();
                        mazeMap.ShowDialog();
                        this.Show();

                        break;
                    }
                default:
                    break;
            }
        }

        public void deleteUserList()
        {
            OAuthUtility.Post
            (
                "https://api.dropboxapi.com/1/fileops/delete",
                new HttpParameterCollection
                {
                    {"access_token", AccessToken},
                    {"root", "auto"},
                    {"path", "/UserList.txt"}
                }
            );
        }

        public void uploadUserList(string path)
        {
            try
            {
                UserIO.writeUsers(path);
                deleteUserList();
                OAuthUtility.Put
                (
                    "https://content.dropboxapi.com/1/files_put/auto/",
                    new HttpParameterCollection
                {
                    {"access_token", AccessToken},
                    {"path", "/UserList.txt"},
                    {"overwrite", "true"},
                    {"autorename", "true"},
                    {File.OpenRead(path)}
                }
                );
                File.Delete(path);
            }
            catch(Exception e)
            {
                MessageBox.Show("No Internet Connection!");
            }
        }

        private void lblGuest_Click(object sender, EventArgs e)
        {
            MazeMap mazeMap = new MazeMap("Guest", 0, 1);
            this.Hide();
            mazeMap.ShowDialog();
            this.Show();
        }

        private void lblRanking_Click(object sender, EventArgs e)
        {
            lblBlack.Visible = false;
            lblPlayAs.Visible = false;
            lblGuest.Visible = false;
            lblUser.Visible = false;
            lblRanking.Visible = false;

            txtBoxRanking.Text = "";
            txtBoxRanking.Text = "World Ranking" + Environment.NewLine + Environment.NewLine;
            UserIO.writeUsersToRichTxtBox(txtBoxRanking);

            txtBoxRanking.Visible = true;
            btnBackRanking.Visible = true;
        }

        private void btnBackRanking_Click(object sender, EventArgs e)
        {
            lblBlack.Visible = true;
            lblPlayAs.Visible = true;
            lblGuest.Visible = true;
            lblUser.Visible = true;
            lblRanking.Visible = true;

            txtBoxRanking.Visible = false;
            btnBackRanking.Visible = false;
        }
    }
}