using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Drawdy_Chapter8_9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            // Kylie Drawdy

            // Declare variables
            string enteredString, decipheredString;

            // get user entered string
            enteredString = txtNumber.Text;

            // call method to get deciphered string
            decipheredString = stringDecode(enteredString);

            // output
            lblResult.Text = decipheredString;
        }

        private string stringDecode(string str)
        {
            // Kylie Drawdy

            // declare variable
            string newString = "";

            // create loop to cycle through string
            for (int i = 0; i < str.Length; i++)
            {
                // covert all character to uppercase
                char c = char.ToUpper(str[i]);

                // if statements to check which letter character is and covert it to its correct number
                if (c == 'A' || c == 'B' || c == 'C')
                {
                    // add the converted number to the new string
                    newString += "2"; 

                }else if (c == 'D' || c == 'E' || c == 'F')
                {
                    newString += "3";
                }else if (c == 'G' || c == 'H' || c == 'I')
                {
                    newString += "4";
                }else if (c == 'J' || c == 'K' || c == 'L')
                {
                    newString += "5";
                }else if (c == 'M' || c == 'O' || c == 'P')
                {
                    newString += "6";
                }else if (c == 'Q' || c == 'R' || c == 'S')
                {
                    newString += "7";
                }else if (c == 'T' || c == 'U' || c == 'V')
                {
                   newString += "8";
                }else if (c == 'W' || c == 'X' || c == 'Y' || c == 'Z')
                {
                    newString += "9";
                }else
                {
                    // if character is not letter keep it as is
                    newString += c;
                }
            }

            return newString;
        }
    }
}
