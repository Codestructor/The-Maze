using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Resources;
using System.IO;

namespace Maze_v1._0
{
    class UserIO
    {
        public struct userDetails
        {
            public string name, password;
            public int score, levelNr;
        }

        public static userDetails[] users = new userDetails[1000];
        public static int nrUsers = 0;
        public static int currentPlayer = 0;

        public static void readUsers(string path)
        {
            StreamReader str = new StreamReader(path);
            string[] userData = new string[3];

            while(str.Peek()>=0)
            {
                userData = str.ReadLine().Split(' ');
                nrUsers++;
                users[nrUsers].name = userData[0];
                users[nrUsers].password = userData[1];
                users[nrUsers].score = Convert.ToInt32(userData[2]);
                users[nrUsers].levelNr = Convert.ToInt32(userData[3]);
            }

            str.Close();
        }

        private static void arrangeUsers()
        {
            int i, j;
            userDetails aux;

            for(i=1; i<nrUsers; i++)
                for(j=i+1; j<=nrUsers; j++)
                    if(users[i].score<users[j].score)
                    {
                        aux = users[i];
                        users[i] = users[j];
                        users[j] = aux;
                    }
        }

        public static void writeUsers(string path)
        {
            arrangeUsers();

            using (StreamWriter stw = File.CreateText(path))
            {
                string userData;

                for (int i = 1; i <= nrUsers; i++)
                {
                    userData = users[i].name + " " + users[i].password + " " + users[i].score.ToString() + " " + users[i].levelNr.ToString();
                    stw.WriteLine(userData);
                }
                stw.Close();
            }
        }

        public static int checkSignInDetails(string username, string password)
        {
            for (int i = 1; i <= nrUsers; i++)
                if (users[i].name == username)
                    if (users[i].password == password)
                    {
                        currentPlayer = i;
                        return 1;
                    }
                    else
                        return 2;
            return 0;
        }

        public static int checkSignUpDetails(string username, string password, string cPassword)
        {
            for (int i = 1; i <= nrUsers; i++)
                if (users[i].name == username)
                    return 1;   //Username already exists
            if (password != cPassword)
                return 2;   //Password and Password confirmation not the same
            else
                if (password.Length < 8)
                    return 3;   //Password too short
            return 0;   //Acount details valid
        }

        public static void addUser(string username, string password)
        {
            nrUsers++;
            currentPlayer = nrUsers;
            users[nrUsers].name = username;
            users[nrUsers].password = password;
            users[nrUsers].score = 0;
            users[nrUsers].levelNr = 1;
        }

        public static void writeUsersToRichTxtBox(RichTextBox richTxtBox)
        {
            arrangeUsers();

            for(int i=1; i<=nrUsers; i++)
            {
                richTxtBox.Text += i.ToString() + ". " + users[i].name + ": " + users[i].score.ToString();
                richTxtBox.Text += Environment.NewLine;
            }
        }

    }
}
