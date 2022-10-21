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
    public partial class frmAddAccessories : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        ClassGenerateID classGenerateID = new ClassGenerateID();
        ClassLoadData classLoadData = new ClassLoadData();
        SqlDataReader dr;
        string title = "BICO-JOSE System";
        //string I_ID, T_ID, P_ID, S_ID; int count;
        frmProductsList frmList;
        private bool mouseDown;
        private Point lastLocation;

        public frmAddAccessories(frmProductsList frmAdd)
        {

            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
            frmList = frmAdd;
            classLoadData.LoadRecordsItem(frmList.dataGridViewItems, frmList.txtSearch);
        }
        public void ClearItem()
        {
            btnSaveItem.Enabled = true;
            btnUpdateItem.Enabled = false;
            txtPrice.Clear();
            txtDescription.Clear();
            txtPrice.Focus();

        }
        public void ClearType()
        {

            txtType.Clear();
            txtType.Focus();

        }
        public void ClearService()
        {
            btnSaveService.Enabled = true;

            txtServiceID.Clear();
            txtServiceName.Clear();
            txtServiceDesc.Clear();
            txtServicePrice.Clear();
            txtServiceName.Focus();

        }
        public void ClearProduct()
        {
            txtProduct.Clear();
            txtProduct.Focus();

        }
        


        private void btnSaveAccessories_Click(object sender, EventArgs e)
        {
            
            
        }

        private void btnCancelAccessories_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnCloseAccessories_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void comBoxTypeAccessories_TextChanged(object sender, EventArgs e)
        {
            
            
            
        }

        private void comBoxTypeAccessories_SelectedIndexChanged(object sender, EventArgs e)
        {
            //LoadProductItem();
        }

        private void frmAddAccessories_Load(object sender, EventArgs e)
        {

        }

        private void txtDescription_TextChanged(object sender, EventArgs e)
        {

        }

        //private void GenerateID_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        //{
            
        //}

        private void btnUpdateAccessories_Click(object sender, EventArgs e)
        {
            
        }

        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
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

        private void comBoxType_TextUpdate(object sender, EventArgs e)
        {
            
        }

        private void comBoxType_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        

        private void comBoxType_SelectedIndexChanged(object sender, EventArgs e)
        {
            classLoadData.LoadProductItem(txtProduct, txtTypeID, comBoxType);
        }

        private void comBoxProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            classLoadData.LoadProductID(txtProductIDType, comBoxProductType);
        }

        private void btnSaveService_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure you want to save this record?", title, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cn.Open();
                    cm = new SqlCommand("INSERT INTO tblServices (Service_ID, Name, Description, Price) VALUES(@ID, @Name, @Description, @Price)", cn);
                    cm.Parameters.AddWithValue("@ID", txtServiceID.Text);
                    cm.Parameters.AddWithValue("@Name", txtServiceName.Text);
                    cm.Parameters.AddWithValue("@Description", txtServiceDesc.Text);
                    cm.Parameters.AddWithValue("@Price", txtServicePrice.Text);
                    cm.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Record has been successfully saved.", title, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearService();
                    btnUpdateService.Enabled = false;
                    classLoadData.LoadRecordsService(frmList.dataGridViewService, frmList.txtSearchService);
                    //frmList.LoadRecordsService();
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnUpdateService_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure you want to update this record?", title, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cn.Open();
                    cm = new SqlCommand("UPDATE tblServices SET Service_ID = @ID, Name = @Name, Description = @Description, Price = @Price WHERE Service_ID LIKE '" + txtServiceID.Text + "'", cn);
                    cm.Parameters.AddWithValue("@ID", txtServiceID.Text);
                    cm.Parameters.AddWithValue("@Name", txtServiceName.Text);
                    cm.Parameters.AddWithValue("@Description", txtServiceDesc.Text);
                    cm.Parameters.AddWithValue("@Price", txtServicePrice.Text);
                    cm.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Record has been successfully updated.");
                    ClearService();
                    btnSaveService.Enabled = false;
                    classLoadData.LoadRecordsService(frmList.dataGridViewService, frmList.txtSearchService);
                    //frmList.LoadRecordsService();
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCloseService_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtServicePrice_KeyPress(object sender, KeyPressEventArgs e)
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

        private void btnSaveType_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure you want to save this record?", title, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cn.Open();
                    cm = new SqlCommand("INSERT INTO tblType (Type_ID, Type, Product_ID, Product) VALUES(@ID, @Type, @ProductID, @Product)", cn);
                    cm.Parameters.AddWithValue("@ID", txtTypID.Text);
                    cm.Parameters.AddWithValue("@ProductID", txtProductIDType.Text);
                    cm.Parameters.AddWithValue("@Product", comBoxProductType.Text);
                    cm.Parameters.AddWithValue("@Type", txtType.Text);
                    cm.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Record has been successfully saved.");
                    
                    ClearType();
                    classLoadData.LoadRecordsType(frmList.dataGridViewType, frmList.txtSearchTypeProducts);
                    classLoadData.LoadRecordsItem(frmList.dataGridViewItems, frmList.txtSearch);
                    //frmList.LoadRecordsType();
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message, title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSaveProduct_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure you want to save this record?", title, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cn.Open();
                    cm = new SqlCommand("INSERT INTO tblProduct (Product_ID, Product) VALUES(@ID, @Product)", cn);
                    cm.Parameters.AddWithValue("@ID", txtProdID.Text);
                    cm.Parameters.AddWithValue("@Product", txtProdName.Text);

                    cm.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Record has been successfully saved.");
                    ClearProduct();
                    classLoadData.LoadRecordsProduct(frmList.dataGridViewProduct, frmList.txtSearchProduct);
                    //frmList.LoadRecordsProduct();
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUpdateProduct_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure you want to update this record?", title, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cn.Open();
                    cm = new SqlCommand("UPDATE tblProduct SET Product_ID = @ID, Product = @Product WHERE Product_ID LIKE '" + txtProdID.Text + "'", cn);
                    cm.Parameters.AddWithValue("@ID", txtProdID.Text);
                    cm.Parameters.AddWithValue("@Product", txtProdName.Text);
                    cm.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Record has been successfully updated.");
                    ClearProduct();
                    btnSaveProduct.Enabled = false;
                    btnUpdateProduct.Enabled = true;
                    classLoadData.LoadRecordsProduct(frmList.dataGridViewProduct, frmList.txtSearchProduct);
                    //frmList.LoadRecordsProduct();
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUpdateType_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure you want to update this record?", title, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cn.Open();
                    cm = new SqlCommand("UPDATE tblType SET Type_ID = @ID, Type = @Type, Product_ID = @ProductID, Product = @Product WHERE Type_ID LIKE '" + txtTypID.Text + "'", cn);
                    cm.Parameters.AddWithValue("@ID", txtTypID.Text);
                    cm.Parameters.AddWithValue("@ProductID", txtProductIDType.Text);
                    cm.Parameters.AddWithValue("@Product", comBoxProductType.Text);
                    cm.Parameters.AddWithValue("@Type", txtType.Text);
                    cm.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Record has been successfully updated.");
                    ClearType();
                    btnSaveType.Enabled = false;
                    btnUpdateType.Enabled = true;
                    classLoadData.LoadRecordsType(frmList.dataGridViewType, frmList.txtSearchTypeProducts);
                    classLoadData.LoadRecordsItem(frmList.dataGridViewItems, frmList.txtSearch);
                    //frmList.LoadRecordsType();
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message, title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnCancelType_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancelProduct_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure you want to save this record?", title, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cn.Open();
                    cm = new SqlCommand("INSERT INTO tblItem (Item_ID, Type_ID, Description, Price, Classification, Type, Stock_Level) VALUES(@ID, @TypeID, @Description, @Price, @Classification, @Type, @Stock_Level)", cn);
                    cm.Parameters.AddWithValue("@ID", txtID.Text);
                    cm.Parameters.AddWithValue("@Description", txtDescription.Text);
                    cm.Parameters.AddWithValue("@TypeID", txtTypeID.Text);
                    cm.Parameters.AddWithValue("@Price", txtPrice.Text);
                    cm.Parameters.AddWithValue("@Classification", comBoxClassification.Text);
                    cm.Parameters.AddWithValue("@Type", comBoxType.Text);
                    cm.Parameters.AddWithValue("@Stock_Level", 3);
                    cm.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Record has been successfully saved.");
                    ClearItem();
                    btnUpdateItem.Enabled = false;
                    classLoadData.LoadRecordsItem(frmList.dataGridViewItems, frmList.txtSearch);
                    //frmList.LoadRecordsItem();
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnUpdateItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure you want to update this record?", title, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cn.Open();
                    cm = new SqlCommand("UPDATE tblItem SET Item_ID = @ItemID, Type_ID = @TypeID, Description = @Description, Price = @Price, Classification = @Classification WHERE Item_ID LIKE '" + txtID.Text + "'", cn);
                    cm.Parameters.AddWithValue("@ItemID", txtID.Text);
                    cm.Parameters.AddWithValue("@Description", txtDescription.Text);
                    cm.Parameters.AddWithValue("@Price", txtPrice.Text);
                    cm.Parameters.AddWithValue("@TypeID", txtTypeID.Text);
                    cm.Parameters.AddWithValue("@Classification", comBoxClassification.Text);
                    cm.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Record has been successfully updated.");
                    ClearItem();
                    btnSaveItem.Enabled = false;
                    classLoadData.LoadRecordsItem(frmList.dataGridViewItems, frmList.txtSearch);
                    //frmList.LoadRecordsItem();
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnCancelItem_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void panelProduct_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
