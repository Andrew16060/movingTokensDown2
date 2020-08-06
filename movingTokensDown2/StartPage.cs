using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace AssessmentGame
{
    public partial class StartPage : Form
    {
        public StartPage()
        {
            InitializeComponent();
        }

        

        // Allows the application to close when the exit button is pressed
        private void btnExit_Click(object sender, EventArgs e)
        {
            // closes application
            Application.Exit();
        }

        // Displays the highscores for the game
        private void btnHighScores_Click(object sender, EventArgs e)
        {
            // intialise high score class to gain the highs scores from the text files to be displayed in the message box
            HighScore highScore = new HighScore();
            // calls the high score method from the class
            highScore.DisplayHighScores();
            // displays the output variable gained from the high score method
            MessageBox.Show(highScore.Output);
        }

        // Displays the tutorial page when this button is clicked
        private void btnHelp_Click(object sender, EventArgs e)
        {
            // shows the help page
            HelpForm helpPage = new HelpForm();
            helpPage.Show();
        }

        // Displays the game form when the start button is clicked
        private void btnStart_Click_1(object sender, EventArgs e)
        {
            // shows the game form
            GameForm gameForm = new GameForm();
            // hides current form
            this.Hide();
            gameForm.Show();
        }
    }
}
