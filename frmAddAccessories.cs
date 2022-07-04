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
    public partial class frmAddAccessories : Form
    {
        public frmAddAccessories()
        {
            InitializeComponent();
            
        }
        public void Clear()
        {
            btnSaveAccessories.Enabled = true;
            btnUpdateAccessories.Enabled = false;
            txtPriceAccessories.Clear();
            txtDescAccessories.Clear();
            txtPriceAccessories.Focus();

        }
        private void btnSaveAccessories_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Record has been successfully saved.");
            Clear();
        }

        private void btnCancelAccessories_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnCloseAccessories_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void comBoxTypeAccessories_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void comBoxTypeAccessories_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
