﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace movingTokensDown2
{
    class token
    {
        PictureBox tokenPictureBox;

        public token(int argsPositionX, int argsPositionY, Bitmap argsImage)
        {
            tokenPictureBox = new PictureBox();
            tokenPictureBox.Image = argsImage;
            tokenPictureBox.Left = argsPositionX;
            tokenPictureBox.Top = argsPositionY;
            tokenPictureBox.Width = 60;
            tokenPictureBox.Height = 60;
            tokenPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
        }

        public PictureBox TokenPictureBox
        {
            get { return tokenPictureBox; }
            set { tokenPictureBox = value; }
        }

        public void moveUpDown(int direction, int distance)
        {
            TokenPictureBox.Top = TokenPictureBox.Top + (direction * distance);
        }

        public void moveRightLeft(int direction, int distance)
        {
            TokenPictureBox.Left = TokenPictureBox.Left + (direction * distance);
        }

        public void resetPosition()
        {
            TokenPictureBox.Left = 0;
            TokenPictureBox.Top = -65;
        }
    }
}