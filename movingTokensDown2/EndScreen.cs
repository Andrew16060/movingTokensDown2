using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace movingTokensDown2
{
    public partial class EndScreen : Form
    {
        public EndScreen(int timeScore)
        {
            InitializeComponent();
            timeScore2 = timeScore;
        }

        int timeScore2;
        string pathUsername = @"../../../gameNames.txt";
        string pathTimeScore = @"../../../gameTimeScore.txt";

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "")
            {
                MessageBox.Show("Please input a name.");
            }
            else
            {
                
                string username = txtName.Text;
                File.AppendAllText(pathUsername, username + "\r\n");
                File.AppendAllText(pathTimeScore, timeScore2 + "\r\n");
                MessageBox.Show("Well done " + username + " on getting a score of " + timeScore2 + "!");
                string[] readUsername = File.ReadAllLines(pathUsername);
                string[] readTimeScore = File.ReadAllLines(pathTimeScore);
                Array.Sort(readTimeScore, readUsername);
                for (int i = readUsername.Length - 1; i > 0; i--)
                {
                    int limit = 0;
                    if  (limit < 10)
                    {
                        lblHighScores.Text += "\r\n" + readUsername[i] + " " + readTimeScore[i];
                        limit++;
                    }
                }
            }
        }
    }
}
