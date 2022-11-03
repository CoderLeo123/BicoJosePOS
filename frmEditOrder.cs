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
        SqlDataReader dr;
        string title = "BICO-JOSE System";
        frmPaymentStatus frmL;
        public frmEditOrder(frmPaymentStatus frmL)
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
            this.frmL = frmL;
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
            string TransNo = lblTransNo.Text;
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
    }
}
