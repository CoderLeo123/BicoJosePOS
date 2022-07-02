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
    public partial class frmItemsList : Form
    {
        public frmItemsList()
        {
            InitializeComponent();
            for(int i=0; i<=10; i++)
            {
                dataGridViewItems.Rows.Add(1, "1", "Brand 1");
            }
             
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void btnAddFrame_Click(object sender, EventArgs e)
        {
            frmAddFrame frm = new frmAddFrame();
            frm.ShowDialog();
        }

        private void btnAddLense_Click(object sender, EventArgs e)
        {
            frmAddLense frm = new frmAddLense();
            frm.ShowDialog();
        }

        private void btnAddAccessories_Click(object sender, EventArgs e)
        {
            frmAddAccessories frm = new frmAddAccessories();
            frm.ShowDialog();
        }
    }
}
