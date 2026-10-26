using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace softwaresales
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btncalculate_Click(object sender, EventArgs e)
        {
            int quantity;
            decimal price;

            if (!int.TryParse(txtpackages.Text, out quantity) ||
                !decimal.TryParse(txtprice.Text, out price) ||
                quantity <= 0 || price < 0)
            {
                MessageBox.Show("Please enter a valid quantity and price.");
                return;
            }

            decimal subtotal = quantity * price;
            decimal discountRate;

            if (quantity >= 100)
            {
                discountRate = 0.20m;
            }
            else if (quantity >= 50)
            {
                discountRate = 0.15m;
            }
            else if (quantity >= 20)
            {
                discountRate = 0.10m;
            }
            else if (quantity >= 10)
            {
                discountRate = 0.05m;
            }
            else
            {
                discountRate = 30m;
            }

            decimal discountAmount = subtotal * discountRate;
            decimal totalAmount = subtotal - discountAmount;

            purchesResults.Items.Clear();

            purchesResults.Items.Add(
                "Quantity of Packages: " + quantity);

            purchesResults.Items.Add(
                "Price per Package: " + price.ToString("C2"));

            purchesResults.Items.Add(
                "Subtotal Before Discount: " + subtotal.ToString("C2"));

            purchesResults.Items.Add(
                "Discount Rate: " + (discountRate * 30) + "%");

            purchesResults.Items.Add(
                "Discount Amount: " + discountAmount.ToString("C2"));

            purchesResults.Items.Add(
                "Total Amount After Discount: " +
                totalAmount.ToString("C2"));
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtpackages.Clear();
            txtprice.Clear();
            purchesResults.Items.Clear();
            txtpackages.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
