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
    public partial class frmEditPaymentOrder : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        SqlDataReader dr;
        ClassLoadData classLoadData = new ClassLoadData();
        ClassPaymentOrderMonitoring classPayment = new ClassPaymentOrderMonitoring();
        ClassGenerateID classGenerateID = new ClassGenerateID();
        frmCashier frml;
        string title = "BICO-JOSE System", transNo = "";
        private bool mouseDown;
        private Point lastLocation;
        public frmEditPaymentOrder()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
            //classPayment.LoadRecordsUnsettled(dataGridViewPaymentStat, txtSearchPending);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;

        }

        private void txtSearchPending_TextChanged(object sender, EventArgs e)
        {
            //if (txtSearchPending.Text == String.Empty)
            //{
            //    //classLoadData.LoadRecordsTransacSettled(dataGridViewSettle, txtSearchSettleds, dateTimePickerSettStart, dateTimePickerSettEnd);
            //    return;
            //}
            //else
            //{
            //    classPayment.LoadRecordsUnsettled(dataGridViewPaymentStat, txtSearchPending);
            //}
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtSearchPending.Text == String.Empty)
            {
                //classLoadData.LoadRecordsTransacSettled(dataGridViewSettle, txtSearchSettleds, dateTimePickerSettStart, dateTimePickerSettEnd);
                return;
            }
            else
            {
                classPayment.LoadRecordsUnsettled(dataGridViewPaymentStat, txtSearchPending);
            }
        }

        private void dataGridViewPaymentStat_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //classPayment.LoadRecordsUnsettled(dataGridViewPaymentStat, txtSearchPending);
            lblCurrentTransN.Text = dataGridViewPaymentStat.Rows[e.RowIndex].Cells[1].Value.ToString();
            string CName = dataGridViewPaymentStat.Rows[e.RowIndex].Cells[2].Value.ToString();
            //string Cashier = dataGridViewPaymentStat.Rows[e.RowIndex].Cells[7].Value.ToString();
            string Balance = dataGridViewPaymentStat.Rows[e.RowIndex].Cells[9].Value.ToString();
            
            frmCashier frmC = new frmCashier();
            frmSettlePayment frm = new frmSettlePayment(frml);
            frm.comBoxPaymentTerms.SelectedIndex = 0;
            frm.comBoxMethodPayment.SelectedIndex = 0;
            classGenerateID.GenerateTransactionNo(frm.lblNewTransactionSet);
            frm.comBoxPaymentTerms.Visible = false;
            frm.labelPT.Text = "Transaction No"; //Payment Terms
            frm.lblNewTransactionSet.Visible = true;

            frm.lblMoneyTitle.Visible = false;
            frm.txtMoney.Visible = false;
            frm.labelBal.Visible = false;
            frm.lblCustomer.Visible = true;
            frm.txtRemBalances.Visible = false;
            frm.lblChangeDueDate.Visible = false;
            frm.labelTot.Text = "Balance Due";
            frm.panelDepositDueDate.Visible = true;
            frm.labelDueDate.Text = "Settled Date";
            frm.dateTimePickerDueDate.Value = DateTime.Now;
            frm.lblCheckSettleBalance.Text = "1";
            frm.lblTransacNo.Text = lblCurrentTransN.Text;
            frm.lblCustomer.Text = CName;
            frm.lblCashier.Text = frmC.lblCashierName.Text;
            frm.txtTotal.Text = Balance;
            
            frm.panelDepositDueDate.Size = new Size(0, 0);//539, 62
            frm.panelDepositDueDate.Visible = false;
            frm.panel1.Size = new Size(539, 339); // 539, 306
            frm.Size = new Size(539, 714); // 539, 680
            frm.ShowDialog();

            //if (txtFirstName.Text == "" && txtLastName.Text == "")
            //{
            //    MessageBox.Show("Kindly input the customer's name first", title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    txtFirstName.Focus();
            //    txtLastName.Focus();
            //}
            //else
            //{

            //    frm.txtTotal.Text = lblNetTotal.Text;
            //    frm.comBoxPaymentTerms.SelectedIndex = 0;
            //    frm.comBoxMethodPayment.SelectedIndex = 0;
            //    frm.lblCustomer.Text = txtFirstName.Text + " " + txtLastName.Text;
            //    frm.lblCashier.Text = lblCashierName.Text;
            //    frm.lblTransacNo.Text = lblTransactionNo.Text;
            //    frm.lblGrossTotal.Text = lblSalesTotal.Text;
            //    frm.lblDiscount.Text = lblDiscount.Text;
            //    frm.lblDPercent.Text = lblDiscPercen.Text;

            //    frm.ShowDialog();
            //}
        }
    }
}
