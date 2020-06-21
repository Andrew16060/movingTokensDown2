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

        Random rand = new Random();
        List<token> redTokens = new List<token>();
        token blueToken;
        //size 35, 35 for red and blue tokens
        Bitmap redImage = new Bitmap(@"../../../redCircle.png");
        Bitmap blueImage = new Bitmap(@"../../../blueCircle.png");
        int redDist = 1;
        int down = 1;
        int left = -1;
        int right = 1;
        int blueDist = 35;
        int listNumber = 0;
        int waitTime = 90;
        int playTime = 0;
        int resetTime = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
            blueToken = new token(15, 344, blueImage);
            Controls.Add(blueToken.TokenPictureBox);
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            moveToken.Enabled = true;
            timePlayed.Enabled = true;
        }

        private void moveToken_Tick(object sender, EventArgs e)
        {
            if (playTime == 20)
            {
                moveToken.Interval = 20;
            }
            if (playTime == 25)
            {
                moveToken.Interval = 15;
            }
            if (playTime == 30)
            {
                moveToken.Interval = 10;
            }
            if (playTime == 35)
            {
                moveToken.Interval = 5;
            }
            if (playTime == 40)
            {
                moveToken.Interval = 1;
            }

            if (resetTime < 6)
            {
                lblTest.Text = waitTime.ToString();
                if (waitTime == 90)
                {
                    for (int i = 0; i < 5; i++)
                    {
                        int randNumber = rand.Next(0, 6);
                        int xCoordinate = randNumber * 35 + 15;
                        redTokens.Add(new token(xCoordinate, -35, redImage));
                        Controls.Add(redTokens[listNumber].TokenPictureBox);
                        listNumber++;
                    }
                    waitTime = 0;
                    resetTime++;
                }
                waitTime++;
                for (int i = 0; i < redTokens.Count; i++)
                {
                    redTokens[i].moveUpDown(down, redDist);
                    if (redTokens[i].TokenPictureBox.Bounds.IntersectsWith(blueToken.TokenPictureBox.Bounds))
                    {
                        moveToken.Enabled = false;
                        timePlayed.Enabled = false;
                        MessageBox.Show("GAME OVER!");
                        EndScreen endScreen = new EndScreen(playTime);
                        this.Hide();
                        endScreen.ShowDialog();
                        this.Close();
                    }
                }
            }
            else
            {
                for (int i = 0; i < redTokens.Count; i++)
                {
                    redTokens[i].moveUpDown(down, redDist);
                    if (redTokens[i].TokenPictureBox.Bounds.IntersectsWith(blueToken.TokenPictureBox.Bounds))
                    {
                        moveToken.Enabled = false;
                        timePlayed.Enabled = false;
                        MessageBox.Show("GAME OVER!");
                        EndScreen endScreen = new EndScreen(playTime);
                        this.Hide();
                        endScreen.ShowDialog();
                        this.Close();
                    }
                    if (redTokens[i].TokenPictureBox.Location.Y > 476)
                    {
                        redTokens[i].resetPosition();
                        int randNumber = rand.Next(0, 6);
                        int xCoordinate = randNumber * 35 + 15;
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
            if (blueToken.TokenPictureBox.Location.X > 190)
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
