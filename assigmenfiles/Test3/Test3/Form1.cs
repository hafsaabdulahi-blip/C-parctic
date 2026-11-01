using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace Test3
{
    public partial class Form1 : Form
    {
        string filePath = "myfile.txt";


        public Form1()
        {
            InitializeComponent();
        }

        // 1. Delete Item Button
        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            }
            else
            {
                MessageBox.Show("Please select an item first.");
            }
        }

        // 2. Delete File Button
        private void DeleteFile_Click(object sender, EventArgs e)
        {
            if (File.Exists(filePath))
            {
                File.Delete(filePath);
                listBox1.Items.Clear();

                MessageBox.Show("File deleted successfully.");
            }
            else
            {
                MessageBox.Show("File does not exist.");
            }


        }

        // 3. Write All Text Button
        private void WriteAllTextBtn_Click(object sender, EventArgs e)
        {
            string text = string.Join(
                Environment.NewLine,
                listBox1.Items.Cast<object>()
            );

            File.WriteAllText(filePath, text);

            MessageBox.Show("Text saved to file successfully.");
        }

        // 4. Stream Reader Button
        private void StreamReaderBtn_Click(object sender, EventArgs e)
        {
            if (File.Exists(filePath))
            {
                listBox1.Items.Clear();

                using (StreamReader reader = new StreamReader(filePath))
                {
                    string Read;

                    while ((Read = reader.ReadLine()) != null)
                    {
                        listBox1.Items.Add(Read);
                    }
                }

                MessageBox.Show("File read successfully.");
            }
            else
            {
                MessageBox.Show("File does not exist. Save text first.");
            }
        }
        private void BtnaddItem_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(Itemtxt.Text))
            {
                listBox1.Items.Add(Itemtxt.Text);

                Itemtxt.Clear();
                Itemtxt.Focus();
            }
            else
            {
                MessageBox.Show("Fadlan qoraal geli!");
            }
        }
    }
}