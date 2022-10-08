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
    public partial class frmDailySales : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        SqlDataReader dr;
        ClassLoadData classLoadData = new ClassLoadData();
        string title = "BICO-JOSE System";
        public frmDailySales()
        {
            InitializeComponent();
            changeDatePriorCurrent(dateTimePickerStartSold);
            changeDatePriorCurrent(dateTimePickerStartTrans);
            classLoadData.LoadRecordsTransacHist(dataGridViewTransacHist, txtSearchTransac, dateTimePickerStartTrans, dateTimePickerEndTrans);
            classLoadData.LoadRecordsSoldItems(dataGridViewSoldItems, txtSearchSold, dateTimePickerStartSold, dateTimePickerEndSold);
        }
        public void changeDatePriorCurrent(DateTimePicker date)
        {
            date.Value = DateTime.Today.AddDays(-3);
        }

        private void btnCloseDailySales_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridViewTransacHist_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridViewSoldItems_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
