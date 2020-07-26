﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace AssessmentGame
{
    public partial class EndScreen : Form
    {
        public EndScreen(int timeScore)
        {
            InitializeComponent();
            timeScore2 = timeScore;
        }

        int timeScore2;
        string pathUsername = @"../../../gameNames.txt";
        string pathTimeScore = @"../../../gameTimeScore.txt";

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "")
            {
                MessageBox.Show("Please input a name.");
                btnSubmit.Enabled = true;
            }
            else
            {
                string username = txtName.Text;
                File.AppendAllText(pathUsername, username + "\r\n");
                File.AppendAllText(pathTimeScore, timeScore2 + "\r\n");
                MessageBox.Show("Well done " + username + " on getting a score of " + timeScore2 + "!");
                btnSubmit.Enabled = false;
            }
        }

        private void btnHighScores_Click(object sender, EventArgs e)
        {
            string[] readUsername = File.ReadAllLines(pathUsername);
            string[] readTimeScore = File.ReadAllLines(pathTimeScore);
            int[] readTimeScoreInt = new int[readTimeScore.Length];
            for (int i = 0; i < readTimeScore.Length; i++)
            {
                readTimeScoreInt[i] = Convert.ToInt32(readTimeScore[i]);
            }
            Array.Sort(readTimeScoreInt, readUsername);

            int limit = 0;
            string output = "";
            for (int i = readUsername.Length - 1; i > 0; i--)
            {
                if (limit < 10)
                {
                    output += readUsername[i] + " " + readTimeScoreInt[i].ToString() + "\r\n";
                    limit++;
                }
            }
            MessageBox.Show(output);
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            StartPage menu = new StartPage();
            this.Hide();
            menu.Show();
        }

        // Only allow alphabetical characters in the name text box
        // Code by 'V4Vendetta' from https://stackoverflow.com/questions/8321871/how-to-make-a-textbox-accept-only-alphabetic-characters
        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }
    }
}
