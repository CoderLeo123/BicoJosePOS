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
        string title = "BICO-JOSE System";
        frmCashier frmC;
        string check = "";
        

        public frmBrowseItem(frmCashier frmC)
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
            LoadRecordsBrowse();
            this.frmC = frmC;
            frmC.LoadCart();
        }
        public void LoadRecordsBrowse()
        {
            try
            {
                int i = 0;
                dataGridViewBrowse.Rows.Clear();
                cn.Open();
                cm = new SqlCommand("SELECT * from ViewItemProductType WHERE (Description LIKE '%" + txtSearch.Text + "%' OR Type LIKE '%" + txtSearch.Text + "%') AND Quantity > 0 ORDER BY Item_ID", cn);
                dr = cm.ExecuteReader();
                while (dr.Read())
                {

                               //                                   2-DESCRIPTION / 1-Description       4-PRODUCT / 3-Product               6-STOCK / 5-Quantity                                                                                                                                      
                    i += 1;                  // 0-Num   1-Item ID / 0-Item_ID                3-TYPE / 2-Type               5-PRICE / 4-Price                 7-CLASSIFICATION / 6-Classification                           
                    dataGridViewBrowse.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString(), dr[6].ToString());

                }
                dr.Close();
                cn.Close();
               
            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void LoadCartItem()
        {
            try
            {
                int i = 0;
                frmC.dataGridViewCart.Rows.Clear();
                cn.Open();
                cm = new SqlCommand("SELECT * from ViewCartItem WHERE Status LIKE 'Cart'", cn);
                dr = cm.ExecuteReader();
                while (dr.Read())
                {
                    string ExpirationDate = dr[2].ToString();
                    //if (string.IsNullOrEmpty(ExpirationDate))
                    //{
                    //    ExpirationDate = "Non-Perishable";

                    //}
                    //else
                    //{
                    //    if (ExpirationDate.Substring(0, 10) != "")
                    //    {
                    //        ExpirationDate = dr[2].ToString().Substring(0, 9);
                    //    }
                    //    else
                    //    {
                    //        ExpirationDate = dr[2].ToString().Substring(0, 10);
                    //    }

                    //}

                                             // 0-Num                2-EXPIRATION / 2-Classification     4-QUANTITY / 3-Quantity              6-TOTAL / 5-TOTAL                                                                
                    i += 1;                 // 1-DESCRIPTION / 1-Description           3-PRICE / 4-Price                 5-DISCOUNT / 11-Discount                      7-Plus                         8-Minus                 9-Delete               10-ID / 0 -Stock_Num
                    frmC.dataGridViewCart.Rows.Add(i, dr[1].ToString(), ExpirationDate, dr[3].ToString(), dr[4].ToString(), dr[5].ToString(), dr[6].ToString(), Properties.Resources._Add, Properties.Resources.Minus, Properties.Resources._Delete, dr[11].ToString());

                }
                dr.Close();
                cn.Close();

            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message, title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
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
                cm = new SqlCommand("SELECT * from ViewCartStockItem WHERE Status LIKE 'Cart'", cn);
                dr = cm.ExecuteReader();
                while (dr.Read())
                {
                    string ExpirationDate = dr[2].ToString();
                    if (string.IsNullOrEmpty(ExpirationDate))
                    {
                        ExpirationDate = "Non-Perishable";

                    }
                    else
                    {
                        if (ExpirationDate.Substring(0, 10) != "")
                        {
                            ExpirationDate = dr[2].ToString().Substring(0, 9);
                        }
                        else
                        {
                            ExpirationDate = dr[2].ToString().Substring(0, 10);
                        }

                    }

                    total += Double.Parse(dr[5].ToString());
                    discount += Double.Parse(dr[11].ToString());

                                            // 0-Num                2-EXPIRATION / 2-Expiration_Date     4-QUANTITY / 3-Quantity              6-TOTAL / 5-TOTAL                                                                
                    i += 1;                 // 1-DESCRIPTION / 1-Description           3-PRICE / 4-Price                 5-DISCOUNT / 11-Discount                      7-Plus                         8-Minus                 9-Delete               10-ID / 0 -Stock_Num
                    frmC.dataGridViewCart.Rows.Add(i, dr[1].ToString(), ExpirationDate, dr[4].ToString(), dr[3].ToString(), dr[11].ToString(), dr[5].ToString(), Properties.Resources._Add, Properties.Resources.Minus, Properties.Resources._Delete, dr[0].ToString(), dr[12].ToString());
                    hasRecord = true;
                }
                dr.Close();
                cn.Close();
                frmC.lblDiscount.Text = discount.ToString("#,##0.00");
                frmC.lblSalesTotal.Text = total.ToString("#,##0.00");
                frmC.GetCartTotal();
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
                    LoadRecordsBrowse();
                    return;
                }
                else
                {
                    LoadRecordsBrowse();
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
                string id = dataGridViewBrowse[1, e.RowIndex].Value.ToString();
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
                        i += 1;
                        frmE.dataGridViewExpDate.Rows.Add(i, DateTime.Parse(dr[0].ToString()).ToShortDateString(), dr[2].ToString(), Properties.Resources.AddNew, dr[1].ToString());
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
                    cm = new SqlCommand("SELECT Item_ID FROM tblCart WHERE Item_ID LIKE '" + id.ToString() + "' ", cn);
                    dr = cm.ExecuteReader();
                    if (dr.Read())
                    {
                        check = dr[0].ToString();
                    }
                    else
                    {
                        check = "";
                    }
                    cn.Close();
                    lblCheck.Text = check;
                    if (check == string.Empty)
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


                        frmE.lblName2.Text = dataGridViewBrowse[2, e.RowIndex].Value.ToString();
                        frmE.lblPrice2.Text = dataGridViewBrowse[5, e.RowIndex].Value.ToString();
                        frmE.lblTotal.Text = "0";
                        frmE.txtQuantity.Text = "0";
                        frmE.tabControl1.SelectedIndex = 1;
                        frmE.tabControl1.TabPages.Clear();
                        TabPage tab = new TabPage("Non Consumable");
                        frmE.tabControl1.TabPages.Add(tab);
                        tab.Controls.Add(frmE.panelNC);
                        tab.Controls.Add(frmE.lblName2);
                        tab.Controls.Add(frmE.dataGridViewNC);

                        frmE.ShowDialog();
                    }
                    else
                    {

                        MessageBox.Show("Selected Item is already in the Cart", title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;

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

