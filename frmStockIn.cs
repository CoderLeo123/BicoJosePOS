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
        string title = "BICO-JOSE System";
        string ID, num = "", pass; int count, count2, rows;
        string check = null;
        //Nullable<DateTime> check = null;
        //Nullable<string> check = null;
        public frmStockIn()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
            LoadStock();
            dataGridViewStockItems.AllowUserToAddRows = false;
            //txtSearch.Text = dataGridViewStockHist.Rows.Count.ToString();
        }
        public void LoadStock()
        {
            try
            {
                int i = 0;
                dataGridViewStockItems.Rows.Clear();
                cn.Open();
                cm = new SqlCommand("SELECT * from ViewStockItemType WHERE Stock_ID LIKE '" + txtStockID.Text + "' AND Status LIKE 'Pending' ", cn);
                dr = cm.ExecuteReader();
                while (dr.Read())
                {
                    int quantity = 0;
                    string ExpirationDate = dr[3].ToString();
                    if (string.IsNullOrEmpty(ExpirationDate))
                    {
                        ExpirationDate = "Non-Perishable";

                    }
                    else
                    {
                        if (ExpirationDate.Substring(0, 10) != "")
                        {
                            ExpirationDate = dr[3].ToString().Substring(0, 9);
                        }
                        else
                        {
                            ExpirationDate = dr[3].ToString().Substring(0, 10);
                        }

                    }
                     i += 1;
                                                     //                                                                      4-DESCRIPTION / 2-Description       6-EXPIRATION / 3-Expiration_Date                                      8-STOCK IN BY / 5-Stock_In_By         10-TYPE / 7-Type
                                                //0-# / i         1/Edit                    2/Delete           3-STOCK ID / 0-Stock_ID            5-QTY / 3-Quantity                              7-STOCK IN DATE / 4-Stock_In_Date                            9-ITEM ID / 6-Item_ID                12-num / 11-num 
                    dataGridViewStockItems.Rows.Add(i, Properties.Resources.Edit, Properties.Resources._Delete, dr[0].ToString(), dr[2].ToString(), quantity.ToString(), ExpirationDate, DateTime.Parse(dr[4].ToString()).ToShortDateString(), dr[5].ToString(), dr[6].ToString(), dr[7].ToString(), dr[10].ToString());
                    
                }
                dr.Close();
                cn.Close();
                btnSaveStockIn.Show();
                NonPerish();

            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message, title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public void NonPerish()
        {
            for (int i = 0; i < dataGridViewStockItems.Rows.Count; i++)
            {
                string scan = dataGridViewStockItems.Rows[i].Cells[6].Value.ToString();
                ((DataGridViewTextBoxColumn)dataGridViewStockItems.Columns[6]).MaxInputLength = 6;
                if (string.IsNullOrEmpty(scan))
                {
                    dataGridViewStockItems.Rows[i].Cells[6].Value = "Non-Perishable";
                }
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
                    cn.Close();
                    cn.Open();
                    cm = new SqlCommand("INSERT INTO tblStock (Stock_ID) VALUES('STK1001')", cn);
                    cm.ExecuteNonQuery();
                    cn.Close();
                    Generate();
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
                cm = new SqlCommand("SELECT * from ViewStockItemType WHERE (Description LIKE '%" + txtSearch.Text + "%' OR Type LIKE '%" + txtSearch.Text + "%') AND Stock_In_Date BETWEEN '" + dateStart.Value.ToShortDateString() + "' AND '"+ dateEnd.Value.ToShortDateString() +"' AND Status LIKE 'DONE' ", cn);
                dr = cm.ExecuteReader();
                while (dr.Read())
                {
                    string ExpirationDate = dr[3].ToString();
                    if (string.IsNullOrEmpty(ExpirationDate))
                    {
                        ExpirationDate = "Non-Perishable";

                    }
                    else
                    {               
                        if(ExpirationDate.Substring(0, 10) != "")
                        {
                            ExpirationDate = dr[3].ToString().Substring(0, 9);
                        }
                        else
                        {
                            ExpirationDate = dr[3].ToString().Substring(0, 10);
                        }
                        
                    }
                        //string CuttedExpirationDate = ExpirationDate.Substring(0, 10);
                        // dr[8].ToString().Substring(0, 10)
                        //                             1-STOCK ID / 1-Stock_ID               3-QTY / 11-Quantity                                         5-EXPIRATION / 3-Expiration_Date         8-ITEM ID / 6-Item_ID                    
                        i += 1;                    // 0-Num            2-DESCRIPTION / 2-Description                      4-STOCK IN DATE / 4-Stock_In_Date                  6-STOCK IN BY / 5-Stock_In_By           9-TYPE / 7-Type           
                    dataGridViewStockHist.Rows.Add(i, dr[0].ToString(), dr[2].ToString(), dr[11].ToString(), DateTime.Parse(dr[4].ToString()).ToShortDateString(), ExpirationDate, dr[5].ToString(), dr[6].ToString(), dr[7].ToString());
                    //dataGridViewStockHist.DefaultCellStyle.Font = new Font("Tahoma", 12);
                }
                dr.Close();
                cn.Close();
                //NonPerishHistory();
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
                    cm = new SqlCommand("DELETE FROM tblStock WHERE num LIKE '" + dataGridViewStockItems.Rows[e.RowIndex].Cells[11].Value.ToString() + "'", cn);
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
                    frm.lblID.Text = dataGridViewStockItems.Rows[e.RowIndex].Cells[11].Value.ToString();
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
                    LoadHistory();
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
                            cm = new SqlCommand("SELECT Expiration_Date FROM tblStock WHERE num LIKE '" + dataGridViewStockItems.Rows[i].Cells[11].Value?.ToString() + "' ", cn);
                            dr = cm.ExecuteReader();
                            dr.Read();
                            //Nullable<DateTime> check = DateTime.TryParse(dr[0].ToString(), out DateTime empty) ? empty : null;
                            // DateTime.Parse(dataGridViewStockItems.Rows[i].Cells[9].Value?.ToString()).ToShortDateString();
                            // lblCheck.Text = check;
                            check = dr[0].ToString();
                            cn.Close();
                            if (string.IsNullOrEmpty(check))
                            {
                                cn.Open();
                                cm = new SqlCommand("UPDATE tblStock SET Expiration_Date = null, Quantity = " + int.Parse(dataGridViewStockItems.Rows[i].Cells[5].Value?.ToString()) + ", Status = 'Done' WHERE num LIKE '" + dataGridViewStockItems.Rows[i].Cells[11].Value?.ToString() + "' ", cn);
                                cm.ExecuteNonQuery();
                                cn.Close();

                            }
                            else
                            {
                                cn.Open();
                                cm = new SqlCommand("UPDATE tblStock SET Expiration_Date = '" + DateTime.Parse(dataGridViewStockItems.Rows[i].Cells[6].Value?.ToString()).ToShortDateString() + "', Quantity = " + int.Parse(dataGridViewStockItems.Rows[i].Cells[5].Value?.ToString()) + ", Status = 'Done' WHERE num LIKE '" + dataGridViewStockItems.Rows[i].Cells[11].Value?.ToString() + "' ", cn);
                                cm.ExecuteNonQuery();
                                cn.Close();

                            }

                            cn.Open();
                            cm = new SqlCommand("UPDATE tblItem SET Quantity = Quantity + " + int.Parse(dataGridViewStockItems.Rows[i].Cells[5].Value?.ToString()) + " WHERE Item_ID LIKE '" + dataGridViewStockItems.Rows[i].Cells[9].Value?.ToString() + "' ", cn);
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

