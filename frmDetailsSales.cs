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
    public partial class frmDetailsSales : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        SqlDataReader dr;
        ClassLoadData classLoadData = new ClassLoadData();
        string title = "BICO-JOSE System";
        public frmDetailsSales()
        {
            InitializeComponent();
        }

        private void dataGridViewService_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            frmCashier frm = new frmCashier();
            string colName = dataGridViewService.Columns[e.ColumnIndex].Name;
            if (colName == "AddSearchItem")
            {
                if (MessageBox.Show("Add this Item?", title, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cn.Open();
                    cm = new SqlCommand("INSERT INTO tblServiceAvailed (Service_ID, Status) VALUES(@Service_ID, 'Pending')", cn);
                    cm.Parameters.AddWithValue("@Service_ID", dataGridViewService[1, e.RowIndex].Value.ToString());

                    cm.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Successfully Added!", title, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    classLoadData.LoadRecordServiceAvail(frm.dataGridViewService, frm.lblSalesTotal);
                    //frmList.LoadStock();
                    this.Close();
                }
            }
        }


    }
}
