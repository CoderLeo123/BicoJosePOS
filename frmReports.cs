using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Drawing.Printing;
namespace Capstone
{
    public partial class frmReports : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        SqlDataReader dr;
        ClassLoadData classLoadData = new ClassLoadData();
        ClassReports classReport = new ClassReports();
        int sWidth = 850, sLength = 1050, lLength = 1400;
        int rowCount = 0;
        string title = "BICO-JOSE System", transNo = "";
        List<ClassReports.SalesReport> List = new List<ClassReports.SalesReport>();
        List<SalesReport> SList = new List<SalesReport>();
        string balSale = ""; bool balance = false;

        public frmReports()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
            
            deleteData(); 
            dateSelect(dataGridViewInitial);
            //lblCheckCell.Text = dataGridViewInitial.Rows[0].Cells[1].Value?.ToString();
            //lblCheckCell.Text = dataGridViewInitial[1, 0].Value.ToString();
            calculateTotalPaymentBalance();
            insertData();
            loopUpdateDgv(dataGridViewInitial);
            
            previewSales();
            //previewBalance();
            
        }
        public void dateSelect(DataGridView dgv)
        {//dataGridViewInitial
            cn = new SqlConnection(dbcon.MyConnection());
            int i = 0;
            dgv.Rows.Clear();
            cn.Open();
            SqlCommand cm = new SqlCommand("SELECT DISTINCT Transaction_Date FROM tblReceipt", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i += 1;
                dgv.Rows.Add(i, dr[0].ToString());
                
            }
            dr.Close();
            cn.Close();
        }
        public void computeSalePerDay(string transDate)
        {//string transDate = dgv.Rows[e.RowIndex].Cells[0].Value.ToString();
            cn = new SqlConnection(dbcon.MyConnection());
            double payment = 0, balance = 0; int rowCount = 0; string TDate = "N/A";
            cn.Open();
            SqlCommand cm = new SqlCommand("SELECT Payment, Balance FROM tblReceipt WHERE Transaction_Date LIKE '%" + transDate + "%' ", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                payment += Math.Round(double.Parse(dr[0].ToString()), 3);
                balance += Math.Round(double.Parse(dr[1].ToString()), 3);
                rowCount++;
                
            }
            dr.Close();
            cn.Close();
            
            //new SalesReport { Date = transDate, Balance = balance, Payment = payment };
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
        public void calculateTotalPaymentBalance()
        {
            string datePerRow = DateTime.Today.ToShortDateString();
            
           
            if (dataGridViewInitial.Rows.Count > 0)
            {
                SList.Clear();
                for (int i = 0; i < dataGridViewInitial.Rows.Count; i++)
                {
                    //lblCheckCell.Text = dataGridViewInitial.Rows[0].Cells[1].Value?.ToString();
                    datePerRow = dataGridViewInitial.Rows[i].Cells[1].Value?.ToString();
                    
                    computeSalePerDay(datePerRow);
                }
            }
        }
        public void loopUpdateDgv(DataGridView dgv)
        {
            
                string datePerRow = DateTime.Today.ToShortDateString();
                if (dgv.Rows.Count > 0)
                {
                    for (int i = 0; i < dataGridViewInitial.Rows.Count-1; i++)
                    {
                        datePerRow = dataGridViewInitial.Rows[i].Cells[1].Value?.ToString();
                        //lblCheckCell.Text = dataGridViewInitial.Rows[i].Cells[1].Value?.ToString();
                        SalesReport Itms = SList[i];
                        updateSaleIntoTbl(datePerRow, Itms.Payment, Itms.Balance);
                    }
                }
            
        }

      
        public void deleteData()
        {
            cn = new SqlConnection(dbcon.MyConnection());
            cn.Open();
            SqlCommand cm = new SqlCommand("DELETE FROM tblSalesReport", cn);
            cm.ExecuteNonQuery();
            cn.Close();
        }
        public void insertData()
        {
            
            string pass = "";            
            
            if (dataGridViewInitial.Rows.Count > 0)
            {

                for (int i = 0; i < dataGridViewInitial.Rows.Count; i++)
                {
                    pass = dataGridViewInitial.Rows[i].Cells[1].Value?.ToString();
                    cn = new SqlConnection(dbcon.MyConnection());
                    cn.Open();
                    SqlCommand cm = new SqlCommand("INSERT INTO tblSalesReport (Date) VALUES('"+ pass + "')", cn);
                    //cm.Parameters.AddWithValue("@Date", pass);
                    cm.ExecuteNonQuery();
                    cn.Close();
                }
            }
        }
        public void updateSaleIntoTbl(string date, double payment, double balance)
        {
            cn = new SqlConnection(dbcon.MyConnection());
            cn.Open();
            SqlCommand cm = new SqlCommand("UPDATE tblSalesReport SET Total_Sale = @Total_Sale, Total_Bal = @Total_Bal WHERE Date LIKE '" + date + "'", cn);
            cm.Parameters.AddWithValue("@Total_Sale", payment);
            cm.Parameters.AddWithValue("@Total_Bal", balance);
            cm.ExecuteNonQuery();
            cn.Close();

        }
        private void printDocumentSales_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            

        }
        public void getRowCount(DataGridView dgv, out int RowCount)
        {

            RowCount = 0;
            if (dgv.Rows.Count > 0)
            {
                RowCount = dgv.Rows.Count;
            }                       
        }
        private void printDocumentBal_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            
            
            System.Drawing.Font printFont = new System.Drawing.Font("Arial", 12, System.Drawing.FontStyle.Regular);
            System.Drawing.Font printFontBold = new System.Drawing.Font("Arial", 12, System.Drawing.FontStyle.Bold);
            
            string printDate = DateTime.Today.ToLongDateString();
            int BalRow = 0, num = 1; getRowCount(dataGridViewInitial, out BalRow);
            int currPage = 1, totalPage = 1;
            float pageWidth = e.PageSettings.PrintableArea.Width; //850 ; 1/4 = 212.5; 1/2 = 425; 3/4 = 637.5
            float pageHeigth = e.PageSettings.PrintableArea.Height; //1100
            float fontHeigth = printFont.GetHeight(); //22.99                       
            //Margins margins = new Margins(100, 100, 100, 100);
            float leftMargin = e.MarginBounds.Left; //100            
            float topMargin = e.MarginBounds.Top; //100
            float rightMargin = e.MarginBounds.Left; //100
            float bottomMargin = e.MarginBounds.Top; //100
            //float rightMargin = e.MarginBounds.Right; //750
            //float bottomMargin = e.MarginBounds.Bottom; //950
            
            float yPos = 0;
            float offSetY = 0;
            float footerStartY = pageHeigth - ((fontHeigth * 4) + bottomMargin);
            float BodyStartY = fontHeigth * 5;
            offSetY += (float)fontHeigth;
            yPos = topMargin;
            void header()
            {
                //'print header
                e.Graphics.DrawString("Bico-Jose Optical Clinic", printFontBold, Brushes.Black, (leftMargin + 240), yPos);
                e.Graphics.DrawString("Address: 3rd Floor Susana Mart, Tungko San Jose Del Monte Bulacan", printFont, Brushes.Black, (leftMargin + 70), (yPos += offSetY)); //offSetY += (float)fontHeigth;
                e.Graphics.DrawString("Clinic's Contact: 09178326666", printFont, Brushes.Black, (leftMargin + 220), (yPos += offSetY)); //offSetY += (float)fontHeigth;
                //e.Graphics.DrawString("SALES REPORT", printFontBold, Brushes.Black, (leftMargin + 260), (yPos += (offSetY * 3))); //offSetY += ((float)fontHeigth * 3);
                e.Graphics.DrawString("#", printFont, Brushes.Black, (leftMargin + 30), (yPos += (offSetY*6)));
                e.Graphics.DrawString("    Date", printFont, Brushes.Black, (leftMargin + 130), yPos);
                e.Graphics.DrawString("    Amount", printFont, Brushes.Black, (leftMargin + 280), yPos);
            }
            void body()
            {
                if (balance == true)
                {
                    e.Graphics.DrawString("BALANCE REPORT", printFontBold, Brushes.Black, (leftMargin + 260), (yPos -= (offSetY * 3)));
                }
                else if (balance == false)
                {
                    e.Graphics.DrawString("SALES REPORT", printFontBold, Brushes.Black, (leftMargin + 260), (yPos -= (offSetY * 3)));
                }
                yPos += (offSetY * 3);
                if (BalRow > 0)
                {
                    for (int i = 0; i < BalRow - 1; i++)
                    {
                        SalesReport data = SList[i];
                        //offSetY += (float)fontHeigth;
                        e.Graphics.DrawString(num.ToString(), printFont, Brushes.Black, (leftMargin + 30), (yPos += offSetY));

                        e.Graphics.DrawString(data.Date, printFont, Brushes.Black, (leftMargin + 130), yPos);//Date
                        if(balance == true)
                        {
                            e.Graphics.DrawString("₱ " + data.Balance.ToString("00.00"), printFont, Brushes.Black, (leftMargin + 280), yPos);//Balance
                        } 
                        else if (balance == false)
                        {
                            e.Graphics.DrawString("₱ " + data.Payment.ToString("00.00"), printFont, Brushes.Black, (leftMargin + 280), yPos);//Balance
                        }

                        num += 1;
                    }
                }
            }
            void footer()
            { //'print footer
                e.Graphics.DrawString("Prepared by:", printFont, Brushes.Black, (leftMargin + 10), footerStartY);
                e.Graphics.DrawString("Printed Date:", printFont, Brushes.Black, (rightMargin + 487), footerStartY);
                e.Graphics.DrawString(lblCashier.Text, printFont, Brushes.Black, (leftMargin + 30), (footerStartY += fontHeigth));
                e.Graphics.DrawString(printDate, printFont, Brushes.Black, (rightMargin + 437), footerStartY);
                e.Graphics.DrawString("____________________", printFont, Brushes.Black, leftMargin, (footerStartY += 2));
                e.Graphics.DrawString("         Admin", printFont, Brushes.Black, (leftMargin + 10), (footerStartY += fontHeigth));
                e.Graphics.DrawString("Page " + currPage + " of " + totalPage, printFont, Brushes.Black, (rightMargin + 100), (pageHeigth - (fontHeigth * 2)));
            }
            header();            
            body();
            footer();           
            

            if ((yPos + offSetY) >= pageHeigth)
            {// If more lines exist, print another page.
                totalPage++; currPage = totalPage;
                e.HasMorePages = true;
                header();
                body();
                footer();
                //offSetY = 0;
                //offSetY += BodyStartY;
                return;
            }
            else
            {
                e.HasMorePages = false;
            }
        }

        private void btnCloseReports_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tabControlReports_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            
            if (tabControlReports.SelectedIndex == 0)
            {
                previewSales();
            }
            else if (tabControlReports.SelectedIndex == 1)
            {
                previewBalance();
            }

        }

        public void previewSales()
        {
            balance = false;
            printPreviewControl.Document = printDocumentBal; // 800, 800 = 8" x 8"
            printDocumentBal.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("SHORT", sWidth, sLength);
            printPreviewControl.Zoom = .6;
            printPreviewControl.StartPage = 0;
        }
        public void previewBalance()
        {
            balance = true;
            printPreviewControlBal.Document = printDocumentBal;            
            printDocumentBal.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("SHORT", sWidth, sLength);
            printPreviewControlBal.Zoom = .6;
            printPreviewControlBal.StartPage = 0;
        }
        private void btnSaveProduct_Click(object sender, EventArgs e)
        {
            ////printPreviewControl preview = new printPreviewControl();
            //printPreviewControl.Document = printDocumentSales;
            //int pLength = 950;
            ////paperSizeUpdate(out pLength);
            //printDocumentSales.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("RECEIPT", 610, pLength);
            //printPreviewControl.Zoom = 0.75;
            ////printPreviewControl.Size = new System.Drawing.Size(400, 650);
            ////printPreviewControl.ShowDialog();
            
        }
    }
}
