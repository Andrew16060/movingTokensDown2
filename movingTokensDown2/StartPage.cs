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
    public partial class StartPage : Form
    {
        public StartPage()
        {
            InitializeComponent();
        }

        string pathUsername = @"../../../gameNames.txt";
        string pathTimeScore = @"../../../gameTimeScore.txt";

        private void btnStart_Click(object sender, EventArgs e)
        {
            Form1 gameForm = new Form1();
            this.Hide();
            gameForm.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnHighScores_Click(object sender, EventArgs e)
        {
            string[] readUsername = File.ReadAllLines(pathUsername);
            string[] readTimeScore = File.ReadAllLines(pathTimeScore);
            int[] readTimeScoreInt = new int[readTimeScore.Length];
            for (int i = 0; i < readTimeScore.Length; i++)
            {
                readTimeScoreInt[i] = Convert.ToInt32(readTimeScore[i]);
            }
            Array.Sort(readTimeScoreInt, readUsername);

            int limit = 0;
            string output = "";
            for (int i = readUsername.Length - 1; i > 0; i--)
            {
                if (limit < 10)
                {
                    output += readUsername[i] + " " + readTimeScoreInt[i].ToString() + "\r\n";
                    limit++;
                }
            }
            MessageBox.Show(output);
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            HelpForm helpPage = new HelpForm();
            helpPage.Show();
        }

        private void lblWelcomeText_Click(object sender, EventArgs e)
        {

        }
    }
}
