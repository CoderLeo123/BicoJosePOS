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
namespace Capstone
{
    public partial class frmFinalReceipt : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        SqlDataReader dr;
        ClassGenerateID classGenerateID = new ClassGenerateID();
        ClassLoadData classLoadData = new ClassLoadData();
        ClassPatientTransaction classPatient = new ClassPatientTransaction();
        string title = "BICO-JOSE System";
        string pID = "", prescID = "", transNo = "";
        public frmFinalReceipt()
        {
            InitializeComponent();
            pID = lblPatientID.Text; prescID = lblPrescriptNo.Text; transNo = lblTransNo.Text;
            displayValue(pID, prescID, transNo);
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

        public void displayValue(string pID, string prescID, string transNo)
        {
            string transType = lblTransType.Text;
            pID = lblPatientID.Text; prescID = lblPrescriptNo.Text; transNo = lblTransNo.Text;
            string FullName = "", Address = "", Phone = "", Age = "", Date = "", Note = "", DueDate = "";
            string FramePrice = "₱ 0.00", LensPrice = "₱ 0.00", TotalCost = "", NetTotal = "₱ 0.00", Deposit = "", Balance = "₱ 0.00", Discount = "₱ 0.00";

            classPatient.LoadPatientDetails(pID, out FullName, out Address, out Phone, out Age, out Date, out Note);
            classPatient.LoadPrescription(dataGridViewPresc, prescID);
            classPatient.LoadItems(dataGridViewItems, transNo);
            classPatient.LoadLense(dataGridViewLense, transNo);

            lblName.Text = FullName;
            lblAddress.Text = Address;
            lblPhone.Text = Phone;
            lblAge.Text = Age;
            lblDate.Text = Date;
            lblNote.Text = Note;
            lblDueDate.Text = DueDate;

            if (transType == "Regular")
            {

                classPatient.LoadTransaction(transNo, out FramePrice, out LensPrice, out TotalCost, out NetTotal, out Deposit, out Balance, out Discount);
                
            }
            else if (transType == "Settled")
            {
                classPatient.LoadSettled(transNo, out TotalCost, out Deposit);
            }
            lblFrame.Text = "₱ "+FramePrice;
            lblLens.Text = "₱ " + LensPrice;
            lblTotalCost.Text = "₱ " + TotalCost;
            lblDiscount.Text = "₱ " + Discount;
            lblNetTotal.Text = "₱ " + NetTotal;
            lblDeposit.Text = "₱ " + Deposit;
            lblBalance.Text = "₱ " + Balance;
        }
        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
 