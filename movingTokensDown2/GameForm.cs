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
    public partial class GameForm : Form
    {
        public GameForm()
        {
            InitializeComponent();
        }

        // Defines random variable
        Random rand = new Random();
        // Creates list for displaying the sick squares linking to the SquareImage class for getting the image properties
        List<SquareImage> greenSquares = new List<SquareImage>();
        SquareImage redSquarePlayer;
        // The squares are 60 by 60 pixels
        // Defines location for images to be used in class
        Bitmap greenSquareImage = new Bitmap(@"../../../squareSick.png");
        Bitmap redSquareImage = new Bitmap(@"../../../squarePlayer.png");
        // Defines variables used such as the distance the  pictures move etc.
        int greenDistance = 1;
        int down = 1;
        int left = -1;
        int right = 1;
        int redDistance = 60;
        int listNumber = 0;
        int waitTime = 150;
        int playTime = 0;
        int resetTime = 0;
        int noDuplicate = 0;

        // Displays the player controlled character when the form loads
        private void Form1_Load(object sender, EventArgs e)
        {
            redSquarePlayer = new SquareImage(15, 629, redSquareImage);
            Controls.Add(redSquarePlayer.SquarePictureBox);
        }

        // When the start button is clicked it starts the two timers to keep track of the time and to move the sick sqaures towards the player
        private void btnStart_Click(object sender, EventArgs e)
        {
            MoveGreenSquares.Enabled = true;
            TimePlayed.Enabled = true;
        }

        // Moves the pictures boxes down the screen
        private void MoveGreenSquares_Tick(object sender, EventArgs e)
        {
            // Slowly increases the speed of the picture boxes to increase difficulty as the game progresses
            if (playTime == 30)
            {
                MoveGreenSquares.Interval = 60;
                down = 2;
            }
            if (playTime == 35)
            {
                MoveGreenSquares.Interval = 40;
                down = 3;
            }
            if (playTime == 45)
            {
                MoveGreenSquares.Interval = 35;
            }
            if (playTime == 50)
            {
                MoveGreenSquares.Interval = 30;
                down = 4;
            }
            // Creates the rows of squares to then be looped when they are moved off the screen
            if (resetTime < 6)
            {
                if (waitTime == 150)
                {
                    for (int i = 0; i < 5; i++)
                    {
                        int randNumber = rand.Next(0, 6);
                        int xCoordinate = randNumber * 60 + 15;
                        greenSquares.Add(new SquareImage(xCoordinate, -60, greenSquareImage));
                        Controls.Add(greenSquares[listNumber].SquarePictureBox);
                        listNumber++;
                    }
                    waitTime = 0;
                    resetTime++;
                }
                waitTime++;
                for (int i = 0; i < greenSquares.Count; i++)
                {
                    if (noDuplicate < 1)
                    {
                        // detect when the picture boxes intersect to indicate that you have lost the game
                        greenSquares[i].moveUpDown(down, greenDistance);
                        if (greenSquares[i].SquarePictureBox.Bounds.IntersectsWith(redSquarePlayer.SquarePictureBox.Bounds))
                        {
                            noDuplicate++;
                            MoveGreenSquares.Enabled = false;
                            TimePlayed.Enabled = false;
                            MessageBox.Show("GAME OVER!");
                            // gets the playTime value to send it to the endScreen form to be saved in a file
                            EndScreen endScreen = new EndScreen(playTime);
                            this.Hide();
                            endScreen.Show();
                            this.Close();
                        }
                    }
                }
            }
            else
            {
                for (int i = 0; i < greenSquares.Count; i++)
                {
                    if (noDuplicate < 1)
                    {
                        // detect when the picture boxes intersect to indicate that you have lost the game
                        greenSquares[i].moveUpDown(down, greenDistance);
                        if (greenSquares[i].SquarePictureBox.Bounds.IntersectsWith(redSquarePlayer.SquarePictureBox.Bounds))
                        {
                            noDuplicate++;
                            MoveGreenSquares.Enabled = false;
                            TimePlayed.Enabled = false;
                            MessageBox.Show("GAME OVER!");
                            // gets the playTime value to send it to the endScreen form to be saved in a file
                            EndScreen endScreen = new EndScreen(playTime);
                            this.Hide();
                            endScreen.Show();
                            this.Close();
                        }
                    }
                    // check if the greenSquares are positioned off the screen so that they can be moved back to the top to be reused again
                    if (greenSquares[i].SquarePictureBox.Location.Y > 800)
                    {
                        greenSquares[i].resetPosition();
                        int randNumber = rand.Next(0, 6);
                        int xCoordinate = randNumber * 60 + 15;
                        greenSquares[i].moveRightLeft(right, xCoordinate);
                    }
                }
            }
        }

        // detect when the player presses the 'A' or 'D' key so that it moves the redSquarePlayer left or right respectively
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A)
            {
                redSquarePlayer.moveRightLeft(left, redDistance);
            }
            if (e.KeyCode == Keys.D)
            {
                redSquarePlayer.moveRightLeft(right, redDistance);
            }
            // stops the redSquarePlayer from moving off the screen
            if (redSquarePlayer.SquarePictureBox.Location.X < 15)
            {
                redSquarePlayer.moveRightLeft(right, redDistance);
            }
            if (redSquarePlayer.SquarePictureBox.Location.X > 315)
            {
                redSquarePlayer.moveRightLeft(left, redDistance);
            }
        }

        // keeps track of the time played in the integer 'playTime'
        private void TimePlayed_Tick(object sender, EventArgs e)
        {
            playTime++;
            this.Text = "TIME: " + playTime.ToString();
        }
    }
}
