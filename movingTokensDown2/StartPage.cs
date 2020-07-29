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

namespace AssessmentGame
{
    public partial class StartPage : Form
    {
        public StartPage()
        {
            InitializeComponent();
        }

        // Defines the location for the text files to be called later
        string pathUsername = @"../../../gameNames.txt";
        string pathTimeScore = @"../../../gameTimeScore.txt";

        // Allows the application to close when the exit button is pressed
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Displays the highscores for the game
        private void btnHighScores_Click(object sender, EventArgs e)
        {
            // Reads the text documents and adds the text into a string
            string[] readUsername = File.ReadAllLines(pathUsername);
            string[] readTimeScore = File.ReadAllLines(pathTimeScore);
            // Converts the string array into an int array for the score
            int[] readTimeScoreInt = new int[readTimeScore.Length];
            for (int i = 0; i < readTimeScore.Length; i++)
            {
                readTimeScoreInt[i] = Convert.ToInt32(readTimeScore[i]);
            }
            // Sorts the int array to get the top 10 scores
            Array.Sort(readTimeScoreInt, readUsername);

            // Defines the limit interger and the output string to eventually display only the top 10 scores in a message box
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
            // Shows the created string with the top 10 scores in a message box
            MessageBox.Show(output);
        }

        // Displays the tutorial page when this button is clicked
        private void btnHelp_Click(object sender, EventArgs e)
        {
            HelpForm helpPage = new HelpForm();
            helpPage.Show();
        }

        // Displays the game form when the start button is clicked
        private void btnStart_Click_1(object sender, EventArgs e)
        {
            GameForm gameForm = new GameForm();
            this.Hide();
            gameForm.Show();
        }
    }
}
