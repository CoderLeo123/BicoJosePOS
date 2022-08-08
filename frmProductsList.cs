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
    public partial class frmProductsList : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        SqlDataReader dr;
        string title = "BICO-JOSE System";

        public frmProductsList()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
            LoadRecordsProducts();
            LoadRecordsService();

        }
        public void LoadRecordsProducts()
        {
            int i = 0;
            dataGridViewProducts.Rows.Clear();
            cn.Open();
            cm = new SqlCommand("SELECT * FROM tblProductType WHERE Type LIKE '%" + txtSearchTypeProducts.Text + "%' OR Product LIKE '%" + txtSearchTypeProducts.Text + "%' Order by Product_ID", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i += 1;
                dataGridViewProducts.Rows.Add(i, dr[1].ToString(), dr[2].ToString(), dr[3].ToString());
            }
            dr.Close();
            cn.Close();
        }
        public void LoadRecordsService()
        {
            int i = 0;
            dataGridViewService.Rows.Clear();
            cn.Open();
            cm = new SqlCommand("SELECT * FROM tblServices WHERE Name LIKE '%" + txtSearchService.Text + "%' OR Description LIKE '%" + txtSearchService.Text + "%' Order by Service_ID", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i += 1;
                dataGridViewService.Rows.Add(i, dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString());
            }
            dr.Close();
            cn.Close();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmProductAdd frm = new frmProductAdd(this);
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
            frmServiceAdd frm = new frmServiceAdd(this);
            frm.ShowDialog();
        }

        private void dataGridViewProducts_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dataGridViewProducts.Columns[e.ColumnIndex].Name;
            if (colName == "Edit")
            {
                frmProductAdd frm = new frmProductAdd(this);
                frm.txtProductID.Text = dataGridViewProducts[1, e.RowIndex].Value.ToString();
                frm.txtType.Text = dataGridViewProducts[2, e.RowIndex].Value.ToString();
                frm.txtProduct.Text = dataGridViewProducts[3, e.RowIndex].Value.ToString();
                frm.btnSave.Enabled = false;
                frm.btnUpdate.Enabled = true;
                frm.ShowDialog();
            }
            else if (colName == "Delete")
            {
                if (MessageBox.Show("Are you sure you want to delete this record?", title, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cn.Open();
                    cm = new SqlCommand("DELETE FROM tblProductType WHERE Product_ID LIKE '" + dataGridViewProducts[1, e.RowIndex].Value.ToString() + "'", cn);
                    cm.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Record has been successfully deleted.", title, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadRecordsProducts();
                }
            }
        }

        private void dataGridViewService_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dataGridViewService.Columns[e.ColumnIndex].Name;
            if (colName == "EditService")
            {
                frmServiceAdd frm = new frmServiceAdd(this);
                frm.txtServiceID.Text = dataGridViewService[1, e.RowIndex].Value.ToString();
                frm.txtServiceName.Text = dataGridViewService[2, e.RowIndex].Value.ToString();
                frm.txtServiceDesc.Text = dataGridViewService[3, e.RowIndex].Value.ToString();
                frm.txtServicePrice.Text = dataGridViewService[4, e.RowIndex].Value.ToString();
                frm.btnSaveService.Enabled = false;
                frm.btnUpdate.Enabled = true;
                frm.ShowDialog();
            }
            else if (colName == "DeleteService")
            {
                if (MessageBox.Show("Are you sure you want to delete this record?", title, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cn.Open();
                    cm = new SqlCommand("DELETE FROM tblServices WHERE Service_ID LIKE '" + dataGridViewService[1, e.RowIndex].Value.ToString() + "'", cn);
                    cm.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Record has been successfully deleted.", title, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadRecordsService();
                }
            }
        }
    }
}
