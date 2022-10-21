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
        string title = "BICO-JOSE System";
        public frmPaymentStatus()
        {
            cn = new SqlConnection(dbcon.MyConnection());
            InitializeComponent();
            classLoad.LoadRecordsSettled(dataGridViewSettled, txtSearchSettled);
            classLoad.LoadRecordsUnsettled(dataGridViewPaymentStat, txtSearchPending);
            classLoad.LoadRecordsOrder(dataGridViewOrderStatus, txtSearchOrderStatus);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void dataGridViewOrderStatus_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dataGridViewOrderStatus.Columns[e.ColumnIndex].Name;
            string TransNo = dataGridViewOrderStatus.Rows[e.RowIndex].Cells[1].Value.ToString();
            frmEditOrder frm = new frmEditOrder();
            frm.txtReleaseBy.Text = lblUser.Text;
            frm.ShowDialog();

        }
    }
}
