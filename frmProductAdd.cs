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
    public partial class frmProductAdd : Form
    {   
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        string title = "BICO-JOSE System";
        frmProductsList frmList;
        public frmProductAdd(frmProductsList frmAdd)
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
            frmList = frmAdd;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        public void Clear()
        {
            txtProduct.Clear();
            txtType.Clear();
            txtProduct.Focus();
            
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure you want to save this record?", title, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cn.Open();
                    cm = new SqlCommand("INSERT INTO tblProductType (Product_ID, Type, Product) VALUES(@ID, @Type, @Product)", cn);
                    cm.Parameters.AddWithValue("@ID", txtProductID.Text);
                    cm.Parameters.AddWithValue("@Product", txtProduct.Text);
                    cm.Parameters.AddWithValue("@Type", txtType.Text);
                    cm.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Record has been successfully saved.");
                    Clear();
                    frmList.LoadRecordsProducts();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void txtAddProd_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmProductAdd_Load(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure you want to update this record?", title, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cn.Open();
                    cm = new SqlCommand("UPDATE tblProductType SET Product_ID = @ID, Type = @Type, Product = @Product WHERE Product_ID LIKE '" + txtProductID.Text + "'", cn);
                    cm.Parameters.AddWithValue("@ID", txtProductID.Text);
                    cm.Parameters.AddWithValue("@Product", txtProduct.Text);
                    cm.Parameters.AddWithValue("@Type", txtType.Text);
                    cm.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Record has been successfully updated.");
                    Clear();
                    btnSave.Enabled = false;
                    btnUpdate.Enabled = true;
                    frmList.LoadRecordsProducts();
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
