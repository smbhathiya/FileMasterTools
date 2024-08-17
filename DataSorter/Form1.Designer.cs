﻿namespace DataSorter
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtFilePath = new System.Windows.Forms.TextBox();
            this.btnUpload = new System.Windows.Forms.Button();
            this.btnSort = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.filesselectbtn = new System.Windows.Forms.Button();
            this.mergebtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtFilePath
            // 
            this.txtFilePath.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtFilePath.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFilePath.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtFilePath.ForeColor = System.Drawing.Color.Black;
            this.txtFilePath.Location = new System.Drawing.Point(180, 30);
            this.txtFilePath.Margin = new System.Windows.Forms.Padding(4);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.Size = new System.Drawing.Size(650, 23);
            this.txtFilePath.TabIndex = 0;
            // 
            // btnUpload
            // 
            this.btnUpload.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnUpload.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpload.FlatAppearance.BorderSize = 0;
            this.btnUpload.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btnUpload.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnUpload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpload.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnUpload.ForeColor = System.Drawing.Color.White;
            this.btnUpload.Location = new System.Drawing.Point(25, 80);
            this.btnUpload.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(200, 50);
            this.btnUpload.TabIndex = 1;
            this.btnUpload.Text = "Select File";
            this.btnUpload.UseVisualStyleBackColor = false;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click_1);
            // 
            // btnSort
            // 
            this.btnSort.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(103)))), ((int)(((byte)(247)))));
            this.btnSort.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSort.FlatAppearance.BorderSize = 0;
            this.btnSort.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.btnSort.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.btnSort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSort.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSort.ForeColor = System.Drawing.Color.White;
            this.btnSort.Location = new System.Drawing.Point(250, 80);
            this.btnSort.Margin = new System.Windows.Forms.Padding(4);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(150, 50);
            this.btnSort.TabIndex = 2;
            this.btnSort.Text = "Organize";
            this.btnSort.UseVisualStyleBackColor = false;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(25, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "File Path";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(25, 200);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "Selected Files:";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.textBox1.ForeColor = System.Drawing.Color.Black;
            this.textBox1.Location = new System.Drawing.Point(180, 200);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(650, 23);
            this.textBox1.TabIndex = 4;
            // 
            // filesselectbtn
            // 
            this.filesselectbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.filesselectbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.filesselectbtn.FlatAppearance.BorderSize = 0;
            this.filesselectbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.filesselectbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.filesselectbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.filesselectbtn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.filesselectbtn.ForeColor = System.Drawing.Color.White;
            this.filesselectbtn.Location = new System.Drawing.Point(25, 250);
            this.filesselectbtn.Margin = new System.Windows.Forms.Padding(4);
            this.filesselectbtn.Name = "filesselectbtn";
            this.filesselectbtn.Size = new System.Drawing.Size(200, 50);
            this.filesselectbtn.TabIndex = 6;
            this.filesselectbtn.Text = "Select Files";
            this.filesselectbtn.UseVisualStyleBackColor = false;
            this.filesselectbtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // mergebtn
            // 
            this.mergebtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(103)))), ((int)(((byte)(247)))));
            this.mergebtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mergebtn.FlatAppearance.BorderSize = 0;
            this.mergebtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.mergebtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.mergebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mergebtn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.mergebtn.ForeColor = System.Drawing.Color.White;
            this.mergebtn.Location = new System.Drawing.Point(250, 250);
            this.mergebtn.Margin = new System.Windows.Forms.Padding(4);
            this.mergebtn.Name = "mergebtn";
            this.mergebtn.Size = new System.Drawing.Size(150, 50);
            this.mergebtn.TabIndex = 7;
            this.mergebtn.Text = "Merge Files";
            this.mergebtn.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(886, 510);
            this.Controls.Add(this.mergebtn);
            this.Controls.Add(this.filesselectbtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSort);
            this.Controls.Add(this.btnUpload);
            this.Controls.Add(this.txtFilePath);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Data Organizer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFilePath;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button filesselectbtn;
        private System.Windows.Forms.Button mergebtn;
    }
}
