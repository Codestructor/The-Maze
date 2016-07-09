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

namespace Maze_v1._0
{
    public partial class MazeMap : Form
    {
        [DllImport("User32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("User32.dll")]
        public static extern int SendMessage(IntPtr Handle, int Msg, int Param1, int Param2);

        private void moveLbl_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, 0xA1, 0x2, 0);
            }
        }

        public static bool isExit;

        bool up = false, down = false, right = false, left = false, ctrl = false;
        bool finish;
        bool pKeyPressed = false, paused = false, running= false;

        int speedCh = 7;
        int windowWidth, windowHeight, gameWidth, gameHeight, tileDim;
        int X0, Y0;
        int xs, ys, xf = 2, yf = 2;
        int X0Map, Y0Map;
        int x, y;
        int[,] a = new int[100, 100];
        int chStep;
        int showSolNr;

        //Level dims
        int xVal, yVal;

        TimeSpan startTime = new TimeSpan();
        TimeSpan currentTime = new TimeSpan();
        TimeSpan changeTime = new TimeSpan();

        PictureBox imgParent;
        PictureBox chImg;
        Rectangle chImgFrame = new Rectangle();
        PictureBox imgFinal;
        Rectangle imgFinalFrame;

        List<Rectangle> listStones = new List<Rectangle>();
        List<PictureBox> listStars = new List<PictureBox>();

        public MazeMap(string userName, int score, int levelNr)
        {
            InitializeComponent();
            lblUsername.Text = userName;
            updateScoreVal(score);

            xVal = 9 + levelNr;
            yVal = xVal - 4;
        }

        private void updateScoreVal(int x)
        {
            if (x < 10)
            {
                lblScoreVal.Text = "000" + x.ToString();
            }
            else if (x < 100)
            {
                lblScoreVal.Text = "00" + x.ToString();
            }
            else if (x < 1000)
            {
                lblScoreVal.Text = "0" + x.ToString();
            }
            else
            {
                lblScoreVal.Text = x.ToString();
            }
        }

        private void closePB_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void minimizePB_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void MazeMap_Load(object sender, EventArgs e)
        {
            isExit = false;

            moveLbl.Width = this.Width;
            moveLbl.Height = 30;
            moveLbl.Location = new Point(0, 0);

            closePB.Width = closePB.Height = moveLbl.Height;
            closePB.Location = new Point(moveLbl.Width - moveLbl.Height, 0);

            minimizePB.Width = minimizePB.Height = moveLbl.Height;
            minimizePB.Location = new Point(moveLbl.Width - 2 * moveLbl.Height, 0);

            characterTmer.Start();
            checkForPauseTimer.Start();

            windowWidth = this.Width;
            windowHeight = this.Height - moveLbl.Height;

            X0 = 2 * windowWidth / 100; //Just for now
            Y0 = moveLbl.Height + 7 * windowHeight / 100;

            lblShowSol.Location = new Point(this.Width / 2 - lblShowSol.Width / 2, moveLbl.Height + ((Y0 - moveLbl.Height) / 2 - lblShowSol.Height / 2));

            label2.Location = new Point(X0, Y0);
            label2.SendToBack();

            lblTimeSpan.Location = new Point(X0 + (label2.Width - lblTimeSpan.Width) / 2, Y0 + label2.Height + 5);
            lblTimeSpan.SendToBack();

            lblPlayingAs.Location = new Point(X0 + (label2.Width - lblPlayingAs.Width) / 2, lblTimeSpan.Top + lblTimeSpan.Height + 5);
            lblPlayingAs.SendToBack();

            lblUsername.Location = new Point(X0 + (label2.Width - lblUsername.Width) / 2, lblPlayingAs.Top + lblPlayingAs.Height + 5);
            lblUsername.SendToBack();

            lblScore.Location = new Point(X0 + (label2.Width - lblScore.Width) / 2, lblUsername.Top + lblUsername.Height + 5);
            lblScore.SendToBack();

            lblScoreVal.Location = new Point(X0 + (label2.Width - lblScoreVal.Width) / 2, lblScore.Top + lblScore.Height + 5);
            lblScoreVal.SendToBack();

            X0 = 15 * windowWidth / 100;

            gameWidth = windowWidth - 2 * X0;
            gameHeight = windowHeight - 2 * (Y0 - moveLbl.Height);

            lblPaused.Size = new Size(gameWidth, gameHeight);
            lblPaused.Location = new Point(X0, Y0);
            lblPaused.Visible = false;

            this.KeyPreview = true;

            showMap();
        }

        private void showMap()
        {
            MazeGeneratorPrim.maxl = 0;
            showSolNr = 0;
            finish = false;

            changeTime = TimeSpan.Zero;

            clearAll();
            /*if (imgParent != null)
                imgParent.Dispose*/

            imgParent = new PictureBox();

            x = xVal;
            y = yVal;

            if (gameWidth / x > gameHeight / y)
            {
                tileDim = gameHeight / y;
                Y0Map = Y0;
                X0Map = X0 + (gameWidth - tileDim * x) / 2;
            }
            else
            {
                tileDim = gameWidth / x;
                Y0Map = Y0 + (gameHeight - tileDim * y) / 2;
                X0Map = X0;
            }

            speedCh = 10 * tileDim / 100;

            imgParent.Width = x * tileDim;
            imgParent.Height = y * tileDim;
            imgParent.SizeMode = PictureBoxSizeMode.StretchImage;
            imgParent.Image = Properties.Resources.Grass;
            imgParent.Location = new Point(X0Map, Y0Map);
            this.Controls.Add(imgParent);
            imgParent.SendToBack();

            x -= 2;
            y -= 2;

            MazeGeneratorPrim.generateMap(x, y, ref xs, ref ys, ref a);

            int xi, yi;

            for (yi = 0; yi <= y + 1; yi++)
            {
                for (xi = 0; xi <= x + 1; xi++)
                {
                    if (a[yi, xi] == 2 || a[yi, xi] == 1)
                    {
                        PictureBox img = new PictureBox();
                        img.Width = img.Height = tileDim;
                        img.SizeMode = PictureBoxSizeMode.StretchImage;
                        img.Image = Properties.Resources.Stone;
                        img.Location = new Point(xi * tileDim, yi * tileDim);

                        this.Controls.Add(img);
                        img.Parent = imgParent;

                        Rectangle frameStone = new Rectangle(img.Location, new Size(img.Width, img.Height));

                        listStones.Add(frameStone);
                    }
                }
            }
            /*if (chImg != null)
                chImg.Dispose();*/

            chImg = new PictureBox();
            chImg.Width = 40 * tileDim / 100;
            chImg.Height = 65 * tileDim / 100;
            chImg.SizeMode = PictureBoxSizeMode.StretchImage;
            chImg.Image = Properties.Resources.RStay;
            chImg.Location = new Point(xs * tileDim, ys * tileDim);
            this.Controls.Add(chImg);

            chImg.BringToFront();
            chImg.BackColor = Color.Transparent;
            chImg.Parent = imgParent;

            chImgFrame.Location = chImg.Location;
            chImgFrame.Size = chImg.Size;

            MazeGeneratorPrim.findMaxLength(xs, ys, 1, ref xf, ref yf, a);

            //if (imgFinal != null)
            //    imgFinal.Dispose();

            imgFinal = new PictureBox();
            imgFinal.Size = new Size(tileDim, tileDim); ;
            imgFinal.SizeMode = PictureBoxSizeMode.StretchImage;
            imgFinal.Image = Properties.Resources.Finish;
            imgFinal.Location = new Point(xf * tileDim, yf * tileDim);

            imgFinalFrame = new Rectangle(imgFinal.Location, imgFinal.Size);

            this.Controls.Add(imgFinal);
            imgFinal.BackColor = Color.Transparent;
            imgFinal.Parent = imgParent;
            imgFinal.BringToFront();

            startTime = DateTime.Now.TimeOfDay;
            timeSpanTimer.Start();

        }

        private void MazeMap_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W || e.KeyCode == Keys.Up)
                up = true;
            if (e.KeyCode == Keys.S || e.KeyCode == Keys.Down)
                down = true;
            if (e.KeyCode == Keys.D || e.KeyCode == Keys.Right)
                right = true;
            if (e.KeyCode == Keys.A || e.KeyCode == Keys.Left)
                left = true;
            if (e.KeyCode == Keys.ControlKey)
            {
                speedCh += tileDim / 4;
                ctrl = true;
            }
            if (e.KeyCode == Keys.P)
            {
                if (pKeyPressed)
                    pKeyPressed = false;
                else
                    pKeyPressed= true;
            }
        }

        private void chStopImageChange()
        {
            if (up)
            {
                PictureBoxFunctions.imgChange(ref chImg, ref chStep, "UStay");
            }
            if (right)
            {
                PictureBoxFunctions.imgChange(ref chImg, ref chStep, "RStay");
            }
            if (down)
            {
                PictureBoxFunctions.imgChange(ref chImg, ref chStep, "DStay");
            }
            if (left)
            {
                PictureBoxFunctions.imgChange(ref chImg, ref chStep, "LStay");
            }
        }

        private void MazeMap_KeyUp(object sender, KeyEventArgs e)
        {
            chStopImageChange();
            if (e.KeyCode == Keys.W || e.KeyCode == Keys.Up)
                up = false;
            if (e.KeyCode == Keys.S || e.KeyCode == Keys.Down)
                down = false;
            if (e.KeyCode == Keys.D || e.KeyCode == Keys.Right)
                right = false;
            if (e.KeyCode == Keys.A || e.KeyCode == Keys.Left)
                left = false;
            if (e.KeyCode == Keys.ControlKey)
            {
                speedCh -= tileDim / 4;
                ctrl = false;
            }
        }

        private void characterTmer_Tick(object sender, EventArgs e)
        {
            if (up)
            {
                PictureBoxFunctions.imgChange(ref chImg, ref chStep, "U" + chStep.ToString());
                if (PictureBoxFunctions.checkCollision(chImg, chImg.Left, chImg.Top - speedCh, listStones))
                    chImg.Top -= speedCh;
            }
            else if (right)
            {
                PictureBoxFunctions.imgChange(ref chImg, ref chStep, "R" + chStep.ToString());
                if (PictureBoxFunctions.checkCollision(chImg, chImg.Left + speedCh, chImg.Top, listStones))
                    chImg.Left += speedCh;
            }
            else if (down)
            {
                PictureBoxFunctions.imgChange(ref chImg, ref chStep, "D" + chStep.ToString());
                if (PictureBoxFunctions.checkCollision(chImg, chImg.Left, chImg.Top + speedCh, listStones))
                    chImg.Top += speedCh;
            }
            else if (left)
            {
                PictureBoxFunctions.imgChange(ref chImg, ref chStep, "L" + chStep.ToString());
                if (PictureBoxFunctions.checkCollision(chImg, chImg.Left - speedCh, chImg.Top, listStones))
                    chImg.Left -= speedCh;
            }

            chImgFrame.Location = chImg.Location;

            if (chImgFrame.IntersectsWith(imgFinalFrame) && !finish)
            {
                finish = true;
                chStopImageChange();
                if (ctrl)
                {
                    speedCh -= tileDim / 4;
                }
                up = down = right = left = ctrl = false;
                
                timeSpanTimer.Stop();

                xVal++;
                yVal++;

                double expected = Convert.ToDouble(MazeGeneratorPrim.maxl) * Convert.ToDouble(tileDim) / (Convert.ToDouble(speedCh) * Convert.ToDouble(1000) / Convert.ToDouble(characterTmer.Interval));
                double managed = Convert.ToDouble(changeTime.Minutes * 60 + changeTime.Seconds);
                int plusScore = Convert.ToInt32(expected / managed * 100);
                plusScore -= showSolNr * 20;

                if (plusScore < 0)
                    plusScore = 0;
                if (plusScore > 120)
                    plusScore = 120;

                if (lblUsername.Text != "Guest")
                {
                    UserIO.users[UserIO.currentPlayer].levelNr++;
                    UserIO.users[UserIO.currentPlayer].score += plusScore;
                    updateScoreVal(UserIO.users[UserIO.currentPlayer].score);
                }
                else
                {
                    updateScoreVal(Convert.ToInt32(lblScoreVal.Text) + plusScore);
                }

                ResultForm rsForm = new ResultForm("Congrats, you found the way!" + Environment.NewLine + "Score: " + plusScore.ToString());
                rsForm.ShowDialog();

                if (isExit)
                {
                    this.Close();
                }

                showMap();
            }

            foreach (PictureBox star in listStars)
            {
                Rectangle frameStar = new Rectangle(star.Left - 5, star.Top - 5, star.Width + 5, star.Height + 5);
                if (chImgFrame.IntersectsWith(frameStar))
                {
                    listStars.Remove(star);
                    star.Dispose();
                    break;
                }
            }
        }

        private void timeSpanTimer_Tick(object sender, EventArgs e)
        {
            currentTime = DateTime.Now.TimeOfDay;
            changeTime += currentTime - startTime;
            startTime = currentTime;
            lblTimeSpan.Text = changeTime.ToString(@"mm\:ss");
        }

        private void clearAll()
        {
            for (int i = 0; i < this.Controls.Count; i++)
                if (this.Controls[i] is PictureBox && this.Controls[i].Name != "closePB" && this.Controls[i].Name != "minimizePB")
                {
                    this.Controls.RemoveAt(i);
                }
            listStars.Clear();
            listStones.Clear();
        }

        private void lblShowSol_Click(object sender, EventArgs e)
        {
            showSolNr++;

            foreach (PictureBox star in listStars)
            {
                star.Dispose();
            }

            listStars.Clear();

            MazeGeneratorPrim.findSolution(chImg.Left / tileDim, chImg.Top / tileDim, 0, xf, yf, a);

            for (int k = 1; k < MazeGeneratorPrim.solLength; k++)
            {
                PictureBox imgPath = new PictureBox();
                imgPath.Size = new Size(tileDim, tileDim);
                imgPath.SizeMode = PictureBoxSizeMode.StretchImage;
                imgPath.Image = Properties.Resources.Grass_Solution;
                imgPath.Location = new Point(MazeGeneratorPrim.solPath[k].X * tileDim, MazeGeneratorPrim.solPath[k].Y * tileDim);

                this.Controls.Add(imgPath);
                imgPath.Parent = imgParent;
                imgPath.BackColor = Color.Transparent;
                imgPath.BringToFront();

                listStars.Add(imgPath);
            }

            chImg.BringToFront();
        }

        private void checkForPauseTimer_Tick(object sender, EventArgs e)
        {
            if(pKeyPressed && !paused)
            {
                lblPaused.Visible = true;
                lblPaused.BringToFront();
                timeSpanTimer.Stop();
                characterTmer.Stop();
                paused = true;
                running = false;
            }
            if(!pKeyPressed && !running)
            {
                lblPaused.Visible = false;
                timeSpanTimer.Start();
                startTime = DateTime.Now.TimeOfDay;
                characterTmer.Start();
                paused = false;
                running = true;
            }
        }
    }
}
