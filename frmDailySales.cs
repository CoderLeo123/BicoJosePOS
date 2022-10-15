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
namespace Capstone
{
    public partial class frmDailySales : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        SqlDataReader dr;
        ClassLoadData classLoadData = new ClassLoadData();
        ClassReports classReport = new ClassReports();
        string title = "BICO-JOSE System", transNo = "";
        
        public frmDailySales()
        {
            InitializeComponent();
            changeDatePriorCurrent(dateTimePickerStartSold);
            changeDatePriorCurrent(dateTimePickerStartTrans);
            classLoadData.LoadRecordsTransacHist(dataGridViewTransacHist, txtSearchTransac, dateTimePickerStartTrans, dateTimePickerEndTrans);
            classLoadData.LoadRecordsSoldItems(dataGridViewSoldItems, txtSearchSold, dateTimePickerStartSold, dateTimePickerEndSold);
        }
        public void changeDatePriorCurrent(DateTimePicker date)
        {
            date.Value = DateTime.Today.AddDays(-3);
        }

        private void btnCloseDailySales_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridViewTransacHist_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            lblCurrentTransN.Text = dataGridViewTransacHist.Rows[e.RowIndex].Cells[2].Value.ToString();

            PrintPreviewDialog preview = new PrintPreviewDialog();
            preview.Document = printDocument;
            int pLength = 920;
            paperSizeUpdate(out pLength);
            printDocument.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("RECEIPT", 500, pLength);
            preview.PrintPreviewControl.Zoom = 0.75;
            preview.Size = new System.Drawing.Size(400, 650);
            preview.ShowDialog();
        }

        private void dataGridViewSoldItems_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void printDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            transNo = lblCurrentTransN.Text; int ITMrowCount = 0; int SrowCount = 0;
            string TransDate = "", PMode = "", PTerms = "", Customer = "", GrossT = "", Discoun = "", NetT = "", Payment = "", Balance = "", Change = "", DisPerc = "", SettledDate = "", Cashier = "";
            classReport.tblReceiptValue(transNo, out TransDate, out PMode, out PTerms, out Customer, out GrossT, out Discoun, out NetT, out Payment, out Balance, out Change, out DisPerc, out SettledDate, out Cashier, out ITMrowCount);
            string Desc = "", Price = "", Quant = "", Total = "", UnitM = "";
            classReport.tblAvailedList(transNo, out Desc, out Price, out Quant, out Total, out UnitM);
            string SName = "", SPrice = "";
            classReport.tblServiceAvailedList(transNo, out SName, out SPrice);

            int x = 0, y = 0, num = 1; //string resultText = ""; //int dgvCount = int.Parse(lblRowCount.Text);
            System.Drawing.Font printFont = new System.Drawing.Font("Arial", 10, System.Drawing.FontStyle.Regular);
            System.Drawing.Font printFontBold = new System.Drawing.Font("Arial", 15, System.Drawing.FontStyle.Bold);
            System.Drawing.Font printFontItallic = new System.Drawing.Font("Arial", 12, System.Drawing.FontStyle.Italic);
            e.Graphics.DrawString("Bico-Jose Optical Clinic", printFontBold, Brushes.Black, 130, 30);
            e.Graphics.DrawString("Address: 3rd Floor Susana Mart, Tungko San Jose Del Monte Bulacan", printFont, Brushes.Black, 30, 80);
            y = 140; x = 320;
            e.Graphics.DrawString("Clinic's Contact: 09178326666", printFont, Brushes.Black, 20, y);//140
            e.Graphics.DrawString("Date Issued: ", printFont, Brushes.Black, (x += 50), y);
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

            if (ITMrowCount > 0)
            {
                for (int i = 0; i < ITMrowCount; i++)
                {
                    x = 320;
                    e.Graphics.DrawString(num.ToString(), printFont, Brushes.Black, 20, (y += 30));//330

                    //Description
                    e.Graphics.DrawString(Desc, printFont, Brushes.Black, 60, y);

                    //Price
                    e.Graphics.DrawString(Price, printFont, Brushes.Black, x, y);

                    //Qty
                    e.Graphics.DrawString(Quant, printFont, Brushes.Black, (x += 60), y);

                    //Unit
                    e.Graphics.DrawString(UnitM, printFont, Brushes.Black, (x += 50), y);

                    //Total
                    e.Graphics.DrawString(Total, printFont, Brushes.Black, (x += 50), y);//330
                    num += 1;
                }
            }
            x = 320;
            //y = 430;
            if (SrowCount > 0)
            {
                for (int i = 0; i < SrowCount; i++)
                {

                }
            }
            e.Graphics.DrawString("Service:  ", printFont, Brushes.Black, 20, (y += 50));//430 + 50
            
            e.Graphics.DrawString(SName, printFont, Brushes.Black, 60, (y += 30));//470      Name
            
            e.Graphics.DrawString(SPrice, printFont, Brushes.Black, x, y);//320   Price
            //y = 550;
            e.Graphics.DrawString("Total Amount: ", printFont, Brushes.Black, 20, (y += 80));//550
            e.Graphics.DrawString(GrossT, printFont, Brushes.Black, (x += 70), y);//390 

            e.Graphics.DrawString("Discount: ", printFont, Brushes.Black, 20, (y += 30));
            e.Graphics.DrawString(Discoun, printFont, Brushes.Black, x, y);//370
            //getValueIfAnyElseBlank(frmC.dataGridViewCart, out resultText, 0, 5);//frmC.dataGridViewCart.Rows[0].Cells[5].Value.ToString()
            e.Graphics.DrawString("(" + Discoun + "%)", printFont, Brushes.Black, (x -= 70), y);//320

            e.Graphics.DrawString("Total Due: ", printFont, Brushes.Black, 20, (y += 30));
            e.Graphics.DrawString(NetT, printFont, Brushes.Black, (x += 70), y);

            e.Graphics.DrawString("Amount Tendered: ", printFont, Brushes.Black, 20, (y += 30));
            e.Graphics.DrawString(Payment, printFont, Brushes.Black, x, y);

            if (PTerms.Equals("Deposit"))
            {
                e.Graphics.DrawString("Remaining Balance: ", printFont, Brushes.Black, 20, (y += 30));
                e.Graphics.DrawString(Balance, printFont, Brushes.Black, x, y);

                e.Graphics.DrawString("Change: ", printFont, Brushes.Black, 20, (y += 30));
                e.Graphics.DrawString("-", printFont, Brushes.Black, x, y);//710

            }
            else
            {
                e.Graphics.DrawString("Remaining Balance: ", printFont, Brushes.Black, 20, (y += 30));
                e.Graphics.DrawString("-", printFont, Brushes.Black, x, y);

                e.Graphics.DrawString("Change: ", printFont, Brushes.Black, 20, (y += 30));
                e.Graphics.DrawString(Change, printFont, Brushes.Black, x, y);//710

            }



            e.Graphics.DrawString("THIS INVOICE/RECEIPT SHALL BE VALID FOR", printFontItallic, Brushes.Black, 60, (y += 60));//770
            e.Graphics.DrawString("ONE (1)) WEEK FROM THE DATE OF THE PERMIT TO USE", printFontItallic, Brushes.Black, 20, (y += 30));//800
            e.Graphics.DrawString("THANKYOU", printFontBold, Brushes.Black, 180, (y += 30));//830

        }
        public void paperSizeUpdate(out int paperL)
        {
            int dgvCount = 0;// int.Parse(lblRowCount.Text);
            paperL = 0;
            if (dgvCount > 0 && dgvCount <= 4)
            {
                paperL = 920;
            }
            else if (dgvCount > 4 && dgvCount <= 7)// + 3 items = 30 * 3 = 90
            {
                paperL = 1020;
            }
            else if (dgvCount > 7 && dgvCount <= 10)// + 3 items = 30 * 3 = 90
            {
                paperL = 1110;
            }
            else if (dgvCount > 10 && dgvCount <= 13)// + 3 items = 30 * 3 = 90
            {
                paperL = 1200;
            }
            else
            {
                paperL = 920;
            }

        }
    }
}
