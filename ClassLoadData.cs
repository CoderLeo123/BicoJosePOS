﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Data;
namespace Capstone
{
    internal class ClassLoadData : ClassComputations
    {

        SQLiteConnection cn = new SQLiteConnection();
        //SQLiteCommand  cm = new SQLiteCommand ();
        DBConnection dbcon = new DBConnection();
        SQLiteDataReader dr;
        ClassComputations classCompute = new ClassComputations();
        string title = "BICO-JOSE System";

        //frmProductsList frmList = new frmProductsList();

        public void LoadRecordsPatient(DataGridView dgv, TextBox txtSearch)
        {//dataGridViewProduct, txtSearchProduct
            cn = new SQLiteConnection(dbcon.MyConnection);
            int i = 0;
            dgv.Rows.Clear();
            cn.Open();
            SQLiteCommand cm = new SQLiteCommand("SELECT * FROM tblPatientRecord WHERE Customer_Name LIKE '%" + txtSearch.Text + "%' Order by Patient_ID DESC", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            { 
                        //                     2-PATIENT NAME / 2-Customer_Name       4-CONTACT / 4-Contact             6-GENDER / 6-Gender 
                i += 1; //0-#  1-PATIENT ID / 1-Patient_ID         3-ADDRESS / 3-Address                 5-AGE / 5-Age                   7-CHECK-UP DATE / 7-Check_Up_Date 
                dgv.Rows.Add(i, dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString(), dr[6].ToString(), DateTime.Parse(dr[7].ToString()).ToShortDateString(), dr[9].ToString(), dr[12].ToString(), dr[13].ToString(), DateTime.Parse(dr[10].ToString()).ToShortDateString());
            }
            dr.Close();
            cn.Close();
        }

        public void LoadRecordsPrescription(DataGridView dgv, TextBox txtSearch)
        {//dataGridViewProduct, txtSearchProduct
            cn = new SQLiteConnection(dbcon.MyConnection);
            int i = 0;
            dgv.Rows.Clear();
            cn.Open();
            SQLiteCommand cm = new SQLiteCommand("SELECT * FROM tblPrescription WHERE Product LIKE '%" + txtSearch.Text + "%' Order by Patient_ID", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                //                     2-PATIENT NAME / 2-Customer_Name       4-CONTACT / 4-Contact             6-GENDER / 6-Gender 
                i += 1; //0-#  1-PATIENT ID / 1-Patient_ID         3-ADDRESS / 3-Address                 5-AGE / 5-Age                   7-CHECK-UP DATE / 7-Check_Up_Date 
                dgv.Rows.Add(i, dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString(), dr[6].ToString(), dr[7].ToString());
            }
            dr.Close();
            cn.Close();
        }

        public void LoadRecordsProduct(DataGridView dgv, TextBox txtSearch)
        {//dataGridViewProduct, txtSearchProduct
            cn = new SQLiteConnection(dbcon.MyConnection);
            int i = 0;
            dgv.Rows.Clear();
            cn.Open();
            SQLiteCommand cm = new SQLiteCommand("SELECT * FROM tblProduct WHERE Product LIKE '%" + txtSearch.Text + "%' Order by Product_ID", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {                             //                     3-PRODUCT / 3-Product              
                i += 1;                   //0-#  1-PRODUCT ID / 1-Product_ID       
                dgv.Rows.Add(i, dr[1].ToString(), dr[2].ToString());
            }
            dr.Close();
            cn.Close();
        }

        public void LoadRecordsType(DataGridView dgv, TextBox txtSearch)
        {// dataGridViewType, txtSearchTypeProducts
            cn = new SQLiteConnection(dbcon.MyConnection);
            int i = 0;
            dgv.Rows.Clear();
            cn.Open(); //JoinProductType
            SQLiteCommand cm = new SQLiteCommand("SELECT * FROM ViewProductType WHERE Type LIKE '%" + txtSearch.Text + "%' OR Product LIKE '%" + txtSearch.Text + "%' Order by Type_ID", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {                             //                       2-TYPE / 2-Type              4-PRODUCT / 3-Product         
                i += 1;                   //0-#  1-TYPE ID / 1-Type_ID          3-PRODUCT ID / 0-Product_ID                  
                dgv.Rows.Add(i, dr[1].ToString(), dr[2].ToString(), dr[0].ToString(), dr[3].ToString());
            }
            dr.Close();
            cn.Close();
        }

        public string selectLenseID(string table, string column, string columnCondition, string returnValue)
        {//SELECT Type_ID from tblType WHERE Type LIKE '%Lense%'
            cn = new SQLiteConnection(dbcon.MyConnection);
            cn.Open();
            SQLiteCommand cm = new SQLiteCommand("SELECT " + column + " FROM " + table + " WHERE " + columnCondition + " LIKE '%Lense%'", cn);
            dr = cm.ExecuteReader();
            dr.Read();
            if (dr.HasRows)
            {
                return returnValue = dr[0].ToString();                
            }
            else
            {                
                return returnValue = "N/A";
                
            }
            //return returnValue = "N/A";
            dr.Close();
            cn.Close();
            
        }

        public void updateLenseCheck(string table, string columnToUpdate, string columnCondition)
        {//UPDATE tblItem SET Lense_Check WHERE Type LIKE variable(Type_ID of "Lense Features")
            cn = new SQLiteConnection(dbcon.MyConnection);
            //string lenseID = "";
            //lenseID = selectLenseID("tblType", "Type_ID", "Type", lenseID);
            //if (!(lenseID.Equals("N/A")))
            //{
                //cn.Close();
                cn.Open();
            SQLiteCommand cm = new SQLiteCommand("UPDATE " + table + " SET " + columnToUpdate + " = 0 WHERE " + columnCondition + " LIKE '%Vision%'", cn);
                cm.ExecuteNonQuery();
                cn.Close();
            //}
            //else
            //{
                
            //    string msg = "The update query must not run";
            //}           
        }
        public void addPesoSign(string price, out string result)
        {
            int length = price.Length;
            result = price;
           
            if (length <= 4)
            {
                result = "₱" + "    " + price;
            }
            else if (length == 5)
            {
                result = "₱" + "   " + price;
            }
            else if (length == 6)
            {
                result = "₱" + " " + price;
            }
            else if (length >= 7)
            {
                result = "₱" + price;
            }
        }
        public void LoadRecordsItem(DataGridView dgv, TextBox txtSearch)
        {//dataGridViewItems, txtSearch
            
            updateLenseCheck("tblItem", "Lense_Check", "Type");
            cn = new SQLiteConnection(dbcon.MyConnection);
            int i = 0;
            dgv.Rows.Clear();
            cn.Open();//ViewItemProductType
            SQLiteCommand cm = new SQLiteCommand("SELECT * FROM ViewItemProductType WHERE Description LIKE '%" + txtSearch.Text + "%' OR Type LIKE '%" + txtSearch.Text + "%' Order by Item_ID DESC", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {

                string Quantity = dr[5].ToString();//Quantity
                string LenseCheck = dr[8].ToString();//Lense_Check
                string displayPrice = dr[11].ToString();
                addPesoSign(displayPrice, out displayPrice);

                if (LenseCheck.Equals("0"))
                {
                    Quantity = "N/A";
                }
                else
                {
                    Quantity = dr[5].ToString();
                }

                         //     2-DESCRIPTION / 1-Description       4-PRODUCT / 3-Product                  5-QUANTITY / 5-Quantity                          7-TYPE ID / 5-Type_ID
                i += 1;   // 0-#                  3-TYPE / 2-Type                     5-PRICE / 4-Price                   7-CLASSIFICATION / 6-Classification
                dgv.Rows.Add(i, dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), displayPrice, Quantity, dr[6].ToString(), dr[10].ToString(), dr[4].ToString(), dr[0].ToString(), Properties.Resources.Edit, Properties.Resources._Delete);
            }
            dr.Close();
            cn.Close();
        }

        public void LoadRecordsService(DataGridView dgv, TextBox txtSearch)
        {//dataGridViewService, txtSearchService
            cn = new SQLiteConnection(dbcon.MyConnection);
            int i = 0;
            dgv.Rows.Clear();
            cn.Open();
            SQLiteCommand cm = new SQLiteCommand("SELECT * FROM tblServices WHERE Name LIKE '%" + txtSearch.Text + "%' OR Description LIKE '%" + txtSearch.Text + "%' Order by Service_ID", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                string displayPrice = dr[5].ToString();
                addPesoSign(displayPrice, out displayPrice);
                //                                  2-NAME / 2-Name                   4-PRICE / 4-Price
                i += 1;                //0-#  1-SERVICE ID / 1-Service_ID       3-DESCRIPTION / 3-Description
                dgv.Rows.Add(i, dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), displayPrice, dr[4].ToString());
            }
            dr.Close();
            cn.Close();
        }

        public void LoadStockOnHand(DataGridView dgv, TextBox textSearch)
        {//dataGridViewOnHand, txtSearch
            try
            {
                cn = new SQLiteConnection(dbcon.MyConnection);
                int i = 0;
                dgv.Rows.Clear();
                cn.Open();
                SQLiteCommand cm = new SQLiteCommand("SELECT * from ViewItemProductType WHERE (Description LIKE '%" + textSearch.Text + "%' OR Type LIKE '%" + textSearch.Text + "%') AND Lense_Check > 0 ", cn);
                dr = cm.ExecuteReader();
                while (dr.Read())
                {

                    
                    //               1-ITEM ID / 0-Item_ID                  2-QTY / 5-Quantity        5-CLASSIFICATION / 6-Classification                        
                    i += 1;   // 0-Num            2-DESCRIPTION / 1-Description        3-TYPE / 2-Type                            
                    dgv.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[5].ToString(), dr[2].ToString(), dr[6].ToString(), dr[10].ToString());
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

        public void LoadStock(DataGridView dgv, TextBox textID, Label labelCheck)
        {//dataGridViewStockItems, txtStockID, label3
            try
            {
                cn = new SQLiteConnection(dbcon.MyConnection);
                int i = 0;
                dgv.Rows.Clear();
                cn.Open();
                SQLiteCommand cm = new SQLiteCommand("SELECT * from ViewStockItemType WHERE Stock_ID LIKE '" + textID.Text + "' AND Status LIKE 'Pending' ", cn);
                dr = cm.ExecuteReader();
                while (dr.Read())
                {
                    int quantity = 0;
                    string ExpirationDate = dr[2].ToString();
                    if (string.IsNullOrEmpty(ExpirationDate))
                    {
                        ExpirationDate = dr[8].ToString(); //13
                    }
                    else
                    {
                        if (ExpirationDate.Substring(0, 8) != "")
                        {
                            ExpirationDate = dr[2].ToString();
                        }
                        else
                        {
                            ExpirationDate = dr[2].ToString().Substring(0, 10);
                        }
                    }
                    i += 1;
                    //                                                                                  4-DESCRIPTION / 1-Description       6-EXPIRATION / 2-Expiration_Date                                      8-STOCK IN BY / 4-Stock_In_By            10-TYPE / 6-Type
                    //0-# / i         1/Edit                    2/Delete           3-STOCK ID / 0-Stock_ID            5-QTY / 10-Quantity                              7-STOCK IN DATE / 3-Stock_In_Date                            9-ITEM ID / 5-Item_ID                     12-num / 11-num 
                    dgv.Rows.Add(i, Properties.Resources.Edit, Properties.Resources._Delete, dr[0].ToString(), dr[1].ToString(), quantity.ToString(), ExpirationDate, DateTime.Parse(dr[3].ToString()).ToShortDateString(), dr[4].ToString(), dr[5].ToString(), dr[6].ToString(), dr[9].ToString(), dr[11].ToString(), dr[8].ToString());

                }
                dr.Close();
                cn.Close();
                //btnSaveStockIn.Show();
                //NonPerish();
                for (int x = 0; x < dgv.Rows.Count; x++)
                {
                    string scan = dgv.Rows[x].Cells[6].Value.ToString();
                    ((DataGridViewTextBoxColumn)dgv.Columns[6]).MaxInputLength = 6;
                    if (string.IsNullOrEmpty(scan))
                    {
                        dgv.Rows[x].Cells[6].Value = "Non-Consumable";
                    }
                }
                //labelCheck.Text = dgv.Rows[0].Cells[5].Value?.ToString();
            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message, title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        //public void NonPerish(DataGridView dgv)
        //{//dataGridViewStockItems
        //    for (int i = 0; i < dgv.Rows.Count; i++)
        //    {
        //        string scan = dgv.Rows[i].Cells[6].Value.ToString();
        //        ((DataGridViewTextBoxColumn)dgv.Columns[6]).MaxInputLength = 6;
        //        if (string.IsNullOrEmpty(scan))
        //        {
        //            dgv.Rows[i].Cells[6].Value = "Non-Perishable";
        //        }
        //    }
        //}

        public void LoadRecordsStockDetail(DataGridView dgv, Label labelID)
        {//dataGridViewDetails, labelItemID
            try
            {
                cn = new SQLiteConnection(dbcon.MyConnection);
                int i = 0;
                dgv.Rows.Clear();
                cn.Open();
                SQLiteCommand cm = new SQLiteCommand("SELECT Stock_In_Date, Quantity, Expiration_Date, Stock_In_By, Unit_Measure, Item_Status FROM tblStock WHERE Item_ID LIKE '%" + labelID.Text + "%' ORDER BY Stock_In_Date DESC", cn);
                dr = cm.ExecuteReader();
                while (dr.Read())
                {
                    string ExpirationDate = dr[2].ToString();
                    
                    if (string.IsNullOrEmpty(ExpirationDate))
                    {
                        ExpirationDate = "Non-Consumable";//13

                    }
                    else
                    {
                        if (ExpirationDate.Substring(0 ,8) != "") //9 = date
                        {
                            ExpirationDate = dr[2].ToString();//.Substring(0, 9);//00/00/0000 = 9 
                        }
                        else
                        {
                            ExpirationDate = dr[2].ToString().Substring(0, 9);//0/00/0000
                        }

                    }

                                                                    //                     2-QTY / 1-Quantity                                   5-STOKED BY / 3-Stock_In_By        
                    i += 1;  //0-#  1-DELIVERY DATE / 1-Stock_In_Date                              3-UNIT / 4-UNit_Measure    4-EXPIRATION / 3-Expiration_Date  
                    dgv.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[4].ToString(), ExpirationDate, dr[3].ToString(), dr[5].ToString());
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

        public void LoadRecordsBrowse(DataGridView dgv, TextBox textSearch)
        {//dataGridViewBrowse, txtSearch
            try
            {
                cn = new SQLiteConnection(dbcon.MyConnection);
                int i = 0;
                dgv.Rows.Clear();
                cn.Open();
                SQLiteCommand cm = new SQLiteCommand("SELECT * from ViewItemProductType WHERE Quantity > 0 AND (Description LIKE '%" + textSearch.Text + "%' OR Type LIKE '%" + textSearch.Text + "%') ORDER BY Item_ID", cn);
                dr = cm.ExecuteReader();
                while (dr.Read())
                {
                    string Quantity = dr[5].ToString();//Quantity
                    string LenseCheck = dr[8].ToString();//Lense_Check
                    string checkLense;
                    string displayPrice = dr[4].ToString();
                    addPesoSign(displayPrice, out displayPrice);
                    if (LenseCheck.Equals("0"))
                    {
                        Quantity = "N/A";
                        checkLense = "0";
                    }
                    else
                    {
                        Quantity = dr[5].ToString();
                    }


                    //                             2-DESCRIPTION / 1-Description       4-PRODUCT / 3-Product               6-STOCK / 5-Quantity                                                                                                                                      
                    i += 1;  // 0-Num   1-Item ID / 0-Item_ID                3-TYPE / 2-Type               5-PRICE / 4-Price                 7-CLASSIFICATION / 6-Classification                           
                    dgv.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), displayPrice, Quantity, dr[6].ToString(), dr[10].ToString(), dr[8].ToString(), dr[4].ToString());
                }
                dr.Close();
                cn.Close();

                cn.Open();
                cm = new SQLiteCommand("SELECT * from ViewItemProductType WHERE Lense_Check = 0 AND (Description LIKE '%" + textSearch.Text + "%' OR Type LIKE '%" + textSearch.Text + "%') ORDER BY Item_ID", cn);
                dr = cm.ExecuteReader();
                while (dr.Read())
                {
                    string Quantity = dr[5].ToString();//Quantity
                    string LenseCheck = dr[8].ToString();//Lense_Check
                    string displayPrice = dr[4].ToString();
                    addPesoSign(displayPrice, out displayPrice);
                    Quantity = "N/A";
                    
                    //                             2-DESCRIPTION / 1-Description       4-PRODUCT / 3-Product               6-STOCK / 5-Quantity                                                                                                                                      
                    i += 1;  // 0-Num   1-Item ID / 0-Item_ID                3-TYPE / 2-Type               5-PRICE / 4-Price                 7-CLASSIFICATION / 6-Classification                           
                    dgv.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), displayPrice, Quantity, dr[6].ToString(), dr[10].ToString(), LenseCheck, dr[4].ToString());
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
        public void ComputeDiscount(double textDiscount, double textPrice, out double textDiscountedResult)
        {//txtDiscount, txtPriceDiscount, txtDiscountedAmount, 
            double discount = textDiscount * .01;
            double result = textPrice * discount;
            textDiscountedResult = result;
        }
        public void LoadCart(DataGridView dgv, Label labelDiscount, Label labelSalesTotal, Label labelPayment, Label labelNetTotal, Button buttonSettle, Button buttonDiscount, Button buttonClear, TextBox textSearch, DataGridView dgv2, Label lblNetNoComa, Label lblGrossNoComma)
        {                           //dataGridViewCart, lblDiscount, lblSalesTotal, lblPayment, lblNetTotal, btnSettlePayment, btnAddDiscount, btnClearCart, txtSearch, dataGridViewService
            cn = new SQLiteConnection(dbcon.MyConnection);                        
                //string servTotal = "0.00";                
                double servTotal = 0;               
                bool hasRecord = false;
                LoadRecordServiceAvail(dgv2, out servTotal, out hasRecord);
                     
                //classCompute.ComputeUnitTotal(dgv);                            
                int i = 0;
                double total = 0;
                double discount = 0;
                double discountResult = 0;
                double addToCurrentTotal = double.Parse(labelSalesTotal.Text);
                dgv.Rows.Clear();
                cn.Open();
                 SQLiteCommand cm = new SQLiteCommand("SELECT * from ViewCartStockItem WHERE Description Like '%" + textSearch.Text + "%' AND Status LIKE 'Cart'", cn);
                dr = cm.ExecuteReader();
                while (dr.Read())
                {
                    string ExpirationDate = dr[2].ToString();
                    //string ExpirationDate = "";
                    if (string.IsNullOrEmpty(ExpirationDate))
                    {
                        ExpirationDate = "Non-Consumable";
                    }
                    else
                    {
                        if (ExpirationDate.Substring(0, 8) != "")
                        {
                            ExpirationDate = dr[2].ToString();//.Substring(0, 9);
                        }
                        else
                        {
                            ExpirationDate = dr[2].ToString().Substring(0, 9);
                        }
                    }
                    total += double.Parse(dr[5].ToString());
                    discount = Double.Parse(dr[11].ToString());

                               // 0-Num                2-EXPIRATION / 2-Expiration_Date                                  4-QUANTITY / 3-Quantity                        6-TOTAL / 5-TOTAL                                                                                                                       11-CartID / 12-Num
                    i += 1;    // 1-DESCRIPTION / 1-Description           3-PRICE / 4-Price                                             5-DISCOUNT / 11-Discount                                                    7-Plus                         8-Minus                 9-Delete              10-StockID / 0-Stock_Num           12-ItemID / 9-Item_ID
                    dgv.Rows.Add(i, dr[1].ToString(), ExpirationDate, "₱" + dr[20].ToString(), dr[3].ToString(), dr[11].ToString(), "₱" + dr[21].ToString(), Properties.Resources._Add, Properties.Resources.Minus, Properties.Resources._Delete, dr[0].ToString(), dr[12].ToString(), dr[9].ToString(), dr[17].ToString(), dr[19].ToString(), dr[4].ToString(), dr[18].ToString(), dr[5].ToString());
                    hasRecord = true;
                }
                dr.Close();
                cn.Close();
                //double passi = 0;
                //if (double.TryParse(servTotal, out passi))
                //    {
                //        passi = double.Parse(servTotal);                        
                //    } else { }
                //total += passi;
                total += servTotal;
                ComputeDiscount(discount, total, out discountResult);
                labelDiscount.Text = discountResult.ToString("0.00");
                labelSalesTotal.Text = total.ToString("#,#0.00");
                lblGrossNoComma.Text = total.ToString("0.00");
                GetCartTotal(labelDiscount, labelSalesTotal, labelPayment, labelNetTotal, lblNetNoComa);
                //LoadRecordServiceAvail(dgv2, out servTotal, out hasRecord);
                //frmC.GetCartTotal();
                if (hasRecord == true)
                {
                    buttonSettle.Enabled = true; buttonDiscount.Enabled = true; buttonClear.Enabled = true;
                }
                else
                { buttonSettle.Enabled = false; buttonDiscount.Enabled = false; buttonClear.Enabled = false; }
            //}
            //catch (Exception ex)
            //{
            //    cn.Close();
            //    MessageBox.Show(ex.Message, title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //}
        }
        
        public void LoadRecordsTransacHist(DataGridView dgv, TextBox txtSearch, DateTimePicker dateStart, DateTimePicker dateEnd)
        {//dataGridViewTransacHist, txtSearchTransac
            cn = new SQLiteConnection(dbcon.MyConnection);
            int i = 0;
            dgv.Rows.Clear();
            cn.Open();
            SQLiteCommand cm = new SQLiteCommand("SELECT DISTINCT Num, Customer, Transaction_No, Cashier, Date FROM ViewPaymentCart WHERE Customer LIKE '%" + txtSearch.Text + "%' OR Cashier LIKE '%" + txtSearch.Text + "%' AND Date BETWEEN '" + dateStart.Value.ToShortDateString() + "' AND '" + dateEnd.Value.ToShortDateString() + "' ORDER BY Transaction_No DESC", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                string TransDate = dr[4].ToString();

                if (TransDate.Substring(0, 9) != "")
                {
                    TransDate = dr[4].ToString();
                }
                else
                {
                    TransDate = dr[4].ToString().Substring(0, 11);
                }
                
                        //                                          2-CUSTOMER / 15-Customer                   4-DATE(TRANSACTION) / 6-Date
                i += 1; //0-#                    1-TRANSACTION NO / 2-Transaction_NO       3-CASHIER / 14-Cashier
                dgv.Rows.Add(i, dr[0].ToString(), dr[2].ToString(), dr[1].ToString(), dr[3].ToString(), dr[4].ToString());
            }
            dr.Close();
            cn.Close();
        }

        public void LoadRecordsTransacSettled(DataGridView dgv, TextBox txtSearch, DateTimePicker dateStart, DateTimePicker dateEnd)
        {//dataGridViewTransacHist, txtSearchTransac
            cn = new SQLiteConnection(dbcon.MyConnection);
            int i = 0;
            dgv.Rows.Clear();
            cn.Open();
            SQLiteCommand cm = new SQLiteCommand("SELECT DISTINCT Num, Customer, New_TransacNo, Cashier, Transaction_Date FROM tblReceiptSettle WHERE Customer LIKE '%" + txtSearch.Text + "%' OR Cashier LIKE '%" + txtSearch.Text + "%' AND Transaction_Date BETWEEN '" + dateStart.Value.ToShortDateString() + "' AND '" + dateEnd.Value.ToShortDateString() + "' ORDER BY New_TransacNo DESC", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                string TransDate = dr[4].ToString();

                if (TransDate.Substring(0, 9) != "")
                {
                    TransDate = dr[4].ToString().Substring(0, 10);
                }
                else
                {
                    TransDate = dr[4].ToString().Substring(0, 10);
                }

                //                                          2-CUSTOMER / 15-Customer                   4-DATE(TRANSACTION) / 6-Date
                i += 1; //0-#                    1-TRANSACTION NO / 2-Transaction_NO       3-CASHIER / 14-Cashier
                dgv.Rows.Add(i, dr[0].ToString(), dr[2].ToString(), dr[1].ToString(), dr[3].ToString(), dr[4].ToString());
            }
            dr.Close();
            cn.Close();
        }

        public void LoadRecordsSoldItems(DataGridView dgv, TextBox txtSearch, DateTimePicker dateStart, DateTimePicker dateEnd)
        {//dataGridViewSoldItems, txtSearchSold
            cn = new SQLiteConnection(dbcon.MyConnection);
            int i = 0;
            dgv.Rows.Clear();//         
            cn.Open();
            SQLiteCommand cm = new SQLiteCommand("SELECT * FROM ViewCartStockItem WHERE Description LIKE '%" + txtSearch.Text + "%' AND Status = 'Sold' OR Date BETWEEN '" + dateStart.Value.ToShortDateString() + "' AND '" + dateEnd.Value.ToShortDateString() + "' ORDER BY Transaction_No DESC", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {

                string TransDate = dr[6].ToString();
                string ExpirationDate = dr[2].ToString();
                if (string.IsNullOrEmpty(ExpirationDate))
                {
                    ExpirationDate = "Non-Consumable";
                }
                else
                {
                    if (ExpirationDate.Substring(0, 8) != "")
                    {
                        ExpirationDate = dr[2].ToString();
                    }
                    else
                    {
                        ExpirationDate = dr[2].ToString().Substring(0, 10);
                    }
                }
                if (TransDate.Substring(0, 10) != "")
                {
                    TransDate = dr[6].ToString();//.Substring(0, 9);
                }
                else
                {
                    TransDate = dr[6].ToString().Substring(0, 10);
                }


                                    //                          2-DESCRIPTION / 1-Description                  4-PRICE / 4-Price                  4-TOTAL / 5-Total
                i += 1; //0-#                    1-TRANSACTION NO / 7-Transaction_NO      3-EXPIRATION / 2-Expiration_Date           4-QTY / 3-Quantity            4-DATE / 6-Date
                dgv.Rows.Add(i, dr[0].ToString(), dr[7].ToString(), dr[1].ToString(), ExpirationDate, "₱" + dr[4].ToString(), dr[3].ToString(), "₱" + dr[5].ToString(), TransDate);
            }
            dr.Close();
            cn.Close();
        }

        public void LoadRecordsBrowseService(DataGridView dgv, TextBox txtSearch)
        {//dataGridViewService
            try
            {
                cn = new SQLiteConnection(dbcon.MyConnection);
                int i = 0;
                dgv.Rows.Clear();
                cn.Open(); //Description LIKE '%" + txtSearch.Text + "%' OR Description LIKE '%" + txtSearch.Text + "%'
                SQLiteCommand cm = new SQLiteCommand("SELECT * FROM tblServices WHERE Name LIKE '%" + txtSearch.Text + "%' OR Description LIKE '%" + txtSearch.Text + "%'", cn);
                dr = cm.ExecuteReader();
                while (dr.Read())
                {
                    //                          2-DESCRIPTION / 3-Description                                       3-ServiceID / 2-Service_ID 
                    i += 1; //0-#  1-NAME / 7-Name                          3-PRICE / 4-Price          
                    dgv.Rows.Add(i, dr[2].ToString(), dr[3].ToString(), "₱" + dr[4].ToString(), Properties.Resources.addToCart, dr[1].ToString(), dr[4].ToString());
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

        public void LoadRecordServiceAvail(DataGridView dgv, out double serviceTotal, out bool hasRecord)
        {//dataGridViewService
            cn = new SQLiteConnection(dbcon.MyConnection);
            int i = 0; hasRecord = false;
            //total = new Label();
            double totalVar = 0;
            //double addToCurrentTotal = double.Parse(total.Text);
            dgv.Rows.Clear();
            cn.Open(); //Description LIKE '%" + txtSearch.Text + "%' OR Description LIKE '%" + txtSearch.Text + "%'
            SQLiteCommand cm = new SQLiteCommand("SELECT * FROM ViewServiceAvailed WHERE Status LIKE 'Pending'", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                totalVar += Double.Parse(dr[3].ToString());
                //                          2-DESCRIPTION / 1-Description                                       5-SID / 2-Service_ID   
                i += 1; //0-#  1-NAME / 7-Name                      3-PRICE / 2-Price          
                dgv.Rows.Add(i, dr[1].ToString(), dr[2].ToString(), "₱" + dr[10].ToString(), Properties.Resources._Delete, dr[0].ToString(), dr[9].ToString(), dr[3].ToString());
                hasRecord = true;
            }
            dr.Close();
            cn.Close();
            //totalVar += addToCurrentTotal;
            //serviceTotal = totalVar.ToString("00.00");
            serviceTotal = totalVar;
            
        }

        public void LoadType(ComboBox comBoType)
        {
            try
            {
                cn = new SQLiteConnection(dbcon.MyConnection);
                cn.Open();//tblProductType
                SQLiteCommand cm = new SQLiteCommand("SELECT Type FROM tblType", cn);
                dr = cm.ExecuteReader();
                while (dr.Read())
                {   //comBoxType
                    comBoType.Items.Add(dr[0].ToString());

                }
                dr.Close();
                cn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void LoadProductItem(TextBox textProduct, TextBox textTypeID, ComboBox comboBoxType)
        { //txtProduct, txtTypeID, comBoxType
            textProduct.Clear();
            textTypeID.Clear();
            try
            {
                cn = new SQLiteConnection(dbcon.MyConnection);
                cn.Open();//tblProductType
                SQLiteCommand cm = new SQLiteCommand("SELECT Type_ID, Product FROM tblType WHERE Type LIKE '" + comboBoxType.Text + "'", cn);
                dr = cm.ExecuteReader();
                while (dr.Read())
                {

                    textTypeID.Text = dr[0].ToString();
                    textProduct.Text = dr[1].ToString();
                }
                dr.Close();
                cn.Close();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void LoadProductID(TextBox textProductIDType, ComboBox comboBoxProductType)
        { //txtProductIDType, comBoxProductType
            textProductIDType.Clear();
            try
            {
                cn = new SQLiteConnection(dbcon.MyConnection);
                cn.Open();
                SQLiteCommand cm = new SQLiteCommand("SELECT Product_ID FROM tblProduct WHERE Product LIKE '%" + comboBoxProductType.Text + "'", cn);
                dr = cm.ExecuteReader();
                while (dr.Read())
                {

                    textProductIDType.Text = dr[0].ToString();

                }
                dr.Close();
                cn.Close();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void LoadProduct(ComboBox comboBoxProductType)
        {// comBoxProductType
            try
            {
                cn = new SQLiteConnection(dbcon.MyConnection);
                cn.Open();
                SQLiteCommand cm = new SQLiteCommand("SELECT Product FROM tblProduct", cn);
                dr = cm.ExecuteReader();
                while (dr.Read())
                {
                    comboBoxProductType.Items.Add(dr[0].ToString());

                }
                dr.Close();
                cn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void LoadUnitMeasure(ComboBox comboBoxUnit)
        {//comBoxUnit
            cn = new SQLiteConnection(dbcon.MyConnection);
            comboBoxUnit.Items.Clear();
            cn.Open();
            SQLiteCommand cm = new SQLiteCommand("SELECT UnitMeasure FROM tblUnitMeasure", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                comboBoxUnit.Items.Add(dr[0].ToString());

            }
            dr.Close();
            cn.Close();
        }

    }
}
