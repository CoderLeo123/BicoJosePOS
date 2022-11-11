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
    public partial class frmPaymentStatus : Form
    {
        SqlConnection cn = new SqlConnection();
        //SqlCommand cm = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        SqlDataReader dr;
        ClassPaymentOrderMonitoring classLoad = new ClassPaymentOrderMonitoring();
        ClassReports classReport = new ClassReports();
        List<ItemList> List = new List<ItemList>();
        string title = "BICO-JOSE System"; string transNo = "";
        public frmPaymentStatus()
        {
            cn = new SqlConnection(dbcon.MyConnection());
            InitializeComponent();
            classLoad.LoadRecordsSettled(dataGridViewSettled, txtSearchSettled);
            classLoad.LoadRecordsUnsettled(dataGridViewPaymentStat, txtSearchPending);
            classLoad.LoadRecordsOrder(dataGridViewOrderStatus, txtSearchOrderStatus);
            classLoad.LoadRecordsOrderClaimed(dataGridViewArrival, txtSearchArrival);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            //this.Dispose();
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


        public void checkWhatIsPress(bool btnReO, bool btnCrit)
        {
            if (btnReO == true)
            {
                colorChange(true, btnPayment); colorChange(false, btnOrder);
            }
            else if (btnCrit == true)
            {
                colorChange(true, btnOrder); colorChange(false, btnPayment);
            }
            
        }
        private void dataGridViewOrderStatus_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dataGridViewOrderStatus.Columns[e.ColumnIndex].Name;
            transNo = dataGridViewOrderStatus.Rows[e.RowIndex].Cells[1].Value?.ToString();
            lblCurrentTransN.Text = dataGridViewOrderStatus.Rows[e.RowIndex].Cells[1].Value?.ToString();
            if (colName == "Ed")
            {
                frmEditOrder frm = new frmEditOrder(this);
                frm.tabControlEditOrder.TabPages.Clear();
                frm.Size = new Size(763, 678);
                TabPage tab = new TabPage("Arrival");
                frm.tabControlEditOrder.TabPages.Add(tab);
                tab.Controls.Add(frm.panelArrived);
                frm.txtReceivedBy.Text = lblUser.Text;
                frm.lblTrans.Text = transNo;
                frm.ShowDialog();

           
            }
            else
            {
                PrintPreviewDialog preview = new PrintPreviewDialog();
                preview.Document = printDocumenItems;
                int pLength = 700;
                //paperSizeUpdate(out pLength);
                printDocumenItems.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("RECEIPT", 620, pLength);
                preview.PrintPreviewControl.Zoom = 0.75;
                preview.Size = new System.Drawing.Size(450, 500);
                preview.ShowDialog();
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
        public class ItemList
        {
            public string Desc { get; set; }
            public double Price { get; set; }
            public int Qty { get; set; }
            public string UnitM { get; set; }
            public double Total { get; set; }
        }
        private void printDocumenItems_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            transNo = lblCurrentTransN.Text; int ITMrowCount = 0; int SrowCount = 0;
            string TransDate = "", PMode = "", PTerms = "", Customer = "", GrossT = "", Discoun = "", NetT = "", Payment = "", Balance = "", Change = "", DisPerc = "", SettledDate = "", Cashier = "";
            classReport.tblReceiptValue(transNo, out TransDate, out PMode, out PTerms, out Customer, out GrossT, out Discoun, out NetT, out Payment, out Balance, out Change, out DisPerc, out SettledDate, out Cashier, out ITMrowCount);

           

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

        private void btnPayment_Click(object sender, EventArgs e)
        {
            tabControlPayOrdStatus.TabPages.Clear();
            TabPage tab = new TabPage("Payment Status");
            tabControlPayOrdStatus.TabPages.Add(tab);
            tab.Controls.Add(panelPayment);
            classLoad.LoadRecordsSettled(dataGridViewSettled, txtSearchSettled);
            classLoad.LoadRecordsUnsettled(dataGridViewPaymentStat, txtSearchPending);            
            checkWhatIsPress(true, false);
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            tabControlPayOrdStatus.TabPages.Clear();
            TabPage tab = new TabPage("Order Status");
            tabControlPayOrdStatus.TabPages.Add(tab);
            tab.Controls.Add(panelOrder);            
            classLoad.LoadRecordsOrder(dataGridViewOrderStatus, txtSearchOrderStatus);
            classLoad.LoadRecordsOrderArrived(dataGridViewArrival, txtSearchArrival);

            TabPage tab2 = new TabPage("Claimed Order");
            tabControlPayOrdStatus.TabPages.Add(tab2);
            tab2.Controls.Add(panelClaimed);
            classLoad.LoadRecordsOrderClaimed(dataGridViewClaimed, txtSearchClaimed);
            checkWhatIsPress(false, true);
        }
        public void LoadRecordsUnsettled(string transno, out string Balance)
        {//dataGridViewProduct, txtSearchProduct
            cn = new SqlConnection(dbcon.MyConnection());
            //int i = 0;
            Balance = "";
            cn.Open();
            SqlCommand cm = new SqlCommand("SELECT * FROM ViewPaymentCart WHERE Transaction_No LIKE '"+ transno + "'", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {

                Balance = dr[5].ToString();
                //                              2-NAME / 2-Customer                             4-DEPOSIT/ 4-Initial_Deposit                 6-DUE DATE/ 6-Due_Date                8-STATUS / 8-Status
                //i += 1; //0-#  1-TRANS NO / 1-Transaction_No         3-PAYMENT / 3-Total_Payment                         5-BALANCE/ 5-Rem_Balance            7-CASHIER / 7-Cashier
                //dgv.Rows.Add(i, dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString(), dr[6].ToString(), dr[7].ToString(), dr[8].ToString());
            }
            dr.Close();
            cn.Close();
        }
        private void dataGridViewArrival_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string pStat = dataGridViewArrival.Rows[e.RowIndex].Cells[6].Value?.ToString();
            string CustName = dataGridViewArrival.Rows[e.RowIndex].Cells[2].Value?.ToString();
            string Cashier = lblCashier.Text;
            string Balance = "";
            string colName = dataGridViewArrival.Columns[e.ColumnIndex].Name;
            transNo = dataGridViewArrival.Rows[e.RowIndex].Cells[1].Value?.ToString();
            LoadRecordsUnsettled(transNo, out Balance);
            lblCurrentTransN.Text = dataGridViewArrival.Rows[e.RowIndex].Cells[1].Value?.ToString();
            if (colName == "Edi")
            {
                frmEditOrder frm = new frmEditOrder(this);
                frm.tabControlEditOrder.TabPages.Clear();
                frm.Size = new Size(763, 450);
                TabPage tab = new TabPage("Item Release");
                frm.tabControlEditOrder.TabPages.Add(tab);
                tab.Controls.Add(frm.panelClaimed);
                frm.txtReleaseBy.Text = lblUser.Text;
                frm.lblTransNo.Text = transNo;
                frm.txtPaymentStatus.Text = pStat;

                frm.lblName.Text = CustName;
                frm.lblSettleTrans.Text = transNo;
                frm.lblBalance.Text = Balance;
                frm.lblCashier.Text = Cashier;

                if (pStat != "Settled")
                {
                    frm.btnSaveOrder.Enabled = false;
                    frm.btnSettle.Enabled = true;
                }
                else
                {
                    frm.btnSettle.Enabled = false;
                    frm.btnSaveOrder.Enabled = true;
                }

                frm.ShowDialog();
            }

        }

        private void txtSearchPending_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtSearchPending.Text == String.Empty)
                {
                    classLoad.LoadRecordsUnsettled(dataGridViewPaymentStat, txtSearchPending);
                    return;
                }
                else
                {
                    classLoad.LoadRecordsUnsettled(dataGridViewPaymentStat, txtSearchPending);
                }
            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message, title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtSearchSettled_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtSearchSettled.Text == String.Empty)
                {
                    classLoad.LoadRecordsSettled(dataGridViewSettled, txtSearchSettled);
                    return;
                }
                else
                {
                    classLoad.LoadRecordsSettled(dataGridViewSettled, txtSearchSettled);
                }
            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message, title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtSearchOrderStatus_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtSearchOrderStatus.Text == String.Empty)
                {
                    classLoad.LoadRecordsOrder(dataGridViewOrderStatus, txtSearchOrderStatus); return;
                }
                else
                {
                    classLoad.LoadRecordsOrder(dataGridViewOrderStatus, txtSearchOrderStatus);
                }
            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message, title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtSearchArrival_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtSearchArrival.Text == String.Empty)
                {
                    classLoad.LoadRecordsOrderArrived(dataGridViewArrival, txtSearchArrival);
                    return;
                }
                else
                {
                    classLoad.LoadRecordsOrderArrived(dataGridViewArrival, txtSearchArrival);
                }
            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message, title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtSearchClaimed_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtSearchClaimed.Text == String.Empty)
                {
                    classLoad.LoadRecordsOrderClaimed(dataGridViewClaimed, txtSearchClaimed);
                    return;
                }
                else
                {
                    classLoad.LoadRecordsOrderClaimed(dataGridViewClaimed, txtSearchClaimed);
                }
            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message, title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
