using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Drawdy_chapter4_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMix_Click(object sender, EventArgs e)
        {

            // Determine which radio buttons are checked
            if (rbFirstRed.Checked && rbSecondRed.Checked)
            {
                this.BackColor = Color.Red;
            }
            else if (rbFirstBlue.Checked &&  rbSecondBlue.Checked)
            {
                this.BackColor = Color.Blue;
            }
            else if (rbFirstYellow.Checked && rbSeconYellow.Checked)
            {
                this.BackColor = Color.Yellow;
            }
            else if ((rbFirstRed.Checked && rbSecondBlue.Checked) || (rbFirstBlue.Checked && rbSecondRed.Checked)) 
            {
                this.BackColor = Color.Purple;
            }
            else if ((rbFirstRed.Checked && rbSeconYellow.Checked) || (rbFirstYellow.Checked && rbSecondRed.Checked))
            {
                this .BackColor = Color.Orange;
            }
            else if ((rbFirstBlue.Checked && rbSeconYellow.Checked) || (rbFirstYellow.Checked && rbSecondBlue.Checked))
            {
                this.BackColor = Color.Green;
            }

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // Function that closes the form
            this.Close();
        }
    }
}
