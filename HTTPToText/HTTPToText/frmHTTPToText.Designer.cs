﻿namespace HTTPToText
{
    partial class frmHTTPToText
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
            this.sfd = new System.Windows.Forms.SaveFileDialog();
            this.button_timer = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.button_file = new System.Windows.Forms.Button();
            this.textBox_url = new System.Windows.Forms.TextBox();
            this.lblPath = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // sfd
            // 
            this.sfd.DefaultExt = "txt";
            this.sfd.FileOk += new System.ComponentModel.CancelEventHandler(this.sfd_FileOk);
            // 
            // button_timer
            // 
            this.button_timer.Location = new System.Drawing.Point(195, 41);
            this.button_timer.Name = "button_timer";
            this.button_timer.Size = new System.Drawing.Size(89, 23);
            this.button_timer.TabIndex = 0;
            this.button_timer.Text = "Start";
            this.button_timer.UseVisualStyleBackColor = true;
            this.button_timer.Click += new System.EventHandler(this.button_timer_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(76, 42);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(106, 20);
            this.numericUpDown1.TabIndex = 1;
            this.numericUpDown1.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // button_file
            // 
            this.button_file.Location = new System.Drawing.Point(530, 41);
            this.button_file.Name = "button_file";
            this.button_file.Size = new System.Drawing.Size(119, 23);
            this.button_file.TabIndex = 2;
            this.button_file.Text = "Text File";
            this.button_file.UseVisualStyleBackColor = true;
            this.button_file.Click += new System.EventHandler(this.button_file_Click);
            // 
            // textBox_url
            // 
            this.textBox_url.Location = new System.Drawing.Point(47, 12);
            this.textBox_url.Name = "textBox_url";
            this.textBox_url.Size = new System.Drawing.Size(602, 20);
            this.textBox_url.TabIndex = 3;
            this.textBox_url.TextChanged += new System.EventHandler(this.textBox_url_TextChanged);
            // 
            // lblPath
            // 
            this.lblPath.AutoSize = true;
            this.lblPath.Location = new System.Drawing.Point(290, 46);
            this.lblPath.Name = "lblPath";
            this.lblPath.Size = new System.Drawing.Size(66, 13);
            this.lblPath.TabIndex = 4;
            this.lblPath.Text = "(no path yet)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Refresh (s)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "URL";
            // 
            // frmHTTPToText
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 79);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblPath);
            this.Controls.Add(this.textBox_url);
            this.Controls.Add(this.button_file);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.button_timer);
            this.Name = "frmHTTPToText";
            this.Text = "HTTP To Text";
            this.Load += new System.EventHandler(this.frmHTTPToText_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SaveFileDialog sfd;
        private System.Windows.Forms.Button button_timer;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button button_file;
        private System.Windows.Forms.TextBox textBox_url;
        private System.Windows.Forms.Label lblPath;

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

