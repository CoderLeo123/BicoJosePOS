using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace Capstone
{

    internal class ClassGenerateID
    {
        
        SqlConnection cn = new SqlConnection();
        //SqlCommand cm = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        SqlDataReader dr;
        string title = "BICO-JOSE System";
        string I_ID, T_ID, P_ID, S_ID, STK_ID, trans_num; int count;
        //frmAddAccessories frmAdd = new frmAddAccessories();
    
        public void GenerateProductID(TextBox productID)
        {
            try
            {
                cn = new SqlConnection(dbcon.MyConnection());

                cn.Open();
                SqlCommand cm = new SqlCommand("SELECT TOP 1 Product_ID FROM tblProduct ORDER BY Product_ID DESC", cn);
                dr = cm.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {
                    P_ID = dr[0].ToString(); //P1001
                    count = int.Parse(P_ID.Substring(1, 4)); //1001
                    productID.Text = P_ID.Substring(0, 1) + (count + 1); //P1002
                }
                else
                {
                    cn.Close();
                    cn.Open();
                    cm = new SqlCommand("INSERT INTO tblProduct (Product_ID) VALUES('P1001')", cn);                                        
                    cm.ExecuteNonQuery();
                    cn.Close();
                    productID.Text = "P1001";
                    //GenerateProductID(frmAdd.txtProdID);
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

        public void GenerateTypeID(TextBox typeID)
        {
            try
            {
                cn = new SqlConnection(dbcon.MyConnection());

                cn.Open();//tblProductType
                SqlCommand cm = new SqlCommand("SELECT TOP 1 Type_ID FROM tblType ORDER BY Type_ID DESC", cn);
                dr = cm.ExecuteReader();
                dr.Read();

                if (dr.HasRows)
                {
                    T_ID = dr[0].ToString(); //T1001
                    count = int.Parse(T_ID.Substring(1, 4)); //1001
                    typeID.Text = T_ID.Substring(0, 1) + (count + 1); //T1002
                }
                else
                {
                    cn.Close();
                    cn.Open();//tblProductType
                    cm = new SqlCommand("INSERT INTO tblType (Type_ID) VALUES('T1001')", cn);
                    cm.ExecuteNonQuery();
                    typeID.Text = "T1001";
                    cn.Close();
                    //GenerateTypeID(frmAdd.txtTypID);
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

        public void GenerateItemID(TextBox itemID)
        {
            try
            {
                cn = new SqlConnection(dbcon.MyConnection());

                cn.Open();
                SqlCommand cm = new SqlCommand("SELECT TOP 1 Item_ID FROM tblItem ORDER BY Item_ID DESC", cn);
                dr = cm.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {
                    I_ID = dr[0].ToString(); //ITM1001
                    count = int.Parse(I_ID.Substring(3, 4)); //1001
                    itemID.Text = I_ID.Substring(0, 3) + (count + 1); //ITM1002
                }
                else
                {
                    cn.Close();
                    cn.Open();
                    cm = new SqlCommand("INSERT INTO tblItem (Item_ID) VALUES('ITM1001')", cn);                    
                    cm.ExecuteNonQuery();
                    itemID.Text = "ITM1001";
                    cn.Close();
                    //GenerateItemID(frmAdd.txtID);
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

        public void GenerateServiceID(TextBox serviceID)
        {
            try
            {
                cn = new SqlConnection(dbcon.MyConnection());
                cn.Open();
                SqlCommand cm = new SqlCommand("SELECT TOP 1 Service_ID FROM tblServices ORDER BY Service_ID DESC", cn);
                dr = cm.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {
                    S_ID = dr[0].ToString(); //S1001
                    count = int.Parse(S_ID.Substring(1, 4)); //1001
                    serviceID.Text = S_ID.Substring(0, 1) + (count + 1); //S1002
                }
                else
                {
                    cn.Close();
                    cn.Open();
                    cm = new SqlCommand("INSERT INTO tblServices (Service_ID) VALUES('S1001')", cn);                                       
                    cm.ExecuteNonQuery();
                    serviceID.Text = "S1001";
                    cn.Close();
                    //GenerateServiceID(frmAdd.txtServiceID);
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

        public void GenerateStockID(TextBox stockID)
        {//txtStockID
            try
            {
                cn = new SqlConnection(dbcon.MyConnection());
                cn.Open();
                SqlCommand cm = new SqlCommand("SELECT TOP 1 Stock_ID FROM tblStock ORDER BY Stock_ID DESC", cn);
                dr = cm.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {
                    STK_ID = dr[0].ToString(); //STK1001
                    count = int.Parse(STK_ID.Substring(3, 4)); //1001
                    stockID.Text = STK_ID.Substring(0, 3) + (count + 1); //STK1002

                }
                else
                {
                    cn.Close();
                    cn.Open();
                    cm = new SqlCommand("INSERT INTO tblStock (Stock_ID) VALUES('STK1001')", cn);                    
                    cm.ExecuteNonQuery();
                    stockID.Text = "STK1001";
                    cn.Close();
                    //Generate();
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

        public void GenerateTransactionNo(Label labelTransactionNo)
        {//lblTransactionNo
            try
            {
                cn = new SqlConnection(dbcon.MyConnection());
                string date = DateTime.Now.ToString("yyyyMMdd");
                cn.Open();
                SqlCommand cm = new SqlCommand("SELECT TOP 1 Transaction_No FROM tblCart ORDER BY Transaction_No DESC", cn);
                dr = cm.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {
                    trans_num = dr[0].ToString(); //2022081710001
                    count = int.Parse(trans_num.Substring(8, 5)); //10001
                    labelTransactionNo.Text = date + (count + 1); //2022081710002
                }
                else
                {
                    cn.Close();
                    cn.Open();
                    //DateTime current = DateTime.Now.Date;
                    //string shortdate = current.Date;
                    labelTransactionNo.Text = date + "10001";
                    cm = new SqlCommand("INSERT INTO tblCart (Transaction_No) VALUES(@Date)", cn);
                    cm.Parameters.AddWithValue("@Date", labelTransactionNo.Text);
                    cm.ExecuteNonQuery();
                    cn.Close();
                    //GenerateTransactionNo();

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

    }
}
