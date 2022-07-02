using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capstone
{
    public partial class frmAddLense : Form
    {
        public frmAddLense()
        {
            InitializeComponent();
        }
        public void Clear()
        {
            btnSaveLense.Enabled = true;
            btnUpdateLense.Enabled = false;
            txtLenseTypes.Clear();
            txtFeature.Clear();
            txtLenseTypes.Focus();

        }
        private void btnSaveLense_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Record has been successfully saved.");
            Clear();
        }

        private void btnCancelLense_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnCloseLense_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
