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
    public partial class frmAddType : Form
    {   
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        SqlDataReader dr;
        string title = "BICO-JOSE System";
        frmProductsList frmList;
        string GID, initial = "T1001"; int count;
        private bool mouseDown;
        private Point lastLocation;
        public frmAddType(frmProductsList frmAdd)
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
            frmList = frmAdd;
        }
        public void Clear()
        {
            
            txtType.Clear();
            txtType.Focus();

        }
        public void Generate()
        {
            try
            {
                cn.Open();
                cm = new SqlCommand("SELECT TOP 1 Type_ID FROM tblProductType ORDER BY Type_ID DESC", cn);
                dr = cm.ExecuteReader();
                dr.Read();
                
                if (dr.HasRows)
                {    
                    GID = dr[0].ToString(); //T1001
                    count = int.Parse(GID.Substring(1, 4)); //1001
                    txtTypeID.Text = GID.Substring(0, 1) + (count + 1); //T1002
                }
                else
                {
                    cn.Close();
                    cn.Open();
                    cm = new SqlCommand("INSERT INTO tblProductType (Type_ID) VALUES('T1001')", cn);
                    cm.ExecuteNonQuery();
                    cn.Close();
                    Generate();
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
        public void LoadProduct()
        {
            try
            {
                cn.Open();
                cm = new SqlCommand("SELECT Product FROM tblProduct", cn);
                dr = cm.ExecuteReader();
                while (dr.Read())
                {
                    comBoxProduct.Items.Add(dr[0].ToString());

                }
                dr.Close();
                cn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public void LoadProductID()
        {
            
            txtProductID.Clear();
            try
            {
                cn.Open();
                cm = new SqlCommand("SELECT Product_ID FROM tblProduct WHERE Product LIKE '%" + comBoxProduct.Text + "'", cn);
                dr = cm.ExecuteReader();
                while (dr.Read())
                {

                    txtProductID.Text = dr[0].ToString();

                }
                dr.Close();
                cn.Close();

            }
            catch (Exception ex)
            {

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
                    cm = new SqlCommand("INSERT INTO tblProductType (Type_ID, Type, Product_ID, Product) VALUES(@ID, @Type, @ProductID, @Product)", cn);
                    cm.Parameters.AddWithValue("@ID", txtTypeID.Text);
                    cm.Parameters.AddWithValue("@ProductID", txtProductID.Text);
                    cm.Parameters.AddWithValue("@Product", comBoxProduct.Text);
                    cm.Parameters.AddWithValue("@Type", txtType.Text);
                    cm.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Record has been successfully saved.");
                    Clear();
                    frmList.LoadRecordsType();
                }
            }
            catch(Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message, title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        //private void frmProductAdd_Load(object sender, EventArgs e)
        //{

        //}

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure you want to update this record?", title, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cn.Open();
                    cm = new SqlCommand("UPDATE tblProductType SET Type_ID = @ID, Type = @Type, Product_ID = @ProductID, Product = @Product WHERE Type_ID LIKE '" + txtTypeID.Text + "'", cn);
                    cm.Parameters.AddWithValue("@ID", txtTypeID.Text);
                    cm.Parameters.AddWithValue("@ProductID", txtProductID.Text);
                    cm.Parameters.AddWithValue("@Product", comBoxProduct.Text);
                    cm.Parameters.AddWithValue("@Type", txtType.Text);
                    cm.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Record has been successfully updated.");
                    Clear();
                    btnSave.Enabled = false;
                    btnUpdate.Enabled = true;
                    frmList.LoadRecordsType();
                    this.Close();
                }
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

        private void comBoxProduct_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void comBoxProduct_TextUpdate(object sender, EventArgs e)
        {
            
        }

        private void comBoxProduct_MouseHover(object sender, EventArgs e)
        {
           
        }

        private void frmAddType_DoubleClick(object sender, EventArgs e)
        {
            
        }

        private void comBoxProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadProductID();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;

        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }

        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void frmAddType_Load(object sender, EventArgs e)
        {

        }
    }
}
