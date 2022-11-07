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
    public partial class frmEditOrder : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        ClassGenerateID classGenerateID = new ClassGenerateID();
        ClassPaymentOrderMonitoring classLoad = new ClassPaymentOrderMonitoring();
        ClassReports classReport = new ClassReports();
        List<ItemList> List = new List<ItemList>();
        SqlDataReader dr;
        string title = "BICO-JOSE System", transNo = "";
        frmPaymentStatus frmL;
        private bool mouseDown;
        private Point lastLocation;
        public frmEditOrder(frmPaymentStatus frmL)
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
            this.frmL = frmL;
            previewItems();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnCloseAccessories_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSaveOrder_Click(object sender, EventArgs e)
        {
            string releaseBy = txtReleaseBy.Text;
            string claimDate = dateTimePickerClaimDate.Value.ToShortDateString();
            string TransNo = lblTransNo.Text;
            try
            {
                if (MessageBox.Show("Are you sure you want to save this record?", title, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cn.Open();
                    cm = new SqlCommand("UPDATE tblOrderStatus SET Status = 'Claimed', Release_By = @Release_By, Date_Claimed = @Date_Claimed WHERE Transaction_No LIKE '" + TransNo + "'", cn);
                    cm.Parameters.AddWithValue("@Release_By", releaseBy);
                    cm.Parameters.AddWithValue("@Date_Claimed", claimDate);
                    
                    cm.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Record has been successfully saved.");
                    
                    this.Close();
                }
                classLoad.LoadRecordsOrder(frmL.dataGridViewOrderStatus, frmL.txtSearchOrderStatus);
                classLoad.LoadRecordsOrderClaimed(frmL.dataGridViewArrival, frmL.txtSearchArrival);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnArrival_Click(object sender, EventArgs e)
        {
            string receivedBy = txtReceivedBy.Text;
            string arrivedDate = dateTimePickerArrival.Value.ToString();
            string TransNo = lblTrans.Text;
            try
            {
                if (MessageBox.Show("Are you sure you want to save this record?", title, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cn.Open();
                    cm = new SqlCommand("UPDATE tblOrderStatus SET Status = 'Arrived', Received_By = @Received_By, Arrival_Date = @Date_Arrived WHERE Transaction_No LIKE '" + TransNo + "'", cn);
                    cm.Parameters.AddWithValue("@Received_By", receivedBy);
                    cm.Parameters.AddWithValue("@Date_Arrived", arrivedDate);

                    cm.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Record has been successfully saved.");

                    this.Close();
                }
                classLoad.LoadRecordsOrder(frmL.dataGridViewOrderStatus, frmL.txtSearchOrderStatus);
                classLoad.LoadRecordsOrderArrived(frmL.dataGridViewArrival, frmL.txtSearchArrival);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public void previewItems()
        {
            printPreviewControlArvl.Document = printDocumentAr; //
            printDocumentAr.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("ORDER", 610, 400);
            printPreviewControlArvl.Zoom = 1;
            printPreviewControlArvl.StartPage = 0;
        }
        private void printDocumentAr_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            transNo = lblTrans.Text; int ITMrowCount = 0; int SrowCount = 0;
            string TransDate = "", PMode = "", PTerms = "", Customer = "", GrossT = "", Discoun = "", NetT = "", Payment = "", Balance = "", Change = "", DisPerc = "", SettledDate = "", Cashier = "";
            classReport.tblReceiptValue(transNo, out TransDate, out PMode, out PTerms, out Customer, out GrossT, out Discoun, out NetT, out Payment, out Balance, out Change, out DisPerc, out SettledDate, out Cashier, out ITMrowCount);

            int x = 0, y = 0, num = 1;
            System.Drawing.Font printFont = new System.Drawing.Font("Arial", 10, System.Drawing.FontStyle.Regular);
            System.Drawing.Font printFontBold = new System.Drawing.Font("Arial", 15, System.Drawing.FontStyle.Bold);
            System.Drawing.Font printFontItallic = new System.Drawing.Font("Arial", 12, System.Drawing.FontStyle.Italic);
             x = 370;
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
                    ItemList Itms = List[i];
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
        }
        public void tblAvailedList(string transacNo, out int rowCount)
        {
            cn = new SqlConnection(dbcon.MyConnection());
            //Desc = ""; Price = ""; Quant = ""; Total = ""; UnitM = "";
            rowCount = 0; List.Clear();
            cn.Open();
            SqlCommand cm = new SqlCommand("SELECT Description, Price, Quantity, Total, Unit_Measure FROM ViewCartStockItem WHERE Transaction_No LIKE '" + transacNo + "'", cn);
            dr = cm.ExecuteReader();

            while (dr.Read())
            {
                ItemList IList = new ItemList();
                IList.Desc = dr.GetString(0);//"Description"
                IList.Price = dr.GetDouble(1);//"Price"
                IList.Qty = dr.GetInt32(2);//"Quantity"
                IList.Total = dr.GetDouble(3);//"Total"
                IList.UnitM = dr.GetString(4);//"Unit_Measure"
                List.Add(IList);
                rowCount++;

            }
            dr.Close();
            cn.Close();
            //rowCount = List.Count;
        }

        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void panel3_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void panel3_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
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

    }
}
