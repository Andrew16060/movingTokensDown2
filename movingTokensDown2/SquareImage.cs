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
        // defines a picture box and its name
        PictureBox squarePictureBox;

        // constructor holding picture box information
        public SquareImage(int argsPositionX, int argsPositionY, Bitmap argsImage)
        {
            // defines picture box height size colour etc.
            squarePictureBox = new PictureBox();
            squarePictureBox.Image = argsImage;
            squarePictureBox.Left = argsPositionX;
            squarePictureBox.Top = argsPositionY;
            squarePictureBox.Width = 60;
            squarePictureBox.Height = 60;
            squarePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            squarePictureBox.BackColor = Color.Transparent;
        }

        // gets the square picture box information from my game form on what to create such as the position to be placed and the image location
        public PictureBox SquarePictureBox
        {
            get { return squarePictureBox; }
            set { squarePictureBox = value; }
        }

        // these are the move squares method telling the squares how to move down and left or right
        public void MoveDown(int direction, int distance)
        {
            SquarePictureBox.Top = SquarePictureBox.Top + (direction * distance);
        }

        public void moveRightLeft(int direction, int distance)
        {
            SquarePictureBox.Left = SquarePictureBox.Left + (direction * distance);
        }


        // method to reset the position of the green squares once they have been moved off the screen
        public void ResetPosition()
        {
            SquarePictureBox.Left = 0;
            SquarePictureBox.Top = -90;
        }
    }
}