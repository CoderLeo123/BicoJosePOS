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
    public partial class frmQuantity : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        SqlDataReader dr;
        string title = "BICO-JOSE System";
        int i; String ID;
        
        frmBrowseItem frmB;
        public frmQuantity(frmBrowseItem frmAdd)
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
            
            frmB = frmAdd;
            Compute();

        }
        public void Compute()
        {
            try
            {
                float total = float.Parse(lblPricesd.Text) * float.Parse(txtQuantity.Text);
                lblTotal.Text = total.ToString("#.##");
                
            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {
            i = frmB.dataGridViewBrowse.SelectedRows[0].Index;
            int Stock = int.Parse(frmB.dataGridViewBrowse[6, i].Value.ToString());
            int input = int.Parse(txtQuantity.Text);
            if (txtQuantity.Text == string.Empty)
            {
                txtQuantity.Text = "0";
                txtQuantity.SelectAll();
            }
            if((input < 1) || (input > Stock))
            {
                txtQuantity.Text = Stock.ToString();
                txtQuantity.SelectAll();
            }
            Compute();
        }

        private void txtQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {

            try
            {
               
                if (e.KeyChar == 8)
                {
                    //accept backspace
                }
               
                else if ((e.KeyChar < 48) || (e.KeyChar > 57))
                {
                    //ascii code 48 - 57 = characters between 0 - 9
                    e.Handled = true;
                    Compute();
                }
                
                
                i = frmB.dataGridViewBrowse.SelectedRows[0].Index;
                if ((e.KeyChar == 13) && (txtQuantity.Text != String.Empty))
                {

                    
                    cn.Open();
                    cm = new SqlCommand("INSERT INTO tblCart (Item_ID, Transaction_No, Quantity, Price, Total, Date, Status) VALUES (@Item_ID, @TransactionNo, @Quantity, @Price, @Total, @Date, 'Cart')", cn);
                    //cm.Parameters.AddWithValue("@Stock_ID", frmB.dataGridViewBrowse[1, i].Value.ToString());
                    //cm.Parameters.AddWithValue("@Stock_Num", frmB.dataGridViewBrowse[1, i].Value.ToString());
                    cm.Parameters.AddWithValue("@Item_ID", frmB.dataGridViewBrowse[1, i].Value.ToString());
                    cm.Parameters.AddWithValue("@TransactionNo", frmB.lblTrans.Text);
                    cm.Parameters.AddWithValue("@Quantity", txtQuantity.Text);
                    cm.Parameters.AddWithValue("@Price", lblPricesd.Text);
                    cm.Parameters.AddWithValue("@Date", DateTime.Now);
                    cm.Parameters.AddWithValue("@Total", lblTotal.Text);
                    cm.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Successfully Added!", title, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                }
                
            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
