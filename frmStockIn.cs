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
using System.Data.SQLite;
namespace Capstone
{
    public partial class frmStockIn : Form
    {
        SQLiteConnection cn = new SQLiteConnection();
        SQLiteCommand cm = new SQLiteCommand();
        DBConnection dbcon = new DBConnection();
        SQLiteDataReader dr;
        ClassGenerateID classGenerateID = new ClassGenerateID();
        ClassLoadData classLoadData = new ClassLoadData();
        ClassInventory classInventory = new ClassInventory();
        
        string title = "BICO-JOSE System";
        string ID, num = "", pass; int count, count2, rows;
        string check = null;
        //Nullable<DateTime> check = null;
        //Nullable<string> check = null;
        public frmStockIn()
        {
            InitializeComponent();
            cn = new SQLiteConnection(dbcon.MyConnection);
            classLoadData.LoadStock(dataGridViewStockItems, txtStockID, label3);
            classLoadData.LoadStockOnHand(dataGridViewOnHand, txtSearch);
            //LoadStock();
            dataGridViewStockItems.AllowUserToAddRows = false;
            //LoadStockOnHand();
            
        }
        
        public void Clear()
        {
            //txtStockID.Clear();
            //txtStockInBy.Clear();
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
            string classifi = dataGridViewStockItems.Rows[e.RowIndex].Cells[13].Value?.ToString();
            string colName = dataGridViewStockItems.Columns[e.ColumnIndex].Name;
            if (colName == "DeleteStockIn")
            {
                if (MessageBox.Show("Remove this Item?", title, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cn.Open();
                    cm = new SQLiteCommand("DELETE FROM tblStock WHERE num LIKE '" + dataGridViewStockItems.Rows[e.RowIndex].Cells[11].Value.ToString() + "'", cn);
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
                    if(classifi == "Consumable")
                    {
                        frm.btnNonPerishable.Enabled = false;
                        frm.btnPerishable.Enabled = true;
                        frm.lblCheck.Text = "Yes";

                    }
                    else if (classifi == "Non-Consumable")
                    {
                        frm.btnNonPerishable.Enabled = true;
                        frm.btnPerishable.Enabled = false;
                        frm.dateExpiration.Enabled = false;
                        frm.lblCheck.Text = "No";

                    }
                    frm.lblID.Text = dataGridViewStockItems.Rows[e.RowIndex].Cells[11].Value.ToString();
                    frm.txtQuantity.Text = dataGridViewStockItems[5, e.RowIndex].Value.ToString();
                    //classLoadData.LoadUnitMeasure(frm.comBoxUnit);
                    //if (string.IsNullOrEmpty(frm.comBoxUnit.Text))
                    //{
                    //    frm.comBoxUnit.Items.Add("pcs");
                    //}
                    //frm.comBoxUnit.SelectedIndex = 0;
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
                string clasifi = dataGridViewOnHand[5, e.RowIndex].Value.ToString();
                if(clasifi == "Non-Consumable")
                {
                    frm.dataGridViewDetails.Columns["Status"].Visible = false;
                }
                else if (clasifi == "Consumable")
                {
                    frm.dataGridViewDetails.Columns["Status"].Visible = true;
                }


                frm.tabControlStock.TabPages.Clear();
                TabPage tab = new TabPage("Stock History");
                frm.tabControlStock.TabPages.Add(tab);
                tab.Controls.Add(frm.panelStockDetail);
                frm.Size = new Size(1220, 496);                
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
                        cm = new SQLiteCommand("DELETE FROM tblStock WHERE num LIKE '" + dataGridViewStockItems.Rows[i].Cells[11].Value.ToString() + "'", cn);
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
            //classGenerateID.GenerateStockID(txtStockID);
        }
        public void UPDATEtblStockNonConsumable(string dateNow, int i)
        {
            cn.Open();
            cm = new SQLiteCommand("UPDATE tblStock SET Expiration_Date = null, Stock_In_Date = @Date, Item_Status = 'Available', Quantity = " + int.Parse(dataGridViewStockItems.Rows[i].Cells[5].Value?.ToString()) + ", Status = 'Done' WHERE num LIKE '" + dataGridViewStockItems.Rows[i].Cells[11].Value?.ToString() + "' ", cn);
            cm.Parameters.AddWithValue("@Date", dateNow);
            cm.ExecuteNonQuery();
            cn.Close();
        }
        public void UPDATEtblStockConsumable(string dateNow, int i)
        {
            cn.Open();
            cm = new SQLiteCommand("UPDATE tblStock SET Item_Status = 'Available', Stock_In_Date = @Date, Expiration_Date = '" + DateTime.Parse(dataGridViewStockItems.Rows[i].Cells[6].Value?.ToString()).ToShortDateString() + "', Quantity = " + int.Parse(dataGridViewStockItems.Rows[i].Cells[5].Value?.ToString()) + ", Status = 'Done' WHERE num LIKE '" + dataGridViewStockItems.Rows[i].Cells[11].Value?.ToString() + "' ", cn);
            cm.Parameters.AddWithValue("@Date", dateNow);
            cm.ExecuteNonQuery();
            cn.Close();
        }
        public void INSERTtblStockInventory(string StkID, string ITMID, int i)
        {
            cn.Open();
            cm = new SQLiteCommand("INSERT INTO tblStockInventory (Stock_ID, Item_ID, Stock_Num, Quantity, Expiration_Date, Status, Unit_Measure) VALUES(@Stock_ID, @Item_ID, @Stock_Num, @Quantity, @Expiration_Date, 'Available', @Unit_Measure)", cn);
            cm.Parameters.AddWithValue("@Stock_ID", StkID);
            cm.Parameters.AddWithValue("@Stock_Num", dataGridViewStockItems.Rows[i].Cells[11].Value?.ToString());
            cm.Parameters.AddWithValue("@Quantity", int.Parse(dataGridViewStockItems.Rows[i].Cells[5].Value?.ToString()));
            cm.Parameters.AddWithValue("@Expiration_Date", DateTime.Parse(dataGridViewStockItems.Rows[i].Cells[6].Value?.ToString()).ToShortDateString());
            cm.Parameters.AddWithValue("@Item_ID", ITMID);
            cm.Parameters.AddWithValue("@Unit_Measure", dataGridViewStockItems.Rows[i].Cells[12].Value?.ToString());
            cm.ExecuteNonQuery();
            cn.Close();
        }
        public void UPDATEtblItemStockCheck(int i)
        {
            cn.Open();
            cm = new SQLiteCommand("UPDATE tblItem SET Stock_Check = 0 WHERE Item_ID LIKE '" + dataGridViewStockItems.Rows[i].Cells[9].Value?.ToString() + "' ", cn);
            cm.ExecuteNonQuery();
            cn.Close();
        }
        public void UPDATEtbleItem(int baseStk, int i)
        {
            cn.Open();
            cm = new SQLiteCommand("UPDATE tblItem SET Base_Stock = " + baseStk + ", Quantity = Quantity + " + int.Parse(dataGridViewStockItems.Rows[i].Cells[5].Value?.ToString()) + " WHERE Item_ID LIKE '" + dataGridViewStockItems.Rows[i].Cells[9].Value?.ToString() + "' ", cn);
            cm.Parameters.AddWithValue("@BaseStock", baseStk);
            cm.ExecuteNonQuery();
            cn.Close();
        }
        private void btnSaveStockIn_Click(object sender, EventArgs e)
        {
            frmAdmin frm = new frmAdmin();
            string dateNow = DateTime.Now.ToString();
           
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
                            //cn.Open();
                            //cm = new SQLiteCommand("UPDATE tblItem SET Stock_Check = 0 WHERE Item_ID LIKE '" + dataGridViewStockItems.Rows[i].Cells[9].Value?.ToString() + "' ", cn);
                            //cm.ExecuteNonQuery();
                            //cn.Close();
                            UPDATEtblItemStockCheck(i);
                        }
                        int baseStk;
                        string ITMID = dataGridViewStockItems.Rows[i].Cells[9].Value?.ToString(); //label3.Text = ITMID;

                        int newStock = int.Parse(dataGridViewStockItems.Rows[i].Cells[5].Value?.ToString());
                        classInventory.determineBaseStock(newStock, out baseStk, ITMID);
                        //cn.Open();
                        //cm = new SQLiteCommand("UPDATE tblItem SET Base_Stock = " + baseStk + ", Quantity = Quantity + " + int.Parse(dataGridViewStockItems.Rows[i].Cells[5].Value?.ToString()) + " WHERE Item_ID LIKE '" + dataGridViewStockItems.Rows[i].Cells[9].Value?.ToString() + "' ", cn);
                        //cm.Parameters.AddWithValue("@BaseStock", baseStk);
                        //cm.ExecuteNonQuery();
                        //cn.Close();
                        UPDATEtbleItem(baseStk, i);
                        classInventory.determineStockLevel(ITMID);
                        try
                        {
                            string StkID = dataGridViewStockItems.Rows[i].Cells[3].Value?.ToString();
                            cn.Open();
                            cm = new SQLiteCommand("SELECT Expiration_Date FROM tblStock WHERE num LIKE '" + dataGridViewStockItems.Rows[i].Cells[11].Value?.ToString() + "' ", cn);
                            dr = cm.ExecuteReader();
                            dr.Read();
                            //Nullable<DateTime> check = DateTime.TryParse(dr[0].ToString(), out DateTime empty) ? empty : null;
                            // DateTime.Parse(dataGridViewStockItems.Rows[i].Cells[9].Value?.ToString()).ToShortDateString();
                            // lblCheck.Text = check;
                            check = dr[0].ToString();
                            dr.Close();
                            cn.Close();
                            //SQLiteDatabase.setLockingEnabled(false);
                            if (string.IsNullOrEmpty(check))
                            {
                                //cn.Open();
                                //cm = new SQLiteCommand("UPDATE tblStock SET Expiration_Date = null, Stock_In_Date = @Date, Item_Status = 'Available', Quantity = " + int.Parse(dataGridViewStockItems.Rows[i].Cells[5].Value?.ToString()) + ", Status = 'Done' WHERE num LIKE '" + dataGridViewStockItems.Rows[i].Cells[11].Value?.ToString() + "' ", cn);
                                //cm.Parameters.AddWithValue("@Date", dateNow);
                                //cm.ExecuteNonQuery();
                                //cn.Close();
                                UPDATEtblStockNonConsumable(dateNow, i);
                            }
                            else
                            {
                                //cn.Open();
                                //cm = new SQLiteCommand("UPDATE tblStock SET Item_Status = 'Available', Stock_In_Date = @Date, Expiration_Date = '" + DateTime.Parse(dataGridViewStockItems.Rows[i].Cells[6].Value?.ToString()).ToShortDateString() + "', Quantity = " + int.Parse(dataGridViewStockItems.Rows[i].Cells[5].Value?.ToString()) + ", Status = 'Done' WHERE num LIKE '" + dataGridViewStockItems.Rows[i].Cells[11].Value?.ToString() + "' ", cn);
                                //cm.Parameters.AddWithValue("@Date", dateNow);
                                //cm.ExecuteNonQuery();
                                //cn.Close();
                                UPDATEtblStockConsumable(dateNow, i);
                                //cn.Open();
                                ////cm = new SQLiteCommand ("UPDATE tblStockInventory SET Stock_Num = '" + dataGridViewStockItems.Rows[i].Cells[11].Value?.ToString() + "', Expiration_Date = '" + DateTime.Parse(dataGridViewStockItems.Rows[i].Cells[6].Value?.ToString()).ToShortDateString() + "', Quantity = " + int.Parse(dataGridViewStockItems.Rows[i].Cells[5].Value?.ToString()) + " WHERE Item_ID LIKE '" + ITMID + "' AND Stock_ID LIKE '" + StkID + "'", cn);
                                //cm = new SqlCommand("UPDATE tblStockInventory SET Quantity = " + int.Parse(dataGridViewStockItems.Rows[i].Cells[5].Value?.ToString()) + ", Expiration_Date = '" + DateTime.Parse(dataGridViewStockItems.Rows[i].Cells[6].Value?.ToString()).ToShortDateString() + "', Stock_ID = '"+StkID+ "', Item_ID = '" + ITMID + "' WHERE Stock_Num LIKE '" + dataGridViewStockItems.Rows[i].Cells[11].Value?.ToString() + "'", cn);
                                ////cm.Parameters.AddWithValue("@Stock_ID", frmList.txtStockID.Text);
                                ////, Unit_Measure = '"+ dataGridViewStockItems.Rows[i].Cells[11].Value?.ToString() + "'
                                //cm.ExecuteNonQuery();
                                //cn.Close();

                                //cn.Open();
                                //cm = new SQLiteCommand("INSERT INTO tblStockInventory (Stock_ID, Item_ID, Stock_Num, Quantity, Expiration_Date, Status, Unit_Measure) VALUES(@Stock_ID, @Item_ID, @Stock_Num, @Quantity, @Expiration_Date, 'Available', @Unit_Measure)", cn);
                                //cm.Parameters.AddWithValue("@Stock_ID", StkID);
                                //cm.Parameters.AddWithValue("@Stock_Num", dataGridViewStockItems.Rows[i].Cells[11].Value?.ToString());
                                //cm.Parameters.AddWithValue("@Quantity", int.Parse(dataGridViewStockItems.Rows[i].Cells[5].Value?.ToString()));
                                //cm.Parameters.AddWithValue("@Expiration_Date", DateTime.Parse(dataGridViewStockItems.Rows[i].Cells[6].Value?.ToString()).ToShortDateString());
                                //cm.Parameters.AddWithValue("@Item_ID", ITMID);
                                //cm.Parameters.AddWithValue("@Unit_Measure", dataGridViewStockItems.Rows[i].Cells[12].Value?.ToString());
                                //cm.ExecuteNonQuery();
                                //cn.Close();
                                INSERTtblStockInventory(StkID, ITMID, i);
                            }

                        }
                        catch (Exception ex)
                        {
                            dr.Close();
                            cn.Close();
                            MessageBox.Show(ex.Message, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }                        
                    }
                    classGenerateID.GenerateStockID(txtStockID);
                    classLoadData.LoadStock(dataGridViewStockItems, txtStockID, label3);
                    classLoadData.LoadStockOnHand(dataGridViewOnHand, txtSearch);
                    //LoadStock();
                    Clear();
                }                
            }
            //txtStockInBy.Text = frm.lblName.Text;
        }

        private void dataGridViewStockItems_SelectionChanged(object sender, EventArgs e)
        { 
        }
             
    }
}

