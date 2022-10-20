using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace Capstone
{
    internal class ClassReports
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        SqlDataReader dr;
        ClassLoadData classLoadData = new ClassLoadData();
        string title = "BICO-JOSE System";

        public void tblReceiptValue(string transacNo, out string TransDate, out string PMode, out string PTerms, out string Customer, out string GrossT, out string Discoun, out string NetT, out string Payment, out string Balance, out string Change, out string DisPerc, out string SettledDate, out string Cashier, out int rowCount)
        {
            cn = new SqlConnection(dbcon.MyConnection());
            TransDate = ""; PMode = ""; PTerms = ""; Customer = ""; GrossT = ""; Discoun = ""; NetT = ""; Payment = ""; Balance = ""; Change = ""; DisPerc = ""; SettledDate = ""; Cashier = "";
            rowCount = -1;
            cn.Open();
            SqlCommand cm = new SqlCommand("SELECT * FROM tblReceipt WHERE Transaction_No LIKE '"+ transacNo + "'", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                rowCount++;
                TransDate = dr[2].ToString(); PMode = dr[3].ToString(); PTerms = dr[4].ToString(); Customer = dr[5].ToString(); 
                GrossT = dr[6].ToString(); Discoun = dr[7].ToString(); NetT = dr[8].ToString(); Payment = dr[9].ToString();
                Balance = dr[10].ToString(); Change = dr[11].ToString(); DisPerc = dr[12].ToString();
                SettledDate = dr[13].ToString(); Cashier = dr[14].ToString();
                
            }
            dr.Close();
            cn.Close();
        }
        public void tblReceiptSettle(string transacNo, out string TransDate, out string PMode, out string Customer, out string NetT, out string Payment, out string Change, out string Cashier)
        {
            cn = new SqlConnection(dbcon.MyConnection());
            TransDate = ""; PMode = "";Customer = ""; NetT = ""; Payment = ""; Change = ""; Cashier = "";
            
            cn.Open();
            SqlCommand cm = new SqlCommand("SELECT * FROM tblReceiptSettle WHERE Transaction_No LIKE '" + transacNo + "'", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
               
                TransDate = dr[2].ToString(); PMode = dr[3].ToString(); Customer = dr[4].ToString();
                 NetT = dr[5].ToString(); Payment = dr[6].ToString();
                 Change = dr[7].ToString(); Cashier = dr[8].ToString();

            }
            dr.Close();
            cn.Close();
        }
        public void tblAvailedList(string transacNo, out string Desc, out string Price, out string Quant, out string Total, out string UnitM)
        {
            cn = new SqlConnection(dbcon.MyConnection());
            Desc = ""; Price = ""; Quant = ""; Total = ""; UnitM = "";
            cn.Open();
            SqlCommand cm = new SqlCommand("SELECT Description, Price, Quantity, Total, Unit_Measure FROM ViewCartStockItem WHERE Transaction_No LIKE '" + transacNo + "'", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                Desc = dr[0].ToString(); Price = dr[1].ToString(); 
                Quant = dr[2].ToString(); Total = dr[3].ToString(); UnitM = dr[4].ToString();
                if (UnitM == string.Empty || UnitM == null)
                {
                    UnitM = "--";
                }
            }
            dr.Close();
            cn.Close();
        }
        public void tblServiceAvailedList(string transacNo, out string SName, out string SPrice, out int rowCount)
        {
            cn = new SqlConnection(dbcon.MyConnection());
            SName = ""; SPrice = ""; rowCount = -1;
            cn.Open();
            SqlCommand cm = new SqlCommand("SELECT Name, Price FROM ViewServiceAvailed WHERE Transaction_No LIKE '" + transacNo + "'", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                rowCount++;
                SName = dr[0].ToString(); SPrice = dr[1].ToString();
                
            }
            dr.Close();
            cn.Close();
        }
    }
}
