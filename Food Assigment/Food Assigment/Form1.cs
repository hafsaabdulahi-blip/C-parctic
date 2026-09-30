using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Food_Assigment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void calculatebtn_Click(object sender, EventArgs e)
        {
            //creat variables
            string food1 = namefood1txt.Text;
            int food1price = int.Parse(pricefood1txt.Text);
            string food2 = namefood2txt.Text;
            int food2price = int.Parse(pricefood2txt.Text);
            //calculate taxt by multiplying 0.07
            double tax = (food1price + food2price) * 0.07;
            // calculating total
            double total = food1price + food2price + tax;
            //output
            lbloutput.Text = total.ToString();
            //erro telling message
            MessageBox.Show("please enter valid.");


        }
     
    }
    }