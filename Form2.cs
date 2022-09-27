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
            LoadRecordsService();

        }
        public void LoadRecords()
        {
            int i = 0;
            dataGridViewItems.Rows.Clear();
            cn.Open();
            cm = new SqlCommand("SELECT * FROM ViewItemProductType WHERE Description LIKE '%" + txtSearch.Text + "%' OR Type LIKE '%" + txtSearch.Text + "%' Order by Item_ID", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {                         //                    2-DESCRIPTION / 1-Description       4-PRODUCT / 4-Product                  6-QUANTITY / 5-Quantity          7-TYPE ID / 5-Type_ID
                i += 1;              // 0-#   1-ITEM ID / 0-Item_ID             3-TYPE / 3-Type                     5-PRICE / 2-Price                   7-CLASSIFICATION / 6-Classification
                dataGridViewItems.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString(), dr[6].ToString(), dr[7].ToString());
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
            {                            //                       2-NAME / 2-Name                   4-PRICE / 4-Price
                i += 1;                //0-#  1-SERVICE ID / 1-Service_ID       3-DESCRIPTION / 3-Description
                dataGridViewService.Rows.Add(i, dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString());
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
                frm.comBoxType.SelectedItem = dataGridViewItems[3, e.RowIndex].Value.ToString();
                frm.txtProduct.Text = dataGridViewItems[4, e.RowIndex].Value.ToString();
                frm.txtPrice.Text = dataGridViewItems[5, e.RowIndex].Value.ToString();
                frm.comBoxClassification.Text = dataGridViewItems[7, e.RowIndex].Value.ToString();
                frm.btnSave.Enabled = false;
                frm.btnUpdateAccessories.Enabled = true;
                
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
            frm.Generate();
            frm.ShowDialog();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtSearch.Text == String.Empty)
                {
                    LoadRecords();
                    return;
                }
                else
                {
                    LoadRecords();
                }
            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message, title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnAddService_Click(object sender, EventArgs e)
        {
            frmServiceAdd frm = new frmServiceAdd(this);
            frm.Generate();
            frm.ShowDialog();
        }

        private void txtSearchService_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtSearchService.Text == String.Empty)
                {
                    LoadRecordsService();
                    return;
                }
                else
                {
                    LoadRecordsService();
                }
            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message, title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
