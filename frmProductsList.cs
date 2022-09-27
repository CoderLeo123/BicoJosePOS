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
            LoadRecordsType();
            LoadRecordsProduct();

        }
        public void LoadRecordsType()
        {
            int i = 0;
           dataGridViewType.Rows.Clear();
            cn.Open();
            cm = new SqlCommand("SELECT * FROM JoinProductType WHERE Type LIKE '%" + txtSearchTypeProducts.Text + "%' OR Product LIKE '%" + txtSearchTypeProducts.Text + "%' Order by Type_ID", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {                             //                       2-TYPE / 2-Type              4-PRODUCT / 3-Product         
                i += 1;                   //0-#  1-TYPE ID / 1-Type_ID          3-PRODUCT ID / 0-Product_ID                  
                dataGridViewType.Rows.Add(i, dr[1].ToString(), dr[2].ToString(), dr[0].ToString(), dr[3].ToString());
            }
            dr.Close();
            cn.Close();
        }
        public void LoadRecordsProduct()
        {
            int i = 0;
            dataGridViewProduct.Rows.Clear();
            cn.Open();
            cm = new SqlCommand("SELECT * FROM tblProduct WHERE Product LIKE '%" + txtSearchProduct.Text + "%' Order by Product_ID", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {                             //                     3-PRODUCT / 3-Product              
                i += 1;                   //0-#  1-PRODUCT ID / 1-Product_ID       
                dataGridViewProduct.Rows.Add(i, dr[1].ToString(), dr[2].ToString());
            }
            dr.Close();
            cn.Close();
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void dataGridViewProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

       

        private void dataGridViewProducts_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
             string colName = dataGridViewType.Columns[e.ColumnIndex].Name;
            if (colName == "Edit")
            {
                frmAddType frm = new frmAddType(this);
                frm.txtTypeID.Text = dataGridViewType[1, e.RowIndex].Value.ToString();
                frm.txtProductID.Text = dataGridViewType[3, e.RowIndex].Value.ToString();
                frm.txtType.Text = dataGridViewType[2, e.RowIndex].Value.ToString();
                frm.comBoxProduct.Text = dataGridViewType[4, e.RowIndex].Value.ToString();
                frm.btnSave.Enabled = false;
                frm.btnUpdate.Enabled = true;
                
                frm.LoadProduct();
                frm.ShowDialog();
            }
            else if (colName == "Delete")
            {
                if (MessageBox.Show("Are you sure you want to delete this record?", title, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cn.Open();
                    cm = new SqlCommand("DELETE FROM tblProductType WHERE Type_ID LIKE '" + dataGridViewType[1, e.RowIndex].Value.ToString() + "'", cn);
                    cm.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Record has been successfully deleted.", title, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadRecordsType();
                }
            }
        }

        private void dataGridViewService_CellContentClick(object sender, DataGridViewCellEventArgs e) //dataGridViewProduct
        {
            string colName = dataGridViewProduct.Columns[e.ColumnIndex].Name;
            if (colName == "EditProduct")
            {
                frmAddProduct frm = new frmAddProduct(this);
                frm.txtProductID.Text = dataGridViewProduct[1, e.RowIndex].Value.ToString();
                frm.txtProduct.Text = dataGridViewProduct[2, e.RowIndex].Value.ToString();
                frm.btnSave.Enabled = false;
                frm.btnUpdate.Enabled = true;
                
                frm.ShowDialog();
            }
            else if (colName == "DeleteProduct")
            {
                if (MessageBox.Show("Are you sure you want to delete this record?", title, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cn.Open();
                    cm = new SqlCommand("DELETE FROM tblProduct WHERE Product_ID LIKE '" + dataGridViewProduct[1, e.RowIndex].Value.ToString() + "'", cn);
                    cm.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Record has been successfully deleted.", title, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadRecordsProduct();
                }
            }
        }

        private void txtSearchTypeProducts_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtSearchTypeProducts.Text == String.Empty)
                {
                    LoadRecordsType();
                    return;
                }
                else
                {
                    LoadRecordsType();
                }
            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message, title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        

        private void button1_Click(object sender, EventArgs e)//btnAddProduct
        {
            frmAddProduct frm = new frmAddProduct(this);
            frm.Generate();
            frm.ShowDialog();
        }

        private void btnAddType_Click(object sender, EventArgs e)
        {
            frmAddType frm = new frmAddType(this);
            frm.LoadProduct();
            frm.Generate();
            frm.ShowDialog();
        }

        private void txtSearchProduct_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtSearchTypeProducts.Text == String.Empty)
                {
                    LoadRecordsProduct();
                    return;
                }
                else
                {
                    LoadRecordsProduct();
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
