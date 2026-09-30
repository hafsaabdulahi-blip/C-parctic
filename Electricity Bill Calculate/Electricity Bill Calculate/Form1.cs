using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Electricity_Bill_Calculate
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btncalculatebill_Click(object sender, EventArgs e)
        {
            // Get customer name from the TextBox
            string customerName = txtcustomername.Text;

            // Get previous meter reading
            double previousReading = double.Parse(txtpreviousreading.Text);

            // Get current meter reading
            double currentReading = double.Parse(txtcurrentreading.Text);

            // Get price per unit
            double pricePerUnit = double.Parse(txtpriceperunits.Text);

            // Calculate the number of units used
            double unitsUsed = currentReading - previousReading;

            // Calculate electricity charge
            double electricityCharge = unitsUsed * pricePerUnit;

            // Set the fixed charge
            double fixedCharge = 5.00;

            // Calculate 5% tax
            double tax = electricityCharge * 0.05;

            // Calculate the total bill
            double totalBill = electricityCharge + fixedCharge + tax;

            // Display the bill details
            MessageBox.Show(
                "Customer: " + customerName +
                "\nUnits Used: " + unitsUsed.ToString("0.00") +
                "\nElectricity Charge: $" + electricityCharge.ToString("0.00") +
                "\nFixed Charge: $" + fixedCharge.ToString("0.00") +
                "\nTax (5%): $" + tax.ToString("0.00") +
                "\nTotal Bill: $" + totalBill.ToString("0.00"),
                "Electricity Bill"
            );

        }
    }
}
