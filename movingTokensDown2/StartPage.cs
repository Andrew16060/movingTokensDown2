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
            Application.Exit();
        }

        // Displays the highscores for the game
        private void btnHighScores_Click(object sender, EventArgs e)
        {
            HighScore highScore = new HighScore();
            highScore.DisplayHighScores();
            MessageBox.Show(highScore.Output);
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
