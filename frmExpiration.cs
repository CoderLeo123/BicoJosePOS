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
    public partial class frmExpiration : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        SqlDataReader dr;
        ClassComputations classCompute = new ClassComputations();
        ClassLoadData classLoadData = new ClassLoadData();
        string title = "BICO-JOSE System";
        frmBrowseItem frmB;
        int r;
        private bool mouseDown;
        private Point lastLocation;

        public frmExpiration(frmBrowseItem frmAdd)
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
            frmB = frmAdd;

            //dataGridViewSelected.Rows.Add('-', ' ', '0', '0', Properties.Resources._Add, Properties.Resources._Delete, '0');
        }
        //public void Compute()
        //{
        //    try
        //    {
        //        float total = float.Parse(lblPrice2.Text) * float.Parse(txtQuantity.Text);
        //        lblTotal.Text = total.ToString("#.##");

        //    }
        //    catch (Exception ex)
        //    {
        //        cn.Close();
        //        MessageBox.Show(ex.Message, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}
        private void btnClose_Click(object sender, EventArgs e)
        {
            try
            {
                cn.Open();
                cm = new SqlCommand("DELETE FROM tblBrowseExp", cn);
                cm.ExecuteNonQuery();
                cn.Close();
                this.Close();
            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void dataGridViewExpDate_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dataGridViewExpDate.Columns[e.ColumnIndex].Name;
            string id = dataGridViewExpDate[4, e.RowIndex].Value.ToString(); //num = Stock

            int i = 0;
            string num = dataGridViewExpDate[0, e.RowIndex].Value.ToString();
            if (colName == "Select")
            {
                try
                {

                    cn.Open();
                    cm = new SqlCommand("INSERT INTO tblBrowseExp (num, Expiration_Date, Quantity, Price) VALUES(@num, @Expiration_Date, @Quantity, @Price)", cn);
                    cm.Parameters.AddWithValue("@num", int.Parse(id.ToString()));
                    cm.Parameters.AddWithValue("@Expiration_Date", DateTime.Parse(dataGridViewExpDate[1, e.RowIndex].Value.ToString()).ToShortDateString());
                    cm.Parameters.AddWithValue("@Quantity", int.Parse(dataGridViewExpDate[2, e.RowIndex].Value.ToString()));
                    cm.Parameters.AddWithValue("@Price", double.Parse(lblPrice.Text));
                    cm.ExecuteNonQuery();
                    dataGridViewExpDate.Rows.RemoveAt(dataGridViewExpDate.CurrentRow.Index);

                    cn.Close();



                    cn.Open();
                    cm = new SqlCommand("SELECT * FROM tblBrowseExp WHERE num LIKE '" + id.ToString() + "' ", cn);
                    dr = cm.ExecuteReader();
                    while (dr.Read())
                    {
                        i += 1;
                        dataGridViewSelected.Rows.Add(i, DateTime.Parse(dr[1].ToString()).ToShortDateString(), dr[2].ToString(), '0', Properties.Resources._Add, Properties.Resources._Delete, dr[0].ToString());

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

        }

        private void dataGridViewSelected_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string colName = dataGridViewSelected.Columns[e.ColumnIndex].Name;
                string id = dataGridViewSelected[6, e.RowIndex].Value.ToString(); //num = Stock
                int i = 0;
                if (colName == "Delete")
                {


                    dataGridViewSelected.Rows.RemoveAt(dataGridViewSelected.CurrentRow.Index);

                    cn.Open();
                    cm = new SqlCommand("SELECT * FROM tblBrowseExp WHERE num LIKE '" + id.ToString() + "' ", cn);
                    dr = cm.ExecuteReader();
                    while (dr.Read())
                    {
                        i += 1;
                        dataGridViewExpDate.Rows.Add(i, DateTime.Parse(dr[1].ToString()).ToShortDateString(), dr[2].ToString(), Properties.Resources.AddNew, dr[0].ToString());

                    }
                    dr.Close();
                    cn.Close();


                    if (dataGridViewSelected.Rows.Count == 0)
                    {
                        cn.Open();
                        cm = new SqlCommand("DELETE FROM tblBrowseExp", cn);
                        cm.ExecuteNonQuery();
                        cn.Close();
                    }
                }
                else if (colName == "plus")
                {

                    dataGridViewSelected.Rows[e.RowIndex].Cells["Qty"].ReadOnly = false;
                    dataGridViewSelected.CurrentCell = dataGridViewSelected.Rows[e.RowIndex].Cells["Qty"];
                    dataGridViewSelected.BeginEdit(true);

                    //int stocks = int.Parse(dataGridViewSelected[2, e.RowIndex].Value.ToString());
                    //if ((int.Parse(dataGridViewSelected[2, e.RowIndex].Value.ToString()) < 1) || ((int.Parse(dataGridViewSelected[2, e.RowIndex].Value.ToString()) > stocks)))
                    //{
                    //    dataGridViewSelected[2, e.RowIndex].Value = stocks.ToString();
                    //}
                }
            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

 
        private void lblName_Click(object sender, EventArgs e)
        {

        }
        
        private void dataGridViewSelected_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            
            


        }

        private void dataGridViewSelected_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {

            //int i = dataGridViewSelected.CurrentRow.Index;
            //int i = dataGridViewSelected.SelectedRows[0].Index;
            //float price = float.Parse(lblPrice.Text);
            //int qty = int.Parse(dataGridViewSelected[2, e.RowIndex].Value.ToString());
            //float total = float.Parse(price.ToString()) * int.Parse(qty.ToString());
            //dataGridViewSelected[3, e.RowIndex].Value = total.ToString("0.00");
            //dataGridViewSelected.Rows[e.RowIndex].Cells["Qty"].ReadOnly = true;


        }

        private void dataGridViewSelected_RowValidating(object sender, DataGridViewCellCancelEventArgs e)
        {
           
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (dataGridViewSelected.Rows.Count > 0)
            {
                
                r = dataGridViewSelected.SelectedRows[0].Index;
                int y = frmB.dataGridViewBrowse.SelectedRows[0].Index;
                if (MessageBox.Show("Are you sure you want to save this record?", title, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    for (int i = 0; i < dataGridViewSelected.Rows.Count; i++)
                    {
                        
                    cn.Open();
                        cm = new SqlCommand("INSERT INTO tblCart (Stock_Num, Item_ID, Transaction_No, Quantity, Price, Total, Date, Status) VALUES (@Stock_Num, @Item_ID, @TransactionNo, @Quantity, @Price, @Total, @Date, 'Cart')", cn);
                        cm.Parameters.AddWithValue("@Stock_Num", dataGridViewSelected.Rows[i].Cells[6].Value.ToString());
                        cm.Parameters.AddWithValue("@Item_ID", frmB.dataGridViewBrowse.Rows[i].Cells[1].Value.ToString());
                        cm.Parameters.AddWithValue("@TransactionNo", frmB.lblTrans.Text);
                        cm.Parameters.AddWithValue("@Quantity", dataGridViewSelected.Rows[i].Cells[2].Value.ToString());
                        cm.Parameters.AddWithValue("@Price", lblPrice.Text);
                        cm.Parameters.AddWithValue("@Date", DateTime.Now);
                        cm.Parameters.AddWithValue("@Total", dataGridViewSelected.Rows[i].Cells[3].Value.ToString());
                        cm.ExecuteNonQuery();
                        cn.Close();
                        
                    }
                    MessageBox.Show("Successfully Added!", title, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmB.LoadCart();
                }
            }
            else
            {
                MessageBox.Show("Please select from the available item above first", title, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        private void dataGridViewSelected_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            float price = float.Parse(lblPrice.Text);
            int qty = int.Parse(dataGridViewSelected[2, e.RowIndex].Value.ToString());
            float total = float.Parse(price.ToString()) * int.Parse(qty.ToString());
            dataGridViewSelected[3, e.RowIndex].Value = total.ToString("#.##");
            dataGridViewSelected.Rows[e.RowIndex].Cells["Qty"].ReadOnly = true;
        }

        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {
            try
            {
                r = frmB.dataGridViewBrowse.SelectedRows[0].Index;
                //int Stock = int.Parse(frmB.dataGridViewBrowse[6, r].Value.ToString());
                int Stock = int.Parse(frmB.lblStock.Text);
                String txtInput = txtQuantity.Text;
                int input = int.Parse(txtInput);
                if (txtQuantity.Text == string.Empty)
                {
                    txtQuantity.Text = "0";
                    txtQuantity.Focus();
                    txtQuantity.SelectAll();
                }
                if ((input < 1) || (input > Stock))
                {

                    txtQuantity.Text = Stock.ToString();
                    txtQuantity.SelectAll();
                }
                classCompute.Compute(txtQuantity, lblPrice2, lblTotal);
            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == 8)
                {
                    //accept backspace
                }
                else if ((e.KeyChar < 48) || (e.KeyChar > 57))
                {
                    //ascii code 48 - 57 = characters between 0 - 9
                    e.Handled = true;
                    classCompute.Compute(txtQuantity, lblPrice2, lblTotal);
                    //Compute();
                }               
                 r = frmB.dataGridViewBrowse.SelectedRows[0].Index;
                int y = dataGridViewNC.SelectedRows[0].Index;
                if ((e.KeyChar == 13) && (txtQuantity.Text != String.Empty))
                {
                    cn.Open();
                    cm = new SqlCommand("INSERT INTO tblCart (Stock_Num, Item_ID, Transaction_No, Quantity, Price, Total, Date, Status) VALUES (@Stock_Num, @Item_ID, @TransactionNo, @Quantity, @Price, @Total, @Date, 'Cart')", cn);
                    //cm.Parameters.AddWithValue("@Stock_ID", frmB.dataGridViewBrowse[1, i].Value.ToString());
                    cm.Parameters.AddWithValue("@Stock_Num", dataGridViewNC[1, y].Value.ToString());
                    cm.Parameters.AddWithValue("@Item_ID", frmB.dataGridViewBrowse[1, r].Value.ToString());
                    cm.Parameters.AddWithValue("@TransactionNo", frmB.lblTrans.Text);
                    cm.Parameters.AddWithValue("@Quantity", txtQuantity.Text);
                    cm.Parameters.AddWithValue("@Price", lblPrice2.Text);
                    cm.Parameters.AddWithValue("@Date", DateTime.Now);
                    cm.Parameters.AddWithValue("@Total", lblTotal.Text);
                    cm.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Successfully Added!", title, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmB.LoadCart();
                }
                frmB.LoadCart();
            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;

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

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }
    }
}
