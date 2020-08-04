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
        private string output;
        // Defines the location for the text files to be called later
        const string PATH_USERNAME = @"../../../gameNames.txt";
        const string PATH_TIME_SCORE = @"../../../gameTimeScore.txt";

        public void DisplayHighScores()
        {
            // Reads the text documents and adds the text into a string
            string[] readUsername = File.ReadAllLines(PATH_USERNAME);
            string[] readTimeScore = File.ReadAllLines(PATH_TIME_SCORE);
            // Converts the string array into an int array for the score
            int[] readTimeScoreInt = new int[readTimeScore.Length];
            for (int i = 0; i < readTimeScore.Length; i++)
            {
                readTimeScoreInt[i] = Convert.ToInt32(readTimeScore[i]);
            }
            // Sorts the int array to get the top 10 scores
            Array.Sort(readTimeScoreInt, readUsername);

            // Defines the limit interger and the output string to eventually display only the top 10 scores in a message box
            int limit = 0;
            for (int i = readUsername.Length - 1; i > 0; i--)
            {
                if (limit < 10)
                {
                    output += readUsername[i] + " " + readTimeScoreInt[i].ToString() + "\r\n";
                    limit++;
                }
            }
        }

        public string Output
        {
            get { return output; }
            set { output = value; }
        }
    }
}
