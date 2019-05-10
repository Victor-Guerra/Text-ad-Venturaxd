namespace Text_Adventure
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
            this.lstBxInventory = new System.Windows.Forms.ListBox();
            this.picBxPreview = new System.Windows.Forms.PictureBox();
            this.rchTxtOut = new System.Windows.Forms.RichTextBox();
            this.txtBxInput = new System.Windows.Forms.TextBox();
            this.bttnSubmit = new System.Windows.Forms.Button();
            this.GrpPreview = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBxPreview)).BeginInit();
            this.SuspendLayout();
            // 
            // lstBxInventory
            // 
            this.lstBxInventory.FormattingEnabled = true;
            this.lstBxInventory.ItemHeight = 25;
            this.lstBxInventory.Location = new System.Drawing.Point(1002, 47);
            this.lstBxInventory.Name = "lstBxInventory";
            this.lstBxInventory.Size = new System.Drawing.Size(323, 454);
            this.lstBxInventory.TabIndex = 0;
            // 
            // picBxPreview
            // 
            this.picBxPreview.Image = global::Text_Adventure.Properties.Resources.E;
            this.picBxPreview.Location = new System.Drawing.Point(40, 47);
            this.picBxPreview.Name = "picBxPreview";
            this.picBxPreview.Size = new System.Drawing.Size(912, 454);
            this.picBxPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBxPreview.TabIndex = 2;
            this.picBxPreview.TabStop = false;
            // 
            // rchTxtOut
            // 
            this.rchTxtOut.BackColor = System.Drawing.Color.Black;
            this.rchTxtOut.ForeColor = System.Drawing.Color.White;
            this.rchTxtOut.Location = new System.Drawing.Point(40, 553);
            this.rchTxtOut.Name = "rchTxtOut";
            this.rchTxtOut.Size = new System.Drawing.Size(1285, 236);
            this.rchTxtOut.TabIndex = 3;
            this.rchTxtOut.Text = "";
            // 
            // txtBxInput
            // 
            this.txtBxInput.Location = new System.Drawing.Point(40, 843);
            this.txtBxInput.Name = "txtBxInput";
            this.txtBxInput.Size = new System.Drawing.Size(912, 31);
            this.txtBxInput.TabIndex = 4;
            // 
            // bttnSubmit
            // 
            this.bttnSubmit.Location = new System.Drawing.Point(1002, 843);
            this.bttnSubmit.Name = "bttnSubmit";
            this.bttnSubmit.Size = new System.Drawing.Size(323, 31);
            this.bttnSubmit.TabIndex = 5;
            this.bttnSubmit.Text = "Submit";
            this.bttnSubmit.UseVisualStyleBackColor = true;
            this.bttnSubmit.Click += new System.EventHandler(this.BttnSubmit_Click);
            // 
            // GrpPreview
            // 
            this.GrpPreview.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.GrpPreview.Location = new System.Drawing.Point(27, 12);
            this.GrpPreview.Name = "GrpPreview";
            this.GrpPreview.Size = new System.Drawing.Size(937, 498);
            this.GrpPreview.TabIndex = 6;
            this.GrpPreview.TabStop = false;
            this.GrpPreview.Text = "Environment";
            // 
            // groupBox1
            // 
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Location = new System.Drawing.Point(993, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(342, 498);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Inventory";
            // 
            // groupBox2
            // 
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox2.Location = new System.Drawing.Point(27, 525);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1308, 275);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Output";
            // 
            // groupBox3
            // 
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox3.Location = new System.Drawing.Point(27, 816);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1308, 66);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Command Input";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(20)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(1368, 908);
            this.Controls.Add(this.bttnSubmit);
            this.Controls.Add(this.txtBxInput);
            this.Controls.Add(this.rchTxtOut);
            this.Controls.Add(this.picBxPreview);
            this.Controls.Add(this.lstBxInventory);
            this.Controls.Add(this.GrpPreview);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBxPreview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstBxInventory;
        private System.Windows.Forms.PictureBox picBxPreview;
        private System.Windows.Forms.RichTextBox rchTxtOut;
        private System.Windows.Forms.TextBox txtBxInput;
        private System.Windows.Forms.Button bttnSubmit;
        private System.Windows.Forms.GroupBox GrpPreview;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}

