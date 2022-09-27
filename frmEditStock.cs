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
    public partial class frmEditStock : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        SqlDataReader dr;
        frmStockIn frmList;
        string title = "BICO-JOSE System";
        private bool mouseDown;
        private Point lastLocation;

        public frmEditStock(frmStockIn frmAdd)
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
            frmList = frmAdd;
            lblCheck.Text = "Yes";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {        //Perishable
                if (lblCheck.Text == "Yes")
                {
                    if (MessageBox.Show("Are you sure you want to update this record?", title, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        int i = frmList.dataGridViewStockItems.CurrentRow.Index;

                        cn.Open();
                        cm = new SqlCommand("UPDATE tblStock SET Expiration_Date = '" + DateTime.Parse(dateExpiration.Value.ToString()).ToShortDateString() + "', Quantity = Quantity + " + int.Parse(txtQuantity.Text) + " WHERE num LIKE '" + lblID.Text + "' ", cn);
                        cm.ExecuteNonQuery();
                        cn.Close();

                        frmList.dataGridViewStockItems[6, i].Value = DateTime.Parse(dateExpiration.Value.ToString()).ToShortDateString();
                        frmList.dataGridViewStockItems[5, i].Value = txtQuantity.Text;

                        this.Close();

                    }
                }    //Non-Perishable
                else if(lblCheck.Text == "No")
                {
                    if (MessageBox.Show("Are you sure you want to update this record?", title, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        int i = frmList.dataGridViewStockItems.CurrentRow.Index;

                        cn.Open();
                        cm = new SqlCommand("UPDATE tblStock SET Expiration_Date = null, Quantity = Quantity + " + int.Parse(txtQuantity.Text) + " WHERE num LIKE '" + lblID.Text + "' ", cn);
                        cm.ExecuteNonQuery();
                        cn.Close();
                        frmList.dataGridViewStockItems[6, i].Value = "Non-Perishable";
                        frmList.dataGridViewStockItems[5, i].Value = txtQuantity.Text;
                        this.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void txtQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 46)
            {
                //accept . character
            }
            else if (e.KeyChar == 8)
            {
                //accept backspace
            }
            else if ((e.KeyChar < 48) || (e.KeyChar > 57))
            {
                //ascii code 48 - 57 = characters between 0 - 9
                e.Handled = true;
            }
        }

        private void btnPerishable_Click(object sender, EventArgs e)
        {
            dateExpiration.Enabled = true;
            lblCheck.Text = "Yes";
            btnNonPerishable.Enabled = false;
        }

        private void btnNonPerishable_Click(object sender, EventArgs e)
        {
            dateExpiration.Enabled = false;
            lblCheck.Text = "No";
            btnPerishable.Enabled = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {
            if (txtQuantity.Text == string.Empty)
            {
                txtQuantity.Text = "0";
                txtQuantity.SelectAll();
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
        public void switchToEdit()
        {
            tabControl1.TabPages.Clear();
            TabPage tab = new TabPage("Edit Stock");
            tabControl1.TabPages.Add(tab);
            tab.Controls.Add(panel2);
        }
        public void switchToAdd()
        {
            tabControl1.TabPages.Clear();
            TabPage tab = new TabPage("Add Unit Measure");
            tabControl1.TabPages.Add(tab);
            tab.Controls.Add(panel3);
        }

        

        private void button1_Click(object sender, EventArgs e) //add button
        {
            switchToAdd();
 
        }

        private void btnCancelUnit_Click(object sender, EventArgs e)
        {
            switchToEdit();
            
        }
        public void LoadUnitMeasure()
        {
            comBoxUnit.Items.Clear();
                cn.Open();
                cm = new SqlCommand("SELECT UnitMeasure FROM tblUnitMeasure", cn);
                dr = cm.ExecuteReader();
                while (dr.Read())
                {
                comBoxUnit.Items.Add(dr[0].ToString());

                }
                dr.Close();
                cn.Close();
            }
        private void btnSaveUnit_Click(object sender, EventArgs e)
        {
            
            if (comBoxUnit.Items.Contains(txtUnit.Text))
            {
                MessageBox.Show("Unit is already in the list", title, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                cn.Open();
                cm = new SqlCommand("INSERT INTO tblUnitMeasure (UnitMeasure) VALUES(@Unit)", cn);
                cm.Parameters.AddWithValue("@Unit", txtUnit.Text);
                cm.ExecuteNonQuery();
                cn.Close();
                switchToEdit();
                LoadUnitMeasure();
            }
        }

        private void btnDeleteUnit_Click(object sender, EventArgs e)
        {
            
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnDeleteUnit_Click_1(object sender, EventArgs e)
        {
            string unit = comBoxUnit.SelectedItem.ToString();
            cn.Open();
            cm = new SqlCommand("DELETE FROM tblUnitMeasure WHERE UnitMeasure LIKE '" + unit + "'", cn);
            cm.ExecuteNonQuery();
            cn.Close();
            
            LoadUnitMeasure();
        }
    }
}
