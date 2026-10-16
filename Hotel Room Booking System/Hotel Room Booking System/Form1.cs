using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Room_Booking_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BookingDetails_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            string guestName = txtGuestName.Text;

            int guestAge;
            int numberOfNights;
            int numberOfGuests;

            bool approved = true;

            if (guestName == "")
            {
                MessageBox.Show("Guest Name cannot be empty.");
                approved = false;
            }

            if (!int.TryParse(txtGuestAge.Text, out guestAge))
            {
                MessageBox.Show("Enter a valid guest age.");
                approved = false;
            }

            if (!int.TryParse(txtNights.Text, out numberOfNights))
            {
                MessageBox.Show("Enter a valid number of nights.");
                approved = false;
            }

            if (!int.TryParse(txtGuests.Text, out numberOfGuests))
            {
                MessageBox.Show("Enter a valid number of guests.");
                approved = false;
            }

            if (!approved)
            {
                return;
            }

            if (guestAge < 18 || guestAge > 90)
            {
                MessageBox.Show("Guest age must be between 18 and 90.");
                approved = false;
            }

            if (numberOfNights < 1 || numberOfNights > 30)
            {
                MessageBox.Show("Number of nights must be between 1 and 30.");
                approved = false;
            }

            if (numberOfGuests < 1 || numberOfGuests > 6)
            {
                MessageBox.Show("Number of guests must be between 1 and 6.");
                approved = false;
            }

            if (rdoStandard.Checked && numberOfGuests > 2)
            {
                MessageBox.Show("Standard rooms can accommodate a maximum of 2 guests.");
                approved = false;
            }

            if (rdoNormal.Checked && numberOfGuests > 4)
            {
                MessageBox.Show("Normal rooms can accommodate a maximum of 4 guests.");
                approved = false;
            }

            if (rdoHight.Checked && numberOfGuests > 6)
            {
                MessageBox.Show("Hight rooms can accommodate a maximum of 6 guests.");
                approved = false;
            }

            if (!approved)
            {
                return;
            }

            decimal roomRate = 0;

            switch (true)
            {
                case true when rdoStandard.Checked:
                    roomRate = 50;
                    break;

                case true when rdoNormal.Checked:
                    roomRate = 80;
                    break;

                case true when rdoHight.Checked:
                    roomRate = 130;
                    break;

                default:
                    MessageBox.Show("Please select a room type.");
                    return;
            }

            decimal roomCost = roomRate * numberOfNights;
            decimal discount = 0;

            if (numberOfNights >= 5 && numberOfNights <= 9)
            {
                discount = roomCost * 0.05m;
            }
            else if (numberOfNights >= 10)
            {
                discount = roomCost * 0.12m;
            }

            if (guestAge >= 60)
            {
                discount += roomCost * 0.05m;
            }

            decimal breakfastCost = 0;

            if (chkBreakFast.Checked)
            {
                breakfastCost = 10 * numberOfGuests * numberOfNights;
            }

            decimal totalCost = roomCost - discount + breakfastCost;

            decimal serviceSurcharge = 0;

            if (numberOfGuests > 4)
            {
                serviceSurcharge = totalCost * 0.05m;
            }

            totalCost += serviceSurcharge;

           grpBookingDetails.Clear();

            grpBookingDetails.AppendText("Guest Name: " + guestName + Environment.NewLine);
            grpBookingDetails.AppendText("Guest Age: " + guestAge + Environment.NewLine);
            grpBookingDetails.AppendText("Number of Nights: " + numberOfNights + Environment.NewLine);
            grpBookingDetails.AppendText("Number of Guests: " + numberOfGuests + Environment.NewLine);
            grpBookingDetails.AppendText("Room Rate Per Night: $" + roomRate + Environment.NewLine);
            grpBookingDetails.AppendText("Room Cost: $" + roomCost + Environment.NewLine);
            grpBookingDetails.AppendText("Discount: $" + discount + Environment.NewLine);
            grpBookingDetails.AppendText("Breakfast Cost: $" + breakfastCost + Environment.NewLine);
            grpBookingDetails.AppendText("Service Surcharge: $" + serviceSurcharge + Environment.NewLine);
            grpBookingDetails.AppendText("Total Cost: $" + totalCost + Environment.NewLine);
            grpBookingDetails.AppendText("Booking Status: Approved" + Environment.NewLine);
        }

        private void btnCalculate_click(object sender, EventArgs e)
        {
            txtGuestName.Clear();
            txtGuestAge.Clear();
            txtNights.Clear();
            txtGuests.Clear();

            grpBookingDetails.Text = " ";

            rdoStandard.Checked = false;
            rdoNormal.Checked = false;
            rdoHight.Checked = false;

            chkBreakFast.Checked = false;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }
    }
}
        
    

