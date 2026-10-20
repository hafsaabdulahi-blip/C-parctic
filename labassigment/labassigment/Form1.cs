using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace labassigment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btncolory_Click(object sender, EventArgs e)
        {
            // create variables
            double calories, fatGrams;
            try
            {


                if (double.TryParse(txtoffat.Text, out calories) &&
                    double.TryParse(txtoffat.Text, out fatGrams) &&
                    calories > 0 && fatGrams >= 0)
                {
                    double caloriesFromFat = fatGrams * 9;
                    if (caloriesFromFat > calories)
                    {
                        MessageBox.Show("Fat calories cannot be greater than total calories.");
                        checklowfat.Checked = false;
                        return;
                    }
                    double percentage = (caloriesFromFat / calories) * 100;

                    lblnumber.Text = "Calories from Fat: " + caloriesFromFat;
                    lblpercentage.Text = "Percentage of Fat: " + percentage.ToString("F2") + "%";


                    if (percentage < 30)
                    {
                        lblnumber.Text += "\nThis food is low in fat.";
                        checklowfat.Checked = true;
                    }
                    else
                    {
                        lblnumber.Text += "\nThis food is not low in fat.";
                        checklowfat.Checked = false;
                    }
                }
                else
                {
                    MessageBox.Show("sogali valid number.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

        
