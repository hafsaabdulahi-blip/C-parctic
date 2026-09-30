namespace Food_Assigment
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblnamefood1 = new System.Windows.Forms.Label();
            this.pricefood1lbl = new System.Windows.Forms.Label();
            this.namefood2lbl = new System.Windows.Forms.Label();
            this.priceffood2lbl = new System.Windows.Forms.Label();
            this.namefood1txt = new System.Windows.Forms.TextBox();
            this.pricefood1txt = new System.Windows.Forms.TextBox();
            this.namefood2txt = new System.Windows.Forms.TextBox();
            this.pricefood2txt = new System.Windows.Forms.TextBox();
            this.calculatebtn = new System.Windows.Forms.Button();
            this.lbloutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblnamefood1
            // 
            this.lblnamefood1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnamefood1.Location = new System.Drawing.Point(53, 26);
            this.lblnamefood1.Name = "lblnamefood1";
            this.lblnamefood1.Size = new System.Drawing.Size(225, 23);
            this.lblnamefood1.TabIndex = 0;
            this.lblnamefood1.Text = "Enter Name Food";
            // 
            // pricefood1lbl
            // 
            this.pricefood1lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pricefood1lbl.Location = new System.Drawing.Point(57, 73);
            this.pricefood1lbl.Name = "pricefood1lbl";
            this.pricefood1lbl.Size = new System.Drawing.Size(221, 32);
            this.pricefood1lbl.TabIndex = 1;
            this.pricefood1lbl.Text = "Enter price food 1\r\n\r\n";
            this.pricefood1lbl.Click += new System.EventHandler(this.label2_Click);
            // 
            // namefood2lbl
            // 
            this.namefood2lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.namefood2lbl.Location = new System.Drawing.Point(55, 117);
            this.namefood2lbl.Name = "namefood2lbl";
            this.namefood2lbl.Size = new System.Drawing.Size(239, 26);
            this.namefood2lbl.TabIndex = 2;
            this.namefood2lbl.Text = "Enter Name Food2";
            // 
            // priceffood2lbl
            // 
            this.priceffood2lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceffood2lbl.Location = new System.Drawing.Point(53, 165);
            this.priceffood2lbl.Name = "priceffood2lbl";
            this.priceffood2lbl.Size = new System.Drawing.Size(222, 33);
            this.priceffood2lbl.TabIndex = 3;
            this.priceffood2lbl.Text = "Enter price food2";
            // 
            // namefood1txt
            // 
            this.namefood1txt.Location = new System.Drawing.Point(468, 23);
            this.namefood1txt.Name = "namefood1txt";
            this.namefood1txt.Size = new System.Drawing.Size(193, 26);
            this.namefood1txt.TabIndex = 4;
            // 
            // pricefood1txt
            // 
            this.pricefood1txt.Location = new System.Drawing.Point(468, 73);
            this.pricefood1txt.Name = "pricefood1txt";
            this.pricefood1txt.Size = new System.Drawing.Size(199, 26);
            this.pricefood1txt.TabIndex = 5;
            // 
            // namefood2txt
            // 
            this.namefood2txt.Location = new System.Drawing.Point(468, 117);
            this.namefood2txt.Name = "namefood2txt";
            this.namefood2txt.Size = new System.Drawing.Size(216, 26);
            this.namefood2txt.TabIndex = 6;
            // 
            // pricefood2txt
            // 
            this.pricefood2txt.Location = new System.Drawing.Point(468, 165);
            this.pricefood2txt.Name = "pricefood2txt";
            this.pricefood2txt.Size = new System.Drawing.Size(213, 26);
            this.pricefood2txt.TabIndex = 7;
            // 
            // calculatebtn
            // 
            this.calculatebtn.Location = new System.Drawing.Point(292, 309);
            this.calculatebtn.Name = "calculatebtn";
            this.calculatebtn.Size = new System.Drawing.Size(154, 42);
            this.calculatebtn.TabIndex = 8;
            this.calculatebtn.Text = "Calculate the price";
            this.calculatebtn.UseVisualStyleBackColor = true;
            this.calculatebtn.Click += new System.EventHandler(this.calculatebtn_Click);
            // 
            // lbloutput
            // 
            this.lbloutput.BackColor = System.Drawing.SystemColors.Control;
            this.lbloutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbloutput.Location = new System.Drawing.Point(155, 228);
            this.lbloutput.Name = "lbloutput";
            this.lbloutput.Size = new System.Drawing.Size(400, 42);
            this.lbloutput.TabIndex = 9;
            this.lbloutput.Text = "\r\n";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbloutput);
            this.Controls.Add(this.calculatebtn);
            this.Controls.Add(this.pricefood2txt);
            this.Controls.Add(this.namefood2txt);
            this.Controls.Add(this.pricefood1txt);
            this.Controls.Add(this.namefood1txt);
            this.Controls.Add(this.priceffood2lbl);
            this.Controls.Add(this.namefood2lbl);
            this.Controls.Add(this.pricefood1lbl);
            this.Controls.Add(this.lblnamefood1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblnamefood1;
        private System.Windows.Forms.Label pricefood1lbl;
        private System.Windows.Forms.Label namefood2lbl;
        private System.Windows.Forms.Label priceffood2lbl;
        private System.Windows.Forms.TextBox namefood1txt;
        private System.Windows.Forms.TextBox pricefood1txt;
        private System.Windows.Forms.TextBox namefood2txt;
        private System.Windows.Forms.TextBox pricefood2txt;
        private System.Windows.Forms.Button calculatebtn;
        private System.Windows.Forms.Label lbloutput;
    }
}

