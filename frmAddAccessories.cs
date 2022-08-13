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
    public partial class frmAddAccessories : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        SqlDataReader dr;
        string title = "BICO-JOSE System";
        string ID; int count;
        frmItemsList frmList;
        public frmAddAccessories(frmItemsList frmAdd)
        {

            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
            frmList = frmAdd;
        }
        public void Clear()
        {
            btnSave.Enabled = true;
            btnUpdateAccessories.Enabled = false;
            txtPrice.Clear();
            txtDescription.Clear();
            txtPrice.Focus();

        }
        private void Generate()
        {
            try
            {
                cn.Open();
                cm = new SqlCommand("SELECT TOP 1 Item_ID FROM tblItem ORDER BY Item_ID DESC", cn);
                dr = cm.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {
                    ID = dr[0].ToString(); //ITM1001
                    count = int.Parse(ID.Substring(3, 4)); //1001
                    txtID.Text = ID.Substring(0, 3) + (count + 1); //ITM1002
                }
                else
                {
                    ID = dr[0].ToString();
                    txtID.Text = ID;
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
        public void LoadType()
        {
            try
            {
                cn.Open();
                cm = new SqlCommand("SELECT Type FROM tblProductType", cn);
                dr = cm.ExecuteReader();
                while (dr.Read())
                {
                    comBoxType.Items.Add(dr[0].ToString());
                    
                }
                dr.Close();
                cn.Close();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public void LoadProduct()
        {
            txtProduct.Clear();
            txtProductID.Clear();
            try
            {
                cn.Open();
                cm = new SqlCommand("SELECT Product_ID, Product FROM tblProductType WHERE Type LIKE '" + comBoxType.Text + "'", cn);
                dr = cm.ExecuteReader();
                while (dr.Read())
                {
                    txtProductID.Text = dr[0].ToString();
                    txtProduct.Text = dr[1].ToString();
                }
                dr.Close();
                cn.Close();
               
            }
            catch(Exception ex)
            {
                
                MessageBox.Show(ex.Message, title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }
        private void btnSaveAccessories_Click(object sender, EventArgs e)
        {
            try
            {
                if(MessageBox.Show("Are you sure you want to save this record?", title, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cn.Open();
                    cm = new SqlCommand("INSERT INTO tblItem (Item_ID, Product_ID, Description, Price) VALUES(@ID, @ProductID, @Description, @Price)", cn);
                    cm.Parameters.AddWithValue("@ID", txtID.Text);
                    cm.Parameters.AddWithValue("@Description", txtDescription.Text);
                    cm.Parameters.AddWithValue("@ProductID", txtProductID.Text);
                    cm.Parameters.AddWithValue("@Price", txtPrice.Text);
                    cm.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Record has been successfully saved.");
                    Clear();
                    btnUpdateAccessories.Enabled = false;
                    frmList.LoadRecords();
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        private void btnCancelAccessories_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnCloseAccessories_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void comBoxTypeAccessories_TextChanged(object sender, EventArgs e)
        {
            LoadProduct();
           
        }

        private void comBoxTypeAccessories_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void frmAddAccessories_Load(object sender, EventArgs e)
        {

        }

        private void txtDescription_TextChanged(object sender, EventArgs e)
        {

        }

        private void GenerateID_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Generate();
            cn.Close();
        }

        private void btnUpdateAccessories_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure you want to update this record?", title, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cn.Open();
                    cm = new SqlCommand("UPDATE tblItem SET Item_ID = @ItemID, Product_ID = @ProductID, Description = @Description, Price = @Price WHERE Item_ID LIKE '" + txtID.Text + "'", cn); 
                    cm.Parameters.AddWithValue("@ItemID", txtID.Text);
                    cm.Parameters.AddWithValue("@Description", txtDescription.Text);
                    cm.Parameters.AddWithValue("@Price", txtPrice.Text);
                    cm.Parameters.AddWithValue("@ProductID", txtProductID.Text);
                    cm.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Record has been successfully updated.");
                    Clear();
                    btnSave.Enabled = false;
                    frmList.LoadRecords();
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
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
    }
}
