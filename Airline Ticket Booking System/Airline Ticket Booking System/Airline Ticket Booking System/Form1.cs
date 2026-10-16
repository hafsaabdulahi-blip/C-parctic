using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Airline_Ticket_Booking_System
{
    public partial class Form1 : Form
    {
        bool bookingApproved = false;
        const decimal TicketPrice = 100m;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            
            bookingApproved = false;

            string passengerName = txtPassengerName.Text.Trim();

            if (passengerName == "")
            {
                MessageBox.Show("Please enter passenger name.");
                return;
            }

            int passengerAge;
            int numberOfTickets;
            double baggageWeight;

            if (!int.TryParse(txtPassengerAge.Text, out passengerAge))
            {
                MessageBox.Show("Please enter a valid passenger age.");
                return;
            }

            if (!int.TryParse(txtNumberOfTickets.Text, out numberOfTickets))
            {
                MessageBox.Show("Please enter a valid number of tickets.");
                return;
            }

            if (!double.TryParse(txtBaggageWeight.Text, out baggageWeight))
            {
                MessageBox.Show("Please enter a valid baggage weight.");
                return;
            }

            if (passengerAge < 1 || passengerAge > 100)
            {
                MessageBox.Show("Passenger age must be between 1 and 100.");
                return;
            }

            if (numberOfTickets < 1 || numberOfTickets > 5)
            {
                MessageBox.Show("Number of tickets must be between 1 and 5.");
                return;
            }

            if (baggageWeight < 0 || baggageWeight > 50)
            {
                MessageBox.Show("Baggage weight must be between 0 and 50 kg.");
                return;
            }

            if (!rdoFristClass.Checked &&
                !rdoNormalClass.Checked &&
                !rdoBusinessClass.Checked)
            {
                MessageBox.Show("Please select a travel class.");
                return;
            }

            if (passengerAge < 12 && rdoFristClass.Checked)
            {
                MessageBox.Show(
                    "Booking rejected: Passengers below 12 years cannot book Frist Class."
                );
                return;
            }

            decimal basicTicketCost = TicketPrice * numberOfTickets;
            decimal ticketDiscount = 0m;
            decimal ageDiscount = 0m;
            decimal insuranceCost = 0m;
            decimal baggageCost = 0m;
            decimal classCost = 0m;

            if (numberOfTickets >= 3 && numberOfTickets <= 4)
            {
                ticketDiscount = basicTicketCost * 0.05m;
            }
            else if (numberOfTickets == 5)
            {
                ticketDiscount = basicTicketCost * 0.10m;
            }

            if (passengerAge < 12)
            {
                ageDiscount = basicTicketCost * 0.20m;
            }
            else if (passengerAge >= 60)
            {
                ageDiscount = basicTicketCost * 0.10m;
            }

            if (chkTravelInsurance.Checked)
            {
                insuranceCost = 25m * numberOfTickets;
            }

            if (rdoFristClass.Checked)
            {
                classCost = 0m;
            }
            else if (rdoNormalClass.Checked)
            {
                classCost = 0m;
            }
            else if (rdoBusinessClass.Checked)
            {
                classCost = 0m;
            }

            decimal totalDiscount = ticketDiscount + ageDiscount;

            decimal totalCost =
                basicTicketCost
                - totalDiscount
                + insuranceCost
                + baggageCost
                + classCost;

            string travelClass = "";

            if (rdoFristClass.Checked)
                travelClass = "Frist Class";
            else if (rdoNormalClass.Checked)
                travelClass = "Normal Class";
            else if (rdoBusinessClass.Checked)
                travelClass = "Business Class";

            bookingApproved = true;

            rtbBookingDetails.Clear();

            rtbBookingDetails.AppendText("Airline Ticket Booking Details\r\n");
            rtbBookingDetails.AppendText("------------------------------\r\n");
            rtbBookingDetails.AppendText("Booking Status: Approved\r\n");
            rtbBookingDetails.AppendText("Passenger Name: " + passengerName + "\r\n");
            rtbBookingDetails.AppendText("Passenger Age: " + passengerAge + "\r\n");
            rtbBookingDetails.AppendText("Number of Tickets: " + numberOfTickets + "\r\n");
            rtbBookingDetails.AppendText("Baggage Weight: " + baggageWeight + " kg\r\n");
            rtbBookingDetails.AppendText("Travel Class: " + travelClass + "\r\n");
            rtbBookingDetails.AppendText("Basic Ticket Cost: $" + basicTicketCost.ToString("0.00") + "\r\n");
            rtbBookingDetails.AppendText("Ticket Discount: $" + ticketDiscount.ToString("0.00") + "\r\n");
            rtbBookingDetails.AppendText("Age Discount: $" + ageDiscount.ToString("0.00") + "\r\n");
            rtbBookingDetails.AppendText("Total Discount: $" + totalDiscount.ToString("0.00") + "\r\n");
            rtbBookingDetails.AppendText("Travel Insurance: $" + insuranceCost.ToString("0.00") + "\r\n");
            rtbBookingDetails.AppendText("Baggage Cost: $" + baggageCost.ToString("0.00") + "\r\n");
            rtbBookingDetails.AppendText("Class Cost: $" + classCost.ToString("0.00") + "\r\n");
            rtbBookingDetails.AppendText("Total Cost: $" + totalCost.ToString("0.00") + "\r\n");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtPassengerName.Clear();
            txtPassengerAge.Clear();
            txtNumberOfTickets.Clear();
            txtBaggageWeight.Clear();

            rdoFristClass.Checked = false;
            rdoNormalClass.Checked = false;
            rdoBusinessClass.Checked = false;

            chkTravelInsurance.Checked = false;

            rtbBookingDetails.Clear();

            bookingApproved = false;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
        
    

