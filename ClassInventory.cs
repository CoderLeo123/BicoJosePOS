﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace Capstone
{
    internal class ClassInventory
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        SqlDataReader dr;
        string title = "BICO-JOSE System";
        //select qty, qty + new stock, if result >= safetylevel, then baseStock column = result, else return the former value of baseStock
        
        public void determineBaseStock(int newStock, out int baseStock, string itemID)
        {//
            cn = new SqlConnection(dbcon.MyConnection());
            baseStock = 0;
            
            cn.Open();
            SqlCommand cm = new SqlCommand("SELECT Quantity, Base_Stock FROM tblItem WHERE Stock_Check = 1 AND Item_ID LIKE '"+ itemID + "'", cn);
            dr = cm.ExecuteReader();
            if (dr.Read())
            {                                         

                int quantity = int.Parse(dr[0].ToString());                
                int newQuantity = quantity + newStock;
                double safeLev = baseStock * .8;
                if(newQuantity >= safeLev)
                {
                    baseStock = newQuantity;
                }
                else
                {
                    baseStock = int.Parse(dr[2].ToString());
                }
            }
            dr.Close();
            cn.Close();
        }
        
        public void determineStockLevel(string itemID)
        {
            cn = new SqlConnection(dbcon.MyConnection());
            cn.Open();
            SqlCommand cm = new SqlCommand("SELECT Quantity, Base_Stock FROM tblItem WHERE Stock_Check = 1 AND Item_ID LIKE '" + itemID + "'", cn);
            dr = cm.ExecuteReader();
            if (dr.Read())
            {
                int currentStock = int.Parse(dr[0].ToString());
                int baseStock = int.Parse(dr[1].ToString());
                int stkLev = 0;
                calculateStockLevel(currentStock, baseStock, out stkLev);
                assignStockLevel(itemID, stkLev);
            }
            dr.Close();
            cn.Close();

        }

        public void assignStockLevel(string itemID, int stockLeve)
        {
            cn = new SqlConnection(dbcon.MyConnection());
            cn.Open();//Set Quantity
            SqlCommand cm = new SqlCommand("UPDATE tblItem SET Base_Stock = @BaseStock WHERE Stock_Check = 1 AND Item_ID LIKE '" + itemID + "'", cn);
            cm.Parameters.AddWithValue("@BaseStock", stockLeve);
            cm.ExecuteNonQuery();
            cn.Close();

        }

        public void calculateStockLevel(int baseStock, int currentStock, out int stockLevel)
        {
            //Safety level = 80%
            //Re Order level = 60%
            //Critical level = 40%
            stockLevel = 0;
            
            double safeLev = baseStock * .8;
            double reOrderLev = baseStock * .6;
            double critLev = baseStock * .4;
            if(currentStock >= safeLev)
            {
                stockLevel = 0;//Safety level 
            }
            else if (currentStock <= reOrderLev && currentStock > critLev)
            {
                stockLevel = 1; //Re Order level
            }
            else if (currentStock <= critLev)
            {
                stockLevel = 2; //Critical level
            }
            else if (currentStock == 0)
            {
                stockLevel = 3; //Out of Stock level
            }


        }
        public void LoadReOrder(DataGridView dgv, TextBox txtSearch)
        {//dataGridViewProduct, txtSearchProduct
            cn = new SqlConnection(dbcon.MyConnection());
            int i = 0;
            dgv.Rows.Clear();
            cn.Open();
            SqlCommand cm = new SqlCommand("SELECT * FROM tblItem WHERE Stock_Check = 1 AND Stock_Level = 1 (Description LIKE '%" + txtSearch.Text + "%' OR Type LIKE '%" + txtSearch.Text + "%' OR Classification LIKE '%" + txtSearch.Text + "%') ORDER BY Item_ID", cn);
            dr = cm.ExecuteReader();//Description,, Quantity, Type, Classification
            while (dr.Read())
            {                             //                     3-PRODUCT / 3-Product              
                i += 1;                   //0-#  1-PRODUCT ID / 1-Product_ID       
                dgv.Rows.Add(i, dr[3].ToString(), dr[5].ToString(), dr[10].ToString(), dr[7].ToString());
            }
            dr.Close();
            cn.Close();
        }

        public void LoadCritical(DataGridView dgv, TextBox txtSearch)
        {//dataGridViewProduct, txtSearchProduct
            cn = new SqlConnection(dbcon.MyConnection());
            int i = 0;
            dgv.Rows.Clear();
            cn.Open();
            SqlCommand cm = new SqlCommand("SELECT * FROM tblItem WHERE Stock_Check = 1 AND Stock_Level = 2 AND (Description LIKE '%" + txtSearch.Text + "%' OR Type LIKE '%" + txtSearch.Text + "%' OR Classification LIKE '%" + txtSearch.Text + "%') ORDER BY Item_ID", cn);
            dr = cm.ExecuteReader();//Description,, Quantity, Type, Classification
            while (dr.Read())
            {                             //                     3-PRODUCT / 3-Product              
                i += 1;                   //0-#  1-PRODUCT ID / 1-Product_ID       
                dgv.Rows.Add(i, dr[3].ToString(), dr[5].ToString(), dr[10].ToString(), dr[7].ToString());
            }
            dr.Close();
            cn.Close();
        }
        public void LoadOutOfStock(DataGridView dgv, TextBox txtSearch)
        {//dataGridViewProduct, txtSearchProduct
            cn = new SqlConnection(dbcon.MyConnection());
            int i = 0;
            dgv.Rows.Clear();
            cn.Open();
            SqlCommand cm = new SqlCommand("SELECT * FROM tblItem WHERE Stock_Check = 1 AND Stock_Level = 3 (Description LIKE '%" + txtSearch.Text + "%' OR Type LIKE '%" + txtSearch.Text + "%' OR Classification LIKE '%" + txtSearch.Text + "%') ORDER BY Item_ID", cn);
            dr = cm.ExecuteReader();//Description,, Quantity, Type, Classification
            while (dr.Read())
            {                             //                     3-PRODUCT / 3-Product              
                i += 1;                   //0-#  1-PRODUCT ID / 1-Product_ID       
                dgv.Rows.Add(i, dr[3].ToString(), dr[5].ToString(), dr[10].ToString(), dr[7].ToString());
            }
            dr.Close();
            cn.Close();
        }

        public void LoadItemWithExpiration(DataGridView dgv, TextBox txtSearch)
        {//dataGridViewProduct, txtSearchProduct
            cn = new SqlConnection(dbcon.MyConnection());
            int i = 0;
            dgv.Rows.Clear();
            cn.Open();
            SqlCommand cm = new SqlCommand("SELECT * FROM tblItem WHERE Classification = 'Consumable' (Description LIKE '%" + txtSearch.Text + "%' OR Type LIKE '%" + txtSearch.Text + "%') ORDER BY Item_ID", cn);
            dr = cm.ExecuteReader();//Description, Type, Quantity, Item_ID
            while (dr.Read())
            {                             //                     3-PRODUCT / 3-Product              
                i += 1;                   //0-#  1-PRODUCT ID / 1-Product_ID       
                dgv.Rows.Add(i, dr[3].ToString(), dr[10].ToString(), dr[5].ToString(), dr[1].ToString());
            }
            dr.Close();
            cn.Close();
        }

        public void LoadNearExpiration(DataGridView dgv, TextBox txtSearch, string ITMID)
        {//dataGridViewProduct, txtSearchProduct
            cn = new SqlConnection(dbcon.MyConnection());
            int i = 0;
            dgv.Rows.Clear();
            cn.Open();
            SqlCommand cm = new SqlCommand("SELECT * FROM ViewStockItemType WHERE Classification = 'Consumable' AND Item_ID LIKE '"+ ITMID + "' ORDER BY Item_ID", cn);
            dr = cm.ExecuteReader();//Description, Expiration_Date
            while (dr.Read())
            {                             //                     3-PRODUCT / 3-Product              
                i += 1;                   //0-#  1-PRODUCT ID / 1-Product_ID       
                dgv.Rows.Add(i, dr[1].ToString(), dr[2].ToString());
            }
            dr.Close();
            cn.Close();
        }


    }
}
