using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HTTPToText {
    public partial class frmHTTPToText : Form {
        public frmHTTPToText() {
            InitializeComponent();
        }

        private void button_file_Click(object sender, EventArgs e) {
            sfd.ShowDialog();
        }

        private void sfd_FileOk(object sender, CancelEventArgs e) {
            lblPath.Text = sfd.FileName;
        }
    }
}
