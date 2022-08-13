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
        
        string ID, num = "", pass; int count, count2, rows;
        string title = "BICO-JOSE System";
        public frmStockIn()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
            LoadStock();
            dataGridViewStockItems.AllowUserToAddRows = false;

        }
        public void LoadStock()
        {
            try
            {
                dataGridViewStockItems.Rows.Clear();
                cn.Open();
                cm = new SqlCommand("SELECT * from JoinStockItemProduct WHERE Stock_ID LIKE '" + txtStockID.Text + "' AND Status LIKE 'Pending' ", cn);
                dr = cm.ExecuteReader();
                while (dr.Read())
                {                                  //                                                                                         4-DESCRIPTION / 2-Description                      6-EXPIRATION / 8-Expiration_Date                                                               8-STOCK IN BY / 7-Stock_In_By         10-TYPE / 3-Type
                                                   //  0-ID / 10-dbo.ID           1/Edit                    2/Delete           3-STOCK ID / 0-Stock_ID            5-QTY / 5-Quantity                                                                 7-STOCK IN DATE / 6-Stock_In_Date                            9-ITEM ID / 1-Item_ID
                    dataGridViewStockItems.Rows.Add(dr[10].ToString(), Properties.Resources.Edit, Properties.Resources._Delete, dr[0].ToString(), dr[2].ToString(), dr[5].ToString(), DateTime.Parse(dr[8].ToString()).ToShortDateString(), DateTime.Parse(dr[6].ToString()).ToShortDateString(), dr[7].ToString(), dr[1].ToString(), dr[3].ToString());
                    
                }
                dr.Close();
                cn.Close();
                btnSaveStockIn.Show();

    
            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message, title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
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

        public void LoadHistory()
        {
            try
            {
                int i = 0;
                dataGridViewStockHist.Rows.Clear();
                cn.Open();
                cm = new SqlCommand("SELECT * from JoinStockItemProduct WHERE CAST(Stock_In_Date as DATE) BETWEEN '" + dateStart.Value.ToShortDateString() + "' AND '"+ dateEnd.Value.ToShortDateString() +"' AND Status LIKE 'DONE' ", cn);
                dr = cm.ExecuteReader();
                while (dr.Read())
                {                                  //                    2-STOCK ID / 0-Stock_ID             4-QTY / 5-Quantity                                                                                                                            8-ITEM ID / 1-Item_ID                    
                    i += 1;                    // 0-Num   1-ID / 10-dbo.ID               3-DESCRIPTION / 2-Description                      5-STOCK IN DATE / 6-Stock_In_Date                 6-EXPIRATION / 8-Expiration_Date           7-STOCK IN BY / 7-Stock_In_By           9-TYPE / 3-Type           
                    dataGridViewStockHist.Rows.Add(i, dr[10].ToString(), dr[0].ToString(), dr[2].ToString(), dr[5].ToString(), DateTime.Parse(dr[6].ToString()).ToShortDateString(), DateTime.Parse(dr[8].ToString()).ToShortDateString(), dr[7].ToString(), dr[1].ToString(), dr[3].ToString());

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
        public void Clear()
        {
            txtStockID.Clear();
            txtStockInBy.Clear();
            dateStockIn.Value = DateTime.Now;
            dataGridViewStockItems.Rows.Clear();

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
            string colName = dataGridViewStockItems.Columns[e.ColumnIndex].Name;
            if (colName == "DeleteStockIn")
            {
                if (MessageBox.Show("Remove this Item?", title, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cn.Open();
                    cm = new SqlCommand("DELETE FROM tblStock WHERE id LIKE '" + dataGridViewStockItems.Rows[e.RowIndex].Cells[0].Value.ToString() + "'", cn);
                    cm.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Record has been successfully deleted.", title, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadStock();
                    
                }

            }
            else if (colName == "EDIT")
            {
                try
                {
                    frmEditStock frm = new frmEditStock(this);
                    frm.dateExpiration.Value = DateTime.Parse(dataGridViewStockItems[6, e.RowIndex].Value.ToString());
                    frm.txtQuantity.Text = dataGridViewStockItems[5, e.RowIndex].Value.ToString();
                    frm.ShowDialog(this);
                }
                catch (Exception ex)
                {
                    cn.Close();
                    MessageBox.Show(ex.Message, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void btnLoadHistory_Click(object sender, EventArgs e)
        {
            LoadHistory();
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
                    dataGridViewStockHist.Rows.Clear();
                    cn.Open();
                    cm = new SqlCommand("SELECT * from JoinStockItemProduct WHERE Description LIKE '%"+ txtSearch.Text + "%' OR Type LIKE '%" + txtSearch.Text + "%' AND Status LIKE 'DONE' ", cn);
                    dr = cm.ExecuteReader();
                    while (dr.Read())
                    {                                  //                    2-STOCK ID / 0-Stock_ID             4-QTY / 5-Quantity                                                                                                                            8-ITEM ID / 1-Item_ID                    
                        i += 1;                    // 0-Num   1-ID / 10-dbo.ID               3-DESCRIPTION / 2-Description                      5-STOCK IN DATE / 6-Stock_In_Date                 6-EXPIRATION / 8-Expiration_Date           7-STOCK IN BY / 7-Stock_In_By           9-TYPE / 3-Type           
                        dataGridViewStockHist.Rows.Add(i, dr[10].ToString(), dr[0].ToString(), dr[2].ToString(), dr[5].ToString(), DateTime.Parse(dr[6].ToString()).ToShortDateString(), DateTime.Parse(dr[8].ToString()).ToShortDateString(), dr[7].ToString(), dr[1].ToString(), dr[3].ToString());

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

            private void dataGridViewStockItems_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            
        }

        private void GenerateStockID_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Generate();
        }

        private void btnSaveStockIn_Click(object sender, EventArgs e)
        {
            
            if (dataGridViewStockItems.Rows.Count > 0)
            {
                
                    if (MessageBox.Show("Are you sure you want to save this records?", title, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                    
                    for (int i = 0; i < dataGridViewStockItems.Rows.Count; i++)
                    {

                        try
                        {
                            cn.Open();
                            cm = new SqlCommand("UPDATE tblStock SET Expiration_Date = '" + DateTime.Parse(dataGridViewStockItems.Rows[i].Cells[6].Value?.ToString()).ToShortDateString() + "', Quantity = Quantity + " + int.Parse(dataGridViewStockItems.Rows[i].Cells[5].Value?.ToString()) + ", ID = '"+ dataGridViewStockItems.Rows[i].Cells[0].Value?.ToString() + "', Status = 'Done' WHERE ID LIKE '"+ dataGridViewStockItems.Rows[i].Cells[0].Value?.ToString() + "' ", cn);
                            cm.ExecuteNonQuery();
                            cn.Close();
                            

                        }
                        catch (Exception ex)
                        {
                            cn.Close();
                            MessageBox.Show(ex.Message, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        
                    }
                    LoadStock();
                    Clear();
                }
                
            }
            
        }

        private void dataGridViewStockItems_SelectionChanged(object sender, EventArgs e)
        { 
        }
             
    }
}

