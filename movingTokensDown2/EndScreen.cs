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
    public partial class EndScreen : Form
    {
        // gets the playTime integer from the GameForm to be saved in a text file
        public EndScreen(int timeScore)
        {
            InitializeComponent();
            timeScore2 = timeScore;
        }

        // defines the path to the files where the scores and names are located
        int timeScore2;
        string pathUsername = @"../../../gameNames.txt";
        string pathTimeScore = @"../../../gameTimeScore.txt";

        // when the submit button is clicked it will save the name inputted into the text box into a file as well as the score with the same index
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            // checks if the textbox is empty to ensure that you have inputted a name
            if (txtName.Text == "")
            {
                MessageBox.Show("Please input a name.");
                btnSubmit.Enabled = true;
            }
            else
            {
                // adds the name and score to text files with the same index to be called and sorted later
                string username = txtName.Text;
                File.AppendAllText(pathUsername, username + "\r\n");
                File.AppendAllText(pathTimeScore, timeScore2 + "\r\n");
                MessageBox.Show("Well done " + username + " on getting a score of " + timeScore2 + "!");
                btnSubmit.Enabled = false;
            }
        }

        // displays the top 10 highscores in the text files
        private void btnHighScores_Click(object sender, EventArgs e)
        {
            // converts the text files names and playTime scores into arrays
            string[] readUsername = File.ReadAllLines(pathUsername);
            string[] readTimeScore = File.ReadAllLines(pathTimeScore);
            int[] readTimeScoreInt = new int[readTimeScore.Length];
            // converts the playTime string array into an int array to be sorted by number
            for (int i = 0; i < readTimeScore.Length; i++)
            {
                readTimeScoreInt[i] = Convert.ToInt32(readTimeScore[i]);
            }
            // sort both arrays by the the highest to the lowest value of the playTime array using parallel arrays
            Array.Sort(readTimeScoreInt, readUsername);

            int limit = 0;
            string output = "";
            // adds the top 10 scores into a string to be displayed in a singular message box
            for (int i = readUsername.Length - 1; i > 0; i--)
            {
                if (limit < 10)
                {
                    output += readUsername[i] + " " + readTimeScoreInt[i].ToString() + "\r\n";
                    limit++;
                }
            }
            // displays scores
            MessageBox.Show(output);
        }

        // takes you back to the menu
        private void btnMenu_Click(object sender, EventArgs e)
        {
            StartPage menu = new StartPage();
            this.Hide();
            menu.Show();
        }

        // only allow alphabetical characters in the name text box
        // code by 'V4Vendetta' from https://stackoverflow.com/questions/8321871/how-to-make-a-textbox-accept-only-alphabetic-characters
        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }
    }
}
