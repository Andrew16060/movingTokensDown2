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
            //35px by 35px is the redToken image...
            //390px width of form, 20px on each side to fit 10 tokens on screen...
        }

        Random rand = new Random();
        List<token> redTokens = new List<token>();
        Bitmap redImage = new Bitmap(@"../../../redCircle.png");
        int blueDist = 5;
        int down = 1;
        int listNumber = 0;
        int waitTime = 7;

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            moveToken.Enabled = true;
        }

        private void moveToken_Tick(object sender, EventArgs e)
        {
            lblTest.Text = waitTime.ToString();
            if (waitTime == 7)
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
                redTokens[i].moveUpDown(down, blueDist);
            }
            waitTime++;
        }
    }
}
