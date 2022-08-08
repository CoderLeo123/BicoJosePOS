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
        string title = "BICO-JOSE System";
        frmProductsList frmList;
        public frmServiceAdd(frmProductsList frmAdd)
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
            frmList = frmAdd;
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
        public void Clear()
        {
            btnSaveService.Enabled = true;
            btnUpdate.Enabled = false;
            txtServiceName.Clear();
            txtServiceDesc.Clear();
            txtServicePrice.Clear();
            txtServiceName.Focus();

        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if(MessageBox.Show("Are you sure you want to save this record?",title,MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes){
                    cn.Open();
                    cm = new SqlCommand("INSERT INTO tblService (Service_ID, Description, Price) VALUES(@ID, @Description, @Price)", cn);
                    cm.Parameters.AddWithValue("@ID", txtServiceID.Text);
                    cm.Parameters.AddWithValue("@Description", txtServiceDesc.Text);
                    cm.Parameters.AddWithValue("@Price", txtServicePrice.Text);
                    cm.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Record has been successfully saved.");
                    Clear();
                    frmList.LoadRecordsService();
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
    }
}
