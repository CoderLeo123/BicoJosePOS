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
        SqlDataReader dr;
        string title = "BICO-JOSE System";
        frmProductsList frmList;
        string GID; int count;
        public frmProductAdd(frmProductsList frmAdd)
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
            frmList = frmAdd;
        }
        public void Clear()
        {
            txtProduct.Clear();
            txtType.Clear();
            txtProduct.Focus();

        }
        private void Generate()
        {
            try
            {
                cn.Open();
                cm = new SqlCommand("SELECT TOP 1 Product_ID FROM tblProductType ORDER BY Product_ID DESC", cn);
                dr = cm.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {
                    GID = dr[0].ToString(); //P1001
                    count = int.Parse(GID.Substring(1, 4)); //1001
                    txtProductID.Text = GID.Substring(0, 1) + (count + 1); //P1002
                }
                else
                {
                    GID = dr[0].ToString();
                    txtProductID.Text = GID;
                }
                dr.Close();
                cn.Close();
            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message, title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void label2_Click(object sender, EventArgs e)
        {

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

        private void GenerateID_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Generate();
        }
    }
}
