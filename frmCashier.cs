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
        string title = "BICO-JOSE System";
        string num; int count;

        public frmCashier()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
            lblDate.Text = DateTime.Parse(DateTime.Now.ToString()).ToShortDateString();

        }
        public void LoadCartItem()
        {
            try
            {
                int i = 0;
                dataGridViewCart.Rows.Clear();
                cn.Open();
                cm = new SqlCommand("SELECT * from ViewCartItem WHERE Description Like '%" + txtSearch.Text + "%' AND Status LIKE 'Cart'", cn);
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
                                            // 0-Num            2-EXPIRATION / 2-Expiration_Date      4-QUANTITY / 3-Quantity              6-TOTAL / 5-TOTAL                                                                
                    i += 1;                 // 1-DESCRIPTION / 1-Description        3-PRICE / 4-Price                 5-DISCOUNT / 11-Discount                      7-Plus                         8-Minus                 9-Delete              10-ID / 5-Stock_Num
                    dataGridViewCart.Rows.Add(i, dr[1].ToString(), dr[2].ToString(), dr[4].ToString(), dr[3].ToString(), dr[11].ToString(), dr[5].ToString(), Properties.Resources._Add, Properties.Resources.Minus, Properties.Resources._Delete, dr[0].ToString());

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

        public void LoadCart()
        {
            try
            {
                int i = 0;
                dataGridViewCart.Rows.Clear();
                cn.Open();
                cm = new SqlCommand("SELECT * from ViewCartStockItem WHERE Description Like '%" + txtSearch.Text + "%' AND Status LIKE 'Cart'", cn);
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
                                            // 0-Num            2-EXPIRATION / 2-Expiration_Date      4-QUANTITY / 3-Quantity              6-TOTAL / 5-TOTAL                                                                
                    i += 1;                 // 1-DESCRIPTION / 1-Description        3-PRICE / 4-Price                 5-DISCOUNT / 11-Discount                      7-Plus                         8-Minus                 9-Delete              10-ID / 5-Stock_Num
                    dataGridViewCart.Rows.Add(i, dr[1].ToString(), ExpirationDate, dr[4].ToString(), dr[3].ToString(), dr[11].ToString(), dr[5].ToString(), Properties.Resources._Add, Properties.Resources.Minus, Properties.Resources._Delete, dr[0].ToString(), dr[12].ToString());

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
        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void GenerateTransactionNo()
        {
            try
            {
                string date = DateTime.Now.ToString("yyyyMMdd");
                cn.Open();
                cm = new SqlCommand("SELECT TOP 1 Transaction_No FROM tblCart ORDER BY Transaction_No DESC", cn);
                dr = cm.ExecuteReader();
                dr.Read();  
                if (dr.HasRows)
                {
                    num = dr[0].ToString(); //2022081710001
                    count = int.Parse(num.Substring(8, 5)); //10001
                    lblTransactionNo.Text = date + (count + 1); //2022081710002

                }
                else
                {

                    cn.Close();
                    cn.Open();
                    //DateTime current = DateTime.Now.Date;
                    //string shortdate = current.Date;
                    lblTransactionNo.Text = date + "10001";
                    cm = new SqlCommand("INSERT INTO tblCart (Transaction_No) VALUES(@Date)", cn);
                    cm.Parameters.AddWithValue("@Date", lblTransactionNo.Text);
                    cm.ExecuteNonQuery();
                    cn.Close();
                    GenerateTransactionNo();

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
                frm.txtPriceDiscount.Text = dataGridViewCart[6, i].Value.ToString();
                frm.lblID.Text = dataGridViewCart[10, i].Value.ToString();
                frm.ShowDialog();
            }

        }

        private void btnSettlePayment_Click(object sender, EventArgs e)
        {
            frmSettlePayment frm = new frmSettlePayment();
            frm.ShowDialog();
        }

        private void btnDailySales_Click(object sender, EventArgs e)
        {
            frmDailySales frm = new frmDailySales();
            frm.ShowDialog();
        }

        private void btnChangePass_Click(object sender, EventArgs e)
        {
            frmChangePassword frm = new frmChangePassword();
            frm.ShowDialog();
        }

        private void btnNewTransaction_Click(object sender, EventArgs e)
        {
            GenerateTransactionNo();
        }
        public void ComputeUnitTotal()
        {
            if (dataGridViewCart.Rows.Count > 0)
            {
                for (int i = 0; i < dataGridViewCart.Rows.Count; i++)
                {
                    //int i = dataGridViewCart.SelectedRows[0].Index;
                    float price = float.Parse(dataGridViewCart.Rows[i].Cells[3].Value.ToString());
                    int qty = int.Parse(dataGridViewCart.Rows[i].Cells[4].Value.ToString());
                    float total;
                    try
                    {
                        total = float.Parse(price.ToString()) * int.Parse(qty.ToString());
                        dataGridViewCart.Rows[i].Cells[6].Value = total.ToString("00.00");

                    }
                    catch (Exception ex)
                    {
                        cn.Close();
                        MessageBox.Show(ex.Message, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
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
                    LoadCart();

                }
            }
            else if (colName == "PlusCart")
            {
                cn.Open();
                cm = new SqlCommand("UPDATE tblCart SET Quantity = Quantity + 1 WHERE Num LIKE '" + dataGridViewCart.Rows[e.RowIndex].Cells[11].Value.ToString() + "'", cn);
                cm.ExecuteNonQuery();
                cn.Close();
                LoadCart();
                ComputeUnitTotal();
            }
            else if (colName == "MinusCart")
            {
                cn.Open();
                cm = new SqlCommand("UPDATE tblCart SET Quantity = Quantity - 1 WHERE Num LIKE '" + dataGridViewCart.Rows[e.RowIndex].Cells[11].Value.ToString() + "'", cn);
                cm.ExecuteNonQuery();
                cn.Close();
                LoadCart();
                ComputeUnitTotal();
            }

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtSearch.Text == String.Empty)
                {
                    LoadCart();
                    return;
                }
                else
                {
                    LoadCart();
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
