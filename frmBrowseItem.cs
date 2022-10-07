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
    
    public partial class frmBrowseItem : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        SqlDataReader dr;
        ClassLoadData classLoadData = new ClassLoadData();
        ClassComputations classCompute = new ClassComputations();
        string title = "BICO-JOSE System";
        frmCashier frmC;
        string check = "";
        

        public frmBrowseItem(frmCashier frmC)
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
            classLoadData.LoadRecordsBrowse(dataGridViewBrowse, txtSearch);
            //LoadRecordsBrowse();
            this.frmC = frmC;
            classLoadData.LoadCart(frmC.dataGridViewCart, frmC.lblDiscount, frmC.lblSalesTotal, frmC.lblPayment, frmC.lblNetTotal, frmC.btnSettlePayment, frmC.btnAddDiscount, frmC.btnClearCart, frmC.txtSearch);
            //LoadCart();
        }
       
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        public void LoadCart()
        {
            try
            {
                Boolean hasRecord = false;
                int i = 0;
                double total = 0;
                double discount = 0;
                frmC.dataGridViewCart.Rows.Clear();
                cn.Open();
                cm = new SqlCommand("SELECT * from ViewCartStockItem WHERE Description Like '%" + frmC.txtSearch.Text + "%' AND Status LIKE 'Cart'", cn);
                dr = cm.ExecuteReader();
                while (dr.Read())
                {
                    string ExpirationDate = dr[2].ToString();
                    if (string.IsNullOrEmpty(ExpirationDate))
                    {
                        ExpirationDate = "Non-Consumable";
                    }
                    else
                    {
                        if (ExpirationDate.Substring(0, 9) != "")//0, 10
                        {
                            ExpirationDate = dr[2].ToString();// ().Substring(0, 9);
                        }
                        else
                        {
                            ExpirationDate = dr[2].ToString().Substring(0, 9);// 0, 10
                        }
                    }
                    total += Double.Parse(dr[5].ToString());
                    discount += Double.Parse(dr[11].ToString());

                                             // 0-Num                2-EXPIRATION / 2-Expiration_Date     4-QUANTITY / 3-Quantity              6-TOTAL / 5-TOTAL                                                                                                       10-CartID / 12-Num
                    i += 1;                 // 1-DESCRIPTION / 1-Description           3-PRICE / 4-Price                 5-DISCOUNT / 11-Discount                      7-Plus                         8-Minus                 9-Delete              10-StockID / 0-Stock_Num           10-ItemID / 9-Item_ID
                    frmC.dataGridViewCart.Rows.Add(i, dr[1].ToString(), ExpirationDate, dr[4].ToString(), dr[3].ToString(), dr[11].ToString(), dr[5].ToString(), Properties.Resources._Add, Properties.Resources.Minus, Properties.Resources._Delete, dr[0].ToString(), dr[12].ToString(), dr[9].ToString());
                    hasRecord = true;
                }
                dr.Close();
                cn.Close();
                frmC.lblDiscount.Text = discount.ToString("#,##0.00");
                frmC.lblSalesTotal.Text = total.ToString("#,##0.00");
                classCompute.GetCartTotal(frmC.lblDiscount, frmC.lblSalesTotal, frmC.lblPayment, frmC.lblNetTotal);
                //frmC.GetCartTotal();
                if (hasRecord == true)
                {
                    frmC.btnSettlePayment.Enabled = true; frmC.btnAddDiscount.Enabled = true; frmC.btnClearCart.Enabled = true;
                }
                else
                { frmC.btnSettlePayment.Enabled = false; frmC.btnAddDiscount.Enabled = false; frmC.btnClearCart.Enabled = false; }
            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message, title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtSearch.Text == String.Empty)
                {
                    classLoadData.LoadRecordsBrowse(dataGridViewBrowse, txtSearch);
                    //LoadRecordsBrowse();
                    return;
                }
                else
                {
                    classLoadData.LoadRecordsBrowse(dataGridViewBrowse, txtSearch);
                    //LoadRecordsBrowse();
                }
            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridViewBrowse_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string colName = dataGridViewBrowse.Columns[e.ColumnIndex].Name;
                string id = dataGridViewBrowse[1, e.RowIndex].Value.ToString(); // Item_ID
                string classification = dataGridViewBrowse[7, e.RowIndex].Value.ToString();
                
                frmExpiration frmE = new frmExpiration(this);
                int i = 0;
                if ((classification == "Consumable") && (colName == "AddToCart"))
                {
                    cn.Open();
                    cm = new SqlCommand("SELECT Expiration_Date, num, Quantity FROM ViewStockItemType WHERE Item_ID LIKE '" + id.ToString() + "' ", cn);
                    dr = cm.ExecuteReader();
                    while (dr.Read())
                    {
                        i += 1; //DateTime.Parse(dr[0].ToString()).ToShortDateString()
                        frmE.dataGridViewExpDate.Rows.Add(i, dr[0].ToString(), dr[2].ToString(), Properties.Resources.AddNew, dr[1].ToString());
                    }
                    dr.Close();
                    cn.Close();
                    
                    frmE.lblName.Text = dataGridViewBrowse[2, e.RowIndex].Value.ToString();
                    frmE.lblPrice.Text = dataGridViewBrowse[5, e.RowIndex].Value.ToString();
                    frmE.tabControl1.TabPages.Clear();
                    TabPage tab2 = new TabPage("Consumable");
                    frmE.tabControl1.TabPages.Add(tab2);
                    tab2.Controls.Add(frmE.panelC);
                    frmE.panelC.Dock = DockStyle.Fill;
                    frmE.ShowDialog();
                    
                }
                else
                {
                    cn.Open();
                    cm = new SqlCommand("SELECT Status FROM tblCart WHERE Item_ID LIKE '" + id.ToString() + "' ", cn);
                    dr = cm.ExecuteReader();
                    if (dr.Read())
                    {
                        check = dr[0].ToString();
                    }
       
                    cn.Close();
                    lblCheck.Text = check;
                    string Stock = lblStock.Text;
                    if (Stock.Equals("N/A"))
                    {
                        cn.Open();
                        cm = new SqlCommand("INSERT INTO tblCart (Stock_Num, Item_ID, Transaction_No, Quantity, Price, Total, Date, Status) VALUES (@Stock_Num, @Item_ID, @TransactionNo, @Quantity, @Price, @Total, @Date, 'Cart')", cn);
                        //cm.Parameters.AddWithValue("@Stock_ID", frmB.dataGridViewBrowse[1, i].Value.ToString());
                        cm.Parameters.AddWithValue("@Stock_Num", dataGridViewBrowse[1, e.RowIndex].Value.ToString());
                        cm.Parameters.AddWithValue("@Item_ID", dataGridViewBrowse[1, e.RowIndex].Value.ToString());
                        cm.Parameters.AddWithValue("@TransactionNo", lblTrans.Text);
                        cm.Parameters.AddWithValue("@Quantity", 0);
                        cm.Parameters.AddWithValue("@Price", dataGridViewBrowse[5, e.RowIndex].Value.ToString());
                        cm.Parameters.AddWithValue("@Date", DateTime.Now);
                        cm.Parameters.AddWithValue("@Total", dataGridViewBrowse[5, e.RowIndex].Value.ToString());
                        cm.ExecuteNonQuery();
                        cn.Close();
                        LoadCart();
                        this.Close();
                    }
                    else
                    {
                        if (!(check.Equals("Sold")))
                        {

                            cn.Open();
                            cm = new SqlCommand("SELECT Num, Quantity, Item_ID, Stock_ID FROM ViewStockItemType WHERE Item_ID LIKE '" + id.ToString() + "' ", cn);
                            dr = cm.ExecuteReader();
                            while (dr.Read())
                            {
                                i += 1;
                                frmE.dataGridViewNC.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString());
                            }
                            dr.Close();
                            cn.Close();

                            lblStock.Text = dataGridViewBrowse[6, e.RowIndex].Value.ToString();
                            frmE.lblName2.Text = dataGridViewBrowse[2, e.RowIndex].Value.ToString();
                            frmE.lblPrice2.Text = dataGridViewBrowse[5, e.RowIndex].Value.ToString();
                            frmE.lblItemIDPass.Text = dataGridViewBrowse[1, e.RowIndex].Value.ToString();
                            frmE.lblTotal.Text = "0";
                            frmE.txtQuantity.Text = "0";
                            frmE.txtQuantity.Focus();
                            frmE.txtQuantity.SelectAll();
                            frmE.tabControl1.SelectedIndex = 1;
                            frmE.tabControl1.TabPages.Clear();
                            TabPage tab = new TabPage("Non Consumable");
                            frmE.tabControl1.TabPages.Add(tab);
                            tab.Controls.Add(frmE.panelNC);
                            tab.Controls.Add(frmE.lblName2);
                            tab.Controls.Add(frmE.dataGridViewNC);
                            frmE.Size = new Size(620, 543);
                            frmE.ShowDialog();
                        }
                        else
                        {

                            MessageBox.Show("Selected Item is already in the Cart", title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;

                        }
                    }
                }
                
            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
    }

