using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace AssessmentGame
{
    class SquareImage
    {
        PictureBox squarePictureBox;

        public SquareImage(int argsPositionX, int argsPositionY, Bitmap argsImage)
        {
            squarePictureBox = new PictureBox();
            squarePictureBox.Image = argsImage;
            squarePictureBox.Left = argsPositionX;
            squarePictureBox.Top = argsPositionY;
            squarePictureBox.Width = 60;
            squarePictureBox.Height = 60;
            squarePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            squarePictureBox.BackColor = Color.Transparent;
        }

        public PictureBox SquarePictureBox
        {
            get { return squarePictureBox; }
            set { squarePictureBox = value; }
        }

        public void moveUpDown(int direction, int distance)
        {
            SquarePictureBox.Top = SquarePictureBox.Top + (direction * distance);
        }

        public void moveRightLeft(int direction, int distance)
        {
            SquarePictureBox.Left = SquarePictureBox.Left + (direction * distance);
        }

        public void resetPosition()
        {
            SquarePictureBox.Left = 0;
            SquarePictureBox.Top = -90;
        }
    }
}