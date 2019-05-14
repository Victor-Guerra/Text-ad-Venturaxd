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
            this.lstBxInventory.Location = new System.Drawing.Point(501, 24);
            this.lstBxInventory.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lstBxInventory.Name = "lstBxInventory";
            this.lstBxInventory.Size = new System.Drawing.Size(164, 238);
            this.lstBxInventory.TabIndex = 0;
            // 
            // picBxPreview
            // 
            this.picBxPreview.Image = global::Text_Adventure.Properties.Resources.E;
            this.picBxPreview.Location = new System.Drawing.Point(20, 24);
            this.picBxPreview.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.picBxPreview.Name = "picBxPreview";
            this.picBxPreview.Size = new System.Drawing.Size(456, 236);
            this.picBxPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBxPreview.TabIndex = 2;
            this.picBxPreview.TabStop = false;
            // 
            // rchTxtOut
            // 
            this.rchTxtOut.BackColor = System.Drawing.Color.Black;
            this.rchTxtOut.ForeColor = System.Drawing.Color.White;
            this.rchTxtOut.Location = new System.Drawing.Point(20, 288);
            this.rchTxtOut.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rchTxtOut.Name = "rchTxtOut";
            this.rchTxtOut.Size = new System.Drawing.Size(644, 125);
            this.rchTxtOut.TabIndex = 3;
            this.rchTxtOut.Text = "";
            // 
            // txtBxInput
            // 
            this.txtBxInput.Location = new System.Drawing.Point(20, 438);
            this.txtBxInput.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtBxInput.Name = "txtBxInput";
            this.txtBxInput.Size = new System.Drawing.Size(458, 20);
            this.txtBxInput.TabIndex = 4;
            // 
            // bttnSubmit
            // 
            this.bttnSubmit.Location = new System.Drawing.Point(501, 438);
            this.bttnSubmit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bttnSubmit.Name = "bttnSubmit";
            this.bttnSubmit.Size = new System.Drawing.Size(162, 20);
            this.bttnSubmit.TabIndex = 5;
            this.bttnSubmit.Text = "Submit";
            this.bttnSubmit.UseVisualStyleBackColor = true;
            this.bttnSubmit.Click += new System.EventHandler(this.BttnSubmit_Click);
            // 
            // GrpPreview
            // 
            this.GrpPreview.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.GrpPreview.Location = new System.Drawing.Point(14, 6);
            this.GrpPreview.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.GrpPreview.Name = "GrpPreview";
            this.GrpPreview.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.GrpPreview.Size = new System.Drawing.Size(468, 259);
            this.GrpPreview.TabIndex = 6;
            this.GrpPreview.TabStop = false;
            this.GrpPreview.Text = "Environment";
            // 
            // groupBox1
            // 
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Location = new System.Drawing.Point(496, 6);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(171, 259);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Inventory";
            // 
            // groupBox2
            // 
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox2.Location = new System.Drawing.Point(14, 273);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(654, 143);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Output";
            // 
            // groupBox3
            // 
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox3.Location = new System.Drawing.Point(14, 424);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Size = new System.Drawing.Size(654, 44);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Command Input";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(20)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(684, 479);
            this.Controls.Add(this.bttnSubmit);
            this.Controls.Add(this.txtBxInput);
            this.Controls.Add(this.rchTxtOut);
            this.Controls.Add(this.picBxPreview);
            this.Controls.Add(this.lstBxInventory);
            this.Controls.Add(this.GrpPreview);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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

