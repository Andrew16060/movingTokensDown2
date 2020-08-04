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
        const string PATH_USERNAME = @"../../../gameNames.txt";
        const string PATH_TIME_SCORE = @"../../../gameTimeScore.txt";

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
                File.AppendAllText(PATH_USERNAME, username + "\r\n");
                File.AppendAllText(PATH_TIME_SCORE, timeScore2 + "\r\n");
                MessageBox.Show("Well done " + username + " on getting a score of " + timeScore2 + "!");
                btnSubmit.Enabled = false;
            }
        }

        // displays the top 10 highscores in the text files
        private void btnHighScores_Click(object sender, EventArgs e)
        {
            HighScore highScore = new HighScore();
            highScore.DisplayHighScores();
            MessageBox.Show(highScore.Output);
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
