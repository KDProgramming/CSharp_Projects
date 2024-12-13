using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Drawdy_Chapter6_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Declare gloabal variable
        const double OIL_CHANGE = 26, LUBE_JOB = 18, RADIATOR_FLUSH = 30, TRANS_FLUSH = 80, INSPECTION_FEE = 15, MUFFLER_REPLACE = 100;
        const double TIRE_ROTATE = 20, TAX_FEE = 0.06;

        double partsTaxFee = 0, partsCharge = 0, laborFee = 0;

        private double OilLubeCharges()
        {
            // create placeholder variable for if statement
            double oilLubeFees = 0;

            // if statements to check which boxes are checked and to add to placeholder
            if (chkOilChange.Checked == true)
            {
                oilLubeFees += OIL_CHANGE;
            }
            if (chkLubeJob.Checked == true)
            {
                oilLubeFees += LUBE_JOB;
            }

            // return oillubefees total
            return oilLubeFees;
            
        }

        private double FlushCharges()
        {
            // create placeholder variable for if statement
            double flushFees = 0;

            // If statements to check which boxes are checked and add to variable
            if (chkRadiatorFlush.Checked == true)
            {
                flushFees += RADIATOR_FLUSH;
            }
            
            if (chkTransFlush.Checked == true)
            {
                flushFees += TRANS_FLUSH;
            }

            // return flush fees total
            return flushFees;
        }

        private double MiscCharges()
        {
            // create placeholder variable for if statement
            double miscFees = 0;

            // If statements to check which boxes are checked and add to variable
            if (chkInspection.Checked == true)
            {
                miscFees += INSPECTION_FEE;
            }
            
            if (chkReplaceMuffler.Checked == true)
            {
                miscFees += MUFFLER_REPLACE;
            }
            
            if (chkTireRotation.Checked == true)
            {
                miscFees += TIRE_ROTATE;
            }

            // return misc fees total
            return miscFees;
        }

        private double OtherCharges()
        {
            // create placeholder variable for if statement
            double otherFees = 0;

            // If statement to parse user input for labor fee and add to variable
            if (double.TryParse(txtLabor.Text, out laborFee))
            {
                otherFees += laborFee;
            }
            else
            {
                MessageBox.Show("Please Enter Acceptable Labor Amount!");
            }

            // If statement to parse user input for parts fee and display to label output
            if (double.TryParse(txtParts.Text, out partsCharge))
            {
                // add parts charge and otherFees to get otherFees total
                otherFees += partsCharge;
                // get tax on parts
                partsTaxFee = TaxCharges(partsCharge);
                // Display total of parts to parts label result
                lblTaxResult.Text = partsTaxFee.ToString("c");
            }

            // Return total of other fees
            return otherFees;

        }

        private double TaxCharges(double partsTotal)
        {
            // multiply parts by tax to get total
            return partsTotal * TAX_FEE;
        }

        private double TotalCharges(double oilLubeFees, double flushFees, double miscFees, double otherFees, double partsTax)
        {
            // add up all charges for the grand total
            return oilLubeFees + flushFees + miscFees + otherFees + partsTax;
        }

        private void ClearOilLube()
        {
            // Clear check boxes in Oil and Lube group
            chkOilChange.Checked = false;
            chkLubeJob.Checked = false;
        }

        private void ClearFlushes()
        {
            // Clear check boxes in Flushes group
            chkRadiatorFlush.Checked = false;
            chkTransFlush.Checked = false;
        }

        private void ClearMisc()
        {
            // Clear check boxes in Misc group
            chkInspection.Checked = false;
            chkReplaceMuffler.Checked = false;
            chkTireRotation.Checked = false;
        }

        private void ClearOther()
        {
            // Clear all text boxes in Parts and Labor group
            txtLabor.Text = string.Empty;
            txtParts.Text = string.Empty;
        }

        private void ClearFees()
        {
            // Clear all labels in Summary group
            LblServiceLaborResult.Text = string.Empty;
            lblPartsResult.Text = string.Empty;
            lblTaxResult.Text = string.Empty;
            lblTotalResult.Text = string.Empty;
        }


        private void btnCalc_Click(object sender, EventArgs e)
        {
            // Declare variables and run them through methods
            double oilLubeFees = OilLubeCharges();
            double flushFees = FlushCharges();
            double miscFees = MiscCharges();
            double otherFees = OtherCharges();

            // Output total for service and labor to label result
            double servLabTotal = oilLubeFees + flushFees + miscFees + laborFee;
            LblServiceLaborResult.Text = servLabTotal.ToString("c");

            // Output the total for parts and the tax on parts to label result
            lblPartsResult.Text = partsCharge.ToString("c");
            lblTaxResult.Text = partsTaxFee.ToString("c");

            // Run all charges though total charges method and output to label result
            double grandTotal = TotalCharges(oilLubeFees, flushFees, miscFees, otherFees, partsTaxFee);
            lblTotalResult.Text = grandTotal.ToString("c");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // On click clear all groups
            ClearFees();
            ClearFlushes();
            ClearOther();
            ClearOilLube();
            ClearMisc();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // Close form on press
            this.Close();
        }
    }
}
