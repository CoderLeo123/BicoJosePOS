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
    public partial class frmStockIn : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        SqlDataReader dr;
        string ID; int count;
        string title = "BICO-JOSE System";
        public frmStockIn()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
            LoadStock();
        }
        public void LoadStock()
        {
            int i = 0;
            dataGridViewStockItems.Rows.Clear();
            cn.Open();
            cm = new SqlCommand("SELECT * from JoinStockItemProduct WHERE Stock_ID LIKE '" + txtStockID.Text + "' AND Status LIKE 'Pending' ", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i += 1;
                dataGridViewStockItems.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[5].ToString(), dr[6].ToString(), dr[7].ToString(), dr[8].ToString());
            }
            dr.Close();
            cn.Close();
            btnSaveStockIn.Show();
        }

        private void Generate()
        {
            try
            {
                cn.Open();
                cm = new SqlCommand("SELECT TOP 1 Stock_ID FROM tblStock ORDER BY Stock_ID DESC", cn);
                dr = cm.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {
                    ID = dr[0].ToString(); //STK1001
                    count = int.Parse(ID.Substring(3, 4)); //1001
                    txtStockID.Text = ID.Substring(0, 3) + (count + 1); //STK1002
                }
                else
                {
                    ID = dr[0].ToString();
                    txtStockID.Text = ID;
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void ClickSearchItem_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmSearchItem frm = new frmSearchItem(this);
            frm.ShowDialog();
        }

        private void dataGridViewStockItems_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void GenerateStockID_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Generate();
        }
    }
}
