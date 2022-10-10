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
    public partial class frmCashier : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        SqlDataReader dr;
        ClassComputations classCompute = new ClassComputations();
        ClassLoadData classLoadData = new ClassLoadData();
        ClassGenerateID classGenerateID = new ClassGenerateID();
        string title = "BICO-JOSE System";
        string num; int count;

        public frmCashier()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
            lblDate.Text = DateTime.Parse(DateTime.Now.ToString()).ToShortDateString();
            classLoadData.LoadCart(dataGridViewCart, lblDiscount, lblSalesTotal, lblPayment, lblNetTotal, btnSettlePayment, btnAddDiscount, btnClearCart, txtSearch, dataGridViewService);
            //classLoadData.LoadRecordServiceAvail(dataGridViewService, lblSalesTotal);
        }
        
        private void button2_Click(object sender, EventArgs e) //Browse Item btn
        {
            if (lblTransactionNo.Text == string.Empty)
            {
                MessageBox.Show("Please generate a Transaction No first", title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                frmBrowseItem frm = new frmBrowseItem(this);
                frm.lblTrans.Text = lblTransactionNo.Text;
                frm.ShowDialog();
            }
        }

        
        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
            frmLogin frm = new frmLogin();
            frm.ShowDialog();

        }
        
       

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAddDiscount_Click(object sender, EventArgs e)
        {
            if (dataGridViewCart.Rows.Count == 0)
            {
                MessageBox.Show("Select item on the Cart first", title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                int i = dataGridViewCart.SelectedRows[0].Index;
                frmDiscount frm = new frmDiscount(this);
                //frm.txtPriceDiscount.Text = dataGridViewCart[6, i].Value.ToString();                
                //frm.lblID.Text = dataGridViewCart[11, i].Value.ToString();
                frm.lblID.Text = lblTransactionNo.Text;
                frm.txtPriceDiscount.Text = lblSalesTotal.Text;
                frm.ShowDialog();
            }
        }

        private void btnSettlePayment_Click(object sender, EventArgs e)
        {
            if(txtFirstName.Text == "" && txtLastName.Text == "")
            {
                MessageBox.Show("Kindly input the customer's name first", title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtFirstName.Focus();
            }
            else
            {
                frmSettlePayment frm = new frmSettlePayment(this);
                frm.txtTotal.Text = lblNetTotal.Text;
                frm.comBoxPaymentTerms.SelectedIndex = 0;
                frm.comBoxMethodPayment.SelectedIndex = 0;
                frm.lblCustomer.Text = txtFirstName.Text + " " + txtLastName.Text;
                frm.lblCashier.Text = lblCashierName.Text;
                frm.lblTransacNo.Text = lblTransactionNo.Text;
                frm.ShowDialog();
            }
            
        }

        private void btnDailySales_Click(object sender, EventArgs e)
        {
            frmDailySales frm = new frmDailySales();
            classLoadData.LoadRecordsTransacHist(frm.dataGridViewTransacHist, frm.txtSearchTransac, frm.dateTimePickerStartTrans, frm.dateTimePickerEndTrans);
            classLoadData.LoadRecordsSoldItems(frm.dataGridViewSoldItems, frm.txtSearchSold, frm.dateTimePickerStartSold, frm.dateTimePickerEndSold);
            frm.ShowDialog();
        }

        private void btnChangePass_Click(object sender, EventArgs e)
        {
            //frmChangePassword frm = new frmChangePassword();
            //frm.ShowDialog();
        }

        private void btnNewTransaction_Click(object sender, EventArgs e)
        {
            classGenerateID.GenerateTransactionNo(lblTransactionNo);
            classLoadData.LoadCart(dataGridViewCart, lblDiscount, lblSalesTotal, lblPayment, lblNetTotal, btnSettlePayment, btnAddDiscount, btnClearCart, txtSearch, dataGridViewService);
        }
        
        private void dataGridViewCart_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dataGridViewCart.Columns[e.ColumnIndex].Name;
            if (colName == "DeleteCart")
            {
                if (MessageBox.Show("Remove this Item?", title, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cn.Open();
                    cm = new SqlCommand("DELETE FROM tblCart WHERE Num LIKE '" + dataGridViewCart.Rows[e.RowIndex].Cells[11].Value.ToString() + "'", cn);
                    cm.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Record has been successfully deleted.", title, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    classLoadData.LoadCart(dataGridViewCart, lblDiscount, lblSalesTotal, lblPayment, lblNetTotal, btnSettlePayment, btnAddDiscount, btnClearCart, txtSearch, dataGridViewService);
                    //LoadCart();

                }
            }
            else if (colName == "PlusCart")
            {
                cn.Open();
                cm = new SqlCommand("UPDATE tblCart SET Quantity = Quantity + 1 WHERE Num LIKE '" + dataGridViewCart.Rows[e.RowIndex].Cells[11].Value.ToString() + "'", cn);
                cm.ExecuteNonQuery();
                cn.Close();
                classLoadData.LoadCart(dataGridViewCart, lblDiscount, lblSalesTotal, lblPayment, lblNetTotal, btnSettlePayment, btnAddDiscount, btnClearCart, txtSearch, dataGridViewService);
                //LoadCart();
                classCompute.ComputeUnitTotal(dataGridViewCart);
                //ComputeUnitTotal();
            }
            else if (colName == "MinusCart")
            {
                cn.Open();
                cm = new SqlCommand("UPDATE tblCart SET Quantity = Quantity - 1 WHERE Num LIKE '" + dataGridViewCart.Rows[e.RowIndex].Cells[11].Value.ToString() + "'", cn);
                cm.ExecuteNonQuery();
                cn.Close();
                classLoadData.LoadCart(dataGridViewCart, lblDiscount, lblSalesTotal, lblPayment, lblNetTotal, btnSettlePayment, btnAddDiscount, btnClearCart, txtSearch, dataGridViewService);
                //LoadCart();
                classCompute.ComputeUnitTotal(dataGridViewCart);
                //ComputeUnitTotal();
            }

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtSearch.Text == String.Empty)
                {
                    classLoadData.LoadCart(dataGridViewCart, lblDiscount, lblSalesTotal, lblPayment, lblNetTotal, btnSettlePayment, btnAddDiscount, btnClearCart, txtSearch, dataGridViewService);
                    //LoadCart();
                    return;
                }
                else
                {
                    classLoadData.LoadCart(dataGridViewCart, lblDiscount, lblSalesTotal, lblPayment, lblNetTotal, btnSettlePayment, btnAddDiscount, btnClearCart, txtSearch, dataGridViewService);
                    //LoadCart();
                }
            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClearCart_Click(object sender, EventArgs e)
        {
            dataGridViewCart.Rows.Clear();

        }

        private void button1_Click(object sender, EventArgs e)//btnBrowseService
        {
            if (lblTransactionNo.Text == string.Empty)
            {
                MessageBox.Show("Please generate a Transaction No first", title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                frmDetailsSales frm = new frmDetailsSales(this);
                frm.Size = new Size(1229, 478); // 685, 478 
                frm.tabControl1.TabPages.Clear();
                TabPage tab = new TabPage("Browse Service");
                frm.tabControl1.TabPages.Add(tab);
                tab.Controls.Add(frm.panelBrowseService);
                //frm.lblTrans.Text = lblTransactionNo.Text;
                classLoadData.LoadRecordsBrowseService(frm.dataGridViewService, frm.txtSearchService);
                frm.ShowDialog();
            }

        }

        private void dataGridViewService_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dataGridViewService.Columns[e.ColumnIndex].Name;
            if (colName == "del")
            {
                if (MessageBox.Show("Remove this Item?", title, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cn.Open();
                    cm = new SqlCommand("DELETE FROM tblServiceAvailed WHERE Num LIKE '" + dataGridViewService.Rows[e.RowIndex].Cells[6].Value.ToString() + "'", cn);
                    //cm.Parameters.AddWithValue("@User_ID", lblUserID.Text);//dataGridViewService.Rows[e.RowIndex].Cells[6].Value.ToString()
                    cm.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Record has been successfully deleted.", title, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    classLoadData.LoadCart(dataGridViewCart, lblDiscount, lblSalesTotal, lblPayment, lblNetTotal, btnSettlePayment, btnAddDiscount, btnClearCart, txtSearch, dataGridViewService);
                    //classLoadData.LoadRecordServiceAvail(dataGridViewService, lblSalesTotal);
                    //LoadCart();

                }
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }

}
