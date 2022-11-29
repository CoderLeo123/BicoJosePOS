using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.SQLite;
namespace Capstone
{
    internal class ClassPatientTransaction
    {
        SQLiteConnection cn = new SQLiteConnection();
        //SqlCommand cm = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        SQLiteDataReader dr;
        ClassComputations classCompute = new ClassComputations();
        string title = "BICO-JOSE System";

        public void LoadRecordsTransacHist(DataGridView dgv, TextBox txtSearch)
        {//dataGridViewTransacHist, txtSearchTransac
            cn = new SQLiteConnection(dbcon.MyConnection);
            int i = 0;
            dgv.Rows.Clear();
            cn.Open();
            SQLiteCommand cm = new SQLiteCommand("SELECT DISTINCT Num, Customer, Transaction_No, Cashier, Date FROM ViewPaymentCart WHERE Customer LIKE '%" + txtSearch.Text + "%' OR Cashier LIKE '%" + txtSearch.Text + "%' ", cn);
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

                //                            2-CUSTOMER / 15-Customer                   4-DATE(TRANSACTION) / 6-Date
                i += 1; //0-#      1-TRANSACTION NO / 2-Transaction_NO       3-CASHIER / 14-Cashier
                dgv.Rows.Add(i, dr[2].ToString(), dr[1].ToString(), dr[3].ToString(), TransDate);
            }
            dr.Close();
            cn.Close();
        }

        public void LoadRecordsTransacSettled(DataGridView dgv, TextBox txtSearch)
        {//dataGridViewTransacHist, txtSearchTransac
            cn = new SQLiteConnection(dbcon.MyConnection);
            int i = 0;
            dgv.Rows.Clear();
            cn.Open();
            SQLiteCommand cm = new SQLiteCommand("SELECT DISTINCT Num, Customer, New_TransacNo, Cashier, Transaction_Date, Transaction_No FROM tblReceiptSettle WHERE Customer LIKE '%" + txtSearch.Text + "%' OR Cashier LIKE '%" + txtSearch.Text + "%' ", cn);
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
                dgv.Rows.Add(i, dr[2].ToString(), dr[1].ToString(), dr[3].ToString(), TransDate, dr[5].ToString());
            }
            dr.Close();
            cn.Close();
        }
        public void LoadPatientTransactionList(DataGridView dgv, string pID)
        {//dataGridViewTransacHist, txtSearchTransac
            cn = new SQLiteConnection(dbcon.MyConnection);
            int i = 0;
            dgv.Rows.Clear();
            cn.Open();
            SQLiteCommand cm = new SQLiteCommand("SELECT * FROM tblPatientTransaction WHERE Patient_ID LIKE '" + pID + "'", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
              
                //          2-NUM / 0-num                               2-NAME / 5-Name                   4-TYPE / 4-Type
                i += 1; //0-#                1-INVOICE/ 2-Transaction_No      3-DATE / 3-Transaction_Date
                dgv.Rows.Add(i, dr[0].ToString(), dr[2].ToString(), dr[5].ToString(), dr[3].ToString(), dr[4].ToString(), dr[6].ToString());
            }
            dr.Close();
            cn.Close();
        }

        public void LoadPatientDetails(string pID, out string FullName, out string Address, out string Phone, out string Age, out string Date, out string Note)
        {
            FullName = ""; Address = ""; Phone = ""; Age = ""; Date = ""; Note = "";
            cn = new SQLiteConnection(dbcon.MyConnection);           
            cn.Open();
            SQLiteCommand cm = new SQLiteCommand("SELECT * FROM tblPatientRecord WHERE Patient_ID LIKE '%" + pID + "%'", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                FullName = dr[2].ToString(); Address = dr[3].ToString(); Phone = dr[4].ToString(); 
                Age = dr[5].ToString(); Date = DateTime.Parse(dr[7].ToString()).ToShortDateString(); Note = dr[11].ToString(); 
            }
            dr.Close();
            cn.Close();
        }
        public void LoadPrescription(DataGridView dgv, string prescID)
        {
            cn = new SQLiteConnection(dbcon.MyConnection);
            
            dgv.Rows.Clear();
            cn.Open();
            SQLiteCommand cm = new SQLiteCommand("SELECT * FROM tblPrescription WHERE Prescript_No LIKE '%" + prescID + "%'", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                
                dgv.Rows.Add("OD", dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString());
                dgv.Rows.Add("OS", dr[6].ToString(), dr[7].ToString(), dr[8].ToString(), dr[9].ToString(), dr[10].ToString());
            }
            dr.Close();
            cn.Close();
        }
        public void LoadTransaction(string transNo, out string FramePrice, out string LensPrice, out string TotalCost, out string NetTotal, out string Deposit, out string Balance, out string Discount, out string DueDate)
        {
            FramePrice = ""; LensPrice = ""; TotalCost = ""; NetTotal = ""; Deposit = ""; Balance = ""; Discount = ""; DueDate = "";

            cn = new SQLiteConnection(dbcon.MyConnection);
            cn.Open();
            SQLiteCommand cm = new SQLiteCommand("SELECT * FROM tblReceipt WHERE Transaction_No LIKE '%" + transNo + "%'", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                FramePrice = dr[15].ToString(); LensPrice = dr[16].ToString(); TotalCost = dr[6].ToString();
                NetTotal = dr[8].ToString(); Deposit = dr[9].ToString(); Balance = dr[10].ToString();
                Discount = dr[7].ToString(); DueDate = DateTime.Parse(dr[13].ToString()).ToLongDateString();
            }
            dr.Close();
            cn.Close();
        }
        public void LoadSettled(string transNo, out string NetTotal, out string Payment, out string DueDate)
        {
            NetTotal = ""; Payment = ""; DueDate = "";

            cn = new SQLiteConnection(dbcon.MyConnection);
            cn.Open();
            SQLiteCommand cm = new SQLiteCommand("SELECT Net_Total, Payment, Transaction_Date FROM tblReceiptSettle WHERE New_TransacNo LIKE '%" + transNo + "%'", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                
                NetTotal = dr[0].ToString(); Payment = dr[1].ToString(); DueDate = DateTime.Parse(dr[2].ToString()).ToLongDateString();
            }
            dr.Close();
            cn.Close();
        }
        public void LoadItems(DataGridView dgv, string transNo, out int RowCount)
        {
            RowCount = 0;
            cn = new SQLiteConnection(dbcon.MyConnection);
            dgv.Rows.Clear(); 
            cn.Open();
            SQLiteCommand cm = new SQLiteCommand("SELECT Quantity, Description FROM ViewCartStockItem WHERE Transaction_No LIKE '%" + transNo + "%' AND Lense_Check = 1", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                RowCount++;
                dgv.Rows.Add(dr[0].ToString(), dr[1].ToString());                
            }
            dr.Close();
            cn.Close();
        }
        public void LoadLense(DataGridView dgv, string transNo, out int RowCount)
        {
            RowCount = 0;
            cn = new SQLiteConnection(dbcon.MyConnection);
            dgv.Rows.Clear();
            cn.Open();
            SQLiteCommand cm = new SQLiteCommand("SELECT Quantity, Description FROM ViewCartStockItem WHERE Transaction_No LIKE '%" + transNo + "%' AND Lense_Check = 0", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                RowCount++;
                dgv.Rows.Add(dr[0].ToString(), dr[1].ToString());
            }
            dr.Close();
            cn.Close();
        }

    }
}
