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
        private string Path = "";
        private string URL = "";

        public frmHTTPToText()
        {
            InitializeComponent();

        }

        private void frmHTTPToText_Load(object sender, EventArgs e)
        {
            Path = Properties.Settings.Default.FilePath;
            URL = Properties.Settings.Default.URL;
            numericUpDown1.Value = Properties.Settings.Default.Timer;

            lblPath.Text = Path;
            textBox_url.Text = URL;
        }

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

        
       
        private void timer_tick(object sender, EventArgs e)
        {
           

            try
            {
                System.Net.WebClient wc = new System.Net.WebClient();
                string webData = wc.DownloadString(textBox_url.Text);
                Console.WriteLine(webData);
                System.IO.File.WriteAllText(Path, webData);
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
            
            Path = sfd.FileName;
            lblPath.Text = Path;

            UpdateSettings();
        }
        private void UpdateSettings()
        {

            Properties.Settings.Default.FilePath = Path;
            Properties.Settings.Default.Timer = (int)numericUpDown1.Value;
            Properties.Settings.Default.URL = textBox_url.Text;
            
            Properties.Settings.Default.Save();
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

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            UpdateSettings();
        }

        private void textBox_url_TextChanged(object sender, EventArgs e)
        {
            UpdateSettings();
        }

       
    }
}
