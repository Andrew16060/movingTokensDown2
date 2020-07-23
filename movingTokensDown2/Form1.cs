using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace movingTokensDown2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Defines random variable
        Random rand = new Random();
        // Creates list for displaying the sick squares linking to the token class for getting the image properties
        List<token> redTokens = new List<token>();
        token blueToken;
        // The squares are 60 by 60 pixels
        // Defines location for images to be used in class
        Bitmap redImage = new Bitmap(@"../../../squareSick.png");
        Bitmap blueImage = new Bitmap(@"../../../squarePlayer.png");
        // Defines variables used such as the distance the  pictures move etc.
        int redDist = 1;
        int down = 1;
        int left = -1;
        int right = 1;
        int blueDist = 60;
        int listNumber = 0;
        int waitTime = 150;
        int playTime = 0;
        int resetTime = 0;
        int noDuplicate = 0;

        // Displays the player controlled character when the form loads
        private void Form1_Load(object sender, EventArgs e)
        {
            blueToken = new token(15, 629, blueImage);
            Controls.Add(blueToken.TokenPictureBox);
        }

        // When the start button is clicked it starts the two timers to keep track of the time and to move the sick sqaures towards the player
        private void btnStart_Click(object sender, EventArgs e)
        {
            moveToken.Enabled = true;
            timePlayed.Enabled = true;
        }

        // Moves the pictures boxes down the screen
        private void moveToken_Tick(object sender, EventArgs e)
        {
            // Slowly increases the speed of the picture boxes to increase difficulty as the game progresses
            if (playTime == 30)
            {
                moveToken.Interval = 60;
                down = 2;
            }
            if (playTime == 35)
            {
                moveToken.Interval = 40;
                down = 3;
            }
            if (playTime == 45)
            {
                moveToken.Interval = 35;
            }
            if (playTime == 50)
            {
                moveToken.Interval = 30;
                down = 4;
            }
            // Creates 
            if (resetTime < 6)
            {
                if (waitTime == 150)
                {
                    for (int i = 0; i < 5; i++)
                    {
                        int randNumber = rand.Next(0, 6);
                        int xCoordinate = randNumber * 60 + 15;
                        redTokens.Add(new token(xCoordinate, -60, redImage));
                        Controls.Add(redTokens[listNumber].TokenPictureBox);
                        listNumber++;
                    }
                    waitTime = 0;
                    resetTime++;
                }
                waitTime++;
                for (int i = 0; i < redTokens.Count; i++)
                {
                    if (noDuplicate < 1)
                    {
                        redTokens[i].moveUpDown(down, redDist);
                        if (redTokens[i].TokenPictureBox.Bounds.IntersectsWith(blueToken.TokenPictureBox.Bounds))
                        {
                            noDuplicate++;
                            moveToken.Enabled = false;
                            timePlayed.Enabled = false;
                            MessageBox.Show("GAME OVER!");
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
                for (int i = 0; i < redTokens.Count; i++)
                {
                    if (noDuplicate < 1)
                    {
                        redTokens[i].moveUpDown(down, redDist);
                        if (redTokens[i].TokenPictureBox.Bounds.IntersectsWith(blueToken.TokenPictureBox.Bounds))
                        {
                            noDuplicate++;
                            moveToken.Enabled = false;
                            timePlayed.Enabled = false;
                            MessageBox.Show("GAME OVER!");
                            EndScreen endScreen = new EndScreen(playTime);
                            this.Hide();
                            endScreen.Show();
                            this.Close();
                        }
                    }
                    if (redTokens[i].TokenPictureBox.Location.Y > 800)
                    {
                        redTokens[i].resetPosition();
                        int randNumber = rand.Next(0, 6);
                        int xCoordinate = randNumber * 60 + 15;
                        redTokens[i].moveRightLeft(right, xCoordinate);
                    }
                }
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A)
            {
                blueToken.moveRightLeft(left, blueDist);
            }
            if (e.KeyCode == Keys.D)
            {
                blueToken.moveRightLeft(right, blueDist);
            }
            if (blueToken.TokenPictureBox.Location.X < 15)
            {
                blueToken.moveRightLeft(right, blueDist);
            }
            if (blueToken.TokenPictureBox.Location.X > 315)
            {
                blueToken.moveRightLeft(left, blueDist);
            }
        }

        private void timePlayed_Tick(object sender, EventArgs e)
        {
            playTime++;
            this.Text = "TIME: " + playTime.ToString();
        }
    }
}
