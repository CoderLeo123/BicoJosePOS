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
    public partial class frmSearchItem : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        SqlDataReader dr;
        frmStockIn frmList;
        
        string title = "BICO-JOSE System";

        public frmSearchItem(frmStockIn frmAdd)
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
            frmList = frmAdd;
            
            LoadRecordsSearch();
        }
        public void LoadRecordsSearch()
        {
            int i = 0;
            dataGridViewSearchItem.Rows.Clear();
            cn.Open();
            cm = new SqlCommand("SELECT * FROM JoinItemProduct WHERE Description LIKE '%" + txtSearchItem.Text + "%' ORDER BY Item_ID", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i += 1;
                dataGridViewSearchItem.Rows.Add(i, dr[0].ToString(), dr[2].ToString(), dr[4].ToString(), dr[5].ToString(), dr[3].ToString());
            }
            dr.Close();
            cn.Close();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridViewSearchItem_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try { 
            string colName = dataGridViewSearchItem.Columns[e.ColumnIndex].Name;
                if (colName == "AddSearchItem")
                {
                    if (frmList.txtStockID.Text == string.Empty)
                    {
                        MessageBox.Show("Please generate a Stock ID", title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        this.Close();
                        frmList.txtStockID.Focus();
                        return;
                    }
                    if (frmList.txtStockInBy.Text == string.Empty)
                    {
                        MessageBox.Show("Please enter a name in Stock In By", title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        this.Close();
                        frmList.txtStockInBy.Focus();
                        return;
                    }
                    if (MessageBox.Show("Add this Item?", title, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        cn.Open();
                        cm = new SqlCommand("INSERT INTO tblStock (Stock_ID, Item_ID, Stock_In_Date, Stock_In_By, Expiration_Date, Status) VALUES(@StockID, @ItemID, @StockDate, @StockInBy, @Expiration, 'Pending')", cn);
                        cm.Parameters.AddWithValue("@StockID", frmList.txtStockID.Text);
                        cm.Parameters.AddWithValue("@ItemID", dataGridViewSearchItem[1, e.RowIndex].Value.ToString());
                        cm.Parameters.AddWithValue("@StockInBy", frmList.txtStockInBy.Text);
                        cm.Parameters.AddWithValue("@StockDate", frmList.dateStockIn.Value);
                        cm.Parameters.AddWithValue("@Expiration", frmList.dateExpiration.Value);
                        cm.ExecuteNonQuery();
                        cn.Close();
                        MessageBox.Show("Successfully Added!", title, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        frmList.LoadStock();

                    }
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
