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
    public partial class frmServiceAdd : Form
    {
        public frmServiceAdd()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        public void Clear()
        {
            btnSave.Enabled = true;
            btnUpdate.Enabled = false;
            txtServName.Clear();
            txtServDesc.Clear();
            txtServPrice.Clear();
            txtServName.Focus();

        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Record has been successfully saved.");
            Clear();
        }
    }
}
