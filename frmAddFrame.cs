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
    public partial class frmAddFrame : Form
    {
        public frmAddFrame()
        {
            InitializeComponent();
           
        }

        private void dataGridViewItems_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        
        private void btnAdd_Click(object sender, EventArgs e)
        {
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            
        }

        private void frmServiceList_Load(object sender, EventArgs e)
        {

        }
        public void Clear()
        {
            btnSaveFrame.Enabled = true;
            btnUpdateFrame.Enabled = false;
            txtPriceFrame.Clear();
            txtNameFrame.Clear();
            txtNameFrame.Focus();

        }
        private void btnSaveFrame_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Record has been successfully saved.");
            Clear();
        }

        private void btnCancelFrame_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnCloseFrame_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
