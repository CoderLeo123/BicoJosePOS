﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.SQLite;
namespace Capstone
{
    internal class ClassReports
    {
        SQLiteConnection cn = new SQLiteConnection();
        SQLiteCommand cm = new SQLiteCommand();
        DBConnection dbcon = new DBConnection();
        SQLiteDataReader dr;
        ClassLoadData classLoadData = new ClassLoadData();
        List<SalesReport> SList = new List<SalesReport>();
        string title = "BICO-JOSE System";

        public void tblReceiptValue(string transacNo, out string TransDate, out string PMode, out string PTerms, out string Customer, out string GrossT, out string Discoun, out string NetT, out string Payment, out string Balance, out string Change, out string DisPerc, out string SettledDate, out string Cashier, out int rowCount)
        {
            cn = new SQLiteConnection(dbcon.MyConnection);
            TransDate = ""; PMode = ""; PTerms = ""; Customer = ""; GrossT = ""; Discoun = ""; NetT = ""; Payment = ""; Balance = ""; Change = ""; DisPerc = ""; SettledDate = ""; Cashier = "";
            rowCount = -1;
            cn.Open();
            SQLiteCommand cm = new SQLiteCommand("SELECT * FROM tblReceipt WHERE Transaction_No LIKE '" + transacNo + "'", cn);
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
        public void tblReceiptSettle(string transacNo, out string TransDate, out string PMode, out string Customer, out string NetT, out string Payment, out string Change, out string Cashier, out string oldTrans, out string newTrans)
        {
            cn = new SQLiteConnection(dbcon.MyConnection);
            TransDate = ""; PMode = "";Customer = ""; NetT = ""; Payment = ""; Change = ""; Cashier = ""; oldTrans = ""; newTrans = "";

            cn.Open();
            SQLiteCommand cm = new SQLiteCommand("SELECT * FROM tblReceiptSettle WHERE New_TransacNo LIKE '" + transacNo + "'", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
               
                TransDate = dr[2].ToString(); PMode = dr[3].ToString(); Customer = dr[4].ToString();
                 NetT = dr[5].ToString(); Payment = dr[6].ToString();
                 Change = dr[7].ToString(); Cashier = dr[8].ToString();
                oldTrans = dr[1].ToString(); newTrans = dr[10].ToString();

            }
            dr.Close();
            cn.Close();
        }
        public void tblAvailedList(string transacNo, out string Desc, out string Price, out string Quant, out string Total, out string UnitM)
        {
            cn = new SQLiteConnection(dbcon.MyConnection);
            Desc = ""; Price = ""; Quant = ""; Total = ""; UnitM = "";
            cn.Open();
            SQLiteCommand cm = new SQLiteCommand("SELECT Description, Price, Quantity, Total, Unit_Measure FROM ViewCartStockItem WHERE Transaction_No LIKE '" + transacNo + "'", cn);
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
            cn = new SQLiteConnection(dbcon.MyConnection);
            SName = ""; SPrice = ""; rowCount = -1;
            cn.Open();
            SQLiteCommand cm = new SQLiteCommand("SELECT Name, Price FROM ViewServiceAvailed WHERE Transaction_No LIKE '" + transacNo + "'", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                rowCount++;
                SName = dr[0].ToString(); SPrice = dr[1].ToString();
                
            }
            dr.Close();
            cn.Close();
        }

        public void dateSelect(DataGridView dgv)
        {//dataGridViewInitial
            cn = new SQLiteConnection(dbcon.MyConnection);
            int i = 0;
            dgv.Rows.Clear();
            cn.Open();
            SQLiteCommand cm = new SQLiteCommand("SELECT DISTINCT Transaction_Date FROM tblReceipt", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i += 1;
                dgv.Rows.Add(i, dr[0].ToString());
                SalesReport List = new SalesReport();
                List.Date = dr.GetString(0); SList.Add(List);
            }
            dr.Close();
            cn.Close();
        }
        public void computeSalePerDay(string transDate)
        {//string transDate = dgv.Rows[e.RowIndex].Cells[0].Value.ToString();
            cn = new SQLiteConnection(dbcon.MyConnection);
            double payment = 0, balance = 0; int rowCount = 0;
            cn.Open();
            SQLiteCommand cm = new SQLiteCommand("SELECT Payment, Balance FROM tblReceipt WHERE Transaction_Date LIKE '" + transDate + "' ", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                payment += double.Parse(dr[0].ToString());
                balance += double.Parse(dr[1].ToString());
                rowCount++;
            }
            dr.Close();
            cn.Close();

            SalesReport List = new SalesReport();
            List.Date = transDate;
            List.Balance = balance;
            List.Payment = payment;

            SList.Add(List);

        }
        public class SalesReport
        {
            public string Date { get; set; }
            public double Payment { get; set; }
            public double Balance { get; set; }

        }


        public void compoteSPerDate(DataGridView dgv)
        {//dataGridViewInitial
            string datePerRow = "";
            int rowCount = dgv.Rows.Count;
            if (dgv.Rows.Count > 0)
            {
                for (int i = 0; i < dgv.Rows.Count; i++)
                {
                    datePerRow = dgv.Rows[i].Cells[1].ToString();
                    computeSalePerDay(datePerRow);
                    insertData(datePerRow);
                    
                }

                for (int i = 0; i < dgv.Rows.Count; i++)
                {
                    datePerRow = dgv.Rows[i].Cells[1].ToString();

                    SalesReport Itms = SList[i];
                    updateSaleIntoTbl(datePerRow, Itms.Payment, Itms.Balance);
                }

            }

        }
        public void insertData(string date)
        {
            try
            {
                date = "";
                cn = new SQLiteConnection(dbcon.MyConnection);
                cn.Open();
                SQLiteCommand cm = new SQLiteCommand("INSERT INTO tblSalesReport (Date) VALUES(@Date)", cn);
                cm.Parameters.AddWithValue("@Date", date);
                cm.ExecuteNonQuery();
                cn.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void updateSaleIntoTbl(string date, double payment, double balance)
        {

            cn.Open();
            SQLiteCommand cm = new SQLiteCommand("UPDATE tblSalesReport SET Total_Sale = @Total_Sale, Total_Bal = @Total_Bal WHERE Date LIKE '" + date + "'", cn);
            cm.Parameters.AddWithValue("@Total_Sale", payment.ToString("#,##0.00"));
            cm.Parameters.AddWithValue("@Total_Bal", balance.ToString("#,##0.00"));
            cm.ExecuteNonQuery();
            cn.Close();

        }

        public void loadSalesPerDay(DataGridView dgv, string Col)
        {
            cn = new SQLiteConnection(dbcon.MyConnection);
            int i = 0;string bal; double balan;
            dgv.Rows.Clear();
            cn.Open();
            SQLiteCommand cm = new SQLiteCommand("SELECT Date, " + Col + " FROM tblSalesReport ORDER BY Date DESC", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {

                //bal = float.Parse(dr[1].ToString()); bal.ToString("00.00")
                //bal = double.Parse(dr[1].ToString()).ToString("00.00");
                //balan = Convert.ToDouble(dr[1].ToString()); balan.ToString("00.00")
                i += 1;    
                dgv.Rows.Add(i, dr[0].ToString(), "₱" + dr[1].ToString(), dr[1].ToString());

            }
            dr.Close();
            cn.Close();
        }

    }
}
