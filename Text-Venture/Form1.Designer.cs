﻿namespace Text_Venture
{
    partial class Game
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game));
            this.lstBxStatus = new System.Windows.Forms.ListBox();
            this.picBxPreview = new System.Windows.Forms.PictureBox();
            this.rchTxtOut = new System.Windows.Forms.RichTextBox();
            this.txtBxInput = new System.Windows.Forms.TextBox();
            this.bttnSubmit = new System.Windows.Forms.Button();
            this.GrpPreview = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBxPreview)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstBxStatus
            // 
            this.lstBxStatus.Font = new System.Drawing.Font("00 Starmap Truetype", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstBxStatus.FormattingEnabled = true;
            this.lstBxStatus.ItemHeight = 14;
            this.lstBxStatus.Location = new System.Drawing.Point(4, 17);
            this.lstBxStatus.Margin = new System.Windows.Forms.Padding(2);
            this.lstBxStatus.Name = "lstBxStatus";
            this.lstBxStatus.Size = new System.Drawing.Size(215, 284);
            this.lstBxStatus.TabIndex = 0;
            this.lstBxStatus.TabStop = false;
            // 
            // picBxPreview
            // 
            this.picBxPreview.Image = ((System.Drawing.Image)(resources.GetObject("picBxPreview.Image")));
            this.picBxPreview.Location = new System.Drawing.Point(20, 24);
            this.picBxPreview.Margin = new System.Windows.Forms.Padding(2);
            this.picBxPreview.Name = "picBxPreview";
            this.picBxPreview.Size = new System.Drawing.Size(631, 303);
            this.picBxPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBxPreview.TabIndex = 2;
            this.picBxPreview.TabStop = false;
            // 
            // rchTxtOut
            // 
            this.rchTxtOut.BackColor = System.Drawing.Color.Black;
            this.rchTxtOut.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.rchTxtOut.Font = new System.Drawing.Font("00 Starmap Truetype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rchTxtOut.ForeColor = System.Drawing.Color.White;
            this.rchTxtOut.Location = new System.Drawing.Point(20, 346);
            this.rchTxtOut.Margin = new System.Windows.Forms.Padding(2);
            this.rchTxtOut.MaxLength = 80;
            this.rchTxtOut.Name = "rchTxtOut";
            this.rchTxtOut.ReadOnly = true;
            this.rchTxtOut.Size = new System.Drawing.Size(871, 198);
            this.rchTxtOut.TabIndex = 3;
            this.rchTxtOut.TabStop = false;
            this.rchTxtOut.Text = "";
            // 
            // txtBxInput
            // 
            this.txtBxInput.BackColor = System.Drawing.Color.Black;
            this.txtBxInput.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txtBxInput.Font = new System.Drawing.Font("00 Starmap Truetype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBxInput.ForeColor = System.Drawing.Color.White;
            this.txtBxInput.Location = new System.Drawing.Point(20, 566);
            this.txtBxInput.Margin = new System.Windows.Forms.Padding(2);
            this.txtBxInput.MaxLength = 66;
            this.txtBxInput.Name = "txtBxInput";
            this.txtBxInput.Size = new System.Drawing.Size(673, 22);
            this.txtBxInput.TabIndex = 1;
            this.txtBxInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtBxInput_KeyPress);
            // 
            // bttnSubmit
            // 
            this.bttnSubmit.Font = new System.Drawing.Font("00 Starmap Truetype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnSubmit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bttnSubmit.Location = new System.Drawing.Point(696, 14);
            this.bttnSubmit.Margin = new System.Windows.Forms.Padding(2);
            this.bttnSubmit.Name = "bttnSubmit";
            this.bttnSubmit.Size = new System.Drawing.Size(181, 20);
            this.bttnSubmit.TabIndex = 2;
            this.bttnSubmit.Text = "Submit";
            this.bttnSubmit.UseVisualStyleBackColor = true;
            this.bttnSubmit.Click += new System.EventHandler(this.BttnSubmit_Click);
            // 
            // GrpPreview
            // 
            this.GrpPreview.Font = new System.Drawing.Font("00 Starmap Truetype", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrpPreview.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.GrpPreview.Location = new System.Drawing.Point(14, 6);
            this.GrpPreview.Margin = new System.Windows.Forms.Padding(2);
            this.GrpPreview.Name = "GrpPreview";
            this.GrpPreview.Padding = new System.Windows.Forms.Padding(2);
            this.GrpPreview.Size = new System.Drawing.Size(641, 325);
            this.GrpPreview.TabIndex = 0;
            this.GrpPreview.TabStop = false;
            this.GrpPreview.Text = "Environment";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lstBxStatus);
            this.groupBox1.Font = new System.Drawing.Font("00 Starmap Truetype", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Location = new System.Drawing.Point(668, 6);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(223, 325);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Status";
            // 
            // groupBox2
            // 
            this.groupBox2.Font = new System.Drawing.Font("00 Starmap Truetype", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox2.Location = new System.Drawing.Point(14, 335);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(881, 213);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Output";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.bttnSubmit);
            this.groupBox3.Font = new System.Drawing.Font("00 Starmap Truetype", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox3.Location = new System.Drawing.Point(14, 552);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(881, 44);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Command Input";
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(20)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(906, 607);
            this.Controls.Add(this.txtBxInput);
            this.Controls.Add(this.rchTxtOut);
            this.Controls.Add(this.picBxPreview);
            this.Controls.Add(this.GrpPreview);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "Game";
            this.ShowIcon = false;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBxPreview)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstBxStatus;
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

