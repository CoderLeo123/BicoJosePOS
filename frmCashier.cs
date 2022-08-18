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
    public partial class frmCashier : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        SqlDataReader dr;
        string title = "BICO-JOSE System";
        string num; int count;

        public frmCashier()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
            lblDate.Text = DateTime.Now.ToString();
            
        }

        private void button2_Click(object sender, EventArgs e) //Browse Item btn
        {
            if (lblTransactionNo.Text == string.Empty)
            {
                MessageBox.Show("Please generate a Transaction No first", title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {

                frmBrowseItem frm = new frmBrowseItem(this);
                frm.lblTrans.Text = lblTransactionNo.Text;
                frm.ShowDialog();
            }
            
        }
        
    
        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void GenerateTransactionNo()
        {
            try
            {
                string date = DateTime.Now.ToString("yyyyMMdd");
                cn.Open();
                cm = new SqlCommand("SELECT TOP 1 Transaction_No FROM tblCart ORDER BY Transaction_No DESC", cn);
                dr = cm.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {
                    num = dr[0].ToString(); //2022081710001
                    count = int.Parse(num.Substring(8, 5)); //10001
                    lblTransactionNo.Text = date + (count + 1); //2022081710002

                }
                else
                {
                    num = dr[0].ToString();
                    lblTransactionNo.Text = num;
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
        
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAddDiscount_Click(object sender, EventArgs e)
        {
            frmDiscount frm = new frmDiscount();
            frm.ShowDialog();
        }

        private void btnSettlePayment_Click(object sender, EventArgs e)
        {
            frmSettlePayment frm = new frmSettlePayment();
            frm.ShowDialog();
        }

        private void btnDailySales_Click(object sender, EventArgs e)
        {
            frmDailySales frm = new frmDailySales();
            frm.ShowDialog();
        }

        private void btnChangePass_Click(object sender, EventArgs e)
        {
            frmChangePassword frm = new frmChangePassword();
            frm.ShowDialog();
        }

        private void btnNewTransaction_Click(object sender, EventArgs e)
        {
            GenerateTransactionNo();
        }
    }
}
