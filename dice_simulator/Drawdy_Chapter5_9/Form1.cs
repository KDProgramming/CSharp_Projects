using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Drawdy_Chapter5_9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Function that generates 2 randm number and displays the cooresponding dice image for the given numer on two dice
        private void btnRoll_Click(object sender, EventArgs e)
        {
            // declare variables
            Random rand = new Random();
            
            // Generate 2 random numbers
            int die1 = rand.Next(1,7);
            int die2 =  rand.Next(1,7);

            // switch image for dice 1
            switch(die1)
            {
                case 1:
                    picDice1.Image = Properties.Resources._1Die;
                    break;
                case 2:
                    picDice1.Image = Properties.Resources._2Die;
                    break;
                case 3:
                    picDice1.Image = Properties.Resources._3Die;
                    break;
                case 4:
                    picDice1.Image = Properties.Resources._4Die;
                    break;
                case 5:
                    picDice1.Image = Properties.Resources._5Die;
                    break;
                case 6:
                    picDice1.Image = Properties.Resources._6Die;
                    break;
                default:
                    break;
            }

            // switch image for dice 2
            switch (die2)
            {
                case 1:
                    picDice2.Image = Properties.Resources._1Die;
                    break;
                case 2:
                    picDice2.Image = Properties.Resources._2Die;
                    break;
                case 3:
                    picDice2.Image = Properties.Resources._3Die;
                    break;
                case 4:
                    picDice2.Image = Properties.Resources._4Die;
                    break;
                case 5:
                    picDice2.Image = Properties.Resources._5Die;
                    break;
                case 6:
                    picDice2.Image = Properties.Resources._6Die;
                    break;
                default:
                    break;
            }

        }

        // Funtion to close form
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
