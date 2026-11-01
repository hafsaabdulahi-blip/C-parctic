namespace Test3
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
            this.DeleteFile = new System.Windows.Forms.Button();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.StreamReaderBtn = new System.Windows.Forms.Button();
            this.WriteAllTextBtn = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.Itemtxt = new System.Windows.Forms.TextBox();
            this.BtnaddItem = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DeleteFile
            // 
            this.DeleteFile.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.DeleteFile.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteFile.Location = new System.Drawing.Point(384, 502);
            this.DeleteFile.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DeleteFile.Name = "DeleteFile";
            this.DeleteFile.Size = new System.Drawing.Size(219, 90);
            this.DeleteFile.TabIndex = 0;
            this.DeleteFile.Text = "Delete File";
            this.DeleteFile.UseVisualStyleBackColor = false;
            this.DeleteFile.Click += new System.EventHandler(this.DeleteFile_Click);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.BackColor = System.Drawing.Color.Red;
            this.DeleteBtn.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteBtn.Location = new System.Drawing.Point(153, 502);
            this.DeleteBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(204, 90);
            this.DeleteBtn.TabIndex = 0;
            this.DeleteBtn.Text = "Delete item";
            this.DeleteBtn.UseVisualStyleBackColor = false;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // StreamReaderBtn
            // 
            this.StreamReaderBtn.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.StreamReaderBtn.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StreamReaderBtn.Location = new System.Drawing.Point(864, 502);
            this.StreamReaderBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.StreamReaderBtn.Name = "StreamReaderBtn";
            this.StreamReaderBtn.Size = new System.Drawing.Size(220, 90);
            this.StreamReaderBtn.TabIndex = 0;
            this.StreamReaderBtn.Text = "Stream Reader";
            this.StreamReaderBtn.UseVisualStyleBackColor = false;
            this.StreamReaderBtn.Click += new System.EventHandler(this.StreamReaderBtn_Click);
            // 
            // WriteAllTextBtn
            // 
            this.WriteAllTextBtn.BackColor = System.Drawing.Color.LightSeaGreen;
            this.WriteAllTextBtn.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WriteAllTextBtn.Location = new System.Drawing.Point(626, 502);
            this.WriteAllTextBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.WriteAllTextBtn.Name = "WriteAllTextBtn";
            this.WriteAllTextBtn.Size = new System.Drawing.Size(208, 90);
            this.WriteAllTextBtn.TabIndex = 0;
            this.WriteAllTextBtn.Text = "Write All Text";
            this.WriteAllTextBtn.UseVisualStyleBackColor = false;
            this.WriteAllTextBtn.Click += new System.EventHandler(this.WriteAllTextBtn_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(157, 29);
            this.listBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(930, 324);
            this.listBox1.TabIndex = 1;
            // 
            // Itemtxt
            // 
            this.Itemtxt.Location = new System.Drawing.Point(157, 384);
            this.Itemtxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Itemtxt.Multiline = true;
            this.Itemtxt.Name = "Itemtxt";
            this.Itemtxt.Size = new System.Drawing.Size(930, 75);
            this.Itemtxt.TabIndex = 2;
            // 
            // BtnaddItem
            // 
            this.BtnaddItem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnaddItem.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnaddItem.Location = new System.Drawing.Point(401, 644);
            this.BtnaddItem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnaddItem.Name = "BtnaddItem";
            this.BtnaddItem.Size = new System.Drawing.Size(379, 82);
            this.BtnaddItem.TabIndex = 3;
            this.BtnaddItem.Text = "Add Item";
            this.BtnaddItem.UseVisualStyleBackColor = false;
            this.BtnaddItem.Click += new System.EventHandler(this.BtnaddItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1243, 794);
            this.Controls.Add(this.BtnaddItem);
            this.Controls.Add(this.Itemtxt);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.WriteAllTextBtn);
            this.Controls.Add(this.StreamReaderBtn);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.DeleteFile);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button DeleteFile;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Button StreamReaderBtn;
        private System.Windows.Forms.Button WriteAllTextBtn;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox Itemtxt;
        private System.Windows.Forms.Button BtnaddItem;
    }
}

