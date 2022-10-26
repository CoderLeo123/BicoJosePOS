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
        List<ItemList> IList = new List<ItemList>();
        List<ServiceList> SerList = new List<ServiceList>();
        string balSale = ""; bool balance = false;
        bool transaction = false; bool sales = false;
        bool settled = false; bool sold = false;
        public frmReports()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
            textRightAlign();
            changeDatePriorCurrent(dateTimePickerStartSold);
            changeDatePriorCurrent(dateTimePickerStartTrans);
            classLoadData.LoadRecordsTransacHist(dataGridViewTransHist, txtSearchTransHist, dateTimePickerStartTrans, dateTimePickerEndTrans);
            classLoadData.LoadRecordsSoldItems(dataGridViewSoldItems, txtSearchSold, dateTimePickerStartSold, dateTimePickerEndSold);
            classLoadData.LoadRecordsTransacSettled(dataGridViewSettle, txtSearchSettleds, dateTimePickerSettStart, dateTimePickerSettEnd);
            deleteData(); 
            dateSelect(dataGridViewInitial);
            //lblCheckCell.Text = dataGridViewInitial.Rows[0].Cells[1].Value?.ToString();
            //lblCheckCell.Text = dataGridViewInitial[1, 0].Value.ToString();
            calculateTotalPaymentBalance();
            insertData();
            loopUpdateDgv(dataGridViewInitial);            
            previewSales();

            lblCurrentTransN.Text = dataGridViewTransHist.Rows[0].Cells[2].Value?.ToString();
            previewTransHist();
            lblSettledID.Text = dataGridViewSettle.Rows[0].Cells[2].Value?.ToString();
            previewSettled();


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
                payment += Math.Round(double.Parse(dr[0].ToString()), 2);
                balance += Math.Round(double.Parse(dr[1].ToString()), 2);
                rowCount++;
                
            }
            dr.Close();
            cn.Close();
            
            //new SalesReport { Date = transDate, Balance = balance, Payment = payment };
            SalesReport List = new SalesReport();
            List.Date = transDate;
            List.Balance = balance;
            List.Payment = payment;
            //SList.Clear();
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
            //lblCurrentTransN.Text = dataGridViewTransHist.Rows[0].Cells[1].Value?.ToString();
            transNo = lblCurrentTransN.Text; int ITMrowCount = 0; int SrowCount = 0;
            string TransDate = "", PMode = "", PTerms = "", Customer = "", GrossT = "", Discoun = "", NetT = "", Payment = "", Balance = "", Change = "", DisPerc = "", SettledDate = "", Cashier = "";
            classReport.tblReceiptValue(transNo, out TransDate, out PMode, out PTerms, out Customer, out GrossT, out Discoun, out NetT, out Payment, out Balance, out Change, out DisPerc, out SettledDate, out Cashier, out ITMrowCount);

            string SName = "", SPrice = "";
            classReport.tblServiceAvailedList(transNo, out SName, out SPrice, out SrowCount);

            int x = 0, y = 0, num = 1;
            System.Drawing.Font printFont = new System.Drawing.Font("Arial", 10, System.Drawing.FontStyle.Regular);
            System.Drawing.Font printFontBold = new System.Drawing.Font("Arial", 15, System.Drawing.FontStyle.Bold);
            System.Drawing.Font printFontItallic = new System.Drawing.Font("Arial", 12, System.Drawing.FontStyle.Italic);
            e.Graphics.DrawString("Bico-Jose Optical Clinic", printFontBold, Brushes.Black, 175, 30);
            e.Graphics.DrawString("Address: 3rd Floor Susana Mart, Tungko San Jose Del Monte Bulacan", printFont, Brushes.Black, 80, 80);
            y = 140; x = 320;
            e.Graphics.DrawString("Clinic's Contact: 09178326666", printFont, Brushes.Black, 20, y);//140
            e.Graphics.DrawString("Date Issued: ", printFont, Brushes.Black, (x += 60), y);
            e.Graphics.DrawString("Mode of Payment:  " + PMode, printFont, Brushes.Black, 20, (y += 30));//170
            e.Graphics.DrawString(TransDate, printFont, Brushes.Black, x, y);
            e.Graphics.DrawString("Payment Terms:  " + PTerms, printFont, Brushes.Black, 20, (y += 30));//200
            e.Graphics.DrawString("Cashier:  " + Cashier, printFont, Brushes.Black, x, y);//200
            e.Graphics.DrawString("Customer Name:  " + Customer, printFont, Brushes.Black, 20, (y += 30));//230
            if (PTerms.Equals("Deposit"))
            {
                e.Graphics.DrawString("Settlement Date for Remaining Balance:  " + SettledDate, printFont, Brushes.Black, 20, (y += 30));//260               
            }

            e.Graphics.DrawString("-----------------------------------------------------------------------------------------------------------------------", printFont, Brushes.Black, 10, (y += 30));//260 or 290
            e.Graphics.DrawString("Invoice No: " + transNo, printFont, Brushes.Black, 20, (y += 50));//310 or 340
            e.Graphics.DrawString("#", printFont, Brushes.Black, 20, (y += 50));//360 or 390
            e.Graphics.DrawString("Description", printFont, Brushes.Black, 60, y);
            e.Graphics.DrawString("Price", printFont, Brushes.Black, x, y);//x=320
            e.Graphics.DrawString("Qty", printFont, Brushes.Black, (x += 60), y);
            e.Graphics.DrawString("Unit", printFont, Brushes.Black, (x += 50), y);
            e.Graphics.DrawString("Total", printFont, Brushes.Black, (x += 50), y);//330

            tblAvailedList(transNo, out ITMrowCount);


            if (ITMrowCount > 0)
            {
                for (int i = 0; i < ITMrowCount; i++)
                {
                    ItemList Itms = IList[i];
                    x = 370;
                    e.Graphics.DrawString(num.ToString(), printFont, Brushes.Black, 20, (y += 30));//330

                    //Description
                    e.Graphics.DrawString(Itms.Desc, printFont, Brushes.Black, 60, y);

                    //Price
                    e.Graphics.DrawString("₱ " + Itms.Price.ToString("00.00"), printFont, Brushes.Black, x, y); ;

                    //Qty
                    e.Graphics.DrawString(Itms.Qty.ToString(), printFont, Brushes.Black, (x += 80), y);

                    //Unit
                    e.Graphics.DrawString(Itms.UnitM, printFont, Brushes.Black, (x += 38), y);

                    //Total
                    e.Graphics.DrawString("₱ " + Itms.Total.ToString("00.00"), printFont, Brushes.Black, (x += 40), y);//330
                    num += 1;
                }
            }
            tblServiceList(transNo, out SrowCount);
            //y = 430;
            if (SrowCount > 0)
            {
                e.Graphics.DrawString("Service:  ", printFont, Brushes.Black, 20, (y += 50));//430 + 50
                num = 1;
                for (int i = 0; i < SrowCount; i++)
                {
                    ServiceList ServList = SerList[i];
                    x = 370;
                    e.Graphics.DrawString(num.ToString(), printFont, Brushes.Black, 20, (y += 30));

                    e.Graphics.DrawString(ServList.Name, printFont, Brushes.Black, 60, y);//470      Name

                    e.Graphics.DrawString("₱ " + ServList.Price.ToString("00.00"), printFont, Brushes.Black, x, y);//320   Price
                    num += 1;
                }
            }
            x = 440;
            //y = 550;
            e.Graphics.DrawString("Total Amount: ", printFont, Brushes.Black, 20, (y += 50));//550
            e.Graphics.DrawString("₱ " + GrossT, printFont, Brushes.Black, (x += 50), y);//390 

            e.Graphics.DrawString("Discount: ", printFont, Brushes.Black, 20, (y += 30));
            e.Graphics.DrawString("₱ " + Discoun, printFont, Brushes.Black, x, y);//370
            //getValueIfAnyElseBlank(frmC.dataGridViewCart, out resultText, 0, 5);//frmC.dataGridViewCart.Rows[0].Cells[5].Value.ToString()
            e.Graphics.DrawString("(" + DisPerc + "%)", printFont, Brushes.Black, (x -= 80), y);//320

            e.Graphics.DrawString("Total Due: ", printFont, Brushes.Black, 20, (y += 30));
            e.Graphics.DrawString("₱ " + NetT, printFont, Brushes.Black, (x += 80), y);

            e.Graphics.DrawString("Amount Tendered: ", printFont, Brushes.Black, 20, (y += 30));
            e.Graphics.DrawString("₱ " + Payment, printFont, Brushes.Black, x, y);

            if (PTerms.Equals("Deposit"))
            {
                e.Graphics.DrawString("Remaining Balance: ", printFont, Brushes.Black, 20, (y += 30));
                e.Graphics.DrawString("₱ " + Balance, printFont, Brushes.Black, x, y);

                e.Graphics.DrawString("Change: ", printFont, Brushes.Black, 20, (y += 30));
                e.Graphics.DrawString("₱ -", printFont, Brushes.Black, x, y);//710

            }
            else
            {
                e.Graphics.DrawString("Remaining Balance: ", printFont, Brushes.Black, 20, (y += 30));
                e.Graphics.DrawString("₱ -", printFont, Brushes.Black, x, y);

                e.Graphics.DrawString("Change: ", printFont, Brushes.Black, 20, (y += 30));
                e.Graphics.DrawString("₱ " + Change, printFont, Brushes.Black, x, y);//710

            }



            e.Graphics.DrawString("THIS INVOICE/RECEIPT SHALL BE VALID FOR", printFontItallic, Brushes.Black, 130, (y += 60));//770
            e.Graphics.DrawString("ONE (1)) WEEK FROM THE DATE OF THE PERMIT TO USE", printFontItallic, Brushes.Black, 70, (y += 30));//800
            e.Graphics.DrawString("THANKYOU", printFontBold, Brushes.Black, (x -= 240), (y += 30));//830


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
                //e.Graphics.DrawString("#", printFont, Brushes.Black, (leftMargin + 30), (yPos += (offSetY*6)));
                //e.Graphics.DrawString("    Date", printFont, Brushes.Black, (leftMargin + 130), yPos);
                //e.Graphics.DrawString("    Amount", printFont, Brushes.Black, (leftMargin + 280), yPos);
            }
            void body()
            {
                if (balance == true)
                {
                    e.Graphics.DrawString("#", printFont, Brushes.Black, (leftMargin + 30), (yPos += (offSetY * 6)));
                    e.Graphics.DrawString("    Date", printFont, Brushes.Black, (leftMargin + 130), yPos);
                    e.Graphics.DrawString("    Amount", printFont, Brushes.Black, (leftMargin + 280), yPos);
                    e.Graphics.DrawString("DAILY BALANCE REPORT", printFontBold, Brushes.Black, (leftMargin + 260), (yPos -= (offSetY * 3)));
                    yPos += (offSetY * 3);                    
                    
                    if (BalRow > 0)
                    {
                        for (int i = 0; i < BalRow - 1; i++)
                        {
                            SalesReport data = SList[i];
                            //offSetY += (float)fontHeigth;
                            e.Graphics.DrawString(num.ToString(), printFont, Brushes.Black, (leftMargin + 30), (yPos += offSetY));

                            e.Graphics.DrawString(data.Date, printFont, Brushes.Black, (leftMargin + 130), yPos);//Date
                            
                                e.Graphics.DrawString("₱ " + data.Balance.ToString("00.00"), printFont, Brushes.Black, (leftMargin + 280), yPos);//Balance
                            
                            

                            num += 1;
                        }
                    }
                }
                else if (balance == false)
                {
                    e.Graphics.DrawString("#", printFont, Brushes.Black, (leftMargin + 30), (yPos += (offSetY * 6)));
                    e.Graphics.DrawString("    Date", printFont, Brushes.Black, (leftMargin + 130), yPos);
                    e.Graphics.DrawString("    Amount", printFont, Brushes.Black, (leftMargin + 280), yPos);
                    e.Graphics.DrawString("DAILY SALES REPORT", printFontBold, Brushes.Black, (leftMargin + 260), (yPos -= (offSetY * 3)));
                    yPos += (offSetY * 3);
                    
                    if (BalRow > 0)
                    {
                        for (int i = 0; i < BalRow - 1; i++)
                        {
                            SalesReport data = SList[i];
                            //offSetY += (float)fontHeigth;
                            e.Graphics.DrawString(num.ToString(), printFont, Brushes.Black, (leftMargin + 30), (yPos += offSetY));

                            e.Graphics.DrawString(data.Date, printFont, Brushes.Black, (leftMargin + 130), yPos);//Date
                            
                            
                                e.Graphics.DrawString("₱ " + data.Payment.ToString("00.00"), printFont, Brushes.Black, (leftMargin + 280), yPos);//Balance
                            

                            num += 1;
                        }
                    }
                }
                else if (transaction == true)
                {
                    e.Graphics.DrawString("#", printFont, Brushes.Black, (leftMargin + 30), (yPos += (offSetY * 6)));
                    e.Graphics.DrawString("    INVOICE", printFont, Brushes.Black, (leftMargin + 130), yPos);
                    e.Graphics.DrawString("    CUSTOMER", printFont, Brushes.Black, (leftMargin + 280), yPos);
                    e.Graphics.DrawString("    CASHIER", printFont, Brushes.Black, (leftMargin + 430), yPos);
                    e.Graphics.DrawString("    DATE", printFont, Brushes.Black, (leftMargin + 580), yPos);
                    e.Graphics.DrawString("TRANSACTION HISTORY", printFontBold, Brushes.Black, (leftMargin + 260), (yPos -= (offSetY * 3)));
                    yPos += (offSetY * 3);
                    
               
                    
                }
                else if (settled == false)
                {
                    e.Graphics.DrawString("SETTLED TRANSACTION", printFontBold, Brushes.Black, (leftMargin + 260), (yPos -= (offSetY * 3)));
                }
                else if (sold == false)
                {
                    e.Graphics.DrawString("SOLD ITEMS", printFontBold, Brushes.Black, (leftMargin + 260), (yPos -= (offSetY * 3)));
                }
                //yPos += (offSetY * 3);
                //if (BalRow > 0)
                //{
                //    for (int i = 0; i < BalRow - 1; i++)
                //    {
                //        SalesReport data = SList[i];
                //        //offSetY += (float)fontHeigth;
                //        e.Graphics.DrawString(num.ToString(), printFont, Brushes.Black, (leftMargin + 30), (yPos += offSetY));

                //        e.Graphics.DrawString(data.Date, printFont, Brushes.Black, (leftMargin + 130), yPos);//Date
                //        if(balance == true)
                //        {
                //            e.Graphics.DrawString("₱ " + data.Balance.ToString("00.00"), printFont, Brushes.Black, (leftMargin + 280), yPos);//Balance
                //        } 
                //        else if (balance == false)
                //        {
                //            e.Graphics.DrawString("₱ " + data.Payment.ToString("00.00"), printFont, Brushes.Black, (leftMargin + 280), yPos);//Balance
                //        }

                //        num += 1;
                //    }
                //}
            }
            void footer()
            { //'print footer
                e.Graphics.DrawString("Prepared by:", printFont, Brushes.Black, (leftMargin + 10), footerStartY);
                e.Graphics.DrawString("Printed Date:", printFont, Brushes.Black, (rightMargin + 487), footerStartY);
                e.Graphics.DrawString(lblCashier.Text, printFont, Brushes.Black, (leftMargin + 30), (footerStartY += fontHeigth));
                e.Graphics.DrawString(printDate, printFont, Brushes.Black, (rightMargin + 437), footerStartY);
                e.Graphics.DrawString("____________________", printFont, Brushes.Black, leftMargin, (footerStartY += 2));
                e.Graphics.DrawString("         Admin", printFont, Brushes.Black, (leftMargin + 10), (footerStartY += fontHeigth));
                e.Graphics.DrawString("Page " + currPage + " of " + totalPage, printFont, Brushes.Black, (rightMargin + 537), (pageHeigth - (fontHeigth * 4)));
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
        public void previewTransHist()
        {
            int pLength = 1000;
            paperSizeUpdate(out pLength);
            printPreviewControlTransH.Document = printDocumentSales; //
            printDocumentSales.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("RECEIPT", 610, pLength);
            printPreviewControlTransH.Zoom = .6;
            printPreviewControlTransH.StartPage = 0;
        }
        public void previewSettled()
        {
            int pLength = 600;
            //paperSizeUpdate(out pLength);
            printPreviewControlSettledP.Document = printDocumentSettledReceipt; //
            printDocumentSettledReceipt.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("RECEIPT", 610, pLength);
            printPreviewControlSettledP.Zoom = .6;
            printPreviewControlSettledP.StartPage = 0;
        }
        public void changeDatePriorCurrent(DateTimePicker date)
        {
            date.Value = DateTime.Today.AddDays(-3);
        }
        public void tblServiceList(string transacNo, out int rowCount)
        {
            cn = new SqlConnection(dbcon.MyConnection());
            //Desc = ""; Price = ""; Quant = ""; Total = ""; UnitM = "";
            rowCount = 0; SerList.Clear();
            cn.Open();
            SqlCommand cm = new SqlCommand("SELECT Name, Price FROM ViewServiceAvailed WHERE Transaction_No LIKE '" + transacNo + "'", cn);
            dr = cm.ExecuteReader();

            while (dr.Read())
            {
                ServiceList List = new ServiceList();
                List.Name = dr.GetString(0);//"Name"
                List.Price = dr.GetDouble(1);//"Price"
                
                SerList.Add(List);
                rowCount++;

            }
            dr.Close();
            cn.Close();
            //rowCount = List.Count;
        }
        public class ServiceList
        {
            public string Name { get; set; }
            public double Price { get; set; }

        }

        private void dataGridViewTransHist_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            lblCurrentTransN.Text = dataGridViewTransHist.Rows[e.RowIndex].Cells[2].Value?.ToString();
            previewTransHist();
            //int pLength = 950;
            //paperSizeUpdate(out pLength);
            //printPreviewControlTransH.Document = printDocumentSales; //
            //printDocumentSales.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("RECEIPT", 610, pLength);
            //printPreviewControlTransH.Zoom = .6;
            //printPreviewControlTransH.StartPage = 0;
        }

        public void tblAvailedList(string transacNo, out int rowCount)
        {
            cn = new SqlConnection(dbcon.MyConnection());
            //Desc = ""; Price = ""; Quant = ""; Total = ""; UnitM = "";
            rowCount = 0; IList.Clear();
            cn.Open();
            SqlCommand cm = new SqlCommand("SELECT Description, Price, Quantity, Total, Unit_Measure FROM ViewCartStockItem WHERE Transaction_No LIKE '" + transacNo + "'", cn);
            dr = cm.ExecuteReader();

            while (dr.Read())
            {
                ItemList itm = new ItemList();
                itm.Desc = dr.GetString(0);//"Description"
                itm.Price = dr.GetDouble(1);//"Price"
                itm.Qty = dr.GetInt32(2);//"Quantity"
                itm.Total = dr.GetDouble(3);//"Total"
                itm.UnitM = dr.GetString(4);//"Unit_Measure"
                 IList.Add(itm);
                rowCount++;


            }
            dr.Close();
            cn.Close();
            //rowCount = List.Count;
        }
        public class ItemList
        {
            public string Desc { get; set; }
            public double Price { get; set; }
            public int Qty { get; set; }
            public string UnitM { get; set; }
            public double Total { get; set; }
        }
        private void printDocumentSettledReceipt_PrintPage(object sender, PrintPageEventArgs e)
        {
            transNo = lblSettledID.Text;
            string TransDate = "", PMode = "", Customer = "", NetT = "", Payment = "", Change = "", Cashier = "";
            classReport.tblReceiptSettle(transNo, out TransDate, out PMode, out Customer, out NetT, out Payment, out Change, out Cashier);


            int x = 0, y = 0; // num = 1; string resultText = ""; int dgvCount = int.Parse(lblRowCount.Text), dgvCountService = int.Parse(lblServRowCount.Text);

            System.Drawing.Font printFont = new System.Drawing.Font("Arial", 10, System.Drawing.FontStyle.Regular);
            System.Drawing.Font printFontBold = new System.Drawing.Font("Arial", 15, System.Drawing.FontStyle.Bold);
            System.Drawing.Font printFontItallic = new System.Drawing.Font("Arial", 12, System.Drawing.FontStyle.Italic);

            e.Graphics.DrawString("Bico-Jose Optical Clinic", printFontBold, Brushes.Black, 175, 30);
            e.Graphics.DrawString("Address: 3rd Floor Susana Mart, Tungko San Jose Del Monte Bulacan", printFont, Brushes.Black, 80, 80);
            y = 140; x = 320;
            e.Graphics.DrawString("Clinic's Contact: 09178326666", printFont, Brushes.Black, 20, y);//140
            e.Graphics.DrawString("Date Issued: ", printFont, Brushes.Black, (x += 60), y);
            e.Graphics.DrawString("Mode of Payment:  " + PMode, printFont, Brushes.Black, 20, (y += 30));//170
            e.Graphics.DrawString(TransDate, printFont, Brushes.Black, x, y);

            e.Graphics.DrawString("Cashier:  " + Cashier, printFont, Brushes.Black, x, (y += 30));//200
            e.Graphics.DrawString("Customer Name:  " + Customer, printFont, Brushes.Black, 20, y);//230
            e.Graphics.DrawString("--------------------------------------------------------------------------------------------------------------------------", printFont, Brushes.Black, 10, (y += 30));//260 or 290
            e.Graphics.DrawString("Invoice No: " + transNo, printFont, Brushes.Black, 20, (y += 50));//310 or 340
            e.Graphics.DrawString("Balance Settlement", printFont, Brushes.Black, 20, (y += 50));//360 or 390


            x = 440;
            //y = 550;
            e.Graphics.DrawString("Total Amount: ", printFont, Brushes.Black, 20, (y += 50));//550
            e.Graphics.DrawString(NetT, printFont, Brushes.Black, (x += 70), y);//510 

            e.Graphics.DrawString("Amount Tendered: ", printFont, Brushes.Black, 20, (y += 30));
            e.Graphics.DrawString(Payment, printFont, Brushes.Black, x, y);

            e.Graphics.DrawString("Change: ", printFont, Brushes.Black, 20, (y += 30));
            e.Graphics.DrawString(Change, printFont, Brushes.Black, x, y);//710          

            e.Graphics.DrawString("THIS INVOICE/RECEIPT SHALL BE VALID FOR", printFontItallic, Brushes.Black, 130, (y += 60));//770
            e.Graphics.DrawString("ONE (1)) WEEK FROM THE DATE OF THE PERMIT TO USE", printFontItallic, Brushes.Black, 70, (y += 30));//800
            e.Graphics.DrawString("THANKYOU", printFontBold, Brushes.Black, (x -= 280), (y += 30));//830

        }

        private void dataGridViewSettle_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            lblSettledID.Text = dataGridViewSettle.Rows[e.RowIndex].Cells[2].Value?.ToString();
            previewSettled();
        }

        
        public void paperSizeUpdate(out int paperL)
        {
            int dgvCount = 0; transNo = lblCurrentTransN.Text;
            tblAvailedList(transNo, out dgvCount);

            paperL = 0;
            if (dgvCount > 0 && dgvCount <= 4)
            {
                paperL = 1000;
            }
            else if (dgvCount > 4 && dgvCount <= 7)// + 3 items = 30 * 3 = 90
            {
                paperL = 1090;
            }
            else if (dgvCount > 7 && dgvCount <= 10)// + 3 items = 30 * 3 = 90
            {
                paperL = 1180;
            }
            else if (dgvCount > 10 && dgvCount <= 13)// + 3 items = 30 * 3 = 90
            {
                paperL = 1270;
            }
            else
            {
                paperL = 1000;
            }

        }

        private void btnReOrder_Click(object sender, EventArgs e)//btnSalesRep
        {
            tabControlReports.TabPages.Clear();
            TabPage tab = new TabPage("SALES REPORT");
            tabControlReports.TabPages.Add(tab);
            tab.Controls.Add(panelSaleRep);
            classReport.loadSalesPerDay(dataGridViewSalesR, "Total_Sale");
            previewSales();
            checkWhatIsPress(true, false, false, false);
        }

        private void btnBalanceRep_Click(object sender, EventArgs e)
        {
            tabControlReports.TabPages.Clear();
            TabPage tab2 = new TabPage("BALANCE REPORT");
            tabControlReports.TabPages.Add(tab2);
            tab2.Controls.Add(panelBalRep);
            classReport.loadSalesPerDay(dataGridViewBalR, "Total_Bal");
            previewBalance();
            checkWhatIsPress(false, true, false, false);
        }

        private void btnHistoryTransSett_Click(object sender, EventArgs e)
        {
            tabControlReports.TabPages.Clear();
            TabPage tab3 = new TabPage("TRANSACTION");
            tabControlReports.TabPages.Add(tab3);
            tab3.Controls.Add(panelSalesHistory);
            changeDatePriorCurrent(dateTimePickerStartTrans);
            classLoadData.LoadRecordsTransacHist(dataGridViewTransHist, txtSearchTransHist, dateTimePickerStartTrans, dateTimePickerEndTrans);

            lblCurrentTransN.Text = dataGridViewTransHist.Rows[0].Cells[2].Value?.ToString();
            previewTransHist();
            
            TabPage tab4 = new TabPage("SETTLED");
            tabControlReports.TabPages.Add(tab4);
            tab4.Controls.Add(panelSettled);
            classLoadData.LoadRecordsTransacSettled(dataGridViewSettle, txtSearchSettleds, dateTimePickerSettStart, dateTimePickerSettEnd);
            lblSettledID.Text = dataGridViewSettle.Rows[0].Cells[2].Value?.ToString();
            previewSettled();

            checkWhatIsPress(false, false, true, false);
        }

        private void btnSoldItems_Click(object sender, EventArgs e)
        {
            tabControlReports.TabPages.Clear();
            TabPage tab5 = new TabPage("SOLD ITEMS");
            tabControlReports.TabPages.Add(tab5);
            tab5.Controls.Add(panelSoldItems);
            classLoadData.LoadRecordsSoldItems(dataGridViewSoldItems, txtSearchSold, dateTimePickerStartSold, dateTimePickerEndSold);
            checkWhatIsPress(false, false, false, true);

        }

        private void printPreviewDialogTransH_Load(object sender, EventArgs e)
        {

        }

        private void lblCashier_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {

        }

        private void btnPreviewTH_Click(object sender, EventArgs e)
        {
            PrintPreviewDialog preview = new PrintPreviewDialog();
            transaction = true;
            preview.Document = printDocumentBal;
            //printPreviewControl.Document = printDocumentBal; // 800, 800 = 8" x 8"
            printDocumentBal.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("SHORT", sWidth, sLength);

            preview.PrintPreviewControl.StartPage = 0;
            
            //pLength = 920;
            //paperSizeUpdate(out pLength);
            //printDocument.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("RECEIPT", 610, pLength);
            preview.PrintPreviewControl.Zoom = 0.75;
            preview.Size = new System.Drawing.Size(900, 900);
            preview.ShowDialog();
        }

        public void checkWhatIsPress(bool btnReO, bool btnCrit, bool btnOutS, bool btnExp)
        {
            if (btnReO == true)
            {
                colorChange(true, btnSalesRep); colorChange(false, btnBalanceRep); colorChange(false, btnHistoryTransSett); colorChange(false, btnSoldItems);
            }
            else if (btnCrit == true)
            {
                colorChange(true, btnBalanceRep); colorChange(false, btnSalesRep); colorChange(false, btnHistoryTransSett); colorChange(false, btnSoldItems);
            }
            else if (btnOutS == true)
            {
                colorChange(true, btnHistoryTransSett); colorChange(false, btnSalesRep); colorChange(false, btnBalanceRep); colorChange(false, btnSoldItems);
            }
            else if (btnExp == true)
            {
                colorChange(true, btnSoldItems); colorChange(false, btnSalesRep); colorChange(false, btnBalanceRep); colorChange(false, btnHistoryTransSett);
            }
        }
        public void colorChange(bool press, Button changeThisBtn)
        {
            if (press == true)
            {
                changeThisBtn.BackColor = Color.Red;

            }
            else if (press == false)
            {
                changeThisBtn.BackColor = Color.LimeGreen;
            }
        }
        public void textRightAlign()
        {
            //DataGridViewColumn column1 = dataGridViewSalesR.Columns[1];
            //column1.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            this.dataGridViewSalesR.Columns["Sa"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
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
