using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace AssessmentGame
{
    class HighScore
    {
        // defines the output variable to be sent to the game form displaying the high scores
        private string output;
        // Defines the location for the text files to be called later
        const string PATH_USERNAME = @"../../../gameNames.txt";
        const string PATH_TIME_SCORE = @"../../../gameTimeScore.txt";

        public void DisplayHighScores()
        {
            // Reads the text document consisting of the usernames and adds it into a string
            string[] readUsername = File.ReadAllLines(PATH_USERNAME);
            // reads the text document consisting of the scores and adds it into a string
            string[] readTimeScore = File.ReadAllLines(PATH_TIME_SCORE);
            // Converts the string array into an int array for the scores
            int[] readTimeScoreInt = new int[readTimeScore.Length];
            for (int i = 0; i < readTimeScore.Length; i++)
            {
                // every position of the string array is looped through to be added to an int array to properly sort by highest to lowest value
                readTimeScoreInt[i] = Convert.ToInt32(readTimeScore[i]);
            }
            // Sorts the int array from highest to lowest and by also using parallel arrays I can sort the username array as well to keep the same index of scores to usernames
            Array.Sort(readTimeScoreInt, readUsername);

            // Defines the limit interger to only allow a maximum of 10 results in the high score box
            int limit = 0;
            const int AMOUNT_DISPLAYED = 10;
            // loops through all of the username array and runs the if statment to pull the username and the score using the same index for both the score and username array whcih will show the top 10 players scores
            for (int i = readUsername.Length - 1; i > 0; i--)
            {
                if (limit < AMOUNT_DISPLAYED)
                {
                    // adds the username and score to the output string to be displayed in a message box
                    output += readUsername[i] + " " + readTimeScoreInt[i].ToString() + "\r\n";
                    // adds one to the limit integer everytime this if statment runs to only allow 10 highscores to be displayed
                    limit++;
                }
            }
        }

        // returns the output string so it can be accessed from the start and end page 
        public string Output
        {
            get { return output; }
            set { output = value; }
        }
    }
}
