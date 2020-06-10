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
        Bitmap redImage = new Bitmap(@"../../../redCircle.png");
        Bitmap blueImage = new Bitmap(@"../../../blueCircle.png");
        int redDist = 1;
        int down = 1;
        int left = -1;
        int right = 1;
        int blueDist = 5;
        int listNumber = 0;
        int waitTime = 35;

        private void Form1_Load(object sender, EventArgs e)
        {
            blueToken = new token(15, 362, blueImage);
            Controls.Add(blueToken.TokenPictureBox);
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            moveToken.Enabled = true;
        }

        private void moveToken_Tick(object sender, EventArgs e)
        {
            lblTest.Text = waitTime.ToString();
            if (waitTime == 35)
            {
                for (int i = 0; i < 3; i++)
                {
                    int randNumber = rand.Next(0, 10);
                    int xCoordinate = randNumber * 35 + 15;
                    redTokens.Add(new token(xCoordinate, 0, redImage));
                    Controls.Add(redTokens[listNumber].TokenPictureBox);
                    listNumber++;
                }
                waitTime = 0;
            }
            for (int i = 0; i < redTokens.Count; i++)
            {
                redTokens[i].moveUpDown(down, redDist);
            }
            waitTime++;
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
        }
    }
}
