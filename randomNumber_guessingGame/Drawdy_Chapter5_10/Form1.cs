using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Drawdy_Chapter5_10
{
    public partial class Form1 : Form
    {
        // declare variables and generate random number
        Random rand = new Random();
        int numGenerated;

        public Form1()
        {
            InitializeComponent();

            // generate random number when form opends
            numGenerated = rand.Next(1, 101);
        }

        // function to generate number and check user input
        private void btnCheck_Click(object sender, EventArgs e)
        {

            // get user inpout from text box
            int userNum = int.Parse(txtGuess.Text);

            if (userNum == numGenerated)
            {
                lblResult.Text = "Correct! Good Job! A New Number is Now Generated!";
                txtGuess.Text = "";
                numGenerated = rand.Next(1, 101);
            } 
            else if (userNum > numGenerated)
            {
                lblResult.Text = "Incorrect! Too High!";
                txtGuess.Text = "";
            } 
            else if (userNum < numGenerated)
            {
                lblResult.Text = "Incorrect! Too Low!";
                txtGuess.Text = "";
            }
            else
            {
                lblResult.Text = "Error! Please Try Again!";
                txtGuess.Text = "";
            }
        }

        // function to close form
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
