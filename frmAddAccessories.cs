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
        string title = "BICO-JOSE System";
        public frmAddAccessories()
        {

            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
        }
        public void Clear()
        {
            btnSave.Enabled = true;
            btnUpdateAccessories.Enabled = false;
            txtPrice.Clear();
            txtDescription.Clear();
            txtPrice.Focus();

        }
        private void btnSaveAccessories_Click(object sender, EventArgs e)
        {
            try
            {
                if(MessageBox.Show("Are you sure you want to save this record?", title, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cn.Open();
                    cm = new SqlCommand("INSERT INTO JoinItemProduct (Item_ID, Description, Price, Type, Product) VALUES(@ID, @Description, @Price, @Type, @Product,)");
                    cm.Parameters.AddWithValue("@ID", txtID.Text);
                    cm.Parameters.AddWithValue("@Description", txtDescription.Text);
                    cm.Parameters.AddWithValue("@Type", comBoxType.Text);
                    cm.Parameters.AddWithValue("@Product", comBoxProduct.Text);
                    cm.Parameters.AddWithValue("@Price", txtPrice.Text);

                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            MessageBox.Show("Record has been successfully saved.");
            Clear();
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
            
        }

        private void comBoxTypeAccessories_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
