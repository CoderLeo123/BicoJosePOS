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
    public partial class frmStockIn : Form
    {
        public frmStockIn()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void ClickSearchItem_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmSearchItem frm = new frmSearchItem();
            frm.ShowDialog();
        }
    }
}
