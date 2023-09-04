using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LunchOrder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            double subTotal = 0;
            double topPrice;
            if (radioHamburger.Checked)
            {
                subTotal = subTotal + 6.95;
                topPrice = 0.75;

            }
            else if (radioPizza.Checked)
            {
                subTotal = subTotal + 5.95;
                topPrice = 0.50;
            }
            else
            {
                subTotal = subTotal + 4.95;
                topPrice = 0.25;
            }

            if (checkTopping.Checked)
            {
                subTotal = subTotal + topPrice;
            }

            if (checkSauces.Checked)
            {
                subTotal = subTotal + topPrice;
            }

            if (checkFries.Checked)
            {
                subTotal = subTotal + topPrice;
            }


            txtSubtotal.Text = String.Format("{0:n2}", subTotal);

            double salesTax = (subTotal * 0.0775);
            txtSalesTax.Text = String.Format("{0:n2}", salesTax);


            double orderTotal = (subTotal + salesTax);
            txtOrderTotal.Text = String.Format("{0:n2}", orderTotal);
        }

        private void ClearTotals()
        {
            txtSubtotal.Text = "";
            txtSalesTax.Text = "";
            txtOrderTotal.Text = "";
        }

        private void ClearAddOns()
        {
            checkTopping.Checked = false;
            checkSauces.Checked = false;
            checkFries.Checked = false;
        }

        private void radioHamburger_CheckedChanged(object sender, EventArgs e)
        {
            ClearTotals();
            ClearAddOns();
            if (radioHamburger.Checked)
            {
                checkTopping.Text = "Lettuce, Tomato, Onions";
                checkSauces.Text = "Ketchup, Mustard, Mayo";
                checkFries.Text = "French Fries";
                groupBox1.Text = "Add-ons($0.75 each)";
            }
        }

        private void radioPizza_CheckedChanged(object sender, EventArgs e)
        {
            ClearTotals();
            ClearAddOns();
            if (radioPizza.Checked)
            {
                checkTopping.Text = "Pepperoni";
                checkSauces.Text = "Sausage";
                checkFries.Text = "Olives";
                groupBox1.Text = "Add-ons($0.50 each)";
            }
        }

        private void radioSalad_CheckedChanged(object sender, EventArgs e)
        {
            ClearTotals();
            ClearAddOns();
            if (radioSalad.Checked)
            {
                ClearTotals();
                ClearAddOns();
                checkTopping.Text = "Croutons";
                checkSauces.Text = "Bacon Bits";
                checkFries.Text = "Bread Sticks";
                groupBox1.Text = "Add-ons($0.25 each)";
            }
        }

        private void chkToppings_CheckedChanged(object sender, EventArgs e)
        {
            ClearTotals();

        }

        private void chkSauce_CheckedChanged(object sender, EventArgs e)
        {
            ClearTotals();

        }

        private void chkFries_CheckedChanged(object sender, EventArgs e)
        {
            ClearTotals();

        }


    }
}



