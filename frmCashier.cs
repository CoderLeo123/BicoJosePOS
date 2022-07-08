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
    public partial class frmCashier : Form
    {
        public frmCashier()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmBrowseItem frm = new frmBrowseItem();
            frm.ShowDialog();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAddDiscount_Click(object sender, EventArgs e)
        {
            frmDiscount frm = new frmDiscount();
            frm.ShowDialog();
        }

        private void btnSettlePayment_Click(object sender, EventArgs e)
        {
            frmSettlePayment frm = new frmSettlePayment();
            frm.ShowDialog();
        }

        private void btnDailySales_Click(object sender, EventArgs e)
        {
            frmDailySales frm = new frmDailySales();
            frm.ShowDialog();
        }

        private void btnChangePass_Click(object sender, EventArgs e)
        {
            frmChangePassword frm = new frmChangePassword();
            frm.ShowDialog();
        }
    }
}
