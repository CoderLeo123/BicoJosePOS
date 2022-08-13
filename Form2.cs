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
    public partial class frmItemsList : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        SqlDataReader dr;
        string title = "BICO-JOSE System";
        public frmItemsList()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
            LoadRecords();

        }
        public void LoadRecords()
        {
            int i = 0;
            dataGridViewItems.Rows.Clear();
            cn.Open();
            cm = new SqlCommand("SELECT * FROM JoinItemProduct Order by Item_ID", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i += 1;
                dataGridViewItems.Rows.Add(i, dr[0].ToString(), dr[2].ToString(), dr[4].ToString(), dr[5].ToString(), dr[3].ToString());
            }
            dr.Close();
            cn.Close();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) //dataGridViewItems
        {
            string colName = dataGridViewItems.Columns[e.ColumnIndex].Name;
            if (colName == "EditItems")
            {
                frmAddAccessories frm = new frmAddAccessories(this);
                frm.txtID.Text = dataGridViewItems[1, e.RowIndex].Value.ToString();
                frm.txtDescription.Text = dataGridViewItems[2, e.RowIndex].Value.ToString();
                frm.comBoxType.Text = dataGridViewItems[3, e.RowIndex].Value.ToString();
                frm.txtProduct.Text = dataGridViewItems[4, e.RowIndex].Value.ToString();
                frm.txtPrice.Text = dataGridViewItems[5, e.RowIndex].Value.ToString();
                frm.btnSave.Enabled = false;
                frm.btnUpdateAccessories.Enabled = true;
                frm.GenerateID.Enabled = false;
                frm.LoadType();
                frm.ShowDialog();
            }
            else if (colName == "DeleteItems")
            {
                if (MessageBox.Show("Are you sure you want to delete this record?", title, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cn.Open();
                    cm = new SqlCommand("DELETE FROM tblItem WHERE Item_ID LIKE '" + dataGridViewItems[1, e.RowIndex].Value.ToString() + "'", cn);
                    cm.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Record has been successfully deleted.", title, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadRecords();

                }
            }
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

        //private void btnAddFrame_Click(object sender, EventArgs e)
        //{
            
        //}

        //private void btnAddLense_Click(object sender, EventArgs e)
        //{
            
        //}

        private void btnAddAccessories_Click(object sender, EventArgs e)
        {
            frmAddAccessories frm = new frmAddAccessories(this);
            frm.LoadType();
            frm.ShowDialog();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtSearch.Text == String.Empty)
                {
                    return;
                }
                else
                {
                    int i = 0;
                    dataGridViewItems.Rows.Clear();
                    cn.Open();
                    cm = new SqlCommand("SELECT * FROM JoinItemProduct WHERE Description LIKE '%" + txtSearch.Text + "%' OR Type LIKE '%" + txtSearch.Text + "%' Order by Item_ID", cn);
                    dr = cm.ExecuteReader();
                    while (dr.Read())
                    {
                        i += 1;
                        dataGridViewItems.Rows.Add(i, dr[0].ToString(), dr[2].ToString(), dr[4].ToString(), dr[5].ToString(), dr[3].ToString());
                    }
                    dr.Close();
                    cn.Close();
                }
            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message, title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
