using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Info
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnshowinfo_Click(object sender, EventArgs e)
        {
           
            string name = txtname.Text;
            int studentId = int.Parse(txtsudentid.Text);
            string department = txtdepartment.Text;
            string semester = txtsemester.Text;

            lbloutput.Text = "Name: " + name +
                             "\nStudent ID: " + studentId +
                             "\nDepartment: " + department +
                             "\nSemester: " + semester;
        }

        private void btnclear_Click(object sender, EventArgs e)
        {

            txtname.Clear();
            txtsudentid.Clear();
            txtdepartment.Clear();
            txtsemester.Clear();
            lbloutput.Text = "";
        
    }

        private void btnexit_Click(object sender, EventArgs e)
        {
         
            Application.Exit();
        
    }
    }
    }

