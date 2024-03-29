﻿using System;
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
    public partial class frmExpiration : Form
    {
        SQLiteConnection cn = new SQLiteConnection();
        SQLiteCommand cm = new SQLiteCommand();
        DBConnection dbcon = new DBConnection();
        SQLiteDataReader dr;
        ClassComputations classCompute = new ClassComputations();
        ClassLoadData classLoadData = new ClassLoadData();
        ClassInventory classInventory = new ClassInventory();
        string title = "BICO-JOSE System";
        frmBrowseItem frmB;
        int r;
        private bool mouseDown;
        private Point lastLocation;

        public frmExpiration(frmBrowseItem frmAdd)
        {
            InitializeComponent();
            cn = new SQLiteConnection(dbcon.MyConnection);
            frmB = frmAdd;

            
        }
      
        private void btnClose_Click(object sender, EventArgs e)
        {
            try
            {
                cn.Open();
                cm = new SQLiteCommand("DELETE FROM tblBrowseExp", cn);
                cm.ExecuteNonQuery();
                cn.Close();
                this.Close();
            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        
        private void dataGridViewExpDate_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //string colName = dataGridViewExpDate.Columns[e.ColumnIndex].Name;
            //string id = dataGridViewExpDate[4, e.RowIndex].Value.ToString(); //num = Stock

            //int i = 0;
            //string num = dataGridViewExpDate[0, e.RowIndex].Value.ToString();
            //if (colName == "Select")
            //{
            //    try
            //    {

            //        cn.Open();
            //        cm = new SqlCommand("INSERT INTO tblBrowseExp (num, Expiration_Date, Quantity, Price) VALUES(@num, @Expiration_Date, @Quantity, @Price)", cn);
            //        cm.Parameters.AddWithValue("@num", int.Parse(id.ToString()));
            //        cm.Parameters.AddWithValue("@Expiration_Date", DateTime.Parse(dataGridViewExpDate[1, e.RowIndex].Value.ToString()).ToShortDateString());
            //        cm.Parameters.AddWithValue("@Quantity", int.Parse(dataGridViewExpDate[2, e.RowIndex].Value.ToString()));
            //        cm.Parameters.AddWithValue("@Price", double.Parse(lblPrice.Text));
            //        cm.ExecuteNonQuery();
            //        dataGridViewExpDate.Rows.RemoveAt(dataGridViewExpDate.CurrentRow.Index);

            //        cn.Close();



            //        cn.Open();
            //        cm = new SqlCommand("SELECT * FROM tblBrowseExp WHERE num LIKE '" + id.ToString() + "' ", cn);
            //        dr = cm.ExecuteReader();
            //        while (dr.Read())
            //        {
            //            i += 1;
            //            dataGridViewSelected.Rows.Add(i, DateTime.Parse(dr[1].ToString()).ToShortDateString(), dr[2].ToString(), '0', Properties.Resources._Add, Properties.Resources._Delete, dr[0].ToString());

            //        }
            //        dr.Close();
            //        cn.Close();
            //    }
            //    catch (Exception ex)
            //    {
            //        cn.Close();
            //        MessageBox.Show(ex.Message, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    }


            //}

        }
        public void addExpItemToCart(int unitStockNum, string ItmID, string TransNo, int unitQuant, double unitPrice, string lenseCheck, double unitTotal, string Unit_Measure)
        {
            string displayPrice = unitPrice.ToString("#,##0.00");
            string displayTotal = unitTotal.ToString("#,##0.00");
            cn.Open();
            cm = new SQLiteCommand("INSERT INTO tblCart (Stock_Num, Item_ID, Transaction_No, Quantity, Price, Total, Date, Status, Lense_Check, Display_Total, Display_Price, Unit_Measure) VALUES (@Stock_Num, @Item_ID, @TransactionNo, @Quantity, @Price, @Total, @Date, 'Cart', @Lense_Check, @Display_Total, @Display_Price, @Unit_Measure)", cn);
            cm.Parameters.AddWithValue("@Stock_Num", unitStockNum);//unitStockNum
            cm.Parameters.AddWithValue("@Item_ID", ItmID);//ItmID = lblItemIDPass.Text
            cm.Parameters.AddWithValue("@TransactionNo", TransNo);// frmB.lblTrans.Text
            cm.Parameters.AddWithValue("@Quantity", unitQuant);//quantItem
            cm.Parameters.AddWithValue("@Price", unitPrice);//unitPrice =lblPrice.Text
            cm.Parameters.AddWithValue("@Lense_Check", lenseCheck);
            cm.Parameters.AddWithValue("@Date", DateTime.Now.ToShortDateString());
            cm.Parameters.AddWithValue("@Total", unitTotal); //unitTotal
            cm.Parameters.AddWithValue("@Unit_Measure", Unit_Measure); //unitTotal
            cm.Parameters.AddWithValue("@Display_Total", displayTotal);
            cm.Parameters.AddWithValue("@Display_Price", displayPrice);
            cm.ExecuteNonQuery();
            cn.Close();           
        }
        public void autoSelectExp()
        {
            if(dataGridViewExpDate.Rows.Count > 0)
            {
                if(txtQuantity.Text != "" && txtQuantity.Text != "0")
                {
                    double unitPrice = double.Parse(lblPrice2.Text);
                    int quantInput = int.Parse(txtQuantity.Text);
                    int unitStockNum = int.Parse(dataGridViewExpDate[4, 0].Value?.ToString());
                    int unitQuantItem = int.Parse(dataGridViewExpDate[2, 0].Value?.ToString());
                    string ItmID = lblItemIDPass.Text;
                    string Umeas = lblUnitMea.Text;
                    string TransNo = frmB.lblTrans.Text;
                    string lenseCheck = lblLenseCheck.Text;
                    double unitTotal = 0;// quantInput * unitPrice;
                    string toStringUnitTotal = "";
                    bool hasRemaining = false;
                    int lacking = quantInput - unitQuantItem;
                    if (quantInput > unitQuantItem)
                    {
                        hasRemaining = false;
                        unitTotal = unitQuantItem * unitPrice;
                        toStringUnitTotal = unitTotal.ToString("00.00"); unitTotal = double.Parse(toStringUnitTotal);
                        //double unitTotal = quantInput * unitPrice;
                        addExpItemToCart(unitStockNum, ItmID, TransNo, unitQuantItem, unitPrice, lenseCheck, unitTotal, Umeas);//checked
                        reducedQuantityTblStock(unitStockNum, unitQuantItem);//checked
                        updateTblStock(unitStockNum, lacking, hasRemaining);  //checked
                        updateTblStockInvent(unitStockNum);
                        int row = 1;
                        while (lacking > 0)
                        {                           
                            unitStockNum = int.Parse(dataGridViewExpDate[4, row].Value?.ToString());
                            unitQuantItem = int.Parse(dataGridViewExpDate[2, row].Value?.ToString());
                            if (lacking < unitQuantItem)
                            {
                                
                                unitTotal = lacking * unitPrice;
                                toStringUnitTotal = unitTotal.ToString("00.00"); unitTotal = double.Parse(toStringUnitTotal);
                                addExpItemToCart(unitStockNum, ItmID, TransNo, lacking, unitPrice, lenseCheck, unitTotal, Umeas);
                                reducedQuantityTblStock(unitStockNum, lacking);
                                lacking = unitQuantItem - lacking;
                                if (lacking <= 0)
                                {
                                    hasRemaining = false;
                                    updateTblStock(unitStockNum, lacking, hasRemaining);
                                }
                                else if (lacking > 0)
                                {
                                    hasRemaining = true;
                                    updateTblStock(unitStockNum, lacking, hasRemaining);
                                }
                                lacking = lacking - unitQuantItem;

                                if (lacking <= 0)
                                {
                                    updateTblStockInvent(unitStockNum);
                                }
                                break;
                            }
                            else if (lacking >= unitQuantItem)
                            {
                                lacking = lacking - unitQuantItem;
                                unitTotal = unitQuantItem * unitPrice;
                                toStringUnitTotal = unitTotal.ToString("00.00"); unitTotal = double.Parse(toStringUnitTotal);
                                addExpItemToCart(unitStockNum, ItmID, TransNo, unitQuantItem, unitPrice, lenseCheck, unitTotal, Umeas);
                                reducedQuantityTblStock(unitStockNum, unitQuantItem);
                                updateTblStockInvent(unitStockNum); hasRemaining = false;
                                updateTblStock(unitStockNum, lacking, hasRemaining);                                                                
                            }
                            row++;
                        }                        
                    }
                    else if (quantInput < unitQuantItem)
                    {
                        //lacking = unitQuantItem - quantInput;
                        lacking = quantInput - unitQuantItem;
                        unitTotal = unitQuantItem * unitPrice;
                        toStringUnitTotal = unitTotal.ToString("00.00"); unitTotal = double.Parse(toStringUnitTotal);
                        //int remaining = unitQuantItem - quantInput;
                        //unitTotal = quantInput * unitPrice;
                        addExpItemToCart(unitStockNum, ItmID, TransNo, quantInput, unitPrice, lenseCheck, unitTotal, Umeas);
                        reducedQuantityTblStock(unitStockNum, quantInput);
                        if (lacking == 0)
                        {
                            updateTblStockInvent(unitStockNum);
                        }
                    }// quantInput
                    reducedQuantity(ItmID, quantInput);//checked
                    classInventory.determineStockLevel(ItmID);//checked

                    frmB.LoadCart();    

                }
            }
        }

        private void dataGridViewSelected_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string colName = dataGridViewSelected.Columns[e.ColumnIndex].Name;
                string id = dataGridViewSelected[6, e.RowIndex].Value.ToString(); //num = Stock
                int i = 0;
                if (colName == "Delete")
                {


                    dataGridViewSelected.Rows.RemoveAt(dataGridViewSelected.CurrentRow.Index);

                    cn.Open();
                    cm = new SQLiteCommand("SELECT * FROM tblBrowseExp WHERE num LIKE '" + id.ToString() + "' ", cn);
                    dr = cm.ExecuteReader();
                    while (dr.Read())
                    {
                        i += 1;
                        dataGridViewExpDate.Rows.Add(i, DateTime.Parse(dr[1].ToString()).ToShortDateString(), dr[2].ToString(), Properties.Resources.AddNew, dr[0].ToString());

                    }
                    dr.Close();
                    cn.Close();


                    if (dataGridViewSelected.Rows.Count == 0)
                    {
                        cn.Open();
                        cm = new SQLiteCommand("DELETE FROM tblBrowseExp", cn);
                        cm.ExecuteNonQuery();
                        cn.Close();
                    }
                }
                else if (colName == "plus")
                {

                    dataGridViewSelected.Rows[e.RowIndex].Cells["Qty"].ReadOnly = false;
                    dataGridViewSelected.CurrentCell = dataGridViewSelected.Rows[e.RowIndex].Cells["Qty"];
                    lblInitialStock.Text = dataGridViewSelected.Rows[e.RowIndex].Cells[2].Value?.ToString();
                    
                    dataGridViewSelected.BeginEdit(true);

                    //int stocks = int.Parse(dataGridViewSelected[2, e.RowIndex].Value.ToString());
                    //if ((int.Parse(dataGridViewSelected[2, e.RowIndex].Value.ToString()) < 1) || ((int.Parse(dataGridViewSelected[2, e.RowIndex].Value.ToString()) > stocks)))
                    //{
                    //    dataGridViewSelected[2, e.RowIndex].Value = stocks.ToString();
                    //}
                }
            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

 
        private void lblName_Click(object sender, EventArgs e)
        {

        }
        
        private void dataGridViewSelected_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            
            


        }

        private void dataGridViewSelected_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {

            //int i = dataGridViewSelected.CurrentRow.Index;
            //int i = dataGridViewSelected.SelectedRows[0].Index;
            //float price = float.Parse(lblPrice.Text);
            //int qty = int.Parse(dataGridViewSelected[2, e.RowIndex].Value.ToString());
            //float total = float.Parse(price.ToString()) * int.Parse(qty.ToString());
            //dataGridViewSelected[3, e.RowIndex].Value = total.ToString("0.00");
            //dataGridViewSelected.Rows[e.RowIndex].Cells["Qty"].ReadOnly = true;


        }

        private void dataGridViewSelected_RowValidating(object sender, DataGridViewCellCancelEventArgs e)
        {
           
        }

        private void btnSave_Click(object sender, EventArgs e) // Still Temporarilly
        {
            //if (dataGridViewSelected.Rows.Count > 0)
            //{
                
            //    r = dataGridViewSelected.SelectedRows[0].Index;
            //    int y = frmB.dataGridViewBrowse.SelectedRows[0].Index;
            //    string ITID = frmB.lblItemIDCheck.Text;
            //    int CartStockTotal = 0; int CartStock = 0;
            //    int StockNum = 0;
                
            //    if (MessageBox.Show("Are you sure you want to save this record?", title, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            //    {
            //        for (int i = 0; i < dataGridViewSelected.Rows.Count; i++)
            //        {
            //            double Total = double.Parse(dataGridViewSelected.Rows[i].Cells[3].Value.ToString());
            //            string displayTotal = Total.ToString("#,##0.00");
            //            cn.Open();
            //            cm = new SqlCommand("INSERT INTO tblCart (Stock_Num, Item_ID, Transaction_No, Quantity, Price, Total, Date, Status, Lense_Check, Display_Total) VALUES (@Stock_Num, @Item_ID, @TransactionNo, @Quantity, @Price, @Total, @Date, 'Cart', @Lense_Check, @Display_Total)", cn);
            //            cm.Parameters.AddWithValue("@Stock_Num", dataGridViewSelected.Rows[i].Cells[6].Value.ToString());
            //            cm.Parameters.AddWithValue("@Item_ID", frmB.dataGridViewBrowse.Rows[0].Cells[1].Value.ToString());
            //            cm.Parameters.AddWithValue("@TransactionNo", frmB.lblTrans.Text);
            //            cm.Parameters.AddWithValue("@Quantity", dataGridViewSelected.Rows[i].Cells[2].Value.ToString());
            //            cm.Parameters.AddWithValue("@Price", lblPrice.Text);
            //            cm.Parameters.AddWithValue("@Lense_Check", lblLenseCheck.Text);
            //            cm.Parameters.AddWithValue("@Date", DateTime.Now);
            //            cm.Parameters.AddWithValue("@Total", dataGridViewSelected.Rows[i].Cells[3].Value.ToString());
            //            cm.Parameters.AddWithValue("@Display_Total", displayTotal);
            //            cm.ExecuteNonQuery();
            //            cn.Close();
            //            StockNum = int.Parse(dataGridViewSelected.Rows[i].Cells[6].Value.ToString());
            //            CartStockTotal += int.Parse(dataGridViewSelected.Rows[i].Cells[2].Value.ToString());
            //            CartStock = int.Parse(dataGridViewSelected.Rows[i].Cells[2].Value.ToString());
            //            reducedQuantityTblStock(StockNum, CartStock);
            //        }
            //        reducedQuantity(ITID, CartStockTotal);
            //        classInventory.determineStockLevel(ITID);
            //        MessageBox.Show("Successfully Added!", title, MessageBoxButtons.OK, MessageBoxIcon.Information);
            //        frmB.LoadCart();
            //        this.Close();
            //        frmB.Close();
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("Please select from the available item above first", title, MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    return;
            //}
        }

        private void dataGridViewSelected_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            float price = float.Parse(lblPrice.Text);
            int qty = int.Parse(dataGridViewSelected[2, e.RowIndex].Value.ToString());
            int intialStock = int.Parse(lblInitialStock.Text);
            float total = float.Parse(price.ToString()) * int.Parse(qty.ToString());
            //dataGridViewSelected[3, e.RowIndex].Value = total.ToString("#.##");
            //dataGridViewSelected.Rows[e.RowIndex].Cells["Qty"].ReadOnly = true;

            if (qty > intialStock)
            {
                dataGridViewSelected[2, e.RowIndex].Value = intialStock.ToString();
                total = float.Parse(price.ToString()) * int.Parse(qty.ToString());
                dataGridViewSelected[3, e.RowIndex].Value = total.ToString("#.##");
                dataGridViewSelected.BeginEdit(true);

            }
            else
            {
                dataGridViewSelected[3, e.RowIndex].Value =  total.ToString("#.##");
                dataGridViewSelected.Rows[e.RowIndex].Cells["Qty"].ReadOnly = true;
            }
            
        }

        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {
            try
            {
                //r = frmB.dataGridViewBrowse.SelectedRows[0].Index;
                //int Stock = int.Parse(frmB.dataGridViewBrowse[6, r].Value.ToString());
                string Stock = frmB.lblStock.Text;
                //int Stock = int.Parse(frmB.lblStock.Text);
                String txtInput = txtQuantity.Text;
                //int input = int.Parse(txtInput);
                if (txtQuantity.Text == string.Empty)
                {
                    txtQuantity.Focus();
                    txtQuantity.Text = "0";                    
                    txtQuantity.SelectAll();
                }
                else
                {
                    if (Stock.Equals("N/A") || Stock.Equals(""))
                    {
                        int intStock = 0;
                    }
                    else
                    {
                        int intStock = int.Parse(Stock);
                        if (!(txtInput.Equals("")))
                        {
                            int input = int.Parse(txtInput);
                            if ((input < 1) || (input > intStock))
                            {
                                txtQuantity.Text = intStock.ToString();
                                txtQuantity.SelectAll();
                            }
                        }
                    }
                    
                }
                
                classCompute.Compute(txtQuantity, lblPrice2, lblTotal);
            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            //try
            //{
                   string Umeas = lblUnitMea.Text;
                string classfici = lblClasific.Text;
                if (e.KeyChar == 8)
                {
                    //accept backspace
                }
                else if ((e.KeyChar < 48) || (e.KeyChar > 57))
                {
                    //ascii code 48 - 57 = characters between 0 - 9
                    e.Handled = true;
                    classCompute.Compute(txtQuantity, lblPrice2, lblTotal);
                    //Compute();
                }
                string ITID = lblItemIDPass.Text;
                int CartStock = int.Parse(txtQuantity.Text);
                double Total = double.Parse(lblTotal.Text);
                double price = double.Parse(lblPrice2.Text);
                string displayTotal = Total.ToString("#,##0.00");
                string displayPrice = price.ToString("#,##0.00");
                if ((e.KeyChar == 13))//enter
                {
                    if (classfici == "Non-Consumable")
                    {
                        cn.Open();
                        cm = new SQLiteCommand("INSERT INTO tblCart (Stock_Num, Item_ID, Transaction_No, Quantity, Price, Total, Date, Status, Lense_Check, Display_Total, Unit_Measure, Display_Price) VALUES (@Stock_Num, @Item_ID, @TransactionNo, @Quantity, @Price, @Total, @Date, 'Cart', @Lense_Check, @Display_Total, @Unit_Measure, @Display_Price)", cn);
                        //cm.Parameters.AddWithValue("@Stock_ID", frmB.dataGridViewBrowse[1, i].Value.ToString());
                        cm.Parameters.AddWithValue("@Stock_Num", dataGridViewNC[1, 0].Value.ToString());
                        cm.Parameters.AddWithValue("@Item_ID", lblItemIDPass.Text);
                        cm.Parameters.AddWithValue("@TransactionNo", frmB.lblTrans.Text);
                        cm.Parameters.AddWithValue("@Quantity", txtQuantity.Text);
                        cm.Parameters.AddWithValue("@Price", lblPrice2.Text);
                        cm.Parameters.AddWithValue("@Date", DateTime.Now.ToShortDateString());
                        cm.Parameters.AddWithValue("@Total", lblTotal.Text);
                        cm.Parameters.AddWithValue("@Unit_Measure", Umeas);
                        cm.Parameters.AddWithValue("@Display_Total", displayTotal);
                        cm.Parameters.AddWithValue("@Display_Price", displayPrice);
                        cm.Parameters.AddWithValue("@Lense_Check", lblLenseCheck.Text);
                        cm.ExecuteNonQuery();
                        cn.Close();
                        MessageBox.Show("Successfully Added!", title, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        frmB.LoadCart();
                        this.Close();
                        frmB.Close();
                        reducedQuantity(ITID, CartStock);
                        classInventory.determineStockLevel(ITID);
                        
                    }
                    else if(classfici == "Consumable")
                    {
                        autoSelectExp();
                        this.Close();
                        frmB.Close();
                    }
                }                               
                frmB.LoadCart();
            //}
            //catch (Exception ex)
            //{
            //    cn.Close();
            //    MessageBox.Show(ex.Message, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }
        public void updateTblStock(int SNum, int remaining, bool hasRemaining)
        {
            string status = "";
            if (hasRemaining == true)
            {
                status = "Available: Only " + remaining.ToString() + " left";
            }
            else if (hasRemaining == false)
            {
                status = "Purchased";
            }
            cn = new SQLiteConnection(dbcon.MyConnection);
            cn.Open();//Set Quantity
            SQLiteCommand cm = new SQLiteCommand("Update tblStock SET Item_Status = 'Purchased' WHERE Num = " + SNum + "", cn);            
            cm.ExecuteNonQuery();
            cn.Close();
        }
        public void reducedQuantity(string itemID, int CartQty)
        {
            cn = new SQLiteConnection(dbcon.MyConnection);
            cn.Open();//Set Quantity
            SQLiteCommand cm = new SQLiteCommand("UPDATE tblItem SET Quantity = Quantity - @Cart WHERE Stock_Check = 1 AND Item_ID LIKE '" + itemID + "'", cn);
            cm.Parameters.AddWithValue("@Cart", CartQty);
            cm.ExecuteNonQuery();
            cn.Close();

        }
        public void reducedQuantityTblStock(int SNum, int CartQty)
        {
            //string StkID = dataGridViewStockItems.Rows[i].Cells[3].Value?.ToString();
            cn = new SQLiteConnection(dbcon.MyConnection);
            cn.Open();//Set Quantity
            SQLiteCommand cm = new SQLiteCommand("UPDATE tblStockInventory SET Quantity = Quantity - @Cart WHERE Stock_Num = " + SNum + " ", cn);
            cm.Parameters.AddWithValue("@Cart", CartQty);
            cm.ExecuteNonQuery();
            cn.Close();

        }
        public void updateTblStockInvent(int SNum)
        {
            //string StkID = dataGridViewStockItems.Rows[i].Cells[3].Value?.ToString();
            cn = new SQLiteConnection(dbcon.MyConnection);
            cn.Open();//Set Quantity
            SQLiteCommand cm = new SQLiteCommand("UPDATE tblStockInventory SET Status = 'Purchased' WHERE Stock_Num = " + SNum + " ", cn);  
            cm.ExecuteNonQuery();
            cn.Close();
        }
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;

        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }

        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void dataGridViewSelected_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            float price = float.Parse(lblPrice.Text);
            int qty = int.Parse(dataGridViewSelected[2, e.RowIndex].Value.ToString());
            float total = float.Parse(price.ToString()) * int.Parse(qty.ToString());
            dataGridViewSelected[3, e.RowIndex].Value = total.ToString("#.##");
            dataGridViewSelected.Rows[e.RowIndex].Cells["Qty"].ReadOnly = true;
        }
    }
}
