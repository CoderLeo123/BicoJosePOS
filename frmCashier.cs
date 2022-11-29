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
using System.Data.SQLite;
namespace Capstone
{
    public partial class frmCashier : Form
    {
        SQLiteConnection cn = new SQLiteConnection();
        SQLiteCommand cm = new SQLiteCommand();
        DBConnection dbcon = new DBConnection();
        SQLiteDataReader dr;
        ClassComputations classCompute = new ClassComputations();
        ClassLoadData classLoadData = new ClassLoadData();
        ClassGenerateID classGenerateID = new ClassGenerateID();
        ClassInventory classInventory = new ClassInventory();
        ClassLoginAndSignUp classLoginMethod = new ClassLoginAndSignUp();
        string title = "BICO-JOSE System";
        string num; int count;

        public frmCashier()
        {
            InitializeComponent();
            cn = new SQLiteConnection(dbcon.MyConnection);
            lblDate.Text = DateTime.Parse(DateTime.Now.ToString()).ToShortDateString();
            classLoadData.LoadCart(dataGridViewCart, lblDiscount, lblSalesTotal, lblPayment, lblNetTotal, btnSettlePayment, btnAddDiscount, btnClearCart, txtSearch, dataGridViewService, lblNetNoComa, lblGrossNoComma);
            
            textRightAlign();
        }
        public void textRightAlign()
        {

            this.dataGridViewCart.Columns["PriceCart"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            this.dataGridViewCart.Columns["TotalCart"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            this.dataGridViewService.Columns["priServ"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
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
            string ID = lblUserNum.Text;
            string loginTime = DateTime.Now.ToString();
            classLoginMethod.insertLogOutDateTime(ID, loginTime);
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
                frm.txtTotal.Text = lblNetNoComa.Text;
                frm.lblMoneyTitle.Visible = false;
                frm.txtMoney.Visible = false;
                frm.comBoxPaymentTerms.SelectedIndex = 0;
                frm.comBoxMethodPayment.SelectedIndex = 0;
                frm.lblCustomer.Text = txtFirstName.Text + " " + txtLastName.Text;
                frm.lblCashier.Text = lblCashierName.Text;
                frm.lblTransacNo.Text = lblTransactionNo.Text;
                frm.lblGrossTotal.Text = lblGrossNoComma.Text;
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
            classLoadData.LoadCart(dataGridViewCart, lblDiscount, lblSalesTotal, lblPayment, lblNetTotal, btnSettlePayment, btnAddDiscount, btnClearCart, txtSearch, dataGridViewService, lblNetNoComa, lblGrossNoComma);
            comBoxDiscountType.SelectedIndex = 0;
        }
        public void returnQuantity(string itemID, int CartQty)
        {
            cn = new SQLiteConnection(dbcon.MyConnection);
            cn.Open();//Set Quantity
            SQLiteCommand cm = new SQLiteCommand("UPDATE tblItem SET Quantity = Quantity + @Cart WHERE Stock_Check = 1 AND Item_ID LIKE '" + itemID + "'", cn);
            cm.Parameters.AddWithValue("@Cart", CartQty);
            cm.ExecuteNonQuery();
            cn.Close();

        }
        public void reducedQuantity(string itemID, int CartQty)
        {
            cn = new SQLiteConnection(dbcon.MyConnection);
            cn.Open();//Set Quantity
            SQLiteCommand cm = new SQLiteCommand("UPDATE tblItem SET Quantity = Quantity - @Cart WHERE Stock_Check = 1 AND Item_ID LIKE '" + itemID + "'", cn);
            cm.Parameters.AddWithValue("@Cart", CartQty);
            cm.ExecuteNonQuery();
            cn.Close();

        }
        public void selectTblQty(string itemID, out int currQty)
        {
            cn = new SQLiteConnection(dbcon.MyConnection);
            currQty = 0;
            cn.Open();
            SQLiteCommand cm = new SQLiteCommand("SELECT Quantity FROM tblItem WHERE Item_ID LIKE '" + itemID + "'", cn);
            dr = cm.ExecuteReader();
            if (dr.Read())
            {
                currQty = int.Parse(dr[0].ToString());
            }
            dr.Close();
            cn.Close();
        }
        public void reducedQuantityTblStock(string SNum, int CartQty)
        {
            //string StkID = dataGridViewStockItems.Rows[i].Cells[3].Value?.ToString();
            cn = new SQLiteConnection(dbcon.MyConnection);
            cn.Open();//Set Quantity
            SQLiteCommand cm = new SQLiteCommand("UPDATE tblStockInventory SET Quantity = Quantity - @Cart WHERE Stock_Num LIKE " + SNum + " ", cn);
            cm.Parameters.AddWithValue("@Cart", CartQty);
            cm.ExecuteNonQuery();
            cn.Close();

        }
        public void returnQuantityTblStock(int SNum, int CartQty)
        {
            //string StkID = dataGridViewStockItems.Rows[i].Cells[3].Value?.ToString();
            cn = new SQLiteConnection(dbcon.MyConnection);
            cn.Open();//Set Quantity
            SQLiteCommand cm = new SQLiteCommand("UPDATE tblStockInventory SET Quantity = Quantity + @Cart, Status = 'Available' WHERE Stock_Num = " + SNum + " ", cn);
            cm.Parameters.AddWithValue("@Cart", CartQty);
            cm.ExecuteNonQuery();
            cn.Close();
        }
        public void updateTblStock(int SNum)
        {
            cn = new SQLiteConnection(dbcon.MyConnection);
            cn.Open();//Set Quantity
            SQLiteCommand cm = new SQLiteCommand("Update tblStock SET Item_Status = 'Available' WHERE Num = " + SNum + "", cn);
            cm.ExecuteNonQuery();
            cn.Close();
        }
        private void dataGridViewCart_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string ItemID = dataGridViewCart.Rows[e.RowIndex].Cells[12].Value.ToString();
            string Classfic = dataGridViewCart.Rows[e.RowIndex].Cells[16].Value.ToString();
            int sNum = int.Parse(dataGridViewCart.Rows[e.RowIndex].Cells[10].Value.ToString());
            int cartQty = int.Parse(dataGridViewCart.Rows[e.RowIndex].Cells[4].Value.ToString());
            int qtyCart = 1, tblQty = 0;
            string colName = dataGridViewCart.Columns[e.ColumnIndex].Name;
            if (colName == "DeleteCart")
            {
                if (MessageBox.Show("Remove this Item?", title, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cn.Open();
                    cm = new SQLiteCommand("DELETE FROM tblCart WHERE Num LIKE '" + dataGridViewCart.Rows[e.RowIndex].Cells[11].Value.ToString() + "'", cn);
                    cm.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Record has been successfully deleted.", title, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    classLoadData.LoadCart(dataGridViewCart, lblDiscount, lblSalesTotal, lblPayment, lblNetTotal, btnSettlePayment, btnAddDiscount, btnClearCart, txtSearch, dataGridViewService, lblNetNoComa, lblGrossNoComma);
                    //LoadCart();
                    returnQuantity(ItemID, cartQty);
                    classInventory.determineStockLevel(ItemID);
                    if(Classfic == "Consumable")
                    {
                        returnQuantityTblStock(sNum, cartQty);
                        updateTblStock(sNum);
                    }

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
                cm = new SQLiteCommand("UPDATE tblCart SET Quantity = Quantity + '" + qtyCart + "' WHERE Num LIKE '" + dataGridViewCart.Rows[e.RowIndex].Cells[11].Value.ToString() + "'", cn);
                cm.ExecuteNonQuery();
                cn.Close();
               
                classCompute.ComputeUnitTotal(dataGridViewCart);
                reducedQuantity(ItemID, qtyCart);
                classInventory.determineStockLevel(ItemID);
                
                classLoadData.LoadCart(dataGridViewCart, lblDiscount, lblSalesTotal, lblPayment, lblNetTotal, btnSettlePayment, btnAddDiscount, btnClearCart, txtSearch, dataGridViewService, lblNetNoComa, lblGrossNoComma);
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
                cm = new SQLiteCommand("UPDATE tblCart SET Quantity = Quantity - '" + qtyCart + "' WHERE Num LIKE '" + dataGridViewCart.Rows[e.RowIndex].Cells[11].Value.ToString() + "'", cn);
                cm.ExecuteNonQuery();
                cn.Close();
                if (Classfic == "Consumable")
                {
                    returnQuantityTblStock(sNum, qtyCart); 
                }
                classCompute.ComputeUnitTotal(dataGridViewCart);
                
                returnQuantity(ItemID, qtyCart);
                classInventory.determineStockLevel(ItemID);
                classLoadData.LoadCart(dataGridViewCart, lblDiscount, lblSalesTotal, lblPayment, lblNetTotal, btnSettlePayment, btnAddDiscount, btnClearCart, txtSearch, dataGridViewService, lblNetNoComa, lblGrossNoComma);
            }

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtSearch.Text == String.Empty)
                {
                    classLoadData.LoadCart(dataGridViewCart, lblDiscount, lblSalesTotal, lblPayment, lblNetTotal, btnSettlePayment, btnAddDiscount, btnClearCart, txtSearch, dataGridViewService, lblNetNoComa, lblGrossNoComma);
                    //LoadCart();
                    return;
                }
                else
                {
                    classLoadData.LoadCart(dataGridViewCart, lblDiscount, lblSalesTotal, lblPayment, lblNetTotal, btnSettlePayment, btnAddDiscount, btnClearCart, txtSearch, dataGridViewService, lblNetNoComa, lblGrossNoComma);
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
           
            if (dataGridViewCart.Rows.Count > 0)
            {
                if (MessageBox.Show("Remove these Items?", title, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    for (int i = 0; i < dataGridViewCart.Rows.Count; i++)
                    {
                        cn.Open();
                        cm = new SQLiteCommand("DELETE FROM tblCart WHERE num Status LIKE 'Cart'", cn);
                        cm.ExecuteNonQuery();
                        cn.Close();
                    }
                    classLoadData.LoadCart(dataGridViewCart, lblDiscount, lblSalesTotal, lblPayment, lblNetTotal, btnSettlePayment, btnAddDiscount, btnClearCart, txtSearch, dataGridViewService, lblNetNoComa, lblGrossNoComma);
                }
            }

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
                    cm = new SQLiteCommand("DELETE FROM tblServiceAvailed WHERE Num LIKE '" + dataGridViewService.Rows[e.RowIndex].Cells[6].Value.ToString() + "'", cn);
                    //cm.Parameters.AddWithValue("@User_ID", lblUserID.Text);//dataGridViewService.Rows[e.RowIndex].Cells[6].Value.ToString()
                    cm.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Record has been successfully deleted.", title, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    classLoadData.LoadCart(dataGridViewCart, lblDiscount, lblSalesTotal, lblPayment, lblNetTotal, btnSettlePayment, btnAddDiscount, btnClearCart, txtSearch, dataGridViewService, lblNetNoComa, lblGrossNoComma);
               

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
           
        }

        private void comBoxDiscountType_SelectedIndexChanged(object sender, EventArgs e)
        {
            float discountPerc = 0;
            string transNo = lblTransactionNo.Text;
            if(comBoxDiscountType.SelectedIndex == 1)
            {
                discountPerc = 20;
                lblDiscPercen.Text = "20";
            }
            else if (comBoxDiscountType.SelectedIndex == 0)
            {
                discountPerc = 0;
                lblDiscPercen.Text = "0";

            }

            cn.Open();
            cm = new SQLiteCommand("UPDATE tblCart SET Discount = " + discountPerc + " WHERE Transaction_No LIKE '%" + transNo + "%'", cn);
            cm.ExecuteNonQuery();
            cn.Close();
            classLoadData.LoadCart(dataGridViewCart, lblDiscount, lblSalesTotal, lblPayment, lblNetTotal, btnSettlePayment, btnAddDiscount, btnClearCart, txtSearch, dataGridViewService, lblNetNoComa, lblGrossNoComma);
        
        }
    }

}
