using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Drawdy_Chapter9_2
{
    public partial class Form1 : Form
    {
        // create structure
        struct DrinkData
        {
            // add fields from textbook
            public string drinkName;
            public int drinkCost;
            public int drinkCount;
        }

        // declare array to hold drink data
        DrinkData[] allDrinks;

        // declare salesTotal variable as decimal for currency formatting
        decimal salesTotal = 0;

        public Form1()
        {
            InitializeComponent();

            // initialize drink array
            allDrinks = new DrinkData[]
            {
                new DrinkData { drinkName = "Cola", drinkCost = 100, drinkCount = 20 },
                new DrinkData { drinkName = "Lemon Lime", drinkCost = 100, drinkCount = 20 },
                new DrinkData { drinkName = "Cream Soda", drinkCost = 150, drinkCount = 20 },
                new DrinkData { drinkName = "Root Beer", drinkCost = 100, drinkCount = 20 },
                new DrinkData { drinkName = "Grape Soda", drinkCost = 150, drinkCount = 20 }
            };
        }

        // Process drink selection
        private void ProcessDrink(int drinkIndex)
        {

            // Check if the drink is available
            if (allDrinks[drinkIndex].drinkCount > 0)
            {
                // subtract from chosen drink count
                allDrinks[drinkIndex].drinkCount--;
                // add to sales total and convert the number into dollars
                salesTotal += allDrinks[drinkIndex].drinkCost / 100m;
                // output sales total
                lblTotal.Text = salesTotal.ToString("C");
                // update drink counts
                lblColaCount.Text = allDrinks[0].drinkCount.ToString();
                lblLemonLCount.Text = allDrinks[1].drinkCount.ToString();
                lblCreamSCount.Text = allDrinks[2].drinkCount.ToString();
                lblRootBCount.Text = allDrinks[3].drinkCount.ToString();
                lblGrapeCount.Text = allDrinks[4].drinkCount.ToString();
            }
            else
            {
                MessageBox.Show(allDrinks[drinkIndex].drinkName + " is out of stock.");
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // pass the index of cola to the processdrink method
            ProcessDrink(0);
        }

        private void picLemonLime_Click(object sender, EventArgs e)
        {
            // pass the index of lemon lime soda to the processdrink method
            ProcessDrink(1);
        }

        private void picCreamSoda_Click(object sender, EventArgs e)
        {
            // pass the index of cream soda to the processdrink method
            ProcessDrink(2);
        }

        private void picRootBeer_Click(object sender, EventArgs e)
        {
            // pass the index of root beer to the processdrink method
            ProcessDrink(3);
        }

        private void picGrape_Click(object sender, EventArgs e)
        {
            // pass the index of grape soda to the processdrink method
            ProcessDrink(4);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // close form on click
            this.Close();
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }
    }
}
