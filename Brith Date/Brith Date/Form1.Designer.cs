namespace Brith_Date
{
    partial class BrithDate
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.dayofweeklbl = new System.Windows.Forms.Label();
            this.monthlbl = new System.Windows.Forms.Label();
            this.dayofthemonthlbl = new System.Windows.Forms.Label();
            this.yearlbl = new System.Windows.Forms.Label();
            this.dayoftheweektxt = new System.Windows.Forms.TextBox();
            this.nameofthemonthtxt = new System.Windows.Forms.TextBox();
            this.numericdayofthemonthtxt = new System.Windows.Forms.TextBox();
            this.yeartxt = new System.Windows.Forms.TextBox();
            this.dateoutpitlbl = new System.Windows.Forms.Label();
            this.showdatebtn = new System.Windows.Forms.Button();
            this.clearbtn = new System.Windows.Forms.Button();
            this.Exitbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dayofweeklbl
            // 
            this.dayofweeklbl.AutoSize = true;
            this.dayofweeklbl.Location = new System.Drawing.Point(51, 45);
            this.dayofweeklbl.Name = "dayofweeklbl";
            this.dayofweeklbl.Size = new System.Drawing.Size(190, 20);
            this.dayofweeklbl.TabIndex = 0;
            this.dayofweeklbl.Text = "Enter the day of the week";
            // 
            // monthlbl
            // 
            this.monthlbl.AutoSize = true;
            this.monthlbl.Location = new System.Drawing.Point(51, 84);
            this.monthlbl.Name = "monthlbl";
            this.monthlbl.Size = new System.Drawing.Size(216, 20);
            this.monthlbl.TabIndex = 1;
            this.monthlbl.Text = "lEnter the name of the month";
            // 
            // dayofthemonthlbl
            // 
            this.dayofthemonthlbl.AutoSize = true;
            this.dayofthemonthlbl.Location = new System.Drawing.Point(51, 128);
            this.dayofthemonthlbl.Name = "dayofthemonthlbl";
            this.dayofthemonthlbl.Size = new System.Drawing.Size(285, 20);
            this.dayofthemonthlbl.TabIndex = 2;
            this.dayofthemonthlbl.Text = "Enter the numeric day of the the month";
            // 
            // yearlbl
            // 
            this.yearlbl.AutoSize = true;
            this.yearlbl.Location = new System.Drawing.Point(51, 177);
            this.yearlbl.Name = "yearlbl";
            this.yearlbl.Size = new System.Drawing.Size(109, 20);
            this.yearlbl.TabIndex = 3;
            this.yearlbl.Text = "Enter the year";
            // 
            // dayoftheweektxt
            // 
            this.dayoftheweektxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dayoftheweektxt.Location = new System.Drawing.Point(525, 45);
            this.dayoftheweektxt.Name = "dayoftheweektxt";
            this.dayoftheweektxt.Size = new System.Drawing.Size(170, 26);
            this.dayoftheweektxt.TabIndex = 4;
            // 
            // nameofthemonthtxt
            // 
            this.nameofthemonthtxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nameofthemonthtxt.Location = new System.Drawing.Point(525, 84);
            this.nameofthemonthtxt.Name = "nameofthemonthtxt";
            this.nameofthemonthtxt.Size = new System.Drawing.Size(173, 26);
            this.nameofthemonthtxt.TabIndex = 4;
            // 
            // numericdayofthemonthtxt
            // 
            this.numericdayofthemonthtxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericdayofthemonthtxt.Location = new System.Drawing.Point(525, 122);
            this.numericdayofthemonthtxt.Name = "numericdayofthemonthtxt";
            this.numericdayofthemonthtxt.Size = new System.Drawing.Size(173, 26);
            this.numericdayofthemonthtxt.TabIndex = 4;
            // 
            // yeartxt
            // 
            this.yeartxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.yeartxt.Location = new System.Drawing.Point(525, 177);
            this.yeartxt.Name = "yeartxt";
            this.yeartxt.Size = new System.Drawing.Size(170, 26);
            this.yeartxt.TabIndex = 4;
            // 
            // dateoutpitlbl
            // 
            this.dateoutpitlbl.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dateoutpitlbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dateoutpitlbl.Location = new System.Drawing.Point(134, 296);
            this.dateoutpitlbl.Name = "dateoutpitlbl";
            this.dateoutpitlbl.Size = new System.Drawing.Size(491, 49);
            this.dateoutpitlbl.TabIndex = 5;
            // 
            // showdatebtn
            // 
            this.showdatebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showdatebtn.Location = new System.Drawing.Point(136, 381);
            this.showdatebtn.Name = "showdatebtn";
            this.showdatebtn.Size = new System.Drawing.Size(105, 29);
            this.showdatebtn.TabIndex = 6;
            this.showdatebtn.Text = "Show Date";
            this.showdatebtn.UseVisualStyleBackColor = true;
            this.showdatebtn.Click += new System.EventHandler(this.showdatebtn_Click);
            // 
            // clearbtn
            // 
            this.clearbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearbtn.Location = new System.Drawing.Point(312, 381);
            this.clearbtn.Name = "clearbtn";
            this.clearbtn.Size = new System.Drawing.Size(99, 32);
            this.clearbtn.TabIndex = 7;
            this.clearbtn.Text = "Clear";
            this.clearbtn.UseVisualStyleBackColor = true;
            // 
            // Exitbtn
            // 
            this.Exitbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exitbtn.Location = new System.Drawing.Point(494, 377);
            this.Exitbtn.Name = "Exitbtn";
            this.Exitbtn.Size = new System.Drawing.Size(111, 33);
            this.Exitbtn.TabIndex = 8;
            this.Exitbtn.Text = "Exit";
            this.Exitbtn.UseVisualStyleBackColor = true;
            this.Exitbtn.Click += new System.EventHandler(this.button3_Click);
            // 
            // BrithDate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Exitbtn);
            this.Controls.Add(this.clearbtn);
            this.Controls.Add(this.showdatebtn);
            this.Controls.Add(this.dateoutpitlbl);
            this.Controls.Add(this.yeartxt);
            this.Controls.Add(this.nameofthemonthtxt);
            this.Controls.Add(this.numericdayofthemonthtxt);
            this.Controls.Add(this.dayoftheweektxt);
            this.Controls.Add(this.yearlbl);
            this.Controls.Add(this.dayofthemonthlbl);
            this.Controls.Add(this.monthlbl);
            this.Controls.Add(this.dayofweeklbl);
            this.Name = "BrithDate";
            this.Text = "Brith Date";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label dayofweeklbl;
        private System.Windows.Forms.Label monthlbl;
        private System.Windows.Forms.Label dayofthemonthlbl;
        private System.Windows.Forms.Label yearlbl;
        private System.Windows.Forms.TextBox dayoftheweektxt;
        private System.Windows.Forms.TextBox nameofthemonthtxt;
        private System.Windows.Forms.TextBox numericdayofthemonthtxt;
        private System.Windows.Forms.TextBox yeartxt;
        private System.Windows.Forms.Label dateoutpitlbl;
        private System.Windows.Forms.Button showdatebtn;
        private System.Windows.Forms.Button clearbtn;
        private System.Windows.Forms.Button Exitbtn;
    }
}

