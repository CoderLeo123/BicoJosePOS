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
    public partial class frmProductsList : Form
    {
        public frmProductsList()
        {
            InitializeComponent();
            for (int i = 0; i <= 10; i++)
            {
                dataGridViewProducts.Rows.Add(1, "Brand 1");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmProductAdd frm = new frmProductAdd();
            frm.ShowDialog();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void dataGridViewProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAddService_Click(object sender, EventArgs e)
        {
            frmServiceAdd frm = new frmServiceAdd();
            frm.ShowDialog();
        }
    }
}
