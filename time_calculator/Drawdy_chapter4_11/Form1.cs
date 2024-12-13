using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Drawdy_chapter4_11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Function to determine number of seconds
        private void btnCalc_Click(object sender, EventArgs e)
        {
            // Declare variables
            const double SECONDS_IN_MINUTE = 60;
            const double SECONDS_IN_HOUR = 3600;
            const double SECONDS_IN_DAY = 86400;
            double secondsEntered;

            // Deterine number of seconds entered and assign to variable
            try
            {
                secondsEntered = double.Parse(txtSecondsEntry.Text);
            }
            catch
            {
                MessageBox.Show("Invalid Number of Seconds Entered!");
                return;
            }

            // Determine time of seconds entered and display output
            if (secondsEntered >= SECONDS_IN_MINUTE && (secondsEntered < SECONDS_IN_HOUR))
            {
                lblResult.Text = "There are " + secondsEntered / SECONDS_IN_MINUTE + " Minutes in " + secondsEntered + " Seconds";
            }
            else if (secondsEntered >= SECONDS_IN_HOUR && (secondsEntered < SECONDS_IN_DAY))
            {
                lblResult.Text = "There are " + secondsEntered / SECONDS_IN_MINUTE + " Minutes in " + secondsEntered + " Seconds" + 
                    "\nThere are " + secondsEntered / SECONDS_IN_HOUR + " Hours in " + secondsEntered + " Seconds";
            }
            else if (secondsEntered >= SECONDS_IN_DAY)
            {
                lblResult.Text = "There are " + secondsEntered / SECONDS_IN_MINUTE + " Minutes in " + secondsEntered + " Seconds" +
                    "\nThere are " + secondsEntered / SECONDS_IN_HOUR + " Hours in " + secondsEntered + " Seconds" + 
                    "\nThere are " + secondsEntered / SECONDS_IN_DAY + " Days in " + secondsEntered + " Seconds";
            }
        }

        // Function to close program
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
