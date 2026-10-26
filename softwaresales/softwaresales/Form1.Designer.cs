namespace softwaresales
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
            this.lblpackages = new System.Windows.Forms.Label();
            this.lblprice = new System.Windows.Forms.Label();
            this.txtpackages = new System.Windows.Forms.TextBox();
            this.txtprice = new System.Windows.Forms.TextBox();
            this.btncalculate = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.purchesResults = new System.Windows.Forms.ListBox();
            this.lblAge = new System.Windows.Forms.Label();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblpackages
            // 
            this.lblpackages.AutoSize = true;
            this.lblpackages.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpackages.Location = new System.Drawing.Point(41, 100);
            this.lblpackages.Name = "lblpackages";
            this.lblpackages.Size = new System.Drawing.Size(174, 20);
            this.lblpackages.TabIndex = 0;
            this.lblpackages.Text = "Number of packages";
            // 
            // lblprice
            // 
            this.lblprice.AutoSize = true;
            this.lblprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblprice.Location = new System.Drawing.Point(41, 136);
            this.lblprice.Name = "lblprice";
            this.lblprice.Size = new System.Drawing.Size(156, 20);
            this.lblprice.TabIndex = 1;
            this.lblprice.Text = "price perpackages";
            // 
            // txtpackages
            // 
            this.txtpackages.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtpackages.Location = new System.Drawing.Point(325, 98);
            this.txtpackages.Name = "txtpackages";
            this.txtpackages.Size = new System.Drawing.Size(207, 26);
            this.txtpackages.TabIndex = 2;
            // 
            // txtprice
            // 
            this.txtprice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtprice.Location = new System.Drawing.Point(325, 136);
            this.txtprice.Name = "txtprice";
            this.txtprice.Size = new System.Drawing.Size(207, 26);
            this.txtprice.TabIndex = 3;
            // 
            // btncalculate
            // 
            this.btncalculate.Location = new System.Drawing.Point(45, 278);
            this.btncalculate.Name = "btncalculate";
            this.btncalculate.Size = new System.Drawing.Size(115, 40);
            this.btncalculate.TabIndex = 4;
            this.btncalculate.Text = "Calculate";
            this.btncalculate.UseVisualStyleBackColor = true;
            this.btncalculate.Click += new System.EventHandler(this.btncalculate_Click);
            // 
            // btnclear
            // 
            this.btnclear.Location = new System.Drawing.Point(232, 279);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(103, 39);
            this.btnclear.TabIndex = 5;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(404, 279);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(112, 39);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(76, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(456, 41);
            this.label3.TabIndex = 7;
            this.label3.Text = "Purchese Information";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // purchesResults
            // 
            this.purchesResults.FormattingEnabled = true;
            this.purchesResults.ItemHeight = 20;
            this.purchesResults.Location = new System.Drawing.Point(564, 14);
            this.purchesResults.Name = "purchesResults";
            this.purchesResults.Size = new System.Drawing.Size(352, 284);
            this.purchesResults.TabIndex = 8;
            // 
            // lblAge
            // 
            this.lblAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAge.Location = new System.Drawing.Point(43, 182);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(100, 29);
            this.lblAge.TabIndex = 9;
            this.lblAge.Text = "Age";
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(327, 185);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(205, 26);
            this.txtAge.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(918, 450);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.purchesResults);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btncalculate);
            this.Controls.Add(this.txtprice);
            this.Controls.Add(this.txtpackages);
            this.Controls.Add(this.lblprice);
            this.Controls.Add(this.lblpackages);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblpackages;
        private System.Windows.Forms.Label lblprice;
        private System.Windows.Forms.TextBox txtpackages;
        private System.Windows.Forms.TextBox txtprice;
        private System.Windows.Forms.Button btncalculate;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox purchesResults;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.TextBox txtAge;
    }
}

