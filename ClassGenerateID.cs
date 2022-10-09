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

        public void GenerateUserID(Label userID)
        {
            try
            {
                cn = new SqlConnection(dbcon.MyConnection());

                cn.Open();
                SqlCommand cm = new SqlCommand("SELECT TOP 1 User_ID FROM tblUser ORDER BY User_ID DESC", cn);
                dr = cm.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {
                    P_ID = dr[0].ToString(); //USR1001
                    count = int.Parse(P_ID.Substring(3, 4)); //1001
                    userID.Text = P_ID.Substring(0, 3) + (count + 1); //USR1002
                }
                //else
                //{
                //    TextBox tb = new TextBox();
                //    cn.Close();
                //    insertIntialID("tblUser", "User_ID", "USR1000");
                //    selectAndIncrement("tblUser", "User_ID", tb, 3, 4, 0);
                //    userID.Text = tb.Text;
                //    deleteInitialID("tblUser", "User_ID", "USR1000");
                //}
                dr.Close();
                cn.Close();
            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message, title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void GeneratePatientID(TextBox patientID)
        {
            try
            {
                cn = new SqlConnection(dbcon.MyConnection());

                cn.Open();
                SqlCommand cm = new SqlCommand("SELECT TOP 1 Patient_ID FROM tblPatientRecord ORDER BY Patient_ID DESC", cn);
                dr = cm.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {
                    P_ID = dr[0].ToString(); //PNT1001
                    count = int.Parse(P_ID.Substring(3, 4)); //1001
                    patientID.Text = P_ID.Substring(0, 3) + (count + 1); //PNT1002
                }
                else
                {
                    cn.Close();
                    insertIntialID("tblPatientRecord", "Patient_ID", "PNT1000");
                    selectAndIncrement("tblPatientRecord", "Patient_ID", patientID, 3, 4, 0);
                    deleteInitialID("tblPatientRecord", "Patient_ID", "PNT1000");
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

        public void GeneratePrescriptionID(TextBox prescriptionID)
        {
            try
            {
                cn = new SqlConnection(dbcon.MyConnection());

                cn.Open();
                SqlCommand cm = new SqlCommand("SELECT TOP 1 Prescript_No FROM tblPrescription ORDER BY Prescript_No DESC", cn);
                dr = cm.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {
                    P_ID = dr[0].ToString(); //PRC1001
                    count = int.Parse(P_ID.Substring(3, 4)); //1001
                    prescriptionID.Text = P_ID.Substring(0, 3) + (count + 1); //PNT1002
                }
                else
                {
                    cn.Close();
                    insertIntialID("tblPrescription", "Prescript_No", "PRC1000");
                    selectAndIncrement("tblPrescription", "Prescript_No", prescriptionID, 3, 4, 0);
                    deleteInitialID("tblPrescription", "Prescript_No", "PRC1000");
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


        public void selectAndIncrement(string table, string column, TextBox Id, int index1Length2, int length1, int index2)
        {//"tblProduct", "Product_ID", productID
            //SELECT TOP 1 Product_ID FROM tblProduct ORDER BY Product_ID DESC
            //string P_ID; int count;
            cn = new SqlConnection(dbcon.MyConnection());
            cn.Open();
            SqlCommand cm = new SqlCommand("SELECT TOP 1 " + column + " FROM " + table + " ORDER BY " + column + " DESC", cn);
            dr = cm.ExecuteReader();
            dr.Read();
            P_ID = dr[0].ToString();
            count = int.Parse(P_ID.Substring(index1Length2, length1)); //1001    1, 4
            Id.Text = P_ID.Substring(index2, index1Length2) + (count + 1); //P1002   0, 1
            dr.Close();
            cn.Close();
        }

        public void deleteInitialID(string table, string column, string value)
        {
            cn = new SqlConnection(dbcon.MyConnection());
            cn.Open();
            SqlCommand cm = new SqlCommand("DELETE FROM " + table + " WHERE " + column + " LIKE '" + value + "'", cn);
            cm.ExecuteNonQuery();
            cn.Close();
        }
     
        public void insertIntialID(string table, string column, string value)
        {//tblProduct, Product_ID, P1001
         //INSERT INTO tblProduct (Product_ID) VALUES('P1001')
            cn = new SqlConnection(dbcon.MyConnection());
            cn.Open();
            SqlCommand cm = new SqlCommand("INSERT INTO "+ table + " ("+ column + ") VALUES('"+ value + "')", cn);
            cm.ExecuteNonQuery();
            cn.Close();
        }

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
                    insertIntialID("tblProduct", "Product_ID", "P1000");
                    selectAndIncrement("tblProduct", "Product_ID", productID, 1, 4, 0);
                    deleteInitialID("tblProduct", "Product_ID", "P1000");
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
                    insertIntialID("tblType", "Type_ID", "T1000");
                    selectAndIncrement("tblType", "Type_ID", typeID, 1, 4, 0);
                    deleteInitialID("tblType", "Type_ID", "T1000");
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
                    insertIntialID("tblItem", "Item_ID", "ITM1000");
                    selectAndIncrement("tblItem", "Item_ID", itemID, 3, 4, 0);
                    deleteInitialID("tblItem", "Item_ID", "ITM1000");
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
                    insertIntialID("tblServices", "Service_ID", "S1000");
                    selectAndIncrement("tblServices", "Service_ID", serviceID, 1, 4, 0);
                    deleteInitialID("tblServices", "Service_ID", "S1000");
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
                    insertIntialID("tblStock", "Stock_ID", "STK1000");
                    selectAndIncrement("tblStock", "Stock_ID", stockID, 3, 4, 0);
                    deleteInitialID("tblStock", "Stock_ID", "STK1000");
                    //cn.Open();
                    //cm = new SqlCommand("INSERT INTO tblStock (Stock_ID) VALUES('STK1001')", cn);                    
                    //cm.ExecuteNonQuery();
                    //stockID.Text = "STK1001";
                    //cn.Close();
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
