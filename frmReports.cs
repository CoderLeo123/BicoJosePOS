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
        int rowCount = 0, once = 2;
        string title = "BICO-JOSE System", transNo = "";
        List<ClassReports.SalesReport> List = new List<ClassReports.SalesReport>();
        List<SalesReport> SList = new List<SalesReport>();
        List<ItemList> IList = new List<ItemList>();
        List<ServiceList> SerList = new List<ServiceList>();
        List<duplicateTransDate> dup = new List<duplicateTransDate>();
        List<dupliDescription> dupDesc = new List<dupliDescription>();
        List<dupliAllInfo> dupAll = new List<dupliAllInfo>();
        List<compareAllInfo> compAll = new List<compareAllInfo>();
        string balSale = "", result = ""; bool balance = false;
        bool transaction = false; bool sales = false;
        bool settled = false; bool sold = false; public bool pesoPaint = true;
        int row = 0;
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
            //dateSelect(dataGridViewInitial, out row);
            //filterDate(row);
            //lblCheckCell.Text = dataGridViewInitial.Rows[0].Cells[1].Value?.ToString();
            //lblCheckCell.Text = dataGridViewInitial[1, 0].Value.ToString();
            calculateTotalPaymentBalance();
            insertData();
            loopUpdateDgv(dataGridViewInitial);
            previewSales();
            checkForBlank(dataGridViewTransHist, out result);
            lblCurrentTransN.Text = result;
            checkForBlank(dataGridViewSettle, out result);
            previewTransHistReceipt();
            lblSettledID.Text = result;
            previewSettledReceipt();
            pesoPaint = true;

        }
        public void checkForBlank(DataGridView dgv, out string result)
        {
            result = "";
            if (dgv.Rows.Count > 0)
            {
                result = dgv.Rows[0].Cells[2].Value?.ToString();
            }
            
        }
        public void dateSelect(DataGridView dgv)
        {//dataGridViewInitial
            cn = new SqlConnection(dbcon.MyConnection());
             row = 0; string transDate = "";
            duplicateTransDate List = new duplicateTransDate();
            dup.Clear();
            List.Date = "";
            dup.Add(List);
            dgv.Rows.Clear();            
            cn.Open();
            SqlCommand cm = new SqlCommand("SELECT DISTINCT Transaction_Date FROM tblReceipt", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                row += 1;
                //dgv.Rows.Add(row, DateTime.Parse(dr[0].ToString()).ToShortDateString());
                transDate = DateTime.Parse(dr[0].ToString()).ToShortDateString();
                //List.Date = transDate;
                //dup.Add(List);
                if (!(List.Date.Contains(transDate))) //we can also use !listWithoutDuplicates.Any(x => x.Equals(item))
                {
                    List.Date = transDate;
                    dup.Add(List);
                    dgv.Rows.Add(row, transDate);
                }
            }
            dr.Close();
            cn.Close();
            //dgv.Rows.Add(row, "234324");
        }

        public class duplicateTransDate
        {
            public string Date { get; set; }           
        }
        public void computeSalePerDay(string transDate)
        {//string transDate = dgv.Rows[e.RowIndex].Cells[0].Value.ToString();
            cn = new SqlConnection(dbcon.MyConnection());
            double payment = 0, balance = 0, change = 0; int rowCount = 0; string TDate = "N/A";
            cn.Open();
            SqlCommand cm = new SqlCommand("SELECT Payment, Balance, Change FROM tblReceipt WHERE Transaction_Date LIKE '%" + transDate + "%' ", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                payment += Math.Round(double.Parse(dr[0].ToString()), 2);
                balance += Math.Round(double.Parse(dr[1].ToString()), 2);
                change += Math.Round(double.Parse(dr[2].ToString()), 2);
                rowCount++;
                
            }
            dr.Close();
            cn.Close();
            payment -= change;
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
            cm.Parameters.AddWithValue("@Total_Sale", payment.ToString("#,##0.00"));
            cm.Parameters.AddWithValue("@Total_Bal", balance.ToString("#,##0.00"));
            cm.ExecuteNonQuery();
            cn.Close();

        }
        private void printDocumentSales_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            try
            {
                //lblCurrentTransN.Text = dataGridViewTransHist.Rows[0].Cells[1].Value?.ToString();
                transNo = lblCurrentTransN.Text; int ITMrowCount = 0; int SrowCount = 0; int rowCountDesc = 0;
            string TransDate = "", PMode = "", PTerms = "", Customer = "", GrossT = "", Discoun = "", NetT = "", Payment = "", Balance = "", Change = "", DisPerc = "", SettledDate = "", Cashier = "";
            classReport.tblReceiptValue(transNo, out TransDate, out PMode, out PTerms, out Customer, out GrossT, out Discoun, out NetT, out Payment, out Balance, out Change, out DisPerc, out SettledDate, out Cashier, out ITMrowCount);

            string SName = "", SPrice = "";
            classReport.tblServiceAvailedList(transNo, out SName, out SPrice, out SrowCount);

            int x = 0, y = 0, num = 1;
            System.Drawing.Font printFont = new System.Drawing.Font("Arial", 10, System.Drawing.FontStyle.Regular);
            System.Drawing.Font printFontBold = new System.Drawing.Font("Arial", 15, System.Drawing.FontStyle.Bold);
            System.Drawing.Font printFontItallic = new System.Drawing.Font("Arial", 12, System.Drawing.FontStyle.Italic);
            e.Graphics.DrawString("Bico-Jose Optical Clinic", printFontBold, Brushes.Black, 175, 30);
            e.Graphics.DrawString("Address: 3rd Floor Susana Mart, Tungko San Jose Del Monte Bulacan", printFont, Brushes.Black, 80, 60);
            e.Graphics.DrawString("Clinic's Contact: 09178326686", printFont, Brushes.Black, 185, 80);
            y = 140; x = 320;
            e.Graphics.DrawString("TIN: 748-219-944-00000", printFont, Brushes.Black, 20, y);//140
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

            tblAvailedList(transNo, out ITMrowCount, out rowCountDesc);
            calcu(rowCountDesc, ITMrowCount);

            if (rowCountDesc > 0)
            {
                for (int i = 0; i < rowCountDesc; i++)
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
                e.Graphics.DrawString("₱ " + Change, printFont, Brushes.Black, x, y);//710

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
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message, "printDocumentSales_PrintPage", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
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
            
            string printDate = DateTime.Today.ToLongDateString(); string resultText = "";
            int BalRow = 0, num = 1; getRowCount(dataGridViewInitial, out BalRow);
            int TransRow = 0; getRowCount(dataGridViewTransHist, out TransRow);
            int SettRow = 0; getRowCount(dataGridViewSettle, out SettRow);
            int SoldRow = 0; getRowCount(dataGridViewSoldItems, out SoldRow);
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
            float offSetX = leftMargin;
            float footerStartY = pageHeigth - ((fontHeigth * 4) + bottomMargin);
            float BodyStartY = fontHeigth * 5;
            offSetY += (float)fontHeigth;
            yPos = topMargin;
            void header()
            {
                //'print header
                e.Graphics.DrawString("Bico-Jose Optical Clinic", printFontBold, Brushes.Black, (leftMargin + 240), yPos);
                e.Graphics.DrawString("Address: 3rd Floor Susana Mart, Tungko San Jose Del Monte Bulacan", printFont, Brushes.Black, (leftMargin + 70), (yPos += offSetY)); //offSetY += (float)fontHeigth;
                e.Graphics.DrawString("Clinic's Contact: 09178326686", printFont, Brushes.Black, (leftMargin + 220), (yPos += offSetY)); //offSetY += (float)fontHeigth;
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
                    e.Graphics.DrawString("DAILY BALANCE REPORT", printFontBold, Brushes.Black, (leftMargin + 240), (yPos -= (offSetY * 3)));
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
                else if (sales == true)
                {
                    e.Graphics.DrawString("#", printFont, Brushes.Black, (leftMargin + 30), (yPos += (offSetY * 6)));
                    e.Graphics.DrawString("    Date", printFont, Brushes.Black, (leftMargin + 130), yPos);
                    e.Graphics.DrawString("    Amount", printFont, Brushes.Black, (leftMargin + 280), yPos);
                    e.Graphics.DrawString("DAILY SALES REPORT", printFontBold, Brushes.Black, (leftMargin + 240), (yPos -= (offSetY * 3)));
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
                    e.Graphics.DrawString("#", printFont, Brushes.Black, (offSetX), (yPos += (offSetY * 6)));
                    e.Graphics.DrawString("    INVOICE", printFont, Brushes.Black, (offSetX += 100), yPos);
                    e.Graphics.DrawString("    CUSTOMER", printFont, Brushes.Black, (offSetX += 150), yPos);
                    e.Graphics.DrawString("    CASHIER", printFont, Brushes.Black, (offSetX += 170), yPos);
                    e.Graphics.DrawString("    DATE", printFont, Brushes.Black, (offSetX += 150), yPos);
                    e.Graphics.DrawString("TRANSACTION HISTORY", printFontBold, Brushes.Black, (leftMargin + 240), (yPos -= (offSetY * 3)));
                    yPos += (offSetY * 3); 
                    if (TransRow > 0)
                    {
                        for (int i = 0; i < TransRow - 1; i++)
                        {
                            offSetX = leftMargin;                            
                            //offSetY += (float)fontHeigth;
                            e.Graphics.DrawString(num.ToString(), printFont, Brushes.Black, (offSetX), (yPos += offSetY));

                            getValueIfAnyElseBlank(TransRow, dataGridViewTransHist, out resultText, i, 2);
                            e.Graphics.DrawString(resultText, printFont, Brushes.Black, (offSetX += 100), yPos);//INVOICE

                            getValueIfAnyElseBlank(TransRow, dataGridViewTransHist, out resultText, i, 3);
                            e.Graphics.DrawString(resultText, printFont, Brushes.Black, (offSetX += 170), yPos);//CUSTOMER

                            getValueIfAnyElseBlank(TransRow, dataGridViewTransHist, out resultText, i, 4);
                            e.Graphics.DrawString(resultText, printFont, Brushes.Black, (offSetX += 150), yPos);//CASHIER

                            getValueIfAnyElseBlank(TransRow, dataGridViewTransHist, out resultText, i, 5);
                            e.Graphics.DrawString(resultText, printFont, Brushes.Black, (offSetX += 150), yPos);//DATE                            
                            num += 1;
                        }
                    }
                }
                else if (settled == true)
                {
                    e.Graphics.DrawString("#", printFont, Brushes.Black, (offSetX), (yPos += (offSetY * 6)));
                    e.Graphics.DrawString("    INVOICE", printFont, Brushes.Black, (offSetX += 100), yPos);
                    e.Graphics.DrawString("    CUSTOMER", printFont, Brushes.Black, (offSetX += 150), yPos);
                    e.Graphics.DrawString("    CASHIER", printFont, Brushes.Black, (offSetX += 170), yPos);
                    e.Graphics.DrawString("    DATE", printFont, Brushes.Black, (offSetX += 150), yPos);
                    e.Graphics.DrawString("SETTLED TRANSACTION", printFontBold, Brushes.Black, (leftMargin + 240), (yPos -= (offSetY * 3)));
                    
                    if (SettRow > 0)
                    {
                        yPos += (offSetY * 3);
                        for (int i = 0; i < SettRow - 1; i++)
                        {
                            offSetX = leftMargin;
                            //offSetY += (float)fontHeigth;
                            e.Graphics.DrawString(num.ToString(), printFont, Brushes.Black, (offSetX), (yPos += offSetY));

                            getValueIfAnyElseBlank(SettRow, dataGridViewSettle, out resultText, i, 2);
                            e.Graphics.DrawString(resultText, printFont, Brushes.Black, (offSetX += 100), yPos);//INVOICE

                            getValueIfAnyElseBlank(SettRow, dataGridViewSettle, out resultText, i, 3);
                            e.Graphics.DrawString(resultText, printFont, Brushes.Black, (offSetX += 170), yPos);//CUSTOMER

                            getValueIfAnyElseBlank(SettRow, dataGridViewSettle, out resultText, i, 4);
                            e.Graphics.DrawString(resultText, printFont, Brushes.Black, (offSetX += 150), yPos);//CASHIER

                            getValueIfAnyElseBlank(SettRow, dataGridViewSettle, out resultText, i, 5);
                            e.Graphics.DrawString(resultText, printFont, Brushes.Black, (offSetX += 150), yPos);//DATE                            
                            num += 1;
                        }
                    }
                }
                else if (sold == true)
                {
                    offSetX -= 50;
                    e.Graphics.DrawString("#", printFont, Brushes.Black, (offSetX), (yPos += (offSetY * 6)));
                    e.Graphics.DrawString("    INVOICE", printFont, Brushes.Black, (offSetX += 40), yPos);
                    e.Graphics.DrawString("    DESCRIPTION", printFont, Brushes.Black, (offSetX += 150), yPos);
                    //e.Graphics.DrawString("    EXPIRATION", printFont, Brushes.Black, (offSetX += 100), yPos);
                    e.Graphics.DrawString("    PRICE", printFont, Brushes.Black, (offSetX += 230), yPos);
                    e.Graphics.DrawString("    QTY", printFont, Brushes.Black, (offSetX += 80), yPos);
                    //e.Graphics.DrawString("    UNIT", printFont, Brushes.Black, (offSetX += 100), yPos);
                    e.Graphics.DrawString("    TOTAL", printFont, Brushes.Black, (offSetX += 60), yPos);
                    e.Graphics.DrawString("    DATE", printFont, Brushes.Black, (offSetX += 110), yPos);
                    e.Graphics.DrawString("SOLD ITEMS", printFontBold, Brushes.Black, (leftMargin + 260), (yPos -= (offSetY * 3)));
                    if (SoldRow > 0)
                    {
                        yPos += (offSetY * 3);
                        for (int i = 0; i < SoldRow - 1; i++)
                        {
                            offSetX = leftMargin - 50;
                            //offSetY += (float)fontHeigth;
                            e.Graphics.DrawString(num.ToString(), printFont, Brushes.Black, (offSetX), (yPos += offSetY));

                            getValueIfAnyElseBlank(SoldRow, dataGridViewSoldItems, out resultText, i, 2);
                            e.Graphics.DrawString(resultText, printFont, Brushes.Black, (offSetX += 30), yPos);//INVOICE

                            getValueIfAnyElseBlank(SoldRow, dataGridViewSoldItems, out resultText, i, 3);
                            e.Graphics.DrawString(resultText, printFont, Brushes.Black, (offSetX += 150), yPos);//DESCRIPTION

                            //getValueIfAnyElseBlank(SoldRow, dataGridViewSoldItems, out resultText, i, 4);
                            //e.Graphics.DrawString(resultText, printFont, Brushes.Black, (offSetX += 150), yPos);//EXPIRATION

                            getValueIfAnyElseBlank(SoldRow, dataGridViewSoldItems, out resultText, i, 5);
                            e.Graphics.DrawString("₱ " + resultText, printFont, Brushes.Black, (offSetX += 260), yPos);//PRICE

                            getValueIfAnyElseBlank(SoldRow, dataGridViewSoldItems, out resultText, i, 6);
                            e.Graphics.DrawString(resultText, printFont, Brushes.Black, (offSetX += 90), yPos);//QTY    

                            //getValueIfAnyElseBlank(SoldRow, dataGridViewSoldItems, out resultText, i, 2);
                            //e.Graphics.DrawString(resultText, printFont, Brushes.Black, (offSetX += 100), yPos);//UNIT

                            getValueIfAnyElseBlank(SoldRow, dataGridViewSoldItems, out resultText, i, 7);
                            e.Graphics.DrawString("₱ " + resultText, printFont, Brushes.Black, (offSetX += 40), yPos);//TOTAL

                            getValueIfAnyElseBlank(SoldRow, dataGridViewSoldItems, out resultText, i, 8);
                            e.Graphics.DrawString(resultText, printFont, Brushes.Black, (offSetX += 100), yPos);//DATE    
                            num += 1;
                        }
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
        public void getValueIfAnyElseBlank(int dgvCount, DataGridView dgv, out string result, int rows, int col)
        {
            result = "N/A";
            if (dgvCount == 0)
            {
                result = "--";
            }
            else
            {
                try
                {
                    result = dgv.Rows[rows].Cells[col].Value?.ToString();

                }
                catch (Exception ex)
                {
                    cn.Close();
                    MessageBox.Show(ex.Message, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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
        public void previewTransList()
        {
            PrintPreviewDialog preview = new PrintPreviewDialog();
            sales = false; balance = false; transaction = true; settled = false; sold = false;
            preview.Document = printDocumentBal; // 800, 800 = 8" x 8"
            printDocumentBal.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("SHORT", sWidth, sLength);
            preview.PrintPreviewControl.StartPage = 0;
            preview.PrintPreviewControl.Zoom = 1;
            preview.Size = new System.Drawing.Size(800, 800);
            preview.ShowDialog();
        }
        public void previewSettledList()
        {
            PrintPreviewDialog preview = new PrintPreviewDialog();
            balance = false; sales = false; transaction = false; settled = true; sold = false;
            preview.Document = printDocumentBal;
            printDocumentBal.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("SHORT", sWidth, sLength);
            preview.PrintPreviewControl.StartPage = 0;
            preview.PrintPreviewControl.Zoom = 1;
            preview.Size = new System.Drawing.Size(800, 800);
            preview.ShowDialog();
        }
        public void previewSoldList()
        {
            PrintPreviewDialog preview = new PrintPreviewDialog();
            sales = false; balance = false; transaction = false; settled = false; sold = true;
            preview.Document = printDocumentBal; // 800, 800 = 8" x 8"
            printDocumentBal.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("SHORT", sWidth, sLength);
            preview.PrintPreviewControl.StartPage = 0;
            preview.PrintPreviewControl.Zoom = 1;
            preview.Size = new System.Drawing.Size(800, 800);
            preview.ShowDialog();
        }
       
        public void previewSales()
        {
            
            sales = true; balance = false; transaction = false; settled = false; sold = false;
            printPreviewControl.Document = printDocumentBal;    // 800, 800 = 8" x 8"
            printDocumentBal.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("SHORT", sWidth, sLength);
            printPreviewControl.Zoom = 1;
            printPreviewControl.StartPage = 0;
        }
        public void previewBalance()
        {
            
            balance = true; sales = false; transaction = false; settled = false; sold = false;
            printPreviewControlBal.Document = printDocumentBal;
            printDocumentBal.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("SHORT", sWidth, sLength);
            printPreviewControlBal.Zoom = 1;
            printPreviewControlBal.StartPage = 0;
        }
        public void previewTransHistReceipt()
        {
            int pLength = 1000;
            paperSizeUpdate(out pLength);
            printPreviewControlTransH.Document = printDocumentSales; 
            printDocumentSales.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("RECEIPT", 610, pLength);
            printPreviewControlTransH.Zoom = 1;
            printPreviewControlTransH.StartPage = 0;
        }
        public void previewSettledReceipt()
        {
            int pLength = 600;
            //paperSizeUpdate(out pLength);
            printPreviewControlSettledP.Document = printDocumentSettledReceipt; //
            printDocumentSettledReceipt.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("RECEIPT", 610, pLength);
            printPreviewControlSettledP.Zoom = 1;
            printPreviewControlSettledP.StartPage = 0;
        }
        public void changeDatePriorCurrent(DateTimePicker date)
        {
            date.Value = DateTime.Today.AddDays(-30);
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
            previewTransHistReceipt();
            //int pLength = 950;
            //paperSizeUpdate(out pLength);
            //printPreviewControlTransH.Document = printDocumentSales; //
            //printDocumentSales.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("RECEIPT", 610, pLength);
            //printPreviewControlTransH.Zoom = .6;
            //printPreviewControlTransH.StartPage = 0;
        }

        public void tblAvailedList(string transacNo, out int rowCount, out int rowCountDesc)
        {
            rowCount = 0; rowCountDesc = 0;
            try
            { 
                cn = new SqlConnection(dbcon.MyConnection());
            //Desc = ""; Price = ""; Quant = ""; Total = ""; UnitM = "";
            int count, rowCountAll = 0, quanti = 0; string des = "", UnitMe = "";
            double price = 0, total = 0;
            dupAll.Clear(); compAll.Clear();
            dupliAllInfo itmAll = new dupliAllInfo();
            compareAllInfo comp = new compareAllInfo();

            itmAll.Desc = " "; itmAll.UnitM = "";
            dupAll.Add(itmAll);

            comp.Desc = ""; comp.UnitM = "";
            compAll.Add(comp);

           //IList.Clear();
            cn.Open();
            //SqlCommand cm = new SqlCommand("SELECT Description, Price, Quantity, Total, Unit_Measure, COUNT(Description) FROM ViewCartStockItem WHERE Transaction_No LIKE '" + transacNo + "' GROUP BY Description, Price, Quantity, Total, Unit_Measure HAVING COUNT(Description) < 1", cn);
            SqlCommand cm = new SqlCommand("SELECT Description, Price, Quantity, Total, Unit_Measure FROM ViewCartStockItem WHERE Transaction_No LIKE '" + transacNo + "'", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                des = dr[0].ToString(); UnitMe = dr[4].ToString(); price = double.Parse(dr[1].ToString()); 
                total = double.Parse(dr[3].ToString()); quanti = int.Parse(dr[2].ToString());

                //comp.Desc = dr.GetString(0);//"Description"
                //comp.Price = dr.GetDouble(1);//"Price"
                //comp.Qty = dr.GetInt32(2);//"Quantity"
                //comp.Total = dr.GetDouble(3);//"Total"
                //comp.UnitM = dr.GetString(4);//"Unit_Measure"

                comp.Desc = des;//"Description"
                comp.Price = price;//"Price"
                comp.Qty = quanti;//"Quantity"
                comp.Total = total;//"Total"
                comp.UnitM = UnitMe;//"Unit_Measure"

                compAll.Add(comp);
                rowCount++;
                //rowCountAll++;

                if (!(itmAll.Desc.Contains(des)))
                {
                    //itmAll.Desc = dr.GetString(0);//"Description"
                    //itmAll.Price = dr.GetDouble(1);//"Price"
                    //itmAll.Qty = dr.GetInt32(2);//"Quantity"
                    //itmAll.UnitM = dr.GetString(4);//"Unit_Measure"
                    //itmAll.Total = dr.GetDouble(3);//"Total"

                    itmAll.Desc = des;//"Description"
                    itmAll.Price = price;//"Price"
                    itmAll.Qty = quanti;//"Quantity"
                    itmAll.UnitM = UnitMe;//"Unit_Measure"
                    itmAll.Total = total;//"Total"

                    dupAll.Add(itmAll);
                    rowCountDesc++;
                }

            }
            dr.Close();
            cn.Close();
                //duplicateFilter(transacNo, out rowCountDesc, out rowCountAll);
                //rowCountDesc = 2; rowCount = 4;
                // calcu(rowCountDesc, rowCount);
            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message, "tblAvailedList", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public class ItemList
        {
            public string Desc { get; set; }
            public double Price { get; set; }
            public int Qty { get; set; }
            public string UnitM { get; set; }
            public double Total { get; set; }
        }
        public void duplicateFilter(string transacNo, out int rowCountDesc, out int rowCountAll)
        {
            cn = new SqlConnection(dbcon.MyConnection());
            //Desc = ""; Price = ""; Quant = ""; Total = ""; UnitM = "";
            int count;
            //int rowCountDesc = 0, rowCountAll = 0;
            rowCountDesc = 0; rowCountAll = 0;
            cn.Open();
            SqlCommand cm = new SqlCommand("SELECT Description, COUNT(Description) FROM ViewCartStockItem WHERE Transaction_No LIKE '" + transacNo + "' GROUP BY Description HAVING COUNT(Description) > 1", cn);
            //SqlCommand cm = new SqlCommand("SELECT Description, Price, Quantity, Total, Unit_Measure FROM ViewCartStockItem WHERE Transaction_No LIKE '" + transacNo + "'", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                dupliDescription itmDesc = new dupliDescription();
                itmDesc.Desc = dr.GetString(0);//"Description"    
                dupDesc.Add(itmDesc);
                rowCountDesc++;
            }
            dr.Close();
            cn.Close();

            cn.Open();// a.Description, a.Price, a.Quantity, a.Total, a.Unit_Measure
             cm = new SqlCommand("SELECT Description, Price, Quantity, Total, Unit_Measure FROM ViewCartStockItem a WHERE (Description) IN (SELECT Description FROM ViewCartStockItem GROUP BY Description HAVING COUNT(*) > 1)", cn);
            //cm = new SqlCommand("SELECT a.Description, a.Price, a.Quantity, a.Total, a.Unit_Measure FROM ViewCartStockItem a JOIN (SELECT Description, Price, Quantity, Total, Unit_Measure, COUNT(Description) FROM ViewCartStockItem WHERE Transaction_No LIKE '" + transacNo + "' GROUP BY Description, Price, Quantity, Total, Unit_Measure HAVING COUNT(Description) > 1) b ON a.Description = b.Description WHERE Transaction_No LIKE '" + transacNo + "' ORDER BY a.Description", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                dupliAllInfo itmAll = new dupliAllInfo();
                itmAll.Desc = dr.GetString(0);//"Description"
                itmAll.Price = dr.GetDouble(1);//"Price"
                itmAll.Qty = dr.GetInt32(2);//"Quantity"
                itmAll.UnitM = dr.GetString(4);//"Unit_Measure"
                itmAll.Total = dr.GetDouble(3);//"Total"                
                dupAll.Add(itmAll);
                rowCountAll++;
            }
            dr.Close();
            cn.Close();

        }
        public void calcu(int rowCountDesc, int rowCountAll)
        {
            try
            {
                IList.Clear();
            string desc = "", all = "", unitM = "";
            int totalQuantity = 0, Quantity = 0; double totalPrice = 0, totalTotal = 0, Total = 0;
            for (int i = 0; i < rowCountDesc; i++)
            {
                ItemList itm = new ItemList();
                dupliAllInfo DescDup = dupAll[i];
                desc = DescDup.Desc;
                totalPrice = DescDup.Price;
                for (int j = 0; j < rowCountAll ; j++)
                {
                    compareAllInfo AllDup = compAll[j];
                    all = AllDup.Desc;
                    unitM = AllDup.UnitM;
                    Quantity = AllDup.Qty;
                    Total = AllDup.Total;
                    if (all == desc)
                    {
                        //totalPrice += AllDup.Price;
                        totalQuantity += Quantity;
                        totalTotal += Total;
                    }                                        
                }
                itm.Desc = desc;//"Description"
                itm.Price = totalPrice;//"Price"
                itm.Qty = totalQuantity;//"Quantity"
                itm.Total = totalTotal;//"Total"
                itm.UnitM = unitM;//"Unit_Measure"
                IList.Add(itm);
            }
            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message, "calcu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public class dupliDescription
        {
            public string Desc { get; set; }       
        }
        public class dupliAllInfo
        {     
            public string Desc { get; set; }
            public double Price { get; set; }
            public int Qty { get; set; }        
            public string UnitM { get; set; }
            public double Total { get; set; }
        }
        public class compareAllInfo
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
            string TransDate = "", PMode = "", Customer = "", NetT = "", Payment = "", Change = "", Cashier = "", oldTrans = "", newTrans = "";
            classReport.tblReceiptSettle(transNo, out TransDate, out PMode, out Customer, out NetT, out Payment, out Change, out Cashier, out oldTrans, out newTrans);


            int x = 0, y = 0; // num = 1; string resultText = ""; int dgvCount = int.Parse(lblRowCount.Text), dgvCountService = int.Parse(lblServRowCount.Text);

            System.Drawing.Font printFont = new System.Drawing.Font("Arial", 10, System.Drawing.FontStyle.Regular);
            System.Drawing.Font printFontBold = new System.Drawing.Font("Arial", 15, System.Drawing.FontStyle.Bold);
            System.Drawing.Font printFontItallic = new System.Drawing.Font("Arial", 12, System.Drawing.FontStyle.Italic);

            e.Graphics.DrawString("Bico-Jose Optical Clinic", printFontBold, Brushes.Black, 175, 30);
            e.Graphics.DrawString("Address: 3rd Floor Susana Mart, Tungko San Jose Del Monte Bulacan", printFont, Brushes.Black, 80, 60);
            e.Graphics.DrawString("Clinic's Contact: 09178326686", printFont, Brushes.Black, 185, 80);
            y = 140; x = 320;
            e.Graphics.DrawString("TIN: 748-219-944-00000", printFont, Brushes.Black, 20, y);//140
            e.Graphics.DrawString("Date Issued: ", printFont, Brushes.Black, (x += 60), y);
            e.Graphics.DrawString("Mode of Payment:  " + PMode, printFont, Brushes.Black, 20, (y += 30));//170
            e.Graphics.DrawString(TransDate, printFont, Brushes.Black, x, y);

            e.Graphics.DrawString("Cashier:  " + Cashier, printFont, Brushes.Black, x, (y += 30));//200
            e.Graphics.DrawString("Customer Name:  " + Customer, printFont, Brushes.Black, 20, y);//230
            e.Graphics.DrawString("--------------------------------------------------------------------------------------------------------------------------", printFont, Brushes.Black, 10, (y += 30));//260 or 290
            e.Graphics.DrawString("Invoice No: " + newTrans, printFont, Brushes.Black, 20, (y += 50));//310 or 340
            e.Graphics.DrawString("Balance Settlement for Transaction No:" + oldTrans, printFont, Brushes.Black, 20, (y += 50));//360 or 390
            //e.Graphics.DrawString("For Transaction No:" + oldTrans, printFont, Brushes.Black, 20, (y += 50));//360 or 390

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
            previewSettledReceipt();
        }

        
        public void paperSizeUpdate(out int paperL)
        {
            int dgvCount = 0, rowCountDesc = 0; transNo = lblCurrentTransN.Text;
            tblAvailedList(transNo, out dgvCount, out rowCountDesc);

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
            //pesoPaint = true;
            //dataGridViewBalR.Columns[3].HeaderText = "balance";
            //var eventArgs = new DataGridViewCellEventArgs(1, 3);
            //dataGridViewBalR_CellPainting(sender, eventArgs);
            
        }

        private void btnHistoryTransSett_Click(object sender, EventArgs e)
        {
            tabControlReports.TabPages.Clear();
            TabPage tab3 = new TabPage("TRANSACTION");
            tabControlReports.TabPages.Add(tab3);
            tab3.Controls.Add(panelSalesHistory);
            changeDatePriorCurrent(dateTimePickerStartTrans);
            classLoadData.LoadRecordsTransacHist(dataGridViewTransHist, txtSearchTransHist, dateTimePickerStartTrans, dateTimePickerEndTrans);
            checkForBlank(dataGridViewTransHist, out result);
            lblCurrentTransN.Text = result;
            previewTransHistReceipt();
            
            TabPage tab4 = new TabPage("SETTLED");
            tabControlReports.TabPages.Add(tab4);
            tab4.Controls.Add(panelSettled);
            classLoadData.LoadRecordsTransacSettled(dataGridViewSettle, txtSearchSettleds, dateTimePickerSettStart, dateTimePickerSettEnd);
            checkForBlank(dataGridViewSettle, out result);
            lblSettledID.Text = result;
            previewSettledReceipt();

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

            previewTransList();
            //PrintPreviewDialog preview = new PrintPreviewDialog();
            //transaction = true;
            //preview.Document = printDocumentBal;
            
            //printDocumentBal.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("SHORT", sWidth, sLength);

            //preview.PrintPreviewControl.StartPage = 0;
            
            ////
            //preview.PrintPreviewControl.Zoom = 0.75;
            //preview.Size = new System.Drawing.Size(900, 900);
            //preview.ShowDialog();
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

        private void dataGridViewBalR_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            void createGraphicsColumn()
            {
                var image = Properties.Resources.icons8_peso_symbol_24;
                
                    if (e.RowIndex != -1 && e.ColumnIndex == 3)
                    {
                        if ((e.PaintParts & DataGridViewPaintParts.Background) != DataGridViewPaintParts.None)
                        {
                            e.Graphics.DrawImage(image, e.CellBounds.Left, e.CellBounds.Top - 1, 27, 27);
                            //pesoPaint = true;
                        }
                        if (!e.Handled)
                        {
                            e.Handled = true;
                            e.PaintContent(e.CellBounds);
                        }

                        //pesoPaint = true;
                    }

                }

            //int u = 1; e.RowIndex != -1 && 
            //once++;
            //if (once > 0)
            //{
            //    //pesoPaint = true;
            //    createGraphicsColumn();
            //    once--;
            //}
            //lcreateGraphicsColumn();

            //pesoPaint = true;
            //if(lblCellPaint.Text == "Check")
            //{
            //    createGraphicsColumn();
            //    lblCellPaint.Text = "";
            //    pesoPaint = false;
            //}
            if (pesoPaint == true)
            {
                createGraphicsColumn();

                pesoPaint = false;
            }
            
            
            //else if (pesoPaint == false)
            //{
            //    e.Handled = true;
            //    e.PaintContent(e.CellBounds);
            //}

            //for(int i = 0; i< dataGridViewBalR.RowCount; i++)
            //{
            //    if (e.RowIndex == i && e.ColumnIndex == 3)
            //    {
            //        using (Image img = Image.FromFile(@"C:\Users\leomar\source\repos\BicoJosePOS\Icon\icons8-peso-symbol-24.png"))
            //        {
            //            e.Graphics.DrawImage(img, e.CellBounds.Left, e.CellBounds.Top - 1, 27, 27);

            //            e.PaintContent(e.ClipBounds);
            //            e.Handled = true;
            //        }
            //    }

            //}

        }
     
      
        private void dataGridViewSalesR_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
          
        }

        private void dataGridViewBalR_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            pesoPaint = false;
            
        }

        private void dataGridViewBalR_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
           pesoPaint = true;
        }

        private void dataGridViewBalR_ColumnHeaderCellChanged(object sender, DataGridViewColumnEventArgs e)
        {
            //lblSettledID.Visible = true;
            //lblSettledID.Text = "bala";
            //pesoPaint = true;
        }

        private void btnPreviewSold_Click(object sender, EventArgs e)
        {
            previewSoldList();
        }

        private void txtSearchTransHist_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtSearchTransHist.Text == String.Empty)
                {
                    classLoadData.LoadRecordsTransacHist(dataGridViewTransHist, txtSearchTransHist, dateTimePickerStartTrans, dateTimePickerEndTrans);

                    return;
                }
                else
                {
                    classLoadData.LoadRecordsTransacHist(dataGridViewTransHist, txtSearchTransHist, dateTimePickerStartTrans, dateTimePickerEndTrans);

                }
            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message, title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtSearchSold_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtSearchSold.Text == String.Empty)
                {
                    classLoadData.LoadRecordsSoldItems(dataGridViewSoldItems, txtSearchSold, dateTimePickerStartSold, dateTimePickerEndSold);
                    return;
                }
                else
                {
                    classLoadData.LoadRecordsSoldItems(dataGridViewSoldItems, txtSearchSold, dateTimePickerStartSold, dateTimePickerEndSold);
                }
            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message, title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtSearchSettleds_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtSearchSettleds.Text == String.Empty)
                {
                    classLoadData.LoadRecordsTransacSettled(dataGridViewSettle, txtSearchSettleds, dateTimePickerSettStart, dateTimePickerSettEnd);
                    return;
                }
                else
                {
                    classLoadData.LoadRecordsTransacSettled(dataGridViewSettle, txtSearchSettleds, dateTimePickerSettStart, dateTimePickerSettEnd);

                }
            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message, title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dateTimePickerEndSold_ValueChanged(object sender, EventArgs e)
        {
            classLoadData.LoadRecordsSoldItems(dataGridViewSoldItems, txtSearchSold, dateTimePickerStartSold, dateTimePickerEndSold);
        }

        private void dateTimePickerStartSold_ValueChanged(object sender, EventArgs e)
        {
            classLoadData.LoadRecordsSoldItems(dataGridViewSoldItems, txtSearchSold, dateTimePickerStartSold, dateTimePickerEndSold);
        }

        private void dateTimePickerEndTrans_ValueChanged(object sender, EventArgs e)
        {
            classLoadData.LoadRecordsTransacHist(dataGridViewTransHist, txtSearchTransHist, dateTimePickerStartTrans, dateTimePickerEndTrans);

        }

        private void dateTimePickerStartTrans_ValueChanged(object sender, EventArgs e)
        {
            classLoadData.LoadRecordsTransacHist(dataGridViewTransHist, txtSearchTransHist, dateTimePickerStartTrans, dateTimePickerEndTrans);

        }

        private void dateTimePickerSettEnd_ValueChanged(object sender, EventArgs e)
        {
            classLoadData.LoadRecordsTransacSettled(dataGridViewSettle, txtSearchSettleds, dateTimePickerSettStart, dateTimePickerSettEnd);

        }

        private void dateTimePickerSettStart_ValueChanged(object sender, EventArgs e)
        {
            classLoadData.LoadRecordsTransacSettled(dataGridViewSettle, txtSearchSettleds, dateTimePickerSettStart, dateTimePickerSettEnd);

        }

        private void btnPreviewSettl_Click(object sender, EventArgs e)
        {
            previewSettledList();
        }

        private void dataGridViewBalR_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            //pesoPaint = true;
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
           
            this.dataGridViewBalR.Columns["ba"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            this.dataGridViewSoldItems.Columns["Price"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
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
