using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Maze_v1._0
{
    class MazeGeneratorPrim
    {
        static Random rnd = new Random();

        static int[] dx = new int[4] { -1, 0, 1, 0 };
        static int[] dy = new int[4] { 0, 1, 0, -1 };
        public static int maxl=0;
        public static int solLength = 0;
        public static Point[] path = new Point[2500];
        public static Point[] maxPath = new Point[2500];
        public static Point[] solPath = new Point[2500];

        public static void createBoundaries (int x, int y, ref int[,] a)
        {
            int xi, yi;
            for (xi = 0; xi <= x + 1; xi++)
                a[0, xi] = a[y + 1, xi] = 2;
            for (yi = 1; yi <= y; yi++)
                a[yi, 0] = a[yi, x + 1] = 2;
        }

        public static void fillGrid (int x, int y, ref int[,] a)
        {
            int xi,yi;
            for (yi = 1; yi <= y; yi++)
                for (xi = 1; xi <= x; xi++)
                    a[yi, xi] = 1;
        }

        public static void startPoint(int x, int y, ref int xs, ref int ys, ref int[,] a)
        {
            xs = rnd.Next(1, x);
            ys = rnd.Next(1, y);
            /*int start = rnd.Next(1, 100)%2;

            if (start == 1)
            {
                xs = rnd.Next(1, 2);
                if (xs == 2)
                    xs = x;
                ys = rnd.Next(1, y);
            }
            else
            {
                ys = rnd.Next(1, 2);
                if (ys == 2)
                    ys = y;
                xs = rnd.Next(1, x);
            }*/
            a[ys, xs] = 0;            
        }

        static bool checkNeighboursForGo(int x, int y, int xPos, int yPos, int orig, int[,] a)
        {
            if(xPos<1 || xPos>x || yPos<1 || yPos>y)
                return false;

            int i, X, Y;

            for(i=0; i<4; i++)
                if(i!=orig)
                {
                    X=xPos+dx[i];
                    Y=yPos+dy[i];

                    if(a[Y, X]==0)
                        return false;
                }
            return true;
        }

        public static void primAlgorithm (int x, int y, int xPres, int yPres, int orig, ref int[,] a)
        {
            if(checkNeighboursForGo(x, y, xPres, yPres, orig, a))
            {
                a[yPres, xPres]=0;

                int i= rnd.Next(0,3);
                for(int j=0; j<4; j++)
                    primAlgorithm(x, y, xPres+dx[(j+i)%4], yPres+dy[(j+i)%4], (j+i+2)%4, ref a);
            }
        }

        public static void generateMap(int x, int y, ref int xs, ref int ys, ref int[,] a)
        {
            createBoundaries (x, y, ref a);
            fillGrid (x ,y, ref a);
            startPoint(x, y, ref xs, ref ys, ref a);

            int i;

            do
            {
                i= rnd.Next(0,3);
            }while(a[ys+dy[i], xs+dx[i]]==2);

            primAlgorithm(x, y, xs+dx[i], ys+dy[i], (i+2)%4, ref a);
        }

        public static void findMaxLength(int x, int y, int i, ref int xf, ref int yf, int[,] a)
        {
            int j, X, Y;

            path[i] = new Point(x, y);

            if(i>maxl)
            {
                maxl = i;
                xf = x;
                yf = y;
                Array.Copy(path, maxPath, 2500);
            }

            for(j=0; j<4; j++)
            {
                X = x + dx[j];
                Y = y + dy[j];

                if (a[Y, X] == 0)
                {
                    a[Y, X] = 1;
                    findMaxLength(X, Y, i+1, ref xf, ref yf, a);
                    a[Y, X] = 0;
                }
            }
        }

        public static void findSolution(int x, int y, int i, int xf, int yf, int[,] a)
        {
            path[i] = new Point(x, y);

            if (x == xf && y == yf)
            {
                Array.Copy(path, solPath, 2500);
                solLength = i;
            }
            else
            {
                int j, X, Y;
                for (j = 0; j < 4; j++)
                {
                    X = x + dx[j];
                    Y = y + dy[j];

                    if (a[Y, X] == 0)
                    {
                        a[y, x] = 1;
                        findSolution(X, Y, i + 1, xf, yf, a);
                        a[y, x] = 0;
                    }
                }
            }
        }
    }
}
