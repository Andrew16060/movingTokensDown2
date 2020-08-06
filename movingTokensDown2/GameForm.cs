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
        const int GREEN_DISTANCE = 1;
        int down = 1;
        const int LEFT = -1;
        const int RIGHT = 1;
        const int RED_DISTANCE = 60;
        // counts the amount of items in the list
        int listNumber = 0;
        // defines a variable to make sure there is a space between each line of squares
        int waitTime = 150;
        // deifnes the play time variable to keep track of the score
        int playTime = 0;
        // defines the variable to allow only 6 lines of squares to be made
        int resetTime = 0;
        // defines duplicte boolean to make sure that the game over text doesn't appear more than once
        bool noDuplicate = true;

        // Displays the player controlled character when the form loads
        private void Form1_Load(object sender, EventArgs e)
        {
            // creates the red square which the player controls using the class defining the specific start position and the image file location
            redSquarePlayer = new SquareImage(15, 629, redSquareImage);
            // adds the red square to the form
            Controls.Add(redSquarePlayer.SquarePictureBox);
        }

        // When the start button is clicked it starts the two timers to keep track of the time and to move the sick sqaures towards the player
        private void btnStart_Click(object sender, EventArgs e)
        {
            // starts the move green squares timer to allow the game to start
            MoveGreenSquares.Enabled = true;
            // starts the time played timer to keep track of the players score
            TimePlayed.Enabled = true;
        }

        // Moves the pictures boxes down the screen
        private void MoveGreenSquares_Tick(object sender, EventArgs e)
        {
            // defines the number for the maximum amount of squares to be placed in a row
            const int MAX_SQUARES = 5;
            // defines the maximum amount of rows to be added before it loops through them
            const int MAX_ROWS = 6;
            // Slowly increases the speed of the picture boxes to increase difficulty as the game progresses
            if (playTime == 30)
            {
                // decreases the move squares timer interval to increase speed
                MoveGreenSquares.Interval = 60;
                // increases the distance that the squares move down the form
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
            if (resetTime < MAX_ROWS)
            {
                // wait time is used to make sure a gap is made between the lines to allow the player to move between them
                if (waitTime == 150)
                {
                    // creates the squares at a fixed y position using a random x value
                    for (int i = 0; i < MAX_SQUARES; i++)
                    {
                        // picks a random number from 0 to 6 which picks a slot in the line to insert a square
                        int randNumber = rand.Next(0, 6);
                        // multiplies the number by 60 to get the distance between the images as well as adding 15 for a gap on the side of the game
                        int xCoordinate = randNumber * 60 + 15;
                        // creates the green squares using the square image class 
                        greenSquares.Add(new SquareImage(xCoordinate, -60, greenSquareImage));
                        // adds the squares to the game form
                        Controls.Add(greenSquares[listNumber].SquarePictureBox);
                        listNumber++;
                    }
                    // sets the wait time to 0 to add the gap again when a new row is created
                    waitTime = 0;
                    // adds one to the reset time variable to only allow 6 rows to be created
                    resetTime++;
                }
                // adds to the wait time integer when the squares move down
                waitTime++;
                // calls the boundsIntersect method to check when the bounds of the picture boxes intersect indicating to the code to end the game
                BoundsIntersect();
            }
            else
            {
                BoundsIntersect();
                // loops through all the green squares
                for (int i = 0; i < greenSquares.Count; i++)
                {
                    // check if the greenSquares are positioned off the screen so that they can be moved back to the top to be reused again
                    if (greenSquares[i].SquarePictureBox.Location.Y > 800)
                    {
                        // calls the reset position method from the green squares class
                        greenSquares[i].ResetPosition();
                        // picks a new point for the squares to be placed on a line
                        int randNumber = rand.Next(0, 6);
                        int xCoordinate = randNumber * 60 + 15;
                        // moves the green square right a random distance to get the squares to be displayed in a random order again as it is a new line
                        greenSquares[i].MoveRightLeft(RIGHT, xCoordinate);
                    }
                }
            }
        }

        // detect when the player presses the 'A' or 'D' key so that it moves the redSquarePlayer left or right respectively
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            // detects the key pressed
            if (e.KeyCode == Keys.A)
            {
                // calls the move right or left method from the square image class to then move the square
                redSquarePlayer.MoveRightLeft(LEFT, RED_DISTANCE);
            }
            if (e.KeyCode == Keys.D)
            {
                redSquarePlayer.MoveRightLeft(RIGHT, RED_DISTANCE);
            }
            // stops the redSquarePlayer from moving off the screen
            // detects when a square is position off of the screen
            if (redSquarePlayer.SquarePictureBox.Location.X < 15)
            {
                // moves the square in the equal and opposite direction forcing it to stay on screen
                redSquarePlayer.MoveRightLeft(RIGHT, RED_DISTANCE);
            }
            if (redSquarePlayer.SquarePictureBox.Location.X > 315)
            {
                redSquarePlayer.MoveRightLeft(LEFT, RED_DISTANCE);
            }
        }

        // keeps track of the time played in the integer 'playTime'
        private void TimePlayed_Tick(object sender, EventArgs e)
        {
            // increases the play time interger every tick of the time played timer
            playTime++;
            // adds the score to the top left of the game form
            this.Text = "TIME: " + playTime.ToString();
        }

        // bounds intersect method to check if the square image bounds are intersecting with others causing the game to end
        public void BoundsIntersect()
        {
            // loops through all the green squares
            for (int i = 0; i < greenSquares.Count; i++)
            {
                // makes sure the end game message box only appears once by using this boolean which turns to fals once the if statement is run
                if (noDuplicate == true)
                {
                    // detect when the picture boxes intersect to indicate that you have lost the game
                    greenSquares[i].MoveDown(down, GREEN_DISTANCE);
                    if (greenSquares[i].SquarePictureBox.Bounds.IntersectsWith(redSquarePlayer.SquarePictureBox.Bounds))
                    {
                        // sets the duplicate boolean to false to not run this if statement more than once
                        noDuplicate = false;
                        // disables all timers to stop the game from running
                        MoveGreenSquares.Enabled = false;
                        TimePlayed.Enabled = false;
                        // displays game over message to alert the player that they have finished playing
                        MessageBox.Show("GAME OVER!");
                        // gets the playTime value to send it to the endScreen form to be saved in a file
                        EndScreen endScreen = new EndScreen(playTime);
                        // hides current form and displays end screen
                        this.Hide();
                        endScreen.Show();
                        this.Close();
                    }
                }
            }
        }
    }
}
