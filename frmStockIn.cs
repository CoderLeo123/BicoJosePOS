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
        ClassGenerateID classGenerateID = new ClassGenerateID();
        ClassLoadData classLoadData = new ClassLoadData();
        string title = "BICO-JOSE System";
        string ID, num = "", pass; int count, count2, rows;
        string check = null;
        //Nullable<DateTime> check = null;
        //Nullable<string> check = null;
        public frmStockIn()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
            classLoadData.LoadStock(dataGridViewStockItems, txtStockID, label3);
            classLoadData.LoadStockOnHand(dataGridViewOnHand, txtSearch);
            //LoadStock();
            dataGridViewStockItems.AllowUserToAddRows = false;
            //LoadStockOnHand();
            
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
                    classLoadData.LoadStock(dataGridViewStockItems, txtStockID, label3);
                    //LoadStock();
                    
                }

            }
            else if (colName == "EDIT")
            {
                try
                {
                    frmEditStock frm = new frmEditStock(this);
                    
                    frm.tabControlStock.TabPages.Clear();
                    TabPage tab = new TabPage("Edit Stock");
                    frm.tabControlStock.TabPages.Add(tab);
                    tab.Controls.Add(frm.panelEditStock);
                    frm.lblID.Text = dataGridViewStockItems.Rows[e.RowIndex].Cells[11].Value.ToString();
                    frm.txtQuantity.Text = dataGridViewStockItems[5, e.RowIndex].Value.ToString();
                    classLoadData.LoadUnitMeasure(frm.comBoxUnit);
                    frm.comBoxUnit.SelectedIndex = 0;
                    //frm.LoadUnitMeasure();
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
            //LoadHistory();
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
                    classLoadData.LoadStockOnHand(dataGridViewOnHand, txtSearch);
                    //LoadStockOnHand();
                }
            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridViewOnHand_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void dataGridViewOnHand_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                frmEditStock frm = new frmEditStock(this);
                frm.tabControlStock.TabPages.Clear();
                TabPage tab = new TabPage("Stock Details");
                frm.tabControlStock.TabPages.Add(tab);
                tab.Controls.Add(frm.panelStockDetail);
                frm.Size = new Size(920, 496);
                

                frm.labelItemID.Text = dataGridViewOnHand[1, e.RowIndex].Value.ToString();
                frm.labelItemName.Text = dataGridViewOnHand[2, e.RowIndex].Value.ToString();
                classLoadData.LoadRecordsStockDetail(frm.dataGridViewDetails, frm.labelItemID);
                //frm.LoadRecordsStockDetail();
                
                frm.ShowDialog(this);
            }

            
        }

        private void dataGridViewOnHand_SelectionChanged(object sender, EventArgs e)
        {
            
        }

        private void btnClearStock_Click(object sender, EventArgs e)
        {
            if (dataGridViewStockItems.Rows.Count > 0)
            {
                if (MessageBox.Show("Remove these records?", title, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    for (int i = 0; i < dataGridViewStockItems.Rows.Count; i++)
                    {
                        cn.Open();
                        cm = new SqlCommand("DELETE FROM tblStock WHERE num LIKE '" + dataGridViewStockItems.Rows[i].Cells[11].Value.ToString() + "'", cn);
                        cm.ExecuteNonQuery();
                        cn.Close();
                    }
                    classLoadData.LoadStock(dataGridViewStockItems, txtStockID, label3);
                    classLoadData.LoadStockOnHand(dataGridViewOnHand, txtSearch);
                }
            }
        }

        private void dataGridViewStockItems_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            
        }
        
        
        private void GenerateStockID_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            classGenerateID.GenerateStockID(txtStockID);
        }

        private void btnSaveStockIn_Click(object sender, EventArgs e)
        {
            
            if (dataGridViewStockItems.Rows.Count > 0)
            {
                    if (MessageBox.Show("Are you sure you want to save this records?", title, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                    
                    for (int i = 0; i < dataGridViewStockItems.Rows.Count; i++)
                    {
                        //string type = dataGridViewStockItems[10, i].Value.ToString();
                        string type = dataGridViewStockItems.Rows[i].Cells[10].Value?.ToString();
                        bool isVisionType = false;
                        //Double Vision Single Vision Progressive Vision
                        //string cut = type.Substring(type.IndexOf('V'), 6); //Vision
                        try { string cut = type.Substring(type.IndexOf('V'), 6); isVisionType = true; } catch (Exception) { isVisionType = false; }
                        if (isVisionType == true)
                        {
                            cn.Open();
                            cm = new SqlCommand("UPDATE tblItem SET Stock_Check = 0 WHERE Item_ID LIKE '" + dataGridViewStockItems.Rows[i].Cells[9].Value?.ToString() + "' ", cn);
                            cm.ExecuteNonQuery();
                            cn.Close();
                        }
                        cn.Open();
                        cm = new SqlCommand("UPDATE tblItem SET Quantity = Quantity + " + int.Parse(dataGridViewStockItems.Rows[i].Cells[5].Value?.ToString()) + " WHERE Item_ID LIKE '" + dataGridViewStockItems.Rows[i].Cells[9].Value?.ToString() + "' ", cn);
                        cm.ExecuteNonQuery();
                        cn.Close();
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

                        }
                        catch (Exception ex)
                        {
                            cn.Close();
                            MessageBox.Show(ex.Message, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        
                    }
                    classLoadData.LoadStock(dataGridViewStockItems, txtStockID, label3);
                    classLoadData.LoadStockOnHand(dataGridViewOnHand, txtSearch);
                    //LoadStock();
                    Clear();
                }
                
            }
            
        }

        private void dataGridViewStockItems_SelectionChanged(object sender, EventArgs e)
        { 
        }
             
    }
}

