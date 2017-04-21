namespace HTTPToText
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
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.button_timer = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.button_file = new System.Windows.Forms.Button();
            this.textBox_url = new System.Windows.Forms.TextBox();
            this.label_textfilepath = new System.Windows.Forms.Label();
            this.URL = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // button_timer
            // 
            this.button_timer.Location = new System.Drawing.Point(195, 41);
            this.button_timer.Name = "button_timer";
            this.button_timer.Size = new System.Drawing.Size(89, 23);
            this.button_timer.TabIndex = 0;
            this.button_timer.Text = "Start";
            this.button_timer.UseVisualStyleBackColor = true;
            this.button_timer.Click += new System.EventHandler(this.button1_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(62, 42);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 1;
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
            // 
            // label_textfilepath
            // 
            this.label_textfilepath.AutoSize = true;
            this.label_textfilepath.Location = new System.Drawing.Point(312, 44);
            this.label_textfilepath.Name = "label_textfilepath";
            this.label_textfilepath.Size = new System.Drawing.Size(35, 13);
            this.label_textfilepath.TabIndex = 4;
            this.label_textfilepath.Text = "label1";
            // 
            // URL
            // 
            this.URL.AutoSize = true;
            this.URL.Location = new System.Drawing.Point(12, 15);
            this.URL.Name = "URL";
            this.URL.Size = new System.Drawing.Size(29, 13);
            this.URL.TabIndex = 5;
            this.URL.Text = "URL";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Refresh";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 79);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.URL);
            this.Controls.Add(this.label_textfilepath);
            this.Controls.Add(this.textBox_url);
            this.Controls.Add(this.button_file);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.button_timer);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button button_timer;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button button_file;
        private System.Windows.Forms.TextBox textBox_url;
        private System.Windows.Forms.Label label_textfilepath;
        private System.Windows.Forms.Label URL;
        private System.Windows.Forms.Label label1;
    }
}

