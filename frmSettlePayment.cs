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
    public partial class frmSettlePayment : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        SqlDataReader dr;
        ClassLoadData classLoadData = new ClassLoadData();
        ClassGenerateID classGenerateID = new ClassGenerateID();
        ClassInventory classInventory = new ClassInventory();
        ClassPaymentOrderMonitoring classPayment = new ClassPaymentOrderMonitoring();
        string title = "BICO-JOSE System";
        double num = 0, curr = 0;
        private bool mouseDown;
        private Point lastLocation;
        frmCashier frmC;


        public frmSettlePayment(frmCashier frm)
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
            frmC = frm;
            dateTimePickerDueDate.Value = DateTime.Today.AddDays(3);
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnCloseDiscount_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void computeChange(TextBox total, TextBox Payment, TextBox changeText)
        {//txtTotal, txtPayment, txtChange
            try
            {
                double sales = double.Parse(total.Text);
                double payment = double.Parse(Payment.Text);
                double change = 0;
                if (Payment.Text == string.Empty)
                {
                    Payment.Text = "0";
                    Payment.SelectAll();
                }else
                {
                    change = payment - sales;
                    changeText.Text = change.ToString("00.00");
                    lblPaymentNotice.Visible = false;
                }
            }
            catch (Exception ex)
            {
                changeText.Text = "0";
            }
        }

        public void requiredDepositPercent(TextBox total, TextBox Payment)
        {
            double paymentInput = double.Parse(Payment.Text);
            double TotalVar = double.Parse(total.Text);
            double initialDepRequired = TotalVar * 0.5;
            double remBal = TotalVar - paymentInput;
            if (paymentInput < initialDepRequired)
            {
                Payment.Text = initialDepRequired.ToString();                
                Payment.SelectAll();
                Payment.Focus();
                
                lblPaymentNotice.Text = "Ateast 50 percent: " + initialDepRequired.ToString("00.00");
                lblPaymentNotice.Visible = true;
                txtRemBalances.Text = remBal.ToString();
            }
            else
            {
                txtRemBalances.Text = remBal.ToString();
            }       
        }

        private void txtPayment_TextChanged(object sender, EventArgs e)
        {
            string pTerms = comBoxPaymentTerms.Text;
            
            try
            {
                if (txtPayment.Text == string.Empty)
                {
                    txtPayment.Focus();
                    txtPayment.Text = "0";
                    txtPayment.SelectAll();
                }
                else
                {
                    if (pTerms == "Full")
                    {
                        lblPaymentNotice.Visible = false;
                        computeChange(txtTotal, txtPayment, txtChange);
                    }
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
             
        }

        private void btnClear_Click(object sender, EventArgs e)
        {

            txtPayment.Clear();
            txtPayment.Text = "0";
            txtPayment.Focus();
        }

        private void btnOne_Click(object sender, EventArgs e)
        {
            txtPayment.Focus();
            txtPayment.Text += btnOne.Text;
        }

        private void btnTwo_Click(object sender, EventArgs e)
        {
            txtPayment.Focus();
            txtPayment.Text += btnTwo.Text;
        }

        private void btnThree_Click(object sender, EventArgs e)
        {
            
            txtPayment.Focus();txtPayment.Text += btnThree.Text;
        }

        private void btnFour_Click(object sender, EventArgs e)
        {
            txtPayment.Focus(); txtPayment.Text += btnFour.Text;
        }

        private void btnFive_Click(object sender, EventArgs e)
        {
            txtPayment.Focus(); txtPayment.Text += btnFive.Text;
        }

        private void btnSix_Click(object sender, EventArgs e)
        {
            txtPayment.Focus(); txtPayment.Text += btnSix.Text;
        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            txtPayment.Focus(); txtPayment.Text += btnZero.Text;
        }

        private void btnSeven_Click(object sender, EventArgs e)
        {
            txtPayment.Focus(); txtPayment.Text += btnSeven.Text;
        }

        private void btnEight_Click(object sender, EventArgs e)
        {
            txtPayment.Focus(); txtPayment.Text += btnEight.Text;
        }

        private void btnDoubleZero_Click(object sender, EventArgs e)
        {
            txtPayment.Focus(); txtPayment.Text += btnDoubleZero.Text;
        }
       
        private void btnEnter_Click(object sender, EventArgs e)
        {

            //int dgvCount = lblRowCount.Text.ToString();
            try
            {
                string pTerms = comBoxPaymentTerms.Text;
                //frmCashier frmC = new frmCashier();
                if (pTerms == "Full")
                { 
                    if (txtChange.Text == String.Empty)
                    {
                    MessageBox.Show("Insufficient amount. Please enter the correct amount!", title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                    }
                    else
                    {
                        //string pTerm = comBoxPaymentTerms.Text;
                        if (double.Parse(txtPayment.Text) < double.Parse(txtTotal.Text))
                        {
                            //MessageBox.Show("Payment must be higher than Total amount", title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            lblPaymentNotice.Text = "Payment should be greater than Total amount";
                            lblPaymentNotice.Visible = true;
                        }
                        else
                        {
                            int pLength = 0;
                            if (lblCheckSettleBalance.Text == "0")
                            {
                                pTerms = comBoxPaymentTerms.Text;
                                PrintPreviewDialog preview = new PrintPreviewDialog();
                                preview.Document = printDocument;
                                pLength = 920;
                                paperSizeUpdate(out pLength);
                                printDocument.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("RECEIPT", 610, pLength);
                                preview.PrintPreviewControl.Zoom = 0.75;
                                preview.Size = new System.Drawing.Size(400, 650);
                                preview.ShowDialog();
                                settlement();
                            }
                            else if (lblCheckSettleBalance.Text == "1")
                            {
                                
                                frmEditPaymentOrder frmEP = new frmEditPaymentOrder();
                                PrintPreviewDialog preview = new PrintPreviewDialog();
                                preview.Document = printDocumentBalance;
                                pLength = 600;
                                
                                printDocumentBalance.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("RECEIPT", 610, pLength);
                                preview.PrintPreviewControl.Zoom = 0.75;
                                preview.Size = new System.Drawing.Size(400, 500);
                                preview.ShowDialog();
                                MessageBox.Show("Payment succesfully", title, MessageBoxButtons.OK, MessageBoxIcon.Information);
                                settleBalance();
                                classPayment.LoadRecordsUnsettled(frmEP.dataGridViewPaymentStat, frmEP.txtSearchPending);                                
                                this.Dispose();

                            }
                            
                        }
                    }
                }
                else if(pTerms == "Deposit")
                {
                    settlement();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
                //MessageBox.Show("Insufficient amount. Please enter the correct amount!", title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }
        public void settleBalance()
        {
            frmEditPaymentOrder frmEP = new frmEditPaymentOrder();
            string transacNum = lblTransacNo.Text;
                float total = float.Parse(txtTotal.Text);
                float payment = float.Parse(txtPayment.Text);//Initial_Deposit
                float change = float.Parse(txtChange.Text);
                string pMethod = comBoxMethodPayment.Text;
                string customer = lblCustomer.Text;
                //string cashier = lblCashier.Text;
                string Settled_Date = DateTime.Now.ToString();
                string Completed_By = lblCashier.Text;
                
                cn.Open();
                cm = new SqlCommand("UPDATE tblPaymentStatus SET Settled_Date = @Settled_Date, Completed_By = @Completed_By, Status = 'Settled' WHERE Transaction_No LIKE '" + transacNum + "' ", cn);
                //cm.Parameters.AddWithValue("@Transaction_No", transacNum);
                cm.Parameters.AddWithValue("@Settled_Date", Settled_Date);
                cm.Parameters.AddWithValue("@Completed_By", Completed_By);
                cm.ExecuteNonQuery();
                cn.Close();

                cn.Open();
                cm = new SqlCommand("INSERT INTO tblReceiptSettle (Transaction_No, Transaction_Date, Payment_Mode, Customer, Net_Total, Payment, Change, Cashier) VALUES(@Transaction_No, @Transaction_Date, @Payment_Mode, @Customer, @Net_Total, @Payment, @Change, @Cashier)", cn);
                cm.Parameters.AddWithValue("@Transaction_No", transacNum);
                cm.Parameters.AddWithValue("@Transaction_Date", Settled_Date);
                cm.Parameters.AddWithValue("@Payment_Mode", pMethod);
                cm.Parameters.AddWithValue("@Customer", customer);
                cm.Parameters.AddWithValue("@Net_Total", total.ToString("00.00"));
                cm.Parameters.AddWithValue("@Payment", payment.ToString("00.00"));
                cm.Parameters.AddWithValue("@Change", change.ToString("00.00"));
                cm.Parameters.AddWithValue("@Cashier", Completed_By);
                cm.ExecuteNonQuery();
                cn.Close();
                classPayment.LoadRecordsUnsettled(frmEP.dataGridViewPaymentStat, frmEP.txtSearchPending);

        }
        public void settlement()
        {
            try
            {
                string transacNum = lblTransacNo.Text;
                //int transacNum = int.Parse(transacInput);
                float payment = float.Parse(txtPayment.Text);//Initial_Deposit
                float change = float.Parse(txtChange.Text);
                string transDate = DateTime.Parse(DateTime.Now.ToString()).ToShortDateString();
                string discountPer = lblDPercent.Text;
                string gross = frmC.lblSalesTotal.Text;
                string pMethod = comBoxMethodPayment.Text;
                string pTerms = comBoxPaymentTerms.Text;
                string cashier = lblCashier.Text;
                string customer = lblCustomer.Text;
                float total = float.Parse(txtTotal.Text); //Total_Payment
                string dueDate = dateTimePickerDueDate.Value.ToShortDateString(); //Due_Date , Expected_Arrival
                float remainBalance = 0; //remBalance
                string status = "";
                string claimDate = ""; //DateTime.Today.AddDays(3).ToShortDateString()
                string releaseBy = "Undefined";
                string finalDiscount = lblDiscount.Text;
                string settlementDate = "Pending";
                string ITMID = "";
                checkPaymentTerms(out status, pTerms, total, payment, out remainBalance, out settlementDate);

                lblPaymentNotice.Visible = false;
                computeChange(txtTotal, txtPayment, txtChange);

                //PrintPreviewDialog preview = new PrintPreviewDialog();
                //preview.Document = printDocument;
                //int pLength = 920;
                //paperSizeUpdate(out pLength);
                //printDocument.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("RECEIPT", 610, pLength);
                //preview.PrintPreviewControl.Zoom = 0.75;
                //preview.Size = new System.Drawing.Size(400, 650);
                //preview.ShowDialog();

                cn.Open();
                cm = new SqlCommand("INSERT INTO tblPaymentStatus (Transaction_No, Customer, Total_Payment, Initial_Deposit, Due_Date, Rem_Balance, Status, Discount_Per_Trans, Settled_Date) VALUES(@Transaction_No, @Customer, @Total_Payment, @Initial_Deposit, @Due_Date, @Rem_Balance, @Status, @Discount_Per_Trans, @Settled_Date)", cn);
                cm.Parameters.AddWithValue("@Transaction_No", transacNum);
                cm.Parameters.AddWithValue("@Customer", customer);
                cm.Parameters.AddWithValue("@Total_Payment", total.ToString("00.00"));
                cm.Parameters.AddWithValue("@Initial_Deposit", payment.ToString("00.00"));
                cm.Parameters.AddWithValue("@Due_Date", dueDate);
                cm.Parameters.AddWithValue("@Rem_Balance", remainBalance.ToString("00.00"));
                cm.Parameters.AddWithValue("@Status", status);
                cm.Parameters.AddWithValue("@Discount_Per_Trans", finalDiscount);
                cm.Parameters.AddWithValue("@Settled_Date", settlementDate);

                cm.ExecuteNonQuery();
                cn.Close();
                checkOrderIfDeposit(out status, pTerms, out claimDate);
                cn.Open();
                cm = new SqlCommand("INSERT INTO tblOrderStatus (Transaction_No, Customer, Expected_Arrival, Status, Date_Claimed, Release_By) VALUES(@Transaction_No, @Customer, @Expected_Arrival, @Status, @Date_Claimed, @Release_By)", cn);
                cm.Parameters.AddWithValue("@Transaction_No", lblTransacNo.Text);
                cm.Parameters.AddWithValue("@Customer", customer);
                cm.Parameters.AddWithValue("@Expected_Arrival", dueDate);
                cm.Parameters.AddWithValue("@Status", status);
                cm.Parameters.AddWithValue("@Date_Claimed", claimDate);
                cm.Parameters.AddWithValue("@Release_By", releaseBy);
                //cm.Parameters.AddWithValue("@Cart_ID", frmC.dataGridViewCart.Rows[i].Cells[11].Value.ToString());
                cm.ExecuteNonQuery();
                cn.Close();

                cn.Open();
                cm = new SqlCommand("INSERT INTO tblReceipt (Transaction_No, Transaction_Date, Payment_Mode, Payment_Terms, Customer, Gross_Total, Discount, Net_Total, Payment, Balance, Change, Discount_Percent, Settled_Date, Cashier) VALUES(@Transaction_No, @Transaction_Date, @Payment_Mode, @Payment_Terms, @Customer, @Gross_Total, @Discount, @Net_Total, @Payment, @Balance, @Change, @Discount_Percent, @Settled_Date, @Cashier)", cn);
                cm.Parameters.AddWithValue("@Transaction_No", lblTransacNo.Text);
                cm.Parameters.AddWithValue("@Transaction_Date", transDate);
                cm.Parameters.AddWithValue("@Payment_Mode", pMethod);
                cm.Parameters.AddWithValue("@Payment_Terms", pTerms);
                cm.Parameters.AddWithValue("@Customer", customer);
                cm.Parameters.AddWithValue("@Gross_Total", gross);
                cm.Parameters.AddWithValue("@Discount", finalDiscount);
                cm.Parameters.AddWithValue("@Net_Total", total.ToString("00.00"));
                cm.Parameters.AddWithValue("@Payment", payment.ToString("00.00"));
                cm.Parameters.AddWithValue("@Balance", remainBalance.ToString("00.00"));
                cm.Parameters.AddWithValue("@Change", change.ToString("00.00"));
                cm.Parameters.AddWithValue("@Discount_Percent", discountPer);
                cm.Parameters.AddWithValue("@Settled_Date", settlementDate);
                cm.Parameters.AddWithValue("@Cashier", cashier);
                cm.ExecuteNonQuery();
                cn.Close();

                for (int i = 0; i < frmC.dataGridViewCart.Rows.Count; i++)
                {
                    ITMID = frmC.dataGridViewCart.Rows[i].Cells[12].Value.ToString();
                    //cn.Open();//Set Quantity
                    //cm = new SqlCommand("UPDATE tblItem SET Quantity = Quantity - " + int.Parse(frmC.dataGridViewCart.Rows[i].Cells[4].Value.ToString()) + " WHERE Item_ID LIKE '" + frmC.dataGridViewCart.Rows[i].Cells[12].Value.ToString() + "'", cn);
                    //cm.ExecuteNonQuery();
                    //cn.Close();
                    classInventory.determineStockLevel(ITMID);

                    cn.Open();
                    cm = new SqlCommand("UPDATE tblCart SET Payment = " + payment + ", Change = " + change + ", PMode = '" + pMethod + "', PTerms = '" + pTerms + "', Cashier = '" + cashier + "', Customer = '" + customer + "', Status = 'Sold', Discount_Per_Trans = '" + finalDiscount + "' WHERE num LIKE '" + frmC.dataGridViewCart.Rows[i].Cells[11].Value.ToString() + "'", cn);
                    cm.ExecuteNonQuery();
                    cn.Close();
                }
                string statusSA = "Sold";
                for (int i = 0; i < frmC.dataGridViewService.Rows.Count; i++)
                {
                    cn.Open();
                    //cm = new SqlCommand("INSERT INTO tblServiceAvailed (Service_ID, Transaction_No, Customer, Status) VALUES(@Service_ID, @Transaction_No, @Customer, @Status)", cn);

                    cm = new SqlCommand("UPDATE tblServiceAvailed SET Transaction_No = @Transaction_No, Customer = @Customer, Status = @Status WHERE Num LIKE @Service_num ", cn);
                    cm.Parameters.AddWithValue("@Service_num", frmC.dataGridViewService.Rows[i].Cells[6].Value.ToString());
                    cm.Parameters.AddWithValue("@Transaction_No", lblTransacNo.Text);
                    cm.Parameters.AddWithValue("@Customer", customer);
                    cm.Parameters.AddWithValue("@Status", statusSA);
                    cm.ExecuteNonQuery();
                    cn.Close();
                }


                MessageBox.Show("Payment succesfully", title, MessageBoxButtons.OK, MessageBoxIcon.Information);
                classGenerateID.GenerateTransactionNo(frmC.lblTransactionNo);
                //frmC.GenerateTransactionNo();
                classLoadData.LoadCart(frmC.dataGridViewCart, frmC.lblDiscount, frmC.lblSalesTotal, frmC.lblPayment, frmC.lblNetTotal, frmC.btnSettlePayment, frmC.btnAddDiscount, frmC.btnClearCart, frmC.txtSearch, frmC.dataGridViewService);
                
                //frmC.LoadCart();

                this.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
                //MessageBox.Show("Insufficient amount. Please enter the correct amount!", title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        public void checkOrderIfDeposit(out string statusValue, string paymentTerms, out string dateClaim)
        {
            try
            {
                statusValue = "";
                dateClaim = "";
                if (paymentTerms == "Full")
                {
                    statusValue = "In The Lab";
                    //dateClaim = DateTime.Today.AddDays(3).ToShortDateString();
                    dateClaim = "Unclaimed";
                }
                else if (paymentTerms == "Deposit")
                {
                    statusValue = "In The Lab";
                    //dateClaim = DateTime.Today.AddDays(3).ToShortDateString();
                    dateClaim = "Unclaimed";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
                statusValue = "In The Lab";
                dateClaim = "";
                return;
            }
        } 

        public void checkPaymentTerms(out string statusValue, string paymentTerms, float total, float payment, out float remBalance, out string settledDate)
        {
            try
            {
                statusValue = "";
                settledDate = "";
                remBalance = total - payment;
                if (paymentTerms == "Full")
                {
                    statusValue = "Settled";
                    remBalance = 0;
                    settledDate = DateTime.Today.ToShortDateString();
                }
                else if (paymentTerms == "Deposit")
                {
                    statusValue = "Pending";
                    remBalance = total - payment;
                    settledDate = "Pending";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
                statusValue = "Pending";
                remBalance = total - payment;
                settledDate = "";
            }            
        }
        
        
        private void txtPayment_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 8)
            {
                //accept backspace
            }

            else if ((e.KeyChar < 48) || (e.KeyChar > 57))
            {
                //ascii code 48 - 57 = characters between 0 - 9
                e.Handled = true;
                
            }
        }

        private void btnTwenty_Click(object sender, EventArgs e)
        {
            txtPayment.Focus();
            curr = double.Parse(txtPayment.Text);
            num = curr + 20;
            txtPayment.Text = num.ToString();
        }

        private void btnFifty_Click(object sender, EventArgs e)
        {
            txtPayment.Focus();
            curr = double.Parse(txtPayment.Text);
            num = curr + 50;
            txtPayment.Text = num.ToString();
        }

        private void btnOneH_Click(object sender, EventArgs e)
        {
            txtPayment.Focus();
            curr = double.Parse(txtPayment.Text);
            num = curr + 100;
            txtPayment.Text = num.ToString();
        }

        private void btnTwoH_Click(object sender, EventArgs e)
        {
            txtPayment.Focus();
            curr = double.Parse(txtPayment.Text);
            num = curr + 200;
            txtPayment.Text = num.ToString();
        }

        private void btnFiveH_Click(object sender, EventArgs e)
        {
            txtPayment.Focus();
            curr = double.Parse(txtPayment.Text);
            num = curr + 500;
            txtPayment.Text = num.ToString();
        }

        private void btnThousand_Click(object sender, EventArgs e)
        {
            try
            {
                txtPayment.Focus();
                curr = double.Parse(txtPayment.Text);
                num = curr + 1000;
                txtPayment.Text = num.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
            
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;

        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }

        }

        private void panel2_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void lblChangeDueDate_Click(object sender, EventArgs e)
        {
            dateTimePickerDueDate.Enabled = true;
            dateTimePickerDueDate.Focus();
        }

        private void dateTimePickerDueDate_ValueChanged(object sender, EventArgs e)
        {
            //dateTimePickerDueDate.Enabled = false;
        }

        private void comBoxPaymentTerms_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comBoxPaymentTerms.SelectedIndex == 0)//Full
            {
                panel1.Size = new Size(539, 339);
                this.Size = new Size(539, 714);
                panelDepositDueDate.Visible = false;
                lblChangeDueDate.Visible = false;
                lblPaymentNotice.Visible = false;
                txtRemBalances.Text = "0";
            }
            else//Deposit
            {
                panel1.Size = new Size(539, 487);
                this.Size = new Size(539, 864);
                panelDepositDueDate.Visible = true;
                lblChangeDueDate.Visible = true;
                txtChange.Text = "0";
            }
        }

        private void btnBackSpace_Click(object sender, EventArgs e)
        {

        }

        private void txtPayment_Leave(object sender, EventArgs e)
        {
            string pTerms = comBoxPaymentTerms.Text;
            if (pTerms == "Full")
            {
                if (double.Parse(txtPayment.Text) < double.Parse(txtTotal.Text))
                {
                    //MessageBox.Show("Payment must be higher than Total amount", title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    lblPaymentNotice.Text = "Payment should be greater than Total amount";
                    lblPaymentNotice.Visible = true;
                    //txtPayment.Focus();
                }
                else
                {
                    lblPaymentNotice.Visible = false;
                    computeChange(txtTotal, txtPayment, txtChange);
                }
                
            }
            else if (pTerms == "Deposit")
            {
                requiredDepositPercent(txtTotal, txtPayment);
            }
            
        }

        private void dateTimePickerDueDate_Leave(object sender, EventArgs e)
        {
            dateTimePickerDueDate.Enabled = false;
        }
        public void getValueIfAnyElseBlank(int dgvCount, DataGridView dgv, out string result, int rows, int col)
        {
            result = "N/A";
            
                
                //dgvCount = int.Parse(lblRowCount.Text);
                if (dgvCount == 0)
                {
                    result = "--";
                }
                else
                {
                try
                {
                    result = dgv.Rows[rows].Cells[col].Value.ToString();
                    //int slength = result.Length;
                    //if (slength > 38)
                    //{
                    //    int xAxis = 60;
                    //    int yAxis = 30;
                    //}
                }
                catch (Exception ex)
                {
                    cn.Close();
                    MessageBox.Show(ex.Message, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
        }
        
        private void printDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            //printDocument.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("pprnm", 200, 500);
            //printDocument.Print();
            //string full = "Settlement Date for Remaining Balance:";
            string deposit = "Settlement Date for Remaining Balance:";
            int x = 0, y = 0, num = 1; string resultText = ""; int dgvCount = int.Parse(lblRowCount.Text), dgvCountService = int.Parse(lblServRowCount.Text);
            System.Drawing.Font printFont = new System.Drawing.Font("Arial", 10, System.Drawing.FontStyle.Regular);
            System.Drawing.Font printFontBold = new System.Drawing.Font("Arial", 15, System.Drawing.FontStyle.Bold);
            System.Drawing.Font printFontItallic = new System.Drawing.Font("Arial", 12, System.Drawing.FontStyle.Italic);
            e.Graphics.DrawString("Bico-Jose Optical Clinic", printFontBold, Brushes.Black, 175, 30);
            e.Graphics.DrawString("Address: 3rd Floor Susana Mart, Tungko San Jose Del Monte Bulacan", printFont, Brushes.Black, 80, 80);
            y = 140; x = 320;
            e.Graphics.DrawString("Clinic's Contact: 09178326666", printFont, Brushes.Black, 20, y);//140
            e.Graphics.DrawString("Date Issued: ", printFont, Brushes.Black, (x += 60), y);            
            e.Graphics.DrawString("Mode of Payment:  " + comBoxMethodPayment.Text, printFont, Brushes.Black, 20, (y += 30));//170
            e.Graphics.DrawString(DateTime.Now.ToString(), printFont, Brushes.Black, x, y);
            e.Graphics.DrawString("Payment Terms:  " + comBoxPaymentTerms.Text, printFont, Brushes.Black, 20, (y += 30));//200
            e.Graphics.DrawString("Cashier:  " + lblCashier.Text, printFont, Brushes.Black, x, y);//200
            e.Graphics.DrawString("Customer Name:  " + lblCustomer.Text, printFont, Brushes.Black, 20, (y += 30));//230
            if (comBoxPaymentTerms.Text.Equals("Deposit"))
            {
                e.Graphics.DrawString("Settlement Date for Remaining Balance:  " + dateTimePickerDueDate.Value.ToShortDateString(), printFont, Brushes.Black, 20, (y += 30));//260               
            }

            e.Graphics.DrawString("--------------------------------------------------------------------------------------------------------------------------", printFont, Brushes.Black, 10, (y += 30));//260 or 290
            e.Graphics.DrawString("Invoice No: " + frmC.lblTransactionNo.Text, printFont, Brushes.Black, 20, (y += 50));//310 or 340
            e.Graphics.DrawString("#", printFont, Brushes.Black, 20, (y += 50));//360 or 390
            e.Graphics.DrawString("Description", printFont, Brushes.Black, 60, y);
            e.Graphics.DrawString("Price", printFont, Brushes.Black, x, y);//x=380
            e.Graphics.DrawString("Qty", printFont, Brushes.Black, (x += 60), y);
            e.Graphics.DrawString("Unit", printFont, Brushes.Black, (x += 50), y);
            e.Graphics.DrawString("Total", printFont, Brushes.Black, (x += 50), y);//330

            if(dgvCount > 0)
            {
                for(int i = 0; i < dgvCount; i++)
                {
                    x = 370; // 320 + 60
                    e.Graphics.DrawString(num.ToString(), printFont, Brushes.Black, 20, (y += 30));//330
                    getValueIfAnyElseBlank(dgvCount, frmC.dataGridViewCart, out resultText, i, 1);//Description
                    e.Graphics.DrawString(resultText, printFont, Brushes.Black, 60, y);

                    getValueIfAnyElseBlank(dgvCount, frmC.dataGridViewCart, out resultText, i, 3);//Price
                    e.Graphics.DrawString("₱ " + resultText, printFont, Brushes.Black, x, y);

                    getValueIfAnyElseBlank(dgvCount, frmC.dataGridViewCart, out resultText, i, 4);//Qty
                    e.Graphics.DrawString(resultText, printFont, Brushes.Black, (x += 80), y);

                    
                    getValueIfAnyElseBlank(dgvCount, frmC.dataGridViewCart, out resultText, i, 13);//Unit
                    e.Graphics.DrawString(resultText, printFont, Brushes.Black, (x += 38), y);

                    getValueIfAnyElseBlank(dgvCount, frmC.dataGridViewCart, out resultText, i, 6);//Total
                    e.Graphics.DrawString("₱ " + resultText, printFont, Brushes.Black, (x += 40), y);//330
                    num += 1;
                }
            }
            
            if (dgvCountService > 0)
            {
                e.Graphics.DrawString("Service:  ", printFont, Brushes.Black, 60, (y += 50));//430 + 50
                num = 1;
                for (int i = 0; i < dgvCountService; i++)
                {
                    x = 370;
                    //y = 430;
                    e.Graphics.DrawString(num.ToString(), printFont, Brushes.Black, 20, (y += 30));
                    getValueIfAnyElseBlank(dgvCountService, frmC.dataGridViewService, out resultText, i, 1);//frmC.dataGridViewService.Rows[0].Cells[1].Value.ToString()
                    e.Graphics.DrawString(resultText, printFont, Brushes.Black, 60, y);//470      Name
                    getValueIfAnyElseBlank(dgvCountService, frmC.dataGridViewService, out resultText, i, 3);//frmC.dataGridViewService.Rows[0].Cells[3].Value.ToString()
                    e.Graphics.DrawString("₱ " + resultText, printFont, Brushes.Black, x, y);//320   Price
                    num += 1;
                }
            }
            x = 440;

            //y = 550;
            e.Graphics.DrawString("Total Amount: ", printFont, Brushes.Black, 20, (y += 50));//550
            e.Graphics.DrawString("₱ " + frmC.lblSalesTotal.Text, printFont, Brushes.Black, (x += 50), y);//510 

            e.Graphics.DrawString("Discount: ", printFont, Brushes.Black, 20, (y += 30));
            e.Graphics.DrawString("₱ " + frmC.lblDiscount.Text, printFont, Brushes.Black, x, y);//370
            getValueIfAnyElseBlank(dgvCount, frmC.dataGridViewCart, out resultText, 0, 5);//frmC.dataGridViewCart.Rows[0].Cells[5].Value.ToString()
            e.Graphics.DrawString("("+ resultText + "%)", printFont, Brushes.Black, (x -= 80), y);//440

            e.Graphics.DrawString("Total Due: ", printFont, Brushes.Black, 20, (y += 30));
            e.Graphics.DrawString("₱ " + txtTotal.Text, printFont, Brushes.Black, (x += 80), y);//510

            e.Graphics.DrawString("Amount Tendered: ", printFont, Brushes.Black, 20, (y += 30));
            e.Graphics.DrawString("₱ " + txtPayment.Text, printFont, Brushes.Black, x, y);
            
            if (comBoxPaymentTerms.Text.Equals("Deposit"))
            {
                e.Graphics.DrawString("Remaining Balance: ", printFont, Brushes.Black, 20, (y += 30));
                e.Graphics.DrawString("₱ " + txtRemBalances.Text, printFont, Brushes.Black, x, y);

                e.Graphics.DrawString("Change: ", printFont, Brushes.Black, 20, (y += 30));
                e.Graphics.DrawString("₱ -", printFont, Brushes.Black, x, y);//710

            }
            else
            {
                e.Graphics.DrawString("Remaining Balance: ", printFont, Brushes.Black, 20, (y += 30));
                e.Graphics.DrawString("₱ -", printFont, Brushes.Black, x, y);

                e.Graphics.DrawString("Change: ", printFont, Brushes.Black, 20, (y += 30));
                e.Graphics.DrawString("₱ " + txtChange.Text, printFont, Brushes.Black, x, y);//710

            }

            

            e.Graphics.DrawString("THIS INVOICE/RECEIPT SHALL BE VALID FOR", printFontItallic, Brushes.Black, 130, (y += 60));//770
            e.Graphics.DrawString("ONE (1)) WEEK FROM THE DATE OF THE PERMIT TO USE", printFontItallic, Brushes.Black, 70, (y += 30));//800
            e.Graphics.DrawString("THANKYOU", printFontBold, Brushes.Black, (x -= 280), (y += 30));//830
        }

        private void btnReceiptPreview_Click(object sender, EventArgs e)
        {
            int pLength = 0;
            if (lblCheckSettleBalance.Text == "0")
            {
                PrintPreviewDialog preview = new PrintPreviewDialog();
                preview.Document = printDocument;
                pLength = 920;
                paperSizeUpdate(out pLength);
                printDocument.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("RECEIPT", 610, pLength);
                preview.PrintPreviewControl.Zoom = 0.75;
                preview.Size = new System.Drawing.Size(400, 650);
                preview.ShowDialog();
                //printPreviewDialog.ShowDialog();
            }
            else if (lblCheckSettleBalance.Text == "1")
            {
                PrintPreviewDialog preview = new PrintPreviewDialog();
                preview.Document = printDocumentBalance;
                pLength = 600;
                
                printDocumentBalance.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("RECEIPT", 610, pLength);
                preview.PrintPreviewControl.Zoom = 0.75;
                preview.Size = new System.Drawing.Size(400, 500);
                preview.ShowDialog();
            }
        }

        private void printDocumentBalance_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            //string deposit = "Settlement Date for Remaining Balance:";
            int x = 0, y = 0; // num = 1; string resultText = ""; int dgvCount = int.Parse(lblRowCount.Text), dgvCountService = int.Parse(lblServRowCount.Text);
            
            System.Drawing.Font printFont = new System.Drawing.Font("Arial", 10, System.Drawing.FontStyle.Regular);
            System.Drawing.Font printFontBold = new System.Drawing.Font("Arial", 15, System.Drawing.FontStyle.Bold);
            System.Drawing.Font printFontItallic = new System.Drawing.Font("Arial", 12, System.Drawing.FontStyle.Italic);
            
            e.Graphics.DrawString("Bico-Jose Optical Clinic", printFontBold, Brushes.Black, 175, 30);
            e.Graphics.DrawString("Address: 3rd Floor Susana Mart, Tungko San Jose Del Monte Bulacan", printFont, Brushes.Black, 80, 80);
            y = 140; x = 320;
            e.Graphics.DrawString("Clinic's Contact: 09178326666", printFont, Brushes.Black, 20, y);//140
            e.Graphics.DrawString("Date Issued: ", printFont, Brushes.Black, (x += 60), y);
            e.Graphics.DrawString("Mode of Payment:  " + comBoxMethodPayment.Text, printFont, Brushes.Black, 20, (y += 30));//170
            e.Graphics.DrawString(DateTime.Now.ToString(), printFont, Brushes.Black, x, y);
            
            e.Graphics.DrawString("Cashier:  " + lblCashier.Text, printFont, Brushes.Black, x, (y += 30));//200
            e.Graphics.DrawString("Customer Name:  " + lblCustomer.Text, printFont, Brushes.Black, 20, y);//230
            e.Graphics.DrawString("--------------------------------------------------------------------------------------------------------------------------", printFont, Brushes.Black, 10, (y += 30));//260 or 290
            e.Graphics.DrawString("Invoice No: " + lblTransacNo.Text, printFont, Brushes.Black, 20, (y += 50));//310 or 340
            e.Graphics.DrawString("Balance Settlement", printFont, Brushes.Black, 20, (y += 50));//360 or 390


            x = 440;
            //y = 550;
            e.Graphics.DrawString("Total Amount: ", printFont, Brushes.Black, 20, (y += 50));//550
            e.Graphics.DrawString("₱ " + txtTotal.Text, printFont, Brushes.Black, (x += 70), y);//510 

            e.Graphics.DrawString("Amount Tendered: ", printFont, Brushes.Black, 20, (y += 30));
            e.Graphics.DrawString("₱ " + txtPayment.Text, printFont, Brushes.Black, x, y);

            e.Graphics.DrawString("Change: ", printFont, Brushes.Black, 20, (y += 30));
            e.Graphics.DrawString("₱ " + txtChange.Text, printFont, Brushes.Black, x, y);//710          

            e.Graphics.DrawString("THIS INVOICE/RECEIPT SHALL BE VALID FOR", printFontItallic, Brushes.Black, 130, (y += 60));//770
            e.Graphics.DrawString("ONE (1)) WEEK FROM THE DATE OF THE PERMIT TO USE", printFontItallic, Brushes.Black, 70, (y += 30));//800
            e.Graphics.DrawString("THANKYOU", printFontBold, Brushes.Black, (x -= 280), (y += 30));//830

        }

        public void paperSizeUpdate(out int paperL)
        {
            int dgvCount = int.Parse(lblRowCount.Text);
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

    }
}
