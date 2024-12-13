using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Drawdy_Chapter8_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            // Kylie Drawdy

            //Declare variables
            string enteredString;
            int totalWords;

            // get text from text box and put into string
            enteredString = txtString.Text;

            // call countWord method and place returned value into total words
            totalWords = countWords(enteredString);

            // output
            lblResult.Text = "Number of Words: " + totalWords.ToString();

        }

        // method to count words in string
        private int countWords(string str)
        {
            // Declare varuables 
            int numWords = 0;
            bool wordBegin = false;

            // loop to run through string
            for (int i = 0; i < str.Length; i++)
            {
                // if statement to see if it is the first character of the string and not a space
                if (i == 0 && !char.IsWhiteSpace(str[i]))
                {
                    wordBegin = true;
                }
                // if statement to check for second word in string
                else if (i > 0 && char.IsWhiteSpace(str[i - 1]))
                {
                    wordBegin = true;
                }
                else
                {
                    wordBegin = false;
                }
                // if statement to see if wordBegin is true
                if (wordBegin == true && (char.IsLetterOrDigit(str[i]) || char.IsPunctuation(str[i])))
                {
                    // add to word count
                    numWords++;
                }
                
            }

            // return value back to main
            return numWords;
        }

    }
}
