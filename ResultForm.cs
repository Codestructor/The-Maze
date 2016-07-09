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

namespace Maze_v1._0
{
    public partial class ResultForm : Form
    {
        [DllImport("User32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("User32.dll")]
        public static extern int SendMessage(IntPtr Handle, int Msg, int Param1, int Param2);

        public ResultForm(string message)
        {
            InitializeComponent();
            lblDebug.Text = message;
        }

        private void ResultForm_Load(object sender, EventArgs e)
        {
            moveLbl.Width = this.Width;
            moveLbl.Height = 30;
            moveLbl.Location = new Point(0, 0);

            exit.Left = 20;
            exit.Top = this.Height - exit.Height - 20;

            nextLvl.Left = this.Width - nextLvl.Width - 20;
            nextLvl.Top = this.Height - nextLvl.Height - 20;

            lblDebug.Width = 70 * this.Width / 100;
            lblDebug.Height = 40 * this.Height / 100;
            lblDebug.Left = this.Width / 2 - lblDebug.Width / 2;
            lblDebug.Top = moveLbl.Height + (nextLvl.Top - moveLbl.Height)/ 2 - lblDebug.Height / 2;
        }

        private void moveLbl_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, 0xA1, 0x2, 0);
            }
        }

        private void exit_Click(object sender, EventArgs e)
        {
            MazeMap.isExit = true;
            this.Close();
        }

        private void nextLvl_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
