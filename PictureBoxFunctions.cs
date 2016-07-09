using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Maze_v1._0
{
    class PictureBoxFunctions
    {
        public static void imgChange(ref PictureBox chImg, ref int chStep, string stg)
        {
            switch (stg)
            {
                case "UStay":
                    chImg.Image = Properties.Resources.UStay;
                    break;
                case "U1":
                    chImg.Image = Properties.Resources.U1;
                    break;
                case "U2":
                    chImg.Image = Properties.Resources.U2;
                    break;
                case "U3":
                    chImg.Image = Properties.Resources.U3;
                    break;
                case "U4":
                    chImg.Image = Properties.Resources.U4;
                    break;
                case "RStay":
                    chImg.Image = Properties.Resources.RStay;
                    break;
                case "R1":
                    chImg.Image = Properties.Resources.R1;
                    break;
                case "R2":
                    chImg.Image = Properties.Resources.R2;
                    break;
                case "R3":
                    chImg.Image = Properties.Resources.R3;
                    break;
                case "R4":
                    chImg.Image = Properties.Resources.R4;
                    break;
                case "DStay":
                    chImg.Image = Properties.Resources.DStay;
                    break;
                case "D1":
                    chImg.Image = Properties.Resources.D1;
                    break;
                case "D2":
                    chImg.Image = Properties.Resources.D2;
                    break;
                case "D3":
                    chImg.Image = Properties.Resources.D3;
                    break;
                case "D4":
                    chImg.Image = Properties.Resources.D4;
                    break;
                case "LStay":
                    chImg.Image = Properties.Resources.LStay;
                    break;
                case "L1":
                    chImg.Image = Properties.Resources.L1;
                    break;
                case "L2":
                    chImg.Image = Properties.Resources.L2;
                    break;
                case "L3":
                    chImg.Image = Properties.Resources.L3;
                    break;
                case "L4":
                    chImg.Image = Properties.Resources.L4;
                    break;
                default:
                    break;
            }
            chStep++;
            if (chStep >= 5)
                chStep = 1;
        }

        public static bool checkCollision(PictureBox collider, int x, int y, List<Rectangle> listObj)
        {
            Rectangle frame = new Rectangle(x, y, collider.Width, collider.Height);

            foreach (Rectangle obj in listObj)
                if (frame.IntersectsWith(obj))
                    return false;
            return true;
        }

    }
}
