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
    public partial class frmAddProduct : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        SqlDataReader dr;
        string title = "BICO-JOSE System";
        string ID; int count;
        frmProductsList frmList;
        public frmAddProduct(frmProductsList frmAdd)
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
            frmList = frmAdd;
        }
        public void Generate()
        {
            try
            {
                cn.Open();
                cm = new SqlCommand("SELECT TOP 1 Product_ID FROM tblProduct ORDER BY Product_ID DESC", cn);
                dr = cm.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {
                    ID = dr[0].ToString(); //P1001
                    count = int.Parse(ID.Substring(1, 4)); //1001
                    txtProductID.Text = ID.Substring(0, 1) + (count + 1); //P1002
                }
                else
                {
                    ID = dr[0].ToString();
                    txtProductID.Text = ID;
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
        //private void GenerateID_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        //{
        //    Generate();
        //}

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void Clear()
        {
            txtProduct.Clear();
            txtProduct.Focus();

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure you want to save this record?", title, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cn.Open();
                    cm = new SqlCommand("INSERT INTO tblProduct (Product_ID, Product) VALUES(@ID, @Product)", cn);
                    cm.Parameters.AddWithValue("@ID", txtProductID.Text);
                    cm.Parameters.AddWithValue("@Product", txtProduct.Text);
                    
                    cm.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Record has been successfully saved.");
                    Clear();
                    frmList.LoadRecordsProduct();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure you want to update this record?", title, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cn.Open();
                    cm = new SqlCommand("UPDATE tblProduct SET Product_ID = @ID, Product = @Product WHERE Product_ID LIKE '" + txtProductID.Text + "'", cn);
                    cm.Parameters.AddWithValue("@ID", txtProductID.Text);
                    cm.Parameters.AddWithValue("@Product", txtProduct.Text);
                    cm.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Record has been successfully updated.");
                    Clear();
                    btnSave.Enabled = false;
                    btnUpdate.Enabled = true;
                    frmList.LoadRecordsProduct();
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
