using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace Capstone
{
    internal class ClassPatientTransaction
    {
        SqlConnection cn = new SqlConnection();
        //SqlCommand cm = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        SqlDataReader dr;
        ClassComputations classCompute = new ClassComputations();
        string title = "BICO-JOSE System";

        public void LoadRecordsTransacHist(DataGridView dgv, TextBox txtSearch)
        {//dataGridViewTransacHist, txtSearchTransac
            cn = new SqlConnection(dbcon.MyConnection());
            int i = 0;
            dgv.Rows.Clear();
            cn.Open();
            SqlCommand cm = new SqlCommand("SELECT DISTINCT Num, Customer, Transaction_No, Cashier, Date FROM ViewPaymentCart WHERE Customer LIKE '%" + txtSearch.Text + "%' OR Cashier LIKE '%" + txtSearch.Text + "%' ", cn);
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
            cn = new SqlConnection(dbcon.MyConnection());
            int i = 0;
            dgv.Rows.Clear();
            cn.Open();
            SqlCommand cm = new SqlCommand("SELECT DISTINCT Num, Customer, Transaction_No, Cashier, Transaction_Date FROM tblReceiptSettle WHERE Customer LIKE '%" + txtSearch.Text + "%' OR Cashier LIKE '%" + txtSearch.Text + "%' ", cn);
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
                dgv.Rows.Add(i, dr[2].ToString(), dr[1].ToString(), dr[3].ToString(), TransDate);
            }
            dr.Close();
            cn.Close();
        }
        public void LoadPatientTransactionList(DataGridView dgv, string pID)
        {//dataGridViewTransacHist, txtSearchTransac
            cn = new SqlConnection(dbcon.MyConnection());
            int i = 0;
            dgv.Rows.Clear();
            cn.Open();
            SqlCommand cm = new SqlCommand("SELECT * FROM tblPatientTransaction WHERE Patient_ID LIKE '"+ pID + "'", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
              
                //          2-NUM / 0-num                               2-NAME / 5-Name                   4-TYPE / 4-Type
                i += 1; //0-#                1-INVOICE/ 2-Transaction_No      3-DATE / 3-Transaction_Date
                dgv.Rows.Add(i, dr[0].ToString(), dr[2].ToString(), dr[5].ToString(), dr[3].ToString(), dr[4].ToString());
            }
            dr.Close();
            cn.Close();
        }

    }
}
