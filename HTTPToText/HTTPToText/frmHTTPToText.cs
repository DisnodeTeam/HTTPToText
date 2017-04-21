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
            saveFileDialog1.ShowDialog();
        }
    }
}
