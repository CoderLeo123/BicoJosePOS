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
    
    public partial class frmBrowseItem : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        SqlDataReader dr;
        string title = "BICO-JOSE System";
        frmCashier frmC;
        public frmBrowseItem(frmCashier frmC)
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
            LoadRecordsBrowse();
            this.frmC = frmC;
        }
        public void LoadRecordsBrowse()
        {
            try
            {
                int i = 0;
                dataGridViewBrowse.Rows.Clear();
                cn.Open();
                cm = new SqlCommand("SELECT * from JoinStockItemProduct WHERE Quantity > 0 ORDER BY ID", cn);
                dr = cm.ExecuteReader();
                while (dr.Read())
                {                                 //                2-DESCRIPTION / 2-Description       4-PRODUCT / 4-Product               6-QTY / 5-Quantity                                                                                                                                      
                    i += 1;                    // 0-Num   1-ID / 10-dbo.ID              3-TYPE / 3-Type                    5-PRICE / 11-Price                   7-EXPIRATION / 8-Expiration_Date                           
                    dataGridViewBrowse.Rows.Add(i, dr[10].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[11].ToString(), dr[5].ToString(), DateTime.Parse(dr[8].ToString()).ToShortDateString());

                }
                dr.Close();
                cn.Close();
            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void LoadCart()
        {
            try
            {
                int i = 0;
                frmC.dataGridViewCart.Rows.Clear();
                cn.Open();
                cm = new SqlCommand("SELECT * from JoinCartStockItem WHERE Status LIKE 'Cart'", cn);
                dr = cm.ExecuteReader();
                while (dr.Read())
                {                        // 0-Num               2-EXPIRATION / 2-Expiration_Date       4-QUANTITY / 3-Quantity              6-TOTAL / 5-TOTAL                                                                
                    i += 1;                 // 1-DESCRIPTION / 1-Description         3-PRICE / 4-Price                 5-DISCOUNT / 11-Discount                      7-Plus                         8-Minus                 9-Delete        
                    frmC.dataGridViewCart.Rows.Add(i, dr[1].ToString(), dr[2].ToString(), dr[4].ToString(), dr[3].ToString(), dr[11].ToString(), dr[5].ToString(), Properties.Resources._Add, Properties.Resources.Minus, Properties.Resources._Delete);

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
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtSearch.Text == String.Empty)
                {
                    return;
                }
                else
                {
                    int i = 0;
                    dataGridViewBrowse.Rows.Clear();
                    cn.Open();
                    cm = new SqlCommand("SELECT * from JoinStockItemProduct WHERE (Description LIKE '%" + txtSearch.Text + "%' OR Type LIKE '%" + txtSearch.Text + "%') AND Status LIKE 'DONE' AND Quantity > 0 ORDER BY ID", cn);
                    dr = cm.ExecuteReader();
                    while (dr.Read())
                    {                                  //                2-DESCRIPTION / 2-Description       4-PRODUCT / 4-Product               6-STOCK / 5-Quantity                                                                                                                                      
                        i += 1;                // 0-Num   1-ID / 10-dbo.ID                  3-TYPE / 3-Type                    5-PRICE / 11-Price                   7-EXPIRATION / 8-Expiration_Date                           
                        dataGridViewBrowse.Rows.Add(i, dr[10].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[11].ToString(), dr[5].ToString(), DateTime.Parse(dr[8].ToString()).ToShortDateString());

                       
                    }
                    dr.Close();
                    cn.Close();
                }
            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridViewBrowse_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string colName = dataGridViewBrowse.Columns[e.ColumnIndex].Name;
                
                frmQuantity frmQ = new frmQuantity(this);
                if (colName == "AddToCart")
                {
                    
                    
                    frmQ.lblPrice.Text = dataGridViewBrowse[5, e.RowIndex].Value.ToString();
                    frmQ.lblTotal.Text = "0";
                    frmQ.txtQuantity.Text = "0";
                    frmQ.ShowDialog();
                }
                
            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
    }

