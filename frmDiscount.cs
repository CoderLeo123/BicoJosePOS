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
    
    public partial class frmDiscount : Form
    {
        SQLiteConnection cn = new SQLiteConnection();
        SQLiteCommand cm = new SQLiteCommand();
        DBConnection dbcon = new DBConnection();
        SQLiteDataReader dr;
        ClassLoadData classLoadData = new ClassLoadData();
        string title = "BICO-JOSE System";
        frmCashier frmC;
        private bool mouseDown;
        private Point lastLocation;

        public frmDiscount(frmCashier frmC)
        {
            InitializeComponent();
            cn = new SQLiteConnection(dbcon.MyConnection);
            this.frmC = frmC;
        }

        private void btnCloseDiscount_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void ComputeDiscount()
        {
            double discount = double.Parse(txtDiscount.Text) * .01;
            double result = double.Parse(txtPriceDiscount.Text) * discount;
            txtDiscountedAmount.Text = result.ToString();
        }
        private void txtDiscount_TextChanged(object sender, EventArgs e)
        {
            if (txtDiscount.Text == string.Empty)
            {
                txtDiscount.Text = "0";
                txtDiscount.SelectAll();
            }
            int value = int.Parse(txtDiscount.Text);
            if (value < 100){
                ComputeDiscount();
            }
            else
            {
                txtDiscount.Text = "0";
                txtDiscount.SelectAll();
                return;
            }
           
        }

        private void txtDiscount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 8)
            {
                //accept backspace
            }

            else if ((e.KeyChar < 48) || (e.KeyChar > 57))
            {
                //ascii code 48 - 57 = characters between 0 - 9
                e.Handled = true;
                
            }
        }

        private void btnConfirmDiscount_Click(object sender, EventArgs e)
        {
            
            if (txtDiscount.Text == string.Empty)
            {
                MessageBox.Show("Please input discount first. Otherwise, close this form", title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                
                if (MessageBox.Show("Are you sure you want to confirm this discount?", title, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        frmC.lblDiscount.Text = txtDiscountedAmount.Text;
                        frmC.lblDiscPercen.Text = txtDiscount.Text;
                        cn.Open();
                        cm = new SQLiteCommand("UPDATE tblCart SET Discount = '" + txtDiscount.Text + "' WHERE Transaction_No LIKE '%" + lblID.Text + "'", cn);
                        cm.ExecuteNonQuery();
                        cn.Close();
                        classLoadData.LoadCart(frmC.dataGridViewCart, frmC.lblDiscount, frmC.lblSalesTotal, frmC.lblPayment, frmC.lblNetTotal, frmC.btnSettlePayment, frmC.btnAddDiscount, frmC.btnClearCart, frmC.txtSearch, frmC.dataGridViewService, frmC.lblNetNoComa, frmC.lblGrossNoComma);
                        //frmC.LoadCart();
                        this.Close();

                    }
                    catch (Exception ex)
                    {
                        cn.Close();
                        MessageBox.Show(ex.Message, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
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
