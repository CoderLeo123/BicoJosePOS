using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Capstone
{
    public partial class frmEditStock : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        SqlDataReader dr;
        frmStockIn frmList;
        string title = "BICO-JOSE System";
        
        public frmEditStock(frmStockIn frmAdd)
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
            frmList = frmAdd;
            lblCheck.Text = "Yes";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (lblCheck.Text == "Yes")
                {
                    if (MessageBox.Show("Are you sure you want to update this record?", title, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        int i = frmList.dataGridViewStockItems.CurrentRow.Index;
                        frmList.dataGridViewStockItems[6, i].Value = DateTime.Parse(dateExpiration.Value.ToString()).ToShortDateString();
                        frmList.dataGridViewStockItems[5, i].Value = txtQuantity.Text;

                        this.Close();

                    }
                }
                else if(lblCheck.Text == "No")
                {
                    if (MessageBox.Show("Are you sure you want to update this record?", title, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        int i = frmList.dataGridViewStockItems.CurrentRow.Index;
                        frmList.dataGridViewStockItems[6, i].Value = "Non-Perishable";
                        frmList.dataGridViewStockItems[5, i].Value = txtQuantity.Text;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void txtQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 46)
            {
                //accept . character
            }
            else if (e.KeyChar == 8)
            {
                //accept backspace
            }
            else if ((e.KeyChar < 48) || (e.KeyChar > 57))
            {
                //ascii code 48 - 57 = characters between 0 - 9
                e.Handled = true;
            }
        }

        private void btnPerishable_Click(object sender, EventArgs e)
        {
            dateExpiration.Enabled = true;
            lblCheck.Text = "Yes";
        }

        private void btnNonPerishable_Click(object sender, EventArgs e)
        {
            dateExpiration.Enabled = false;
            lblCheck.Text = "No";
        }
    }
}
