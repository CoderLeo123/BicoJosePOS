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
    public partial class frmServiceAdd : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        SqlDataReader dr;
        string title = "BICO-JOSE System";
        frmProductsList frmList;
        string ID; int count;
        public frmServiceAdd(frmProductsList frmAdd)
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
            frmList = frmAdd;

        }
        public void Clear()
        {
            btnSaveService.Enabled = true;

            txtServiceID.Clear();
            txtServiceName.Clear();
            txtServiceDesc.Clear();
            txtServicePrice.Clear();
            txtServiceName.Focus();

        }
        private void Generate()
        {
            try
            {
                cn.Open();
                cm = new SqlCommand("SELECT TOP 1 Service_ID FROM tblServices ORDER BY Service_ID DESC", cn);
                dr = cm.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {
                    ID = dr[0].ToString(); //S1001
                    count = int.Parse(ID.Substring(1, 4)); //1001
                    txtServiceID.Text = ID.Substring(0, 1) + (count + 1); //S1002
                }
                else
                {
                    ID = dr[0].ToString();
                    txtServiceID.Text = ID;
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if(MessageBox.Show("Are you sure you want to save this record?",title,MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes){
                    cn.Open();
                    cm = new SqlCommand("INSERT INTO tblServices (Service_ID, Name, Description, Price) VALUES(@ID, @Name, @Description, @Price)", cn);
                    cm.Parameters.AddWithValue("@ID", txtServiceID.Text);
                    cm.Parameters.AddWithValue("@Name", txtServiceName.Text);
                    cm.Parameters.AddWithValue("@Description", txtServiceDesc.Text);
                    cm.Parameters.AddWithValue("@Price", txtServicePrice.Text);
                    cm.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Record has been successfully saved.");
                    Clear();
                    btnUpdate.Enabled = false;
                    frmList.LoadRecordsService();
                }
            }catch(Exception ex)
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
                    cm = new SqlCommand("UPDATE tblServices SET Service_ID = @ID, Name = @Name, Description = @Description, Price = @Price WHERE Service_ID LIKE '" + txtServiceID.Text + "'", cn); 
                    cm.Parameters.AddWithValue("@ID", txtServiceID.Text);
                    cm.Parameters.AddWithValue("@Name", txtServiceName.Text);
                    cm.Parameters.AddWithValue("@Description", txtServiceDesc.Text);
                    cm.Parameters.AddWithValue("@Price", txtServicePrice.Text);
                    cm.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Record has been successfully updated.");
                    Clear();
                    btnSaveService.Enabled = false;
                    frmList.LoadRecordsService();
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

        private void txtServiceName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
