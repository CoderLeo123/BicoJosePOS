using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.SQLite;
namespace Capstone
{
    public partial class frmFinalReceipt : Form
    {
        SQLiteConnection cn = new SQLiteConnection();
        SQLiteCommand cm = new SQLiteCommand();
        DBConnection dbcon = new DBConnection();
        SQLiteDataReader dr;
        ClassGenerateID classGenerateID = new ClassGenerateID();
        ClassLoadData classLoadData = new ClassLoadData();
        ClassPatientTransaction classPatient = new ClassPatientTransaction();
        string title = "BICO-JOSE System";
        string pID = "", prescID = "", transNo = "", oldTrans = "";
        public frmFinalReceipt()
        {
            InitializeComponent();
            //pID = lblPatientID.Text; prescID = lblPrescriptNo.Text; transNo = lblTransNo.Text; oldTrans = lblOldTransNo.Text;
            //displayValue(pID, prescID, transNo, oldTrans);
        }
        private Bitmap memorying;
        public void Print(Panel pnl)
        {
            PrinterSettings ps = new PrinterSettings();
            panelReceipt = pnl;
            getPrintArea(pnl);
            printPreviewDialog.Document = printDocument;
            printDocument.PrintPage += new PrintPageEventHandler(printDocument_PrintPage);
            printPreviewDialog.ShowDialog();
        }
        public void getPrintArea(Panel pnl)
        {
            memorying = new Bitmap(pnl.Width, pnl.Height);
            pnl.DrawToBitmap(memorying, new Rectangle(0, 0, pnl.Width, pnl.Height));
        }
        private void btnPrint_Click(object sender, EventArgs e)
        {
            Print(this.panelReceipt);
        }

        private void printDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Rectangle pageArea = e.PageBounds; //(pageArea.Width / 2) - (this.panelReceipt.Width / 2), this.panelReceipt.Location.Y
            e.Graphics.DrawImage(memorying, 0, this.panelReceipt.Location.Y);
        }

        public void displayValue(string pID, string prescID, string transNo, string oldTrans, string transType)
        {
            //pID = lblPatientID.Text; prescID = lblPrescriptNo.Text; transNo = lblTransNo.Text; oldTrans = lblOldTransNo.Text; transType = lblTransType.Text;
            string FullName = "", Address = "", Phone = "", Age = "", Date = "", Note = "", DueDate = "";
            string FramePrice = "0.00", LensPrice = "0.00", TotalCost = "0.00", NetTotal = "0.00", Deposit = "0.00", Balance = "0.00", Discount = "0.00";
            int FRowCount = 1, LRowCount = 1, Frameheight = 85, WholeHeight = 247, frm = 892;
            classPatient.LoadPatientDetails(pID, out FullName, out Address, out Phone, out Age, out Date, out Note);
            classPatient.LoadPrescription(dataGridViewPresc, prescID);
            
            lblName.Text = FullName;
            lblAddress.Text = Address;
            lblPhone.Text = Phone;
            lblAge.Text = Age;
            lblDate.Text = Date;
            lblNote.Text = Note;

            classPatient.LoadItems(dataGridViewItems, transNo, out FRowCount);
            classPatient.LoadLense(dataGridViewLense, transNo, out LRowCount);
            determinPanelFormHeight(FRowCount, out Frameheight, out WholeHeight, out frm, Frameheight, WholeHeight, frm);
            changePanelFormSize(Frameheight, WholeHeight, frm, 0);

            determinPanelFormHeight(LRowCount, out Frameheight, out WholeHeight, out frm, Frameheight, WholeHeight, frm);
            changePanelFormSize(Frameheight, WholeHeight, frm, 1);

            if (transType == "Regular")
            {                
                classPatient.LoadTransaction(transNo, out FramePrice, out LensPrice, out TotalCost, out NetTotal, out Deposit, out Balance, out Discount, out DueDate);
            }
            else if (transType == "Settlement")
            {
                lblTotalText.Text = "Due Balance:"; lblDepositText.Text = "Payment:"; lblDueDateText.Text = "SETTLED DATE:";
                classPatient.LoadSettled(oldTrans, out TotalCost, out Deposit, out DueDate);                
            }           

            lblFrame.Text = "₱ " + FramePrice;
            lblLens.Text = "₱ " + LensPrice;
            lblTotalCost.Text = "₱ " + TotalCost;
            lblDiscount.Text = "₱ " + Discount;
            lblNetTotal.Text = "₱ " + NetTotal;
            lblDeposit.Text = "₱ " + Deposit;
            lblBalance.Text = "₱ " + Balance;
            lblDueDate.Text = DueDate;

        }
        public void determinPanelFormHeight(int RowCount, out int Frameheight, out int WholeHeight, out int frm, int currFrame, int currWhole, int currFrm)
        {//Frame = 517, 85; NoteDue = 517, 85; Lens = 517, 77; whole = 517, 247; frm = 1177, 892;
            //Frameheight = 85; WholeHeight = 247; frm = 892;
            int temp = 35;
            Frameheight = currFrame- temp; WholeHeight = currWhole - temp; frm = currFrm - temp;
            int offset = 0;
            for (int i = 1; i < 10; i++)
            {
                if (RowCount == i)
                {
                    offset += (temp * i);
                    Frameheight += offset; WholeHeight += offset; frm += offset;                    
                    break;
                }
            }
        }
        public void changePanelFormSize(int Frameheight, int WholeHeight, int frm, int check)
        {
            if(check == 0)
            {
                panelFrame.Size = new Size(517, Frameheight);              
                panelWhole.Size = new Size(517, WholeHeight);
                this.Size = new Size(1036, frm);
            }
            else if (check == 1)
            {                
                //panelDueNote.Size = new Size(517, Frameheight);
                panelWhole.Size = new Size(517, WholeHeight);
                this.Size = new Size(1036, frm);
            }            
        }
        
        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
//if (RowCount == 1)
//{
//    Frameheight = 85; WholeHeight = 247; frm = 892;
//}
//else if (RowCount == 2)
//{
//    Frameheight += 15; WholeHeight += 15; frm += 15;
//}
//else if (RowCount == 3)
//{
//    Frameheight += 30; WholeHeight += 30; frm += 30;
//}
//else if (RowCount == 4)
//{
//    Frameheight += 45; WholeHeight += 45; frm += 45;
//}
//else if (RowCount == 5)
//{
//    Frameheight += 60; WholeHeight += 60; frm += 60;
//}