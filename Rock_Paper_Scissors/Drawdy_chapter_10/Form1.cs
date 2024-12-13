using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Drawdy_chapter_10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Declare variables
        string compChoice;  // variables outside voids = global variable

        private void Form1_Load(object sender, EventArgs e)
        {
            // call method to get computer choice
            setCompChoice();
        }

        private void setCompChoice()
        {
            // Set up random number generator object
            Random randomGen = new Random();

            // Generate random number betrweeen 1 and 3
            int randomChoice = randomGen.Next(1, 4);

            // deteremine which was chose
            switch (randomChoice)
            {
                case 1:
                    compChoice = "Rock";
                    break;
                case 2:
                    compChoice = "Paper";
                    break;
                case 3:
                    compChoice = "Scissors";
                    break;
            }
        }

        private void decideWinner(string uChoice) // method is looking for  a string, uChoice is parameter, userChoice is argument (passing through)
        {
            // Determine winner 
            string winner;
            if (uChoice == "Rock" && compChoice == "Scissors" || uChoice == "Paper" && compChoice == "Rock" || uChoice == "Scissors" && compChoice == "Paper")
            {
                winner = "Player";
            }
            else if (uChoice == "Rock" && compChoice == "Paper" || uChoice == "Paper" && compChoice == "Scissors" || uChoice == "Scissors" && compChoice == "Rock")
            {
                winner = "Computer";
            }
            else
            {
                winner = "Tie";
            }

            // Display results
            lblResults.Text = "Computers choice: " + compChoice + "\n" + "Users choice: " + uChoice + "\n" + "Winner: " + winner;
        }

        private void picBoxRock_Click(object sender, EventArgs e)
        {
            // Declare variables
            string userChoice = "Rock";

            // Call method to determine winner
            decideWinner(userChoice);

            // call method to reset user choice
            setCompChoice();
        }

        private void picBoxPaper_Click(object sender, EventArgs e)
        {
            // Declare variables
            string userChoice = "Paper";

            // Call method to determine winner
            decideWinner(userChoice);

            // call method to reset user choice
            setCompChoice();
        }

        private void picBoxScissors_Click(object sender, EventArgs e)
        {
            // Declare variables
            string userChoice = "Scissors";

            // Call method to determine winner
            decideWinner(userChoice);

            // call method to reset user choice
            setCompChoice();
        }
    }
}
