namespace labassigment
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
            this.checklowfat = new System.Windows.Forms.CheckBox();
            this.lbldisplay = new System.Windows.Forms.Label();
            this.btncolory = new System.Windows.Forms.Button();
            this.lblpercentage = new System.Windows.Forms.Label();
            this.lblnumber = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtcolor = new System.Windows.Forms.TextBox();
            this.txtoffat = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // checklowfat
            // 
            this.checklowfat.AutoSize = true;
            this.checklowfat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checklowfat.Location = new System.Drawing.Point(159, 194);
            this.checklowfat.Name = "checklowfat";
            this.checklowfat.Size = new System.Drawing.Size(513, 29);
            this.checklowfat.TabIndex = 17;
            this.checklowfat.Text = "30% of the total calories of the food the food is consider";
            this.checklowfat.UseVisualStyleBackColor = true;
            // 
            // lbldisplay
            // 
            this.lbldisplay.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbldisplay.Location = new System.Drawing.Point(185, 315);
            this.lbldisplay.Name = "lbldisplay";
            this.lbldisplay.Size = new System.Drawing.Size(423, 74);
            this.lbldisplay.TabIndex = 16;
            // 
            // btncolory
            // 
            this.btncolory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncolory.Location = new System.Drawing.Point(253, 240);
            this.btncolory.Name = "btncolory";
            this.btncolory.Size = new System.Drawing.Size(178, 46);
            this.btncolory.TabIndex = 15;
            this.btncolory.Text = "Calculate colory";
            this.btncolory.UseVisualStyleBackColor = true;
            this.btncolory.Click += new System.EventHandler(this.btncolory_Click);
            // 
            // lblpercentage
            // 
            this.lblpercentage.AutoSize = true;
            this.lblpercentage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpercentage.Location = new System.Drawing.Point(135, 113);
            this.lblpercentage.Name = "lblpercentage";
            this.lblpercentage.Size = new System.Drawing.Size(157, 25);
            this.lblpercentage.TabIndex = 14;
            this.lblpercentage.Text = "percentage of fat";
            // 
            // lblnumber
            // 
            this.lblnumber.AutoSize = true;
            this.lblnumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnumber.Location = new System.Drawing.Point(135, 65);
            this.lblnumber.Name = "lblnumber";
            this.lblnumber.Size = new System.Drawing.Size(149, 25);
            this.lblnumber.TabIndex = 13;
            this.lblnumber.Text = "Number of color";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(128, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 25);
            this.label2.TabIndex = 12;
            // 
            // txtcolor
            // 
            this.txtcolor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtcolor.Location = new System.Drawing.Point(381, 62);
            this.txtcolor.Name = "txtcolor";
            this.txtcolor.Size = new System.Drawing.Size(264, 26);
            this.txtcolor.TabIndex = 11;
            // 
            // txtoffat
            // 
            this.txtoffat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtoffat.Location = new System.Drawing.Point(381, 120);
            this.txtoffat.Name = "txtoffat";
            this.txtoffat.Size = new System.Drawing.Size(264, 26);
            this.txtoffat.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.checklowfat);
            this.Controls.Add(this.lbldisplay);
            this.Controls.Add(this.btncolory);
            this.Controls.Add(this.lblpercentage);
            this.Controls.Add(this.lblnumber);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtcolor);
            this.Controls.Add(this.txtoffat);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checklowfat;
        private System.Windows.Forms.Label lbldisplay;
        private System.Windows.Forms.Button btncolory;
        private System.Windows.Forms.Label lblpercentage;
        private System.Windows.Forms.Label lblnumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtcolor;
        private System.Windows.Forms.TextBox txtoffat;
    }
}

