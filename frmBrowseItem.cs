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
        public frmBrowseItem()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
            LoadRecordsBrowse();
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
                    {                                  //                2-DESCRIPTION / 2-Description       4-PRODUCT / 4-Product               6-QTY / 5-Quantity                                                                                                                                      
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
    }
    }

