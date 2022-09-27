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
    public partial class frmSettlePayment : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        SqlDataReader dr;
        string title = "BICO-JOSE System";
        int num = 0;
        private bool mouseDown;
        private Point lastLocation;

        public frmSettlePayment()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnCloseDiscount_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtPayment_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double sales = double.Parse(txtTotal.Text);
                double payment = double.Parse(txtPayment.Text);
                double change = payment - sales;
                txtChange.Text = change.ToString("#,##0.00");

                
                if (txtPayment.Text == string.Empty)
                {
                    txtPayment.Text = "0";
                    txtPayment.SelectAll();
                }
                
            }
            catch(Exception ex)
            {
                txtChange.Text = "0.00";
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            
            txtPayment.Clear();
            txtPayment.Focus();
        }

        private void btnOne_Click(object sender, EventArgs e)
        {
            txtPayment.Text += btnOne.Text;
        }

        private void btnTwo_Click(object sender, EventArgs e)
        {
            txtPayment.Text += btnTwo.Text;
        }

        private void btnThree_Click(object sender, EventArgs e)
        {
            txtPayment.Text += btnThree.Text;
        }

        private void btnFour_Click(object sender, EventArgs e)
        {
            txtPayment.Text += btnFour.Text;
        }

        private void btnFive_Click(object sender, EventArgs e)
        {
            txtPayment.Text += btnFive.Text;
        }

        private void btnSix_Click(object sender, EventArgs e)
        {
            txtPayment.Text += btnSix.Text;
        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            txtPayment.Text += btnZero.Text;
        }

        private void btnSeven_Click(object sender, EventArgs e)
        {
            txtPayment.Text += btnSeven.Text;
        }

        private void btnEight_Click(object sender, EventArgs e)
        {
            txtPayment.Text += btnEight.Text;
        }

        private void btnDoubleZero_Click(object sender, EventArgs e)
        {
            txtPayment.Text += btnDoubleZero.Text;
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            try
            {
                frmCashier frmC = new frmCashier();
                if (double.Parse(txtChange.Text) < 0 || (txtChange.Text == String.Empty))
                {
                    MessageBox.Show("Insufficient amount. Please enter the correct amount!", title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    comBoxMethodPayment.Text = frmC.lblMethod.Text;
                    comBoxPaymentTerms.Text = frmC.lblTerms.Text;
                    for (int i = 0; i < frmC.dataGridViewCart.Rows.Count; i++)
                    {
                        cn.Open();
                        cm = new SqlCommand("UPDATE tblItem SET Quantity = Quantity - " + int.Parse(frmC.dataGridViewCart.Rows[i].Cells[4].Value.ToString()) + " WHERE Item_ID LIKE '" + frmC.dataGridViewCart.Rows[i].Cells[12].Value.ToString() + "'", cn);
                        cm.ExecuteNonQuery();
                        cn.Close();

                        cn.Open();
                        cm = new SqlCommand("UPDATE tblCart SET Status = 'Sold' WHERE num LIKE '" + frmC.dataGridViewCart.Rows[i].Cells[11].Value.ToString() + "'", cn);
                        cm.ExecuteNonQuery();
                        cn.Close();
                    }
                    MessageBox.Show("Payment succesfully saved", title, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmC.GenerateTransactionNo();
                    frmC.LoadCart();
                    this.Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
                //MessageBox.Show("Insufficient amount. Please enter the correct amount!", title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void txtPayment_KeyPress(object sender, KeyPressEventArgs e)
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

        private void btnTwenty_Click(object sender, EventArgs e)
        {
            num = int.Parse(txtPayment.Text) + 20;
            txtPayment.Text = num.ToString();
        }

        private void btnFifty_Click(object sender, EventArgs e)
        {
            num = int.Parse(txtPayment.Text) + 50;
            txtPayment.Text = num.ToString();
        }

        private void btnOneH_Click(object sender, EventArgs e)
        {
            num = int.Parse(txtPayment.Text) + 100;
            txtPayment.Text = num.ToString();
        }

        private void btnTwoH_Click(object sender, EventArgs e)
        {
            num = int.Parse(txtPayment.Text) + 200;
            txtPayment.Text = num.ToString();
        }

        private void btnFiveH_Click(object sender, EventArgs e)
        {
            num = int.Parse(txtPayment.Text) + 500;
            txtPayment.Text = num.ToString();
        }

        private void btnThousand_Click(object sender, EventArgs e)
        {
            num = int.Parse(txtPayment.Text) + 1000;
            txtPayment.Text = num.ToString();
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;

        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }

        }

        private void panel2_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }
    }
}
