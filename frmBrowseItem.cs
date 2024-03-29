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

    public partial class frmBrowseItem : Form
    {
        SQLiteConnection cn = new SQLiteConnection();
        SQLiteCommand cm = new SQLiteCommand();
        DBConnection dbcon = new DBConnection();
        SQLiteDataReader dr;
        ClassLoadData classLoadData = new ClassLoadData();
        ClassComputations classCompute = new ClassComputations();
        string title = "BICO-JOSE System";
        frmCashier frmC;
        string check = "";


        public frmBrowseItem(frmCashier frmC)
        {
            InitializeComponent();
            cn = new SQLiteConnection(dbcon.MyConnection);
            classLoadData.LoadRecordsBrowse(dataGridViewBrowse, txtSearch);
            //LoadRecordsBrowse();
            this.frmC = frmC;
            classLoadData.LoadCart(frmC.dataGridViewCart, frmC.lblDiscount, frmC.lblSalesTotal, frmC.lblPayment, frmC.lblNetTotal, frmC.btnSettlePayment, frmC.btnAddDiscount, frmC.btnClearCart, frmC.txtSearch, frmC.dataGridViewService, frmC.lblNetNoComa, frmC.lblGrossNoComma);
            //LoadCart();
            textRightAlign();
        }
        public void textRightAlign()
        {

            this.dataGridViewBrowse.Columns["PriceBrowseItem"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;


        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void LoadCart()
        {
                double servTotal = 0;
                //string servTotal = "0";
                bool hasRecord = false;
                classLoadData.LoadRecordServiceAvail(frmC.dataGridViewService, out servTotal, out hasRecord);
                
                int i = 0;
                double total = 0;
                double discount = 0;
                double discountResult = 0;
                double addToCurrentTotal = double.Parse(frmC.lblSalesTotal.Text);
                frmC.dataGridViewCart.Rows.Clear();
                cn.Open();
                cm = new SQLiteCommand("SELECT * from ViewCartStockItem WHERE Description Like '%" + frmC.txtSearch.Text + "%' AND Status LIKE 'Cart'", cn);
                dr = cm.ExecuteReader();
                while (dr.Read())
                {
                    string ExpirationDate = dr[2].ToString();
                    if (string.IsNullOrEmpty(ExpirationDate))
                    {
                        ExpirationDate = "Non-Consumable";
                    }
                    else
                    {
                        if (ExpirationDate.Substring(0, 8) != "")//0, 10
                        {
                            ExpirationDate = dr[2].ToString();// ().Substring(0, 9);
                        }
                        else
                        {
                            ExpirationDate = dr[2].ToString().Substring(0, 9);// 0, 10
                        }
                    }
                    total += Double.Parse(dr[5].ToString());
                    discount = Double.Parse(dr[11].ToString());

                    // 0-Num                                  2-EXPIRATION / 2-Expiration_Date     4-QUANTITY / 3-Quantity              6-TOTAL / 5-TOTAL                                                                                                       10-CartID / 12-Num
                    i += 1;                 // 1-DESCRIPTION / 1-Description           3-PRICE / 4-Price                 5-DISCOUNT / 11-Discount                      7-Plus                         8-Minus                 9-Delete              10-StockID / 0-Stock_Num           10-ItemID / 9-Item_ID
                    frmC.dataGridViewCart.Rows.Add(i, dr[1].ToString(), ExpirationDate, "₱" + dr[20].ToString(), dr[3].ToString(), dr[11].ToString(), "₱" + dr[21].ToString(), Properties.Resources._Add, Properties.Resources.Minus, Properties.Resources._Delete, dr[0].ToString(), dr[12].ToString(), dr[9].ToString(), dr[17].ToString(), dr[19].ToString(), dr[4].ToString(), dr[18].ToString(), dr[5].ToString());
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
                classLoadData.ComputeDiscount(discount, total, out discountResult);
                frmC.lblDiscount.Text = discountResult.ToString("0.00");
                frmC.lblSalesTotal.Text = total.ToString("#,##0.00");
                frmC.lblGrossNoComma.Text = total.ToString("0.00");
                classCompute.GetCartTotal(frmC.lblDiscount, frmC.lblSalesTotal, frmC.lblPayment, frmC.lblNetTotal, frmC.lblNetNoComa);
                //frmC.GetCartTotal();
                if (hasRecord == true)
                {
                    frmC.btnSettlePayment.Enabled = true; frmC.btnAddDiscount.Enabled = true; frmC.btnClearCart.Enabled = true;
                }
                else
                { frmC.btnSettlePayment.Enabled = false; frmC.btnAddDiscount.Enabled = false; frmC.btnClearCart.Enabled = false; }
         
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtSearch.Text == String.Empty)
                {
                    classLoadData.LoadRecordsBrowse(dataGridViewBrowse, txtSearch);
                    //LoadRecordsBrowse();
                    return;
                }
                else
                {
                    classLoadData.LoadRecordsBrowse(dataGridViewBrowse, txtSearch);
                    //LoadRecordsBrowse();
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
                // void ifBlankThenZero(out string result)
                //{
                //    result = "1";
                //    result = dataGridViewBrowse[8, e.RowIndex].Value?.ToString();
                //    if(result == "")
                //    {
                //        result = "0";
                //    }
                //}
                string colName = dataGridViewBrowse.Columns[e.ColumnIndex].Name;
                string uMeasu = dataGridViewBrowse[8, e.RowIndex].Value.ToString();
                lblItemIDCheck.Text = dataGridViewBrowse[1, e.RowIndex].Value.ToString();
                //lblItemIDCheck.Visible = true;
                string id = lblItemIDCheck.Text; // Item_ID
                string classification = dataGridViewBrowse[7, e.RowIndex].Value.ToString();
                string Stock2 = dataGridViewBrowse[6, e.RowIndex].Value.ToString(); //STOCK quantity
                string lense_check = dataGridViewBrowse[9, e.RowIndex].Value?.ToString();                
                //ifBlankThenZero(out lense_check);
                lblLensecheck.Text = lense_check;
                //string Stock = lblStock.Text;
                string Stock_Num = "";
                frmExpiration frmE = new frmExpiration(this);
                int i = 0;
                if ((classification == "Consumable") && (colName == "AddToCart"))
                {
                    cn.Open();
                    cm = new SQLiteCommand("SELECT Expiration_Date, Stock_Num, Quantity FROM tblStockInventory WHERE Item_ID LIKE '" + id.ToString() + "' AND Status = 'Available' AND Quantity > 0 ORDER BY Expiration_Date ASC", cn);
                    dr = cm.ExecuteReader();
                    while (dr.Read())
                    {
                        i += 1; //
                        frmE.dataGridViewExpDate.Rows.Add(i, dr[0].ToString(), dr[2].ToString(), Properties.Resources.AddNew, dr[1].ToString());
                    }
                    dr.Close();
                    cn.Close();
                    
                    //frmE.lblName.Text = dataGridViewBrowse[2, e.RowIndex].Value.ToString();
                    //frmE.lblPrice.Text = dataGridViewBrowse[10, e.RowIndex].Value.ToString();
                    //frmE.tabControl1.TabPages.Clear();
                    //TabPage tab2 = new TabPage("Consumable");
                    //frmE.tabControl1.TabPages.Add(tab2);
                    //tab2.Controls.Add(frmE.panelC);
                    //frmE.panelC.Dock = DockStyle.Fill;

                    lblStock.Text = dataGridViewBrowse[6, e.RowIndex].Value.ToString();//total stock quantity
                    frmE.lblClasific.Text = dataGridViewBrowse[7, e.RowIndex].Value.ToString();
                    frmE.lblName2.Text = dataGridViewBrowse[2, e.RowIndex].Value.ToString();// Description
                    frmE.lblPrice2.Text = dataGridViewBrowse[10, e.RowIndex].Value.ToString();// priceReal
                    frmE.lblItemIDPass.Text = dataGridViewBrowse[1, e.RowIndex].Value.ToString();
                    frmE.lblTotal.Text = "0";
                    frmE.lblLenseCheck.Text = lense_check;
                    frmE.lblUnitMea.Text = uMeasu;
                    frmE.txtQuantity.Text = "0";
                    frmE.txtQuantity.Focus();
                    frmE.txtQuantity.SelectAll();
                    //frmE.tabControl1.SelectedIndex = 1;
                    frmE.tabControl1.TabPages.Clear();
                    TabPage tab = new TabPage("Item");
                    frmE.tabControl1.TabPages.Add(tab);
                    tab.Controls.Add(frmE.panelNC);
                    tab.Controls.Add(frmE.lblName2);
                     
                    frmE.Size = new Size(620, 543);
                    frmE.ShowDialog();
                    
                }
                else if ((classification == "Non-Consumable") && (colName == "AddToCart"))
                {
                    
                    cn.Open();
                    cm = new SQLiteCommand("SELECT Status FROM tblCart WHERE Item_ID LIKE '" + id.ToString() + "' ", cn);
                    dr = cm.ExecuteReader();
                    if (dr.Read())
                    {
                        check = dr[0].ToString();
                    }
                    dr.Close();
                    cn.Close();
                    lblCheck.Text = check;

                    cn.Open();
                    cm = new SQLiteCommand("SELECT Num FROM tblStock WHERE Item_ID LIKE '" + id.ToString() + "' ", cn);
                    dr = cm.ExecuteReader();
                    if (dr.Read())
                    {
                        Stock_Num = dr[0].ToString();
                    }
                    dr.Close();
                    cn.Close();

                    if (Stock2.Equals("N/A"))
                    {
                        float price = float.Parse(dataGridViewBrowse[10, e.RowIndex].Value.ToString());
                        string displayPrice = price.ToString("#,##0.00");

                        cn.Open();
                        cm = new SQLiteCommand("INSERT INTO tblCart (Stock_Num, Item_ID, Transaction_No, Quantity, Price, Total, Date, Lense_Check, Status, Display_Total, Display_Price) VALUES (@Stock_Num, @Item_ID, @TransactionNo, @Quantity, @Price, @Total, @Date, @Lense_Check, 'Cart', @Display_Total, @Display_Price)", cn);
                        //cm.Parameters.AddWithValue("@Stock_ID", frmB.dataGridViewBrowse[1, i].Value.ToString());
                        cm.Parameters.AddWithValue("@Stock_Num", int.Parse(Stock_Num));
                        cm.Parameters.AddWithValue("@Item_ID", dataGridViewBrowse[1, e.RowIndex].Value.ToString());
                        cm.Parameters.AddWithValue("@TransactionNo", lblTrans.Text);
                        cm.Parameters.AddWithValue("@Quantity", 1);
                        cm.Parameters.AddWithValue("@Price", price.ToString("00.00")); 
                        cm.Parameters.AddWithValue("@Date", DateTime.Now);
                        cm.Parameters.AddWithValue("@Total", price.ToString("00.00")); //lense_check
                        cm.Parameters.AddWithValue("@Lense_Check", lense_check);
                        cm.Parameters.AddWithValue("@Display_Total", displayPrice);
                        cm.Parameters.AddWithValue("@Display_Price", displayPrice);
                        cm.ExecuteNonQuery();
                        cn.Close();
                        LoadCart();
                        this.Close();
                    }
                    else
                    {
                        if (!(check.Equals("Cart"))) //check = Anything or Null
                        {

                            cn.Open();
                            cm = new SQLiteCommand("SELECT Num, Quantity, Item_ID, Stock_ID FROM ViewStockItemType WHERE Item_ID LIKE '" + id.ToString() + "' ", cn);
                            dr = cm.ExecuteReader();
                            while (dr.Read())
                            {
                                i += 1;
                                frmE.dataGridViewNC.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString());
                            }
                            dr.Close();
                            cn.Close();

                            lblStock.Text = dataGridViewBrowse[6, e.RowIndex].Value.ToString();
                            frmE.lblClasific.Text = dataGridViewBrowse[7, e.RowIndex].Value.ToString();
                            frmE.lblName2.Text = dataGridViewBrowse[2, e.RowIndex].Value.ToString();
                            frmE.lblPrice2.Text = dataGridViewBrowse[10, e.RowIndex].Value.ToString();
                            frmE.lblItemIDPass.Text = dataGridViewBrowse[1, e.RowIndex].Value.ToString();
                            frmE.lblTotal.Text = "0"; 
                            frmE.lblUnitMea.Text = uMeasu;
                            frmE.lblLenseCheck.Text = lense_check;
                            frmE.txtQuantity.Text = "0";
                            frmE.txtQuantity.Focus();
                            frmE.txtQuantity.SelectAll();
                            //frmE.tabControl1.SelectedIndex = 1;
                            frmE.tabControl1.TabPages.Clear();
                            TabPage tab = new TabPage("Non Consumable");
                            frmE.tabControl1.TabPages.Add(tab);
                            tab.Controls.Add(frmE.panelNC);
                            tab.Controls.Add(frmE.lblName2);
                            tab.Controls.Add(frmE.dataGridViewNC);
                            frmE.Size = new Size(620, 543);
                            frmE.ShowDialog();
                        }
                        else if(check.Equals("Cart"))
                        {

                            MessageBox.Show("Selected Item is already in the Cart", title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;

                        }
                    }
                }
                
            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message, "Gridview Clicked", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
    }

