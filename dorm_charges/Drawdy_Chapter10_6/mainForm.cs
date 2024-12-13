using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Drawdy_Chapter10_6
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            // Kylie Drawdy

            // declare variables
            double dormTotal = 0;
            double mealPlanTotal = 0;
            double grandTotal = 0;

            // check which dorm radio button is checked and add to dorm and grand totals
            if (radioAllen.Checked)
            {
                // add amount to totals
                dormTotal += 1500;
                grandTotal += 1500;
            } else if (radioPike.Checked)
            {
                // add amount to totals
                dormTotal += 1600;
                grandTotal += 1600;
            } else if (radioFarthing.Checked)
            {
                // add amount to totals
                dormTotal += 1800;
                grandTotal += 1800;
            } else if (radioSuites.Checked)
            {
                // add amounts to totals
                dormTotal += 2500;
                grandTotal += 2500;
            }
            else
            {
                // display message box error 
                MessageBox.Show("Please Choose a Dormitory!");
            }

            // check which meal plan is checked and add to meal plan and grand totals
            if (radio7Meals.Checked)
            {
                // add amount to totals
                mealPlanTotal += 600;
                grandTotal += 600;
            } else if (radio14Meals.Checked)
            {
                // add amount to totals
                mealPlanTotal += 1200;
                grandTotal += 1200;
            } else if (radioUnlimited.Checked)
            {
                // add amount to totals
                mealPlanTotal += 1700;
                grandTotal += 1700;
            }
            else
            {
                // display message box error 
                MessageBox.Show("Please Choose a Meal Plan!");
            }

            // create instance of results form
            resultsForm myResultsForm = new resultsForm();

            // display results in my results form
            myResultsForm.lblDormTotal.Text = dormTotal.ToString();
            myResultsForm.lblMealTotal.Text = mealPlanTotal.ToString();
            myResultsForm.lblGrandTotal.Text = grandTotal.ToString();

            // show form to display results
            myResultsForm.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // Close the form
            this.Close();
        }
    }
}
