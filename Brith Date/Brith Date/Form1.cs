using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Brith_Date
{
    public partial class BrithDate : Form
    {
        public BrithDate()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void showdatebtn_Click(object sender, EventArgs e)
        {
            //CREATING VARIABLES TO STROEINPUT
            string Dayoftheweek, month, Day, year, FullDate;
            //Assign variables to user input
            Dayoftheweek = dayoftheweektxt.Text;
            month = nameofthemonthtxt.Text;
            Day = numericdayofthemonthtxt.Text;
            year = yeartxt.Text;
            //PROCESSING -USING CONCATINATION
            FullDate=Dayoftheweek +"," + month + "," +Day +"," + year;
            //DISPLAY THE OUTPUT
            dateoutpitlbl.Text = FullDate;
            //Clear textbox and label
            dayoftheweektxt.Text = "";
            nameofthemonthtxt.Clear();
            numericdayofthemonthtxt.Text = string.Empty;
            dateoutpitlbl.Text = string.Empty;
            //close the form using function
            //this.close
            this.Close();

        }
    }
}
