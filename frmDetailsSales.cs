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
        frmCashier frmC;
        //frmCashier frmList;
        private bool mouseDown;
        private Point lastLocation;
        public frmDetailsSales(frmCashier frmL)
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
            frmC = frmL;
      
        }

        private void dataGridViewService_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            frmCashier frmC = new frmCashier();
            string colName = dataGridViewService.Columns[e.ColumnIndex].Name;
            string check = "";
            string SID = dataGridViewService.Rows[e.RowIndex].Cells[5].Value?.ToString();
            cn.Open();
            cm = new SqlCommand("SELECT Service_ID FROM tblServiceAvailed WHERE Status = 'Pending' AND Service_ID LIKE '" + SID + "' ", cn);
            dr = cm.ExecuteReader();
            if (dr.Read())
            {
                check = dr[0].ToString();
            }
            cn.Close();
            if ((check.Equals("")) || (check == string.Empty))
            {
                if (colName == "add")
                {
                    if (MessageBox.Show("Add this Item?", title, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        cn.Open();
                        cm = new SqlCommand("INSERT INTO tblServiceAvailed (Service_ID, Status) VALUES(@Service_ID, 'Pending')", cn);
                        cm.Parameters.AddWithValue("@Service_ID", dataGridViewService.Rows[e.RowIndex].Cells[5].Value?.ToString());

                        cm.ExecuteNonQuery();
                        cn.Close();
                        MessageBox.Show("Successfully Added!", title, MessageBoxButtons.OK, MessageBoxIcon.Information);
                       classLoadData.LoadCart(frmC.dataGridViewCart, frmC.lblDiscount, frmC.lblSalesTotal, frmC.lblPayment, frmC.lblNetTotal, frmC.btnSettlePayment, frmC.btnAddDiscount, frmC.btnClearCart, frmC.txtSearch, frmC.dataGridViewService, frmC.lblNetNoComa, frmC.lblGrossNoComma);
                       
                        this.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("Selected Service is already in the Cart", title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmDetailsSales_FormClosed(object sender, FormClosedEventArgs e)
        {
            
            classLoadData.LoadCart(frmC.dataGridViewCart, frmC.lblDiscount, frmC.lblSalesTotal, frmC.lblPayment, frmC.lblNetTotal, frmC.btnSettlePayment, frmC.btnAddDiscount, frmC.btnClearCart, frmC.txtSearch, frmC.dataGridViewService, frmC.lblNetNoComa, frmC.lblGrossNoComma);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void panel1_MouseLeave(object sender, EventArgs e)
        {

        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
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

        private void printDocumentTransacDe_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

        }
    }
}
