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
    public partial class frmSearchItem : Form
    {
        SQLiteConnection cn = new SQLiteConnection();
        SQLiteCommand cm = new SQLiteCommand();
        DBConnection dbcon = new DBConnection();
        SQLiteDataReader dr;
        ClassLoadData classLoadData = new ClassLoadData();
        string title = "BICO-JOSE System";
        frmStockIn frmList;
        string num = ""; int count2;
        

        public frmSearchItem(frmStockIn frmAdd)
        {
            InitializeComponent();
            cn = new SQLiteConnection(dbcon.MyConnection);

            LoadRecordsSearch(0);
            textRightAlign();
            //num = AutoGenerateID(num);
            frmList = frmAdd;
        }
        public void textRightAlign()
        {

            this.dataGridViewSearchItem.Columns["PriceSearchItem"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            

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
        public void LoadRecordsSearch(int lenseCheckValue)
        {
            int i = 0;
            dataGridViewSearchItem.Rows.Clear();
            cn.Open();
            cm = new SQLiteCommand("SELECT * FROM ViewItemProductType WHERE Stock_Check > " +lenseCheckValue +" ORDER BY Item_ID", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                string displayPrice = dr[11].ToString();
                addPesoSign(displayPrice, out displayPrice);
                //                                        2-DESCRIPTION / 1-Description          4-PRODUCT / 3-Product              6-CLASSIFICATION / 7-Classification
                i += 1;                      //  1-ITEM ID / 0-Item_ID                 3-TYPE / 2-Type                    5-PRICE / 4-Price
                dataGridViewSearchItem.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), displayPrice, dr[6].ToString(), dr[10].ToString(), dr[4].ToString());
            }
            dr.Close();
            cn.Close();
        }

       public void valueChangingLoadRecordSearch()
        {
                
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridViewSearchItem_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            try
            {
                string colName = dataGridViewSearchItem.Columns[e.ColumnIndex].Name;
                string classifi = dataGridViewSearchItem.Rows[e.RowIndex].Cells[6].Value?.ToString();
                string dateNow = DateTime.Now.ToString();
                int stockNum = 0;
                if (colName == "AddSearchItem")
                {
                    //num = AutoGenerateID(num);
                    if (frmList.txtStockID.Text == "")
                    {
                        MessageBox.Show("Please generate a Stock ID", title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        this.Close();
                        frmList.txtStockID.Focus();
                        return;
                    }
                    if (frmList.txtStockInBy.Text == "")
                    {
                        MessageBox.Show("Please enter a name in Stock In By", title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        this.Close();
                        frmList.txtStockInBy.Focus();
                        return;
                    }
                    if (MessageBox.Show("Add this Item?", title, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        //if(classifi == "Consumable")
                        //{
                        //    cn.Open();
                        //    cm = new SqlCommand("INSERT INTO tblStockInventory (Stock_ID, Item_ID) VALUES(@Stock_ID, @Item_ID)", cn);
                        //    cm.Parameters.AddWithValue("@Stock_ID", frmList.txtStockID.Text);
                        //    cm.Parameters.AddWithValue("@Item_ID", dataGridViewSearchItem[1, e.RowIndex].Value.ToString());
                        //    cm.ExecuteNonQuery();
                        //    cn.Close();
                        //}                        
                        cn.Open();
                        cm = new SQLiteCommand("INSERT INTO tblStock (Stock_ID, Item_ID, Stock_In_Date, Stock_In_By, Status, Type) VALUES(@StockID, @ItemID, @StockDate, @StockInBy, 'Pending', @Type)", cn);
                        cm.Parameters.AddWithValue("@StockID", frmList.txtStockID.Text);
                        cm.Parameters.AddWithValue("@ItemID", dataGridViewSearchItem[1, e.RowIndex].Value.ToString());
                        cm.Parameters.AddWithValue("@StockInBy", frmList.txtStockInBy.Text);
                        cm.Parameters.AddWithValue("@StockDate", dateNow);
                        cm.Parameters.AddWithValue("@Type", dataGridViewSearchItem[3, e.RowIndex].Value.ToString());
                        //cm.Parameters.AddWithValue("@Num", num.ToString());
                        //cm.Parameters.AddWithValue("@Expiration", DateTime.Now);
                        cm.ExecuteNonQuery();
                        cn.Close();
                        MessageBox.Show("Successfully Added!", title, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        classLoadData.LoadStock(frmList.dataGridViewStockItems, frmList.txtStockID, frmList.label3);
                        //frmList.LoadStock();

                        this.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                cn.Close();
                //MessageBox.Show(ex.Message, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
       
        private void dataGridViewSearchItem_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void txtSearchItem_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtSearchItem.Text == String.Empty)
                {
                    LoadRecordsSearch(0);
                    return;
                }
                else
                {

                    LoadRecordsSearch(0);
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
