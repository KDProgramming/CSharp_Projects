using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Drawdy_Exam2
{
    public partial class Form1 : Form
    {
        // declare variable for  grand total
        private double productTotal = 0;

        // declare sodas as fields in order to set default values
        private theProducts cherryCola;
        private theProducts regCola;
        private theProducts creamSoda;
        private theProducts orangeSoda;
        private theProducts grapeSoda;

        public Form1()
        {
            InitializeComponent();

            // initialize cherry cola object
            cherryCola = new theProducts
            {
                Name = "Cherry Cola",
                Description = "Cherry Flavored Cola Soda",
                Price = 2.5,
                Quantity = 5
            };

            // initialize regular cola object
            regCola = new theProducts
            {
                Name = "Regular Cola",
                Description = "Regular Cola Soda",
                Price = 2,
                Quantity = 5
            };

            // initialize cream soda
            creamSoda = new theProducts
            {
                Name = "Cream Soda",
                Description = "Vanilla Flavored Cola-Like Soda",
                Price = 2,
                Quantity = 5
            };

            // initialize orange soda
            orangeSoda = new theProducts
            {
                Name = "Orange Soda",
                Description = "Orange Flavored Soda",
                Price = 1.5,
                Quantity = 5
            };

            // initialize grape soda
            grapeSoda = new theProducts
            {
                Name = "Grape Soda",
                Description = "Grape Flavored Soda",
                Price = 1.5,
                Quantity = 5
            };
        }

        private void btnComplete_Click(object sender, EventArgs e)
        {
            // Kylir Drawdy

            // declare variables
            const double SALES_TAX = 0.11;
            double grandTotal = 0;
            double taxTotal = 0;


            // calculate tax total
            taxTotal = productTotal * SALES_TAX;
            // calculate grand total
            grandTotal = productTotal + taxTotal;
            

            // disable add buttons
            btnCherryColaAdd.Visible = false;
            btnColaRegAdd.Visible = false;
            btnCreamAdd.Visible = false;
            btnGrapeAdd.Visible = false;
            btnOrangeAdd.Visible = false;

            // display totals
            lblTaxTotal.Text = "Total Tax: " + taxTotal.ToString("c");
            lblPretaxTotal.Text = "Total Before Tax: " + productTotal.ToString("c");
            lblGrandTotal.Text = "Grand Total: "+ grandTotal.ToString("c");
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // Kylie Drawdy
            this.Close();
        }

        private void btnGrapeAdd_Click(object sender, EventArgs e)
        {
            // Kylie Drawdy
            
            // check if quantity is 0, if not, change quantity
            if (grapeSoda.Quantity == 0)
            {
                // display error
                MessageBox.Show("Out of Stock!");
            }
            else
            {
                // subtract 1 from quantity
                grapeSoda.Quantity -= 1;
                lblGrapeQuan.Text = grapeSoda.Quantity.ToString();

                // add soda amount to grand total and display in text box
                productTotal += grapeSoda.Price;
                lblProductTotal.Text = productTotal.ToString("c");

            }
        }

        private void btnOrangeAdd_Click(object sender, EventArgs e)
        {
            // Kylie Drawdy

            // check if quantity is 0, if not, change quantity
            if (orangeSoda.Quantity == 0)
            {
                // display error
                MessageBox.Show("Out of Stock!");
            }
            else
            {
                // subtract 1 from quantity
                orangeSoda.Quantity -= 1;
                lblOrangeQuan.Text = orangeSoda.Quantity.ToString();

                // add soda amount to grand total and display in text box
                productTotal += orangeSoda.Price;
                lblProductTotal.Text = productTotal.ToString("c");
            }
        }

        private void btnCreamAdd_Click(object sender, EventArgs e)
        {
            // Kylie Drawdy

            // check if quantity is 0, if not, change quantity
            if (creamSoda.Quantity == 0)
            {
                // display error
                MessageBox.Show("Out of Stock!");
            }
            else
            {
                // subtract 1 from quantity
                creamSoda.Quantity -= 1;
                lblCreamQuan.Text = creamSoda.Quantity.ToString();

                // add soda amount to grand total and display in text box
                productTotal += creamSoda.Price;
                lblProductTotal.Text = productTotal.ToString("c");
            }
        }

        private void btnColaRegAdd_Click(object sender, EventArgs e)
        {
            // Kylie Drawdy

            // check if quantity is 0, if not, change quantity
            if (regCola.Quantity == 0)
            {
                // display error
                MessageBox.Show("Out of Stock!");
            }
            else
            {
                // subtract 1 from quantity
                regCola.Quantity -= 1;
                lblRegColaQuan.Text = regCola.Quantity.ToString();

                // add soda amount to grand total and display in text box
                productTotal += regCola.Price;
                lblProductTotal.Text = productTotal.ToString("c");
            }
        }

        private void btnCherryColaAdd_Click(object sender, EventArgs e)
        {
            // Kylie Drawdy

            // check if quantity is 0, if not, change quantity
            if (cherryCola.Quantity == 0)
            {
                // display error
                MessageBox.Show("Out of Stock!");
            }
            else
            {
                // subtract 1 from quantity
                cherryCola.Quantity -= 1;
                lblCherryColaQuan.Text = cherryCola.Quantity.ToString();

                // add soda amount to grand total and display in text box
                productTotal += cherryCola.Price;
                lblProductTotal.Text = productTotal.ToString("c");
            }
        }
    }
}
