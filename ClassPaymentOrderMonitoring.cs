using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace Capstone
{
    internal class ClassPaymentOrderMonitoring
    {
        SqlConnection cn = new SqlConnection();
        //SqlCommand cm = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        SqlDataReader dr;
        ClassComputations classCompute = new ClassComputations();
        string title = "BICO-JOSE System";

        public void LoadRecordsUnsettled(DataGridView dgv, TextBox txtSearch)
        {//dataGridViewProduct, txtSearchProduct
            cn = new SqlConnection(dbcon.MyConnection());
            int i = 0;
            dgv.Rows.Clear();
            cn.Open();
            SqlCommand cm = new SqlCommand("SELECT * FROM ViewPaymentCart WHERE Status = 'Pending' AND Transaction_No LIKE '%" + txtSearch.Text + "%' Order by Transaction_No DESC", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                //                              2-NAME / 2-Customer                      4-DEPOSIT/ 4-Initial_Deposit         6-DUE DATE/ 6-Due_Date                8-STATUS / 8-Status
                i += 1; //0-#  1-TRANS NO / 1-Transaction_No         3-PAYMENT / 3-Total_Payment         5-BALANCE/ 5-Rem_Balance            7-CASHIER / 7-Cashier
                dgv.Rows.Add(i, dr[1].ToString(), dr[2].ToString(), "₱" + dr[3].ToString(), "₱" + dr[4].ToString(), "₱" + dr[5].ToString(), dr[6].ToString(), dr[7].ToString(), dr[8].ToString(), dr[5].ToString());
            }
            dr.Close();
            cn.Close();
        }

        public void updateReleaseBy(string cashier, string transNo)
        {
            cn = new SqlConnection(dbcon.MyConnection());
            cn.Open();
            SqlCommand cm = new SqlCommand("UPDATE tblPaymentStatus SET Completed_By = @Completed_By WHERE Status LIKE 'Settled'", cn);
            cm.Parameters.AddWithValue("@Completed_By", cashier);

            cn.Close();
        }

        public void LoadRecordsSettled(DataGridView dgv, TextBox txtSearch)
        {//dataGridViewProduct, txtSearchProduct
            cn = new SqlConnection(dbcon.MyConnection());
            int i = 0; string ReleaseBY = "";
            dgv.Rows.Clear();
            cn.Open();
            SqlCommand cm = new SqlCommand("SELECT * FROM ViewPaymentCart WHERE Status = 'Settled' AND Customer LIKE '%" + txtSearch.Text + "%' Order by Transaction_No DESC", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                ReleaseBY = dr[7].ToString();
                //updateReleaseBy(ReleaseBY);


                //                              2-NAME / 2-Customer                   4-SETTLED DATE/ 10-Settled_Date          8-STATUS / 8-Status
                i += 1; //0-#  1-TRANS NO / 1-Transaction_No        3-BALANCE/ 5-Rem_Balance          5-COMPLETED BY / 11-Completed_By
                dgv.Rows.Add(i, dr[1].ToString(), dr[2].ToString(), dr[5].ToString(), dr[10].ToString(), dr[11].ToString(), dr[8].ToString());
            }
            dr.Close();
            cn.Close();
        }
        public void LoadRecordsOrder(DataGridView dgv, TextBox txtSearch)
        {//dataGridViewProduct, txtSearchProduct
            cn = new SqlConnection(dbcon.MyConnection());
            int i = 0;
            dgv.Rows.Clear();
            cn.Open();//Status = 'In The Lab'
            SqlCommand cm = new SqlCommand("SELECT * FROM tblOrderStatus WHERE Status = 'In The Lab' AND Customer LIKE '%" + txtSearch.Text + "%' Order by Transaction_No DESC", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                //                              2-CUSTOMER / 2-Customer             4-ARRIVAL/ 4-Expected_Arrival          6-RELEASE BY / 6-Release_By
                i += 1; //0-#  1-TRANS NO / 1-Transaction_No        3-STATUS/ 3-Status          5-DATE CLAIMED / 5-Date_Claimed
                dgv.Rows.Add(i, dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString(), dr[6].ToString());
            }
            dr.Close();
            cn.Close();
        }
        public void LoadRecordsOrderArrived(DataGridView dgv, TextBox txtSearch)
        {//dataGridViewProduct, txtSearchProduct
            cn = new SqlConnection(dbcon.MyConnection());
            int i = 0;
            dgv.Rows.Clear();
            cn.Open();//Status = 'In The Lab'
            SqlCommand cm = new SqlCommand("SELECT * FROM tblOrderStatus WHERE Status = 'Arrived' AND Customer LIKE '%" + txtSearch.Text + "%' Order by Transaction_No DESC", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                //                              2-CUSTOMER / 2-Customer             4-ARRIVAL/ 4-arrival date          6-RELEASE BY / 6-received by
                i += 1; //0-#  1-TRANS NO / 1-Transaction_No        3-STATUS/ 3-Status         
                dgv.Rows.Add(i, dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[8].ToString(), dr[10].ToString(), dr[9].ToString());
            }
            dr.Close();
            cn.Close();
        }
        public void LoadRecordsOrderClaimed(DataGridView dgv, TextBox txtSearch)
        {//dataGridViewProduct, txtSearchProduct
            cn = new SqlConnection(dbcon.MyConnection());
            int i = 0;
            dgv.Rows.Clear();
            cn.Open();//Status = 'In The Lab'
            SqlCommand cm = new SqlCommand("SELECT * FROM tblOrderStatus WHERE Status = 'Claimed' AND Customer LIKE '%" + txtSearch.Text + "%' Order by Transaction_No DESC", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                //                              2-CUSTOMER / 2-Customer                             6-RELEASE BY / 6-Release_By
                i += 1; //0-#  1-TRANS NO / 1-Transaction_No        3-STATUS/ 3-Status      5-DATE CLAIMED / 5-Date_Claimed
                dgv.Rows.Add(i, dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[5].ToString(), dr[6].ToString());
            }
            dr.Close();
            cn.Close();
        }

    }
}
    