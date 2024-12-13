using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Drawdy_Chapter4_9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Function to calculate total of coins
        private void btnExit_Click(object sender, EventArgs e)
        {
            // Declare variables
            const int DOLLAR_TOTAL = 100;
            const int QUARTER_TOTAL = 25;
            const int PENNY_TOTAL = 1;
            const int NICKEL_TOTAL = 5;
            const int DIME_TOTAL = 10;

            int numQuarters, numPennies, numNickels, numDimes;
            double quarterTotal, pennyTotal, nickelTotal, dimeTotal, coinsTotal;

            // Get total of coins
            try
            {
                numQuarters = int.Parse(txtQuarter.Text);
            }
            catch
            {
                MessageBox.Show("Invalid Amount of Quarters Entered!");
                return;
            }
            try
            {
                numPennies = int.Parse(txtPenny.Text);
            }
            catch
            {
                MessageBox.Show("Invalid Amount of Pennies Entered!");
                return;
            }
            try
            {
                numNickels = int.Parse(txtNickel.Text);
            }
            catch
            {
                MessageBox.Show("Invalid Amount of Nickels Entered!");
                return;
            }
            try
            {
                numDimes = int.Parse(txtDime.Text);
            }
            catch
            {
                MessageBox.Show("Invalid Amount of Dimes Entered!");
                return;
            }

            // Calc number of quarters
            quarterTotal = numQuarters * QUARTER_TOTAL;

            // Calc number of nickels
            nickelTotal = numNickels * NICKEL_TOTAL;

            // Calc number of pennies
            pennyTotal = numPennies * PENNY_TOTAL;

            // Calc number of dimes
            dimeTotal = numDimes * DIME_TOTAL;

            // Calc total of all coins
            coinsTotal = quarterTotal + nickelTotal + dimeTotal + pennyTotal;

            // Check if coins are equal to dollar
            if (coinsTotal == 100)
            {
                lblResult.Text = "Congrats, You Won the Game!";
            }
            else if (coinsTotal > 100)
            {
                lblResult.Text = "Way Too Much, You Lose! \nYour Total Was " + coinsTotal.ToString() + " Cents";
            }
            else if (coinsTotal < 100)
            {
                lblResult.Text = "Not Enough, You Lose! \nYour Total Was " + coinsTotal.ToString() + " Cents";
            }
            else
            {
                MessageBox.Show("Invalid Input!");
                return;
            }
        }
        
        // Close form on click
        private void btnCalc_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
