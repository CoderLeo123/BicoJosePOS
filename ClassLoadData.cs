using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace Capstone
{
    internal class ClassLoadData : ClassComputations
    {
        
        SqlConnection cn = new SqlConnection();
        //SqlCommand cm = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        SqlDataReader dr;
        ClassComputations classCompute = new ClassComputations();
        string title = "BICO-JOSE System";
        
        //frmProductsList frmList = new frmProductsList();

        public void LoadRecordsProduct(DataGridView dgv, TextBox txtSearch)
        {//dataGridViewProduct, txtSearchProduct
            cn = new SqlConnection(dbcon.MyConnection());
            int i = 0;
            dgv.Rows.Clear();
            cn.Open();
            SqlCommand cm = new SqlCommand("SELECT * FROM tblProduct WHERE Product LIKE '%" + txtSearch.Text + "%' Order by Product_ID", cn);
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
            cn = new SqlConnection(dbcon.MyConnection());
            int i = 0;
            dgv.Rows.Clear();
            cn.Open(); //JoinProductType
            SqlCommand cm = new SqlCommand("SELECT * FROM ViewProductType WHERE Type LIKE '%" + txtSearch.Text + "%' OR Product LIKE '%" + txtSearch.Text + "%' Order by Type_ID", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {                             //                       2-TYPE / 2-Type              4-PRODUCT / 3-Product         
                i += 1;                   //0-#  1-TYPE ID / 1-Type_ID          3-PRODUCT ID / 0-Product_ID                  
                dgv.Rows.Add(i, dr[1].ToString(), dr[2].ToString(), dr[0].ToString(), dr[3].ToString());
            }
            dr.Close();
            cn.Close();
        }

        public void LoadRecordsItem(DataGridView dgv, TextBox txtSearch)
        {//dataGridViewItems, txtSearch
            cn = new SqlConnection(dbcon.MyConnection());
            int i = 0;
            dgv.Rows.Clear();
            cn.Open();//ViewItemProductType
            SqlCommand cm = new SqlCommand("SELECT * FROM ViewItemProductType WHERE Description LIKE '%" + txtSearch.Text + "%' OR Type LIKE '%" + txtSearch.Text + "%' Order by Item_ID", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {                         //     2-DESCRIPTION / 1-Description       4-PRODUCT / 3-Product                  6-QUANTITY / 5-Quantity                          7-TYPE ID / 5-Type_ID
                i += 1;              // 0-#                  3-TYPE / 2-Type                     5-PRICE / 4-Price                   7-CLASSIFICATION / 6-Classification
                dgv.Rows.Add(i, dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString(), dr[6].ToString(), dr[0].ToString(), Properties.Resources.Edit, Properties.Resources._Delete);
            }
            dr.Close();
            cn.Close();
        }

        public void LoadRecordsService(DataGridView dgv, TextBox txtSearch)
        {//dataGridViewService, txtSearchService
            cn = new SqlConnection(dbcon.MyConnection());
            int i = 0;
            dgv.Rows.Clear();
            cn.Open();
            SqlCommand cm = new SqlCommand("SELECT * FROM tblServices WHERE Name LIKE '%" + txtSearch.Text + "%' OR Description LIKE '%" + txtSearch.Text + "%' Order by Service_ID", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {                            //                       2-NAME / 2-Name                   4-PRICE / 4-Price
                i += 1;                //0-#  1-SERVICE ID / 1-Service_ID       3-DESCRIPTION / 3-Description
                dgv.Rows.Add(i, dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString());
            }
            dr.Close();
            cn.Close();
        }

        public void LoadStockOnHand(DataGridView dgv, TextBox textSearch)
        {//dataGridViewOnHand, txtSearch
            try
            {
                cn = new SqlConnection(dbcon.MyConnection());
                int i = 0;
                dgv.Rows.Clear();
                cn.Open();
                SqlCommand cm = new SqlCommand("SELECT * from ViewItemProductType WHERE (Description LIKE '%" + textSearch.Text + "%' OR Type LIKE '%" + textSearch.Text + "%')", cn);
                dr = cm.ExecuteReader();
                while (dr.Read())
                {

                    //               1-ITEM ID / 0-Item_ID                  2-QTY / 5-Quantity             5-CLASSIFICATION / 2-Classification                        
                    i += 1;   // 0-Num            2-DESCRIPTION / 1-Description               3-TYPE / 2-Type                            
                    dgv.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[5].ToString(), dr[2].ToString(), dr[6].ToString());
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
                cn = new SqlConnection(dbcon.MyConnection());
                int i = 0;
                dgv.Rows.Clear();
                cn.Open();
                SqlCommand cm = new SqlCommand("SELECT * from ViewStockItemType WHERE Stock_ID LIKE '" + textID.Text + "' AND Status LIKE 'Pending' ", cn);
                dr = cm.ExecuteReader();
                while (dr.Read())
                {
                    int quantity = 0;
                    string ExpirationDate = dr[2].ToString();
                    if (string.IsNullOrEmpty(ExpirationDate))
                    {
                        ExpirationDate = "Non-Consumable"; //13
                    }
                    else
                    {
                        if (ExpirationDate.Substring(0, 10) != "")
                        {
                            ExpirationDate = dr[2].ToString().Substring(0, 9);
                        }
                        else
                        {
                            ExpirationDate = dr[2].ToString().Substring(0, 10);
                        }
                    }
                    i += 1;
                    //                                                                      4-DESCRIPTION / 1-Description       6-EXPIRATION / 2-Expiration_Date                                      8-STOCK IN BY / 4-Stock_In_By            10-TYPE / 6-Type
                    //0-# / i         1/Edit                    2/Delete           3-STOCK ID / 0-Stock_ID            5-QTY / 10-Quantity                              7-STOCK IN DATE / 3-Stock_In_Date                            9-ITEM ID / 5-Item_ID                12-num / 11-num 
                    dgv.Rows.Add(i, Properties.Resources.Edit, Properties.Resources._Delete, dr[0].ToString(), dr[1].ToString(), quantity.ToString(), ExpirationDate, DateTime.Parse(dr[3].ToString()).ToShortDateString(), dr[4].ToString(), dr[5].ToString(), dr[6].ToString(), dr[9].ToString());

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
                cn = new SqlConnection(dbcon.MyConnection());
                int i = 0;
                dgv.Rows.Clear();
                cn.Open();
                SqlCommand cm = new SqlCommand("SELECT Stock_In_Date, Quantity, Expiration_Date, Stock_In_By, Unit_Measure FROM tblStock WHERE Item_ID LIKE '%" + labelID.Text + "%'", cn);
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
                        if (ExpirationDate.Substring(0, 9) != "") //9 = date
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
                    dgv.Rows.Add(i, DateTime.Parse(dr[0].ToString()).ToShortDateString(), dr[1].ToString(), dr[4].ToString(), ExpirationDate, dr[3].ToString());
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
                cn = new SqlConnection(dbcon.MyConnection());
                int i = 0;
                dgv.Rows.Clear();
                cn.Open();
                SqlCommand cm = new SqlCommand("SELECT * from ViewItemProductType WHERE (Description LIKE '%" + textSearch.Text + "%' OR Type LIKE '%" + textSearch.Text + "%') AND Quantity > 0 ORDER BY Item_ID", cn);
                dr = cm.ExecuteReader();
                while (dr.Read())
                {
                    //                             2-DESCRIPTION / 1-Description       4-PRODUCT / 3-Product               6-STOCK / 5-Quantity                                                                                                                                      
                    i += 1;  // 0-Num   1-Item ID / 0-Item_ID                3-TYPE / 2-Type               5-PRICE / 4-Price                 7-CLASSIFICATION / 6-Classification                           
                    dgv.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString(), dr[6].ToString());
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

        public void LoadCart(DataGridView dgv, Label labelDiscount, Label labelSalesTotal, Label labelPayment, Label labelNetTotal, Button buttonSettle, Button buttonDiscount, Button buttonClear, TextBox textSearch)
        {                           //dataGridViewCart, lblDiscount, lblSalesTotal, lblPayment, lblNetTotal, btnSettlePayment, btnAddDiscount, btnClearCart, txtSearch
            try
            {                
                cn = new SqlConnection(dbcon.MyConnection());
                Boolean hasRecord = false;
                int i = 0;
                double total = 0;
                double discount = 0;
                dgv.Rows.Clear();
                cn.Open();
                SqlCommand cm = new SqlCommand("SELECT * from ViewCartStockItem WHERE Description Like '%" + textSearch.Text + "%' AND Status LIKE 'Cart'", cn);
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
                        if (ExpirationDate.Substring(0, 9) != "")
                        {
                            ExpirationDate = dr[2].ToString();//.Substring(0, 9);
                        }
                        else
                        {
                            ExpirationDate = dr[2].ToString().Substring(0, 9);
                        }
                    }
                    total += Double.Parse(dr[5].ToString());
                    discount += Double.Parse(dr[11].ToString());

                    // 0-Num                2-EXPIRATION / 2-Expiration_Date     4-QUANTITY / 3-Quantity              6-TOTAL / 5-TOTAL                                                                                                       10-CartID / 12-Num
                    i += 1;                 // 1-DESCRIPTION / 1-Description           3-PRICE / 4-Price                 5-DISCOUNT / 11-Discount                      7-Plus                         8-Minus                 9-Delete              10-StockID / 0-Stock_Num           10-ItemID / 9-Item_ID
                    dgv.Rows.Add(i, dr[1].ToString(), ExpirationDate, dr[4].ToString(), dr[3].ToString(), dr[11].ToString(), dr[5].ToString(), Properties.Resources._Add, Properties.Resources.Minus, Properties.Resources._Delete, dr[0].ToString(), dr[12].ToString(), dr[9].ToString());
                    hasRecord = true;
                }
                dr.Close();
                cn.Close();
                labelDiscount.Text = discount.ToString("#,##0.00");
                labelSalesTotal.Text = total.ToString("#,##0.00");
                //frmCashier frmC = new frmCashier(); //frmC.lblDiscount, frmC.lblSalesTotal, frmC.lblPayment, out frmC.lblNetTotal
                GetCartTotal(labelDiscount, labelSalesTotal, labelPayment, labelNetTotal);
                //frmC.GetCartTotal();
                if (hasRecord == true)
                {
                    buttonSettle.Enabled = true; buttonDiscount.Enabled = true; buttonClear.Enabled = true;
                }
                else
                { buttonSettle.Enabled = false; buttonDiscount.Enabled = false; buttonClear.Enabled = false; }
            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message, title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void LoadType(ComboBox comBoType)
        {
            try
            {
                cn = new SqlConnection(dbcon.MyConnection());
                cn.Open();//tblProductType
                SqlCommand cm = new SqlCommand("SELECT Type FROM tblType", cn);
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
                cn = new SqlConnection(dbcon.MyConnection());
                cn.Open();//tblProductType
                SqlCommand cm = new SqlCommand("SELECT Type_ID, Product FROM tblType WHERE Type LIKE '" + comboBoxType.Text + "'", cn);
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
                cn = new SqlConnection(dbcon.MyConnection());
                cn.Open();
                SqlCommand cm = new SqlCommand("SELECT Product_ID FROM tblProduct WHERE Product LIKE '%" + comboBoxProductType.Text + "'", cn);
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
                cn = new SqlConnection(dbcon.MyConnection());
                cn.Open();
                SqlCommand cm = new SqlCommand("SELECT Product FROM tblProduct", cn);
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
            cn = new SqlConnection(dbcon.MyConnection());
            comboBoxUnit.Items.Clear();
            cn.Open();
            SqlCommand cm = new SqlCommand("SELECT UnitMeasure FROM tblUnitMeasure", cn);
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
