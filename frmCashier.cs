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
        ClassInventory classInventory = new ClassInventory();
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
                //int i = dataGridViewCart.SelectedRows[0].Index;
                //frm.txtPriceDiscount.Text = dataGridViewCart[6, i].Value.ToString();                
                //frm.lblID.Text = dataGridViewCart[11, i].Value.ToString();
                frmDiscount frm = new frmDiscount(this);
                frm.tabControlDiscPromo.TabPages.Clear();
                TabPage tab = new TabPage("Discount");
                frm.tabControlDiscPromo.TabPages.Add(tab);
                tab.Controls.Add(frm.panelPromo);                
                frm.lblID.Text = lblTransactionNo.Text;
                frm.txtPriceDiscount.Text = lblSalesTotal.Text;
                frm.ShowDialog();
            }
        }

        private void btnSettlePayment_Click(object sender, EventArgs e)
        {
            frmSettlePayment frm = new frmSettlePayment(this);
            frm.lblRowCount.Text = dataGridViewCart.Rows.Count.ToString();
            frm.lblServRowCount.Text = dataGridViewService.Rows.Count.ToString();

            if (txtFirstName.Text == "" && txtLastName.Text == "")
            {
                MessageBox.Show("Kindly input the customer's name first", title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtFirstName.Focus();
                txtLastName.Focus();
            }
            else
            {
                frm.lblCheckSettleBalance.Text = "0";
                frm.labelTot.Text = "Total";
                frm.txtTotal.Text = lblNetTotal.Text;
                frm.comBoxPaymentTerms.SelectedIndex = 0;
                frm.comBoxMethodPayment.SelectedIndex = 0;
                frm.lblCustomer.Text = txtFirstName.Text + " " + txtLastName.Text;
                frm.lblCashier.Text = lblCashierName.Text;
                frm.lblTransacNo.Text = lblTransactionNo.Text;
                frm.lblGrossTotal.Text = lblSalesTotal.Text;
                frm.lblDiscount.Text = lblDiscount.Text;
                frm.lblDPercent.Text = lblDiscPercen.Text;
                 
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
        public void returnQuantity(string itemID, int CartQty)
        {
            cn = new SqlConnection(dbcon.MyConnection());
            cn.Open();//Set Quantity
            SqlCommand cm = new SqlCommand("UPDATE tblItem SET Quantity = Quantity + @Cart WHERE Stock_Check = 1 AND Item_ID LIKE '" + itemID + "'", cn);
            cm.Parameters.AddWithValue("@Cart", CartQty);
            cm.ExecuteNonQuery();
            cn.Close();

        }
        public void reducedQuantity(string itemID, int CartQty)
        {
            cn = new SqlConnection(dbcon.MyConnection());
            cn.Open();//Set Quantity
            SqlCommand cm = new SqlCommand("UPDATE tblItem SET Quantity = Quantity - @Cart WHERE Stock_Check = 1 AND Item_ID LIKE '" + itemID + "'", cn);
            cm.Parameters.AddWithValue("@Cart", CartQty);
            cm.ExecuteNonQuery();
            cn.Close();

        }
        public void selectTblQty(string itemID, out int currQty)
        {
            cn = new SqlConnection(dbcon.MyConnection());
            currQty = 0;
            cn.Open();
            SqlCommand cm = new SqlCommand("SELECT Quantity FROM tblItem WHERE Item_ID LIKE '" + itemID + "'", cn);
            dr = cm.ExecuteReader();
            if (dr.Read())
            {
                currQty = int.Parse(dr[0].ToString());
            }
            dr.Close();
            cn.Close();
        }
        private void dataGridViewCart_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string ItemID = dataGridViewCart.Rows[e.RowIndex].Cells[12].Value.ToString();
            int cartQty = int.Parse(dataGridViewCart.Rows[e.RowIndex].Cells[4].Value.ToString());
            int qtyCart = 1, tblQty = 0;
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
                    returnQuantity(ItemID, cartQty);
                    classInventory.determineStockLevel(ItemID);
                }
            }
            else if (colName == "PlusCart")
            {
                selectTblQty(ItemID, out tblQty);
                if(tblQty <= 0)
                {
                    qtyCart = 0;
                }
                else if(tblQty > 0)
                {
                    qtyCart = 1;
                }
                cn.Open();
                cm = new SqlCommand("UPDATE tblCart SET Quantity = Quantity + '"+ qtyCart + "' WHERE Num LIKE '" + dataGridViewCart.Rows[e.RowIndex].Cells[11].Value.ToString() + "'", cn);
                cm.ExecuteNonQuery();
                cn.Close();
                //classLoadData.LoadCart(dataGridViewCart, lblDiscount, lblSalesTotal, lblPayment, lblNetTotal, btnSettlePayment, btnAddDiscount, btnClearCart, txtSearch, dataGridViewService);
                
                classCompute.ComputeUnitTotal(dataGridViewCart);
                reducedQuantity(ItemID, qtyCart);
                classInventory.determineStockLevel(ItemID);
                
                classLoadData.LoadCart(dataGridViewCart, lblDiscount, lblSalesTotal, lblPayment, lblNetTotal, btnSettlePayment, btnAddDiscount, btnClearCart, txtSearch, dataGridViewService);
            }
            else if (colName == "MinusCart")
            {
                selectTblQty(ItemID, out tblQty);
                if (tblQty <= 0)//0 pababa pwede magadd sa tblItem
                {
                    qtyCart = 1;
                }
                else if (cartQty == 0)
                {
                    qtyCart = 0;
                }
                cn.Open();
                cm = new SqlCommand("UPDATE tblCart SET Quantity = Quantity - '" + qtyCart + "' WHERE Num LIKE '" + dataGridViewCart.Rows[e.RowIndex].Cells[11].Value.ToString() + "'", cn);
                cm.ExecuteNonQuery();
                cn.Close();
                //classLoadData.LoadCart(dataGridViewCart, lblDiscount, lblSalesTotal, lblPayment, lblNetTotal, btnSettlePayment, btnAddDiscount, btnClearCart, txtSearch, dataGridViewService);
                
                classCompute.ComputeUnitTotal(dataGridViewCart);
                
                returnQuantity(ItemID, qtyCart);
                classInventory.determineStockLevel(ItemID);
                classLoadData.LoadCart(dataGridViewCart, lblDiscount, lblSalesTotal, lblPayment, lblNetTotal, btnSettlePayment, btnAddDiscount, btnClearCart, txtSearch, dataGridViewService);
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

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            
        }

        private void btnSettleBalance_Click(object sender, EventArgs e)
        {
            frmEditPaymentOrder frm = new frmEditPaymentOrder();
            frm.ShowDialog();
        }

        private void btnAddPromo_Click(object sender, EventArgs e)
        {
            //int i = dataGridViewCart.SelectedRows[0].Index;
            //string Classifi = dataGridViewCart.Rows[i].Cells[14].Value.ToString();
            //if (Classifi == "Consumable")
            //{
            //    frmDiscount frm = new frmDiscount(this);
            //    frm.tabControlDiscPromo.TabPages.Clear();
            //    TabPage tab = new TabPage("Discount");
            //    frm.tabControlDiscPromo.TabPages.Add(tab);
            //    tab.Controls.Add(frm.panelPromo);
            //    frm.ShowDialog();
            //}
            //else
            //{
            //    //MessageBox.Show("Only items with expiration can have promo", title, MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}

            
            
            //frm.txtPriceDiscount.Text = dataGridViewCart[6, i].Value.ToString();                
            //frm.lblID.Text = dataGridViewCart[11, i].Value.ToString();
        }
    }

}
