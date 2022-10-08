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
                        computeChange(txtTotal, txtPayment, txtChange);
                    }
                    else if (pTerms == "Deposit")
                    {
                        requiredDepositPercent(txtTotal, txtPayment);
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
            try
            {
                string transacNum = lblTransacNo.Text;
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
                string claimDate = "";
                checkPaymentTerms(status, pTerms, total, payment, remainBalance);
                checkOrderIfDeposit(status, pTerms, claimDate);
                //frmCashier frmC = new frmCashier();
                if (txtChange.Text == String.Empty)
                {
                    MessageBox.Show("Insufficient amount. Please enter the correct amount!", title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    for (int i = 0; i < frmC.dataGridViewCart.Rows.Count; i++)
                    {
                        cn.Open();//Set Quantity
                        cm = new SqlCommand("UPDATE tblItem SET Quantity = Quantity - " + int.Parse(frmC.dataGridViewCart.Rows[i].Cells[4].Value.ToString()) + " WHERE Item_ID LIKE '" + frmC.dataGridViewCart.Rows[i].Cells[12].Value.ToString() + "'", cn);
                        cm.ExecuteNonQuery();
                        cn.Close();

                        cn.Open();
                        cm = new SqlCommand("UPDATE tblCart SET Payment = " + payment.ToString("00.00") + ", Change = " + change.ToString("00.00") + ", PMode = '" + pMethod + "', PTerms = '" + pTerms + "', Cashier = '" + cashier + "', Customer = '" + customer + "', Status = 'Sold' WHERE num LIKE '" + frmC.dataGridViewCart.Rows[i].Cells[11].Value.ToString() + "'", cn);
                        cm.ExecuteNonQuery();
                        cn.Close();

                        cn.Open();//Set Customer, Expected_Arrival,   Status = VariableMethod, Release By = 'Undefined', Date_Claimed = 'Not Yet' NULL 
                        cm = new SqlCommand("UPDATE tblOrderStatus SET Transaction_No = " + transacNum + ", Customer = " + customer + ", Expected_Arrival = " + dueDate + " , Status = " + status + ", Date_Claimed = " + claimDate + ", Release By = 'Undefined' WHERE Cart_ID LIKE '" + frmC.dataGridViewCart.Rows[i].Cells[11].Value.ToString() + "'", cn);
                        cm.ExecuteNonQuery();
                        cn.Close();

                    }

                    cn.Open();//Set Customer, Total_Payment, Initial_Deposit, Due_Date,  Rem_Balance = VariableMethod, Status = 'Pending'
                    cm = new SqlCommand("UPDATE tblPaymentStatus SET Transaction_No = " + transacNum + ", Customer = " + customer + ", Total_Payment = " + total.ToString("00.00") + ", Initial_Deposit = " + payment.ToString("00.00") + ", Due_Date = " + dueDate + " , Rem_Balance = " + remainBalance + ", Status = " + status + " WHERE Transaction_No LIKE '" + transacNum + "'", cn);
                    cm.ExecuteNonQuery();
                    cn.Close();

                    cn.Open();
                    cm = new SqlCommand("UPDATE tblServiceAvailed SET Transaction_No = " + transacNum + ", Customer = " + customer + ", Status = 'Sold'  WHERE Transaction_No LIKE '" + transacNum + "'", cn);
                    cm.ExecuteNonQuery();
                    cn.Close();

                    MessageBox.Show("Payment succesfully saved", title, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    classGenerateID.GenerateTransactionNo(frmC.lblTransactionNo);
                    //frmC.GenerateTransactionNo();
                    classLoadData.LoadCart(frmC.dataGridViewCart, frmC.lblDiscount, frmC.lblSalesTotal, frmC.lblPayment, frmC.lblNetTotal, frmC.btnSettlePayment, frmC.btnAddDiscount, frmC.btnClearCart, frmC.txtSearch);
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
        public void checkOrderIfDeposit(string statusValue, string paymentTerms, string dateClaim)
        {
            try
            {
                if (paymentTerms == "Full")
                {
                    statusValue = "Claimed";
                    dateClaim = DateTime.Now.ToShortDateString();
                }
                else if (paymentTerms == "Deposit")
                {
                    statusValue = "In The Lab";
                    dateClaim = "Not Yet";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        } 

        public void checkPaymentTerms(string statusValue, string paymentTerms, float total, float payment, float remBalance)
        {
            try
            {
                remBalance = total - payment;
                if (paymentTerms == "Full")
                {
                    statusValue = "Settled";
                }
                else if (paymentTerms == "Deposit")
                {
                    statusValue = "Pending";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
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
            txtPayment.Focus();
            num = int.Parse(txtPayment.Text) + 1000;
            txtPayment.Text = num.ToString();
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
                panel1.Size = new Size(539, 408);
                this.Size = new Size(539, 1055);
                panelDepositDueDate.Visible = true;
            }
            else
            {
                panel1.Size = new Size(539, 246);
                this.Size = new Size(539, 939);
                panelDepositDueDate.Visible = false;
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
                    MessageBox.Show("Payment must be higher than Total amount", title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtPayment.Focus();
                }
                else
                {
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
    }
}
