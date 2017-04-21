using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace HTTPToText
{
    public partial class frmHTTPToText : Form
    {
        private Timer timer;
        private bool Running = false;
        public void InitTimer()
        {
            
            Console.WriteLine("Starting...");
            timer = new Timer();
            timer.Tick += new EventHandler(timer_tick);
            timer.Interval = (int)numericUpDown1.Value * 1000; // in miliseconds
            timer.Start();
        }
            
        public void ClearTimer()
        {
            Console.WriteLine("Stopping...");
            timer.Stop();
            timer = null;
        }

        public frmHTTPToText()
        {
            InitializeComponent();
        }
        private void timer_tick(object sender, EventArgs e)
        {
           

            try
            {
                System.Net.WebClient wc = new System.Net.WebClient();
                string webData = wc.DownloadString(textBox_url.Text);
                Console.WriteLine(webData);
            }
            catch (Exception ex) {
            }
        }
        


        private void button_timer_Click(object sender, EventArgs e)
        {
            if (textBox_url.Text == "")
            {
                Running = false;
                UpdateRunning();
                MessageBox.Show("Please Enter a URL!");

                return;
            }
            Running = !Running;
            UpdateRunning();
        }
        private void button_file_Click(object sender, EventArgs e)
        {
            sfd.ShowDialog();
        }

        private void sfd_FileOk(object sender, CancelEventArgs e)
        {
            lblPath.Text = sfd.FileName;

        }
        private void UpdateRunning()
        {
            Console.WriteLine("Updating Run State: " + Running);
            if (Running)
            {
                if (timer == null)
                {
                    InitTimer();
                }
                button_timer.Text = "Stop";
            }
            else
            {
                if (timer != null)
                {
                    ClearTimer();
                }

                button_timer.Text = "Start";
            }
        }

    }
}
