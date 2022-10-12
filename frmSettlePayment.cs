﻿using System;
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
        string title = "BICO-JOSE System";
        int num = 0;
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

            if (paymentInput < initialDepRequired)
            {
                Payment.Text = initialDepRequired.ToString();                
                Payment.SelectAll();
                Payment.Focus();
                
                lblPaymentNotice.Text = "Ateast 50 percent: " + initialDepRequired.ToString("00.00");
                lblPaymentNotice.Visible = true;
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
                    //else if (pTerms == "Deposit")
                    //{
                    //    requiredDepositPercent(txtTotal, txtPayment);
                        
                    //}
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
                string transacNum = lblTransacNo.Text;
                //int transacNum = int.Parse(transacInput);
                float payment = float.Parse(txtPayment.Text);//Initial_Deposit
                float change = float.Parse(txtChange.Text);
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
                string finalDiscount = frmC.lblDiscount.Text;
                string settlementDate = "Pending";
                checkPaymentTerms(out status, pTerms, total, payment, out remainBalance, out settlementDate);
                
                //frmCashier frmC = new frmCashier();
                if (txtChange.Text == String.Empty)
                {
                    MessageBox.Show("Insufficient amount. Please enter the correct amount!", title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    PrintPreviewDialog preview = new PrintPreviewDialog();
                    preview.Document = printDocument;
                    int pLength = 920;
                    paperSizeUpdate(out pLength);
                    printDocument.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("RECEIPT", 500, pLength);
                    preview.PrintPreviewControl.Zoom = 0.75;
                    preview.Size = new System.Drawing.Size(400, 650);
                    preview.ShowDialog();

                    cn.Open();
                    cm = new SqlCommand("INSERT INTO tblPaymentStatus (Transaction_No, Customer, Total_Payment, Initial_Deposit, Due_Date, Rem_Balance, Status, Discount_Per_Trans, Settled_Date) VALUES(@Transaction_No, @Customer, @Total_Payment, @Initial_Deposit, @Due_Date, @Rem_Balance, @Status, @Discount_Per_Trans, @Settled_Date)", cn);
                    cm.Parameters.AddWithValue("@Transaction_No", transacNum);
                    cm.Parameters.AddWithValue("@Customer", customer);
                    cm.Parameters.AddWithValue("@Total_Payment", total);
                    cm.Parameters.AddWithValue("@Initial_Deposit", payment);
                    cm.Parameters.AddWithValue("@Due_Date", dueDate);
                    cm.Parameters.AddWithValue("@Rem_Balance", remainBalance);
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

                    for (int i = 0; i < frmC.dataGridViewCart.Rows.Count; i++)
                    {
                        cn.Open();//Set Quantity
                        cm = new SqlCommand("UPDATE tblItem SET Quantity = Quantity - " + int.Parse(frmC.dataGridViewCart.Rows[i].Cells[4].Value.ToString()) + " WHERE Item_ID LIKE '" + frmC.dataGridViewCart.Rows[i].Cells[12].Value.ToString() + "'", cn);
                        
                        cm.ExecuteNonQuery();
                        cn.Close();

                        cn.Open();
                        cm = new SqlCommand("UPDATE tblCart SET Payment = " + payment + ", Change = " + change + ", PMode = '" + pMethod + "', PTerms = '" + pTerms + "', Cashier = '" + cashier + "', Customer = '" + customer + "', Status = 'Sold', Discount_Per_Trans = '" + finalDiscount + "' WHERE num LIKE '" + frmC.dataGridViewCart.Rows[i].Cells[11].Value.ToString() + "'", cn);
                        cm.ExecuteNonQuery();
                        cn.Close();

                        
                        //cn.Open();//Set Customer, Expected_Arrival,   Status = VariableMethod, Release By = 'Undefined', Date_Claimed = 'Not Yet' NULL 
                        //cm = new SqlCommand("UPDATE tblOrderStatus SET Transaction_No = @TransactionNo, Customer = '" + customer + "', Expected_Arrival = " + DateTime.Parse(dueDate).ToShortDateString() + " , Status = '" + status + "', Date_Claimed = " + DateTime.Parse(claimDate).ToShortDateString() + ", Release_By = 'Undefined' WHERE Cart_ID LIKE '" + frmC.dataGridViewCart.Rows[i].Cells[11].Value.ToString() + "'", cn);
                        //cm.Parameters.AddWithValue("@TransactionNo", lblTransacNo.Text); 
                        //cm.ExecuteNonQuery();
                        //cn.Close();


                    }

                    

                    string statusSA = "Sold";
                    cn.Open();
                    cm = new SqlCommand("INSERT INTO tblServiceAvailed (Transaction_No, Customer, Status) VALUES(@Transaction_No, @Customer, @Status)", cn);
                    cm.Parameters.AddWithValue("@Transaction_No", lblTransacNo.Text);
                    cm.Parameters.AddWithValue("@Customer", customer);
                    cm.Parameters.AddWithValue("@Status", statusSA);
                    cm.ExecuteNonQuery();
                    cn.Close();

                    //cn.Open();//Set Customer, Total_Payment, Initial_Deposit, Due_Date,  Rem_Balance = VariableMethod, Status = 'Pending'
                    //cm = new SqlCommand("UPDATE tblPaymentStatus SET Transaction_No = @TransactionNo, Customer = '" + customer + "', Total_Payment = " + total + ", Initial_Deposit = " + payment + ", Due_Date = " + DateTime.Parse(dueDate).ToShortDateString() + " , Rem_Balance = " + remainBalance + ", Status = '" + status + "' WHERE Transaction_No LIKE @TransactionNo", cn);
                    //cm.Parameters.AddWithValue("@TransactionNo", lblTransacNo.Text); 
                    //cm.ExecuteNonQuery();
                    //cn.Close();

                    //cn.Open();
                    //cm = new SqlCommand("UPDATE tblServiceAvailed SET Transaction_No = @TransactionNo, Customer = '" + customer + "', Status = 'Sold'  WHERE Transaction_No LIKE @TransactionNo", cn);
                    //cm.Parameters.AddWithValue("@TransactionNo", lblTransacNo.Text); 
                    //cm.ExecuteNonQuery();
                    //cn.Close();

                    MessageBox.Show("Payment succesfully saved", title, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    classGenerateID.GenerateTransactionNo(frmC.lblTransactionNo);
                    //frmC.GenerateTransactionNo();
                    classLoadData.LoadCart(frmC.dataGridViewCart, frmC.lblDiscount, frmC.lblSalesTotal, frmC.lblPayment, frmC.lblNetTotal, frmC.btnSettlePayment, frmC.btnAddDiscount, frmC.btnClearCart, frmC.txtSearch, frmC.dataGridViewService);
                    //frmC.LoadCart();
                    
                    this.Dispose();
                }
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
            num = int.Parse(txtPayment.Text) + 20;
            txtPayment.Text = num.ToString();
        }

        private void btnFifty_Click(object sender, EventArgs e)
        {
            txtPayment.Focus();
            num = int.Parse(txtPayment.Text) + 50;
            txtPayment.Text = num.ToString();
        }

        private void btnOneH_Click(object sender, EventArgs e)
        {
            txtPayment.Focus();
            num = int.Parse(txtPayment.Text) + 100;
            txtPayment.Text = num.ToString();
        }

        private void btnTwoH_Click(object sender, EventArgs e)
        {
            txtPayment.Focus();
            num = int.Parse(txtPayment.Text) + 200;
            txtPayment.Text = num.ToString();
        }

        private void btnFiveH_Click(object sender, EventArgs e)
        {
            txtPayment.Focus();
            num = int.Parse(txtPayment.Text) + 500;
            txtPayment.Text = num.ToString();
        }

        private void btnThousand_Click(object sender, EventArgs e)
        {
            try
            {
                txtPayment.Focus();
                num = int.Parse(txtPayment.Text) + 1000;
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
            if (comBoxPaymentTerms.SelectedIndex == 0)
            {
                panel1.Size = new Size(539, 302);
                this.Size = new Size(539, 665);
                panelDepositDueDate.Visible = false;
                lblChangeDueDate.Visible = false;
                lblPaymentNotice.Visible = false;
            }
            else
            {
                panel1.Size = new Size(539, 436);
                this.Size = new Size(539, 812);
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
                    lblPaymentNotice.Text = "Payment must be higher than Total amount";
                    lblPaymentNotice.Visible = true;
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
        public void getValueIfAnyElseBlank(DataGridView dgv, out string result, int rows, int col)
        {
            int dgvCount = int.Parse(lblRowCount.Text);
            if (dgvCount == 0)
            {
                result = "No Data";
            }
            else
            {
                result = dgv.Rows[rows].Cells[col].Value.ToString();
                //int slength = result.Length;
                //if (slength > 38)
                //{
                //    int xAxis = 60;
                //    int yAxis = 30;
                //}
            }
        }
        private void printDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            //printDocument.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("pprnm", 200, 500);
            //printDocument.Print();
            int x = 0, y = 0, num = 1; string resultText = ""; int dgvCount = int.Parse(lblRowCount.Text);
            System.Drawing.Font printFont = new System.Drawing.Font("Arial", 10, System.Drawing.FontStyle.Regular);
            System.Drawing.Font printFontBold = new System.Drawing.Font("Arial", 15, System.Drawing.FontStyle.Bold);
            System.Drawing.Font printFontItallic = new System.Drawing.Font("Arial", 12, System.Drawing.FontStyle.Italic);
            e.Graphics.DrawString("Bico-Jose Optical Clinic", printFontBold, Brushes.Black, 130, 30);
            e.Graphics.DrawString("Address: 3rd Floor Susana Mart, Tungko San Jose Del Monte Bulacan", printFont, Brushes.Black, 30, 80);
            y = 140; x = 320;
            e.Graphics.DrawString("Contact Number: 09178326666", printFont, Brushes.Black, 20, y);//140
            e.Graphics.DrawString("Date Issued: " + frmC.lblDate.Text , printFont, Brushes.Black, x, y);
            e.Graphics.DrawString("Mode of Payment:  " + comBoxMethodPayment.Text, printFont, Brushes.Black, 20, (y += 30));//170
            e.Graphics.DrawString("Settlement Date for Remaining Balance:  " + dateTimePickerDueDate.Value.ToShortDateString(), printFont, Brushes.Black, 20, (y += 30));//200
            e.Graphics.DrawString("---------------------------------------------------------------------------------------------------", printFont, Brushes.Black, 10, (y += 30));//230
            e.Graphics.DrawString("Invoice No: " + frmC.lblTransactionNo.Text, printFont, Brushes.Black, 20, (y += 50));//280
            e.Graphics.DrawString("#", printFont, Brushes.Black, 20, (y += 50));//330
            e.Graphics.DrawString("Description", printFont, Brushes.Black, 60, y);
            e.Graphics.DrawString("Price", printFont, Brushes.Black, x, y);
            e.Graphics.DrawString("Qty", printFont, Brushes.Black, (x += 50), y);
            e.Graphics.DrawString("Total", printFont, Brushes.Black, (x += 50), y);//330

            if(dgvCount > 0)
            {
                for(int i = 0; i < dgvCount; i++)
                {
                    x = 320;
                    e.Graphics.DrawString(num.ToString(), printFont, Brushes.Black, 20, (y += 30));//330
                    getValueIfAnyElseBlank(frmC.dataGridViewCart, out resultText, i, 1);//Description
                    e.Graphics.DrawString(resultText, printFont, Brushes.Black, 60, y);
                    getValueIfAnyElseBlank(frmC.dataGridViewCart, out resultText, i, 3);//Price
                    e.Graphics.DrawString(resultText, printFont, Brushes.Black, x, y);
                    getValueIfAnyElseBlank(frmC.dataGridViewCart, out resultText, i, 4);//Qty
                    e.Graphics.DrawString(resultText, printFont, Brushes.Black, (x += 50), y);
                    getValueIfAnyElseBlank(frmC.dataGridViewCart, out resultText, i, 6);//Total
                    e.Graphics.DrawString(resultText, printFont, Brushes.Black, (x += 50), y);//330
                    num += 1;
                }
            }
            x = 320;
            //y = 430;
            e.Graphics.DrawString("Service:  ", printFont, Brushes.Black, 20, (y += 50));//430 + 50
            getValueIfAnyElseBlank(frmC.dataGridViewService, out resultText, 0, 1);//frmC.dataGridViewService.Rows[0].Cells[1].Value.ToString()
            e.Graphics.DrawString(resultText, printFont, Brushes.Black, 60, (y+=30));//470      Name
            getValueIfAnyElseBlank(frmC.dataGridViewService, out resultText, 0, 3);//frmC.dataGridViewService.Rows[0].Cells[3].Value.ToString()
            e.Graphics.DrawString(resultText, printFont, Brushes.Black, x, y);//320   Price
            //y = 550;
            e.Graphics.DrawString("Total Amount: ", printFont, Brushes.Black, 20, (y += 80));//550
            e.Graphics.DrawString(frmC.lblSalesTotal.Text, printFont, Brushes.Black, (x += 70), y);//390 

            e.Graphics.DrawString("Discount: ", printFont, Brushes.Black, 20, (y += 30));
            e.Graphics.DrawString(frmC.lblDiscount.Text, printFont, Brushes.Black, x, y);//370
            getValueIfAnyElseBlank(frmC.dataGridViewCart, out resultText, 0, 5);//frmC.dataGridViewCart.Rows[0].Cells[5].Value.ToString()
            e.Graphics.DrawString("("+ resultText + "%)", printFont, Brushes.Black, (x -= 70), y);//320

            e.Graphics.DrawString("Total Due: ", printFont, Brushes.Black, 20, (y += 30));
            e.Graphics.DrawString(txtTotal.Text, printFont, Brushes.Black, (x += 70), y);

            e.Graphics.DrawString("Amount Tendered: ", printFont, Brushes.Black, 20, (y += 30));
            e.Graphics.DrawString(txtPayment.Text, printFont, Brushes.Black, x, y);

            e.Graphics.DrawString("Remaining Balance: ", printFont, Brushes.Black, 20, (y += 30));
            e.Graphics.DrawString("-", printFont, Brushes.Black, x, y);

            e.Graphics.DrawString("Change: ", printFont, Brushes.Black, 20, (y += 30));
            e.Graphics.DrawString(txtChange.Text, printFont, Brushes.Black, x, y);//710

            e.Graphics.DrawString("THIS INVOICE/RECEIPT SHALL BE VALID FOR", printFontItallic, Brushes.Black, 60, (y += 60));//770
            e.Graphics.DrawString("ONE (1)) WEEK FROM THE DATE OF THE PERMIT TO USE", printFontItallic, Brushes.Black, 20, (y += 30));//800
            e.Graphics.DrawString("THANKYOU", printFontBold, Brushes.Black, 180, (y += 30));//830
        }

        private void btnReceiptPreview_Click(object sender, EventArgs e)
        {
            PrintPreviewDialog preview = new PrintPreviewDialog();
            preview.Document = printDocument;
            int pLength = 920;
            paperSizeUpdate(out pLength);
            printDocument.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("RECEIPT", 500, pLength);
            preview.PrintPreviewControl.Zoom = 0.75;
            preview.Size = new System.Drawing.Size(400, 650);            
            preview.ShowDialog();
            //printPreviewDialog.ShowDialog();
        }

        public void paperSizeUpdate(out int paperL)
        {
            int dgvCount = int.Parse(lblRowCount.Text);
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
