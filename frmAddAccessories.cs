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
        string title = "BICO-JOSE System"; bool duplicate = false;        
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
        }

        private void frmAddAccessories_Load(object sender, EventArgs e)
        {
        }

        private void txtDescription_TextChanged(object sender, EventArgs e)
        {
        }      
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
                scanForDuplicateName("Name", "tblServices", txtServiceName, out duplicate);
                double Price = double.Parse(txtServicePrice.Text);
                string displayPrice = Price.ToString("#,##0.00");
                if (duplicate == false)
                {
                    if (MessageBox.Show("Are you sure you want to save this record?", title, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        cn.Open();
                        cm = new SqlCommand("INSERT INTO tblServices (Service_ID, Name, Description, Price, Display_Price) VALUES(@ID, @Name, @Description, @Price, @Display_Price)", cn);
                        cm.Parameters.AddWithValue("@ID", txtServiceID.Text);
                        cm.Parameters.AddWithValue("@Name", txtServiceName.Text);
                        cm.Parameters.AddWithValue("@Description", txtServiceDesc.Text);
                        cm.Parameters.AddWithValue("@Price", Price);
                        cm.Parameters.AddWithValue("@Display_Price", displayPrice);

                        cm.ExecuteNonQuery();
                        cn.Close();
                        MessageBox.Show("Record has been successfully saved.", title, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearService();
                        btnUpdateService.Enabled = false;
                        classLoadData.LoadRecordsService(frmList.dataGridViewService, frmList.txtSearchService);                       
                        this.Close();
                    }
                }
                else if (duplicate == true)
                {
                    MessageBox.Show("That service name is already on the record", title, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
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
                double Price = double.Parse(txtServicePrice.Text);
                string displayPrice = Price.ToString("#,##0.00");//₱
                  if (MessageBox.Show("Are you sure you want to update this record?", title, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        cn.Open();
                        cm = new SqlCommand("UPDATE tblServices SET Service_ID = @ID, Name = @Name, Description = @Description, Price = @Price, Display_Price = @Display_Price WHERE Service_ID LIKE '" + txtServiceID.Text + "'", cn);
                        cm.Parameters.AddWithValue("@ID", txtServiceID.Text);
                        cm.Parameters.AddWithValue("@Name", txtServiceName.Text);
                        cm.Parameters.AddWithValue("@Description", txtServiceDesc.Text);
                        cm.Parameters.AddWithValue("@Display_Price", displayPrice);
                        cm.Parameters.AddWithValue("@Price", Price);
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
                scanForDuplicateName("Type", "tblType", txtType, out duplicate);
                if (duplicate == false)
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
                        this.Close();
                    }
                }
                else if (duplicate == true)
                {
                    MessageBox.Show("That Type name is already on the record", title, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
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
                scanForDuplicateName("Product", "tblProduct", txtProdName, out duplicate);

                if (duplicate == false)
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
                        this.Close();
                    }
                }
                else if (duplicate == true)
                {
                    MessageBox.Show("That Product name is already on the record", title, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
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
        public void addPesoSign(string price, out string result)
        {
            int length = price.Length;
            result = price;
            if (length <= 4)
            {
                result = "\t\t" + price;
            }
            else if (length <= 8 && length > 4)
            {
                result = "\t" + price;
            }
        }
        private void btnSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                scanForDuplicateName("Description", "tblItem", txtDescription, out duplicate);
                double Price = double.Parse(txtPrice.Text);
                string displayPrice = Price.ToString("#,##0.00");             
                if (duplicate == false)
                {
                    if (MessageBox.Show("Are you sure you want to save this record?", title, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        cn.Open();
                        cm = new SqlCommand("INSERT INTO tblItem (Item_ID, Type_ID, Description, Price, Classification, Type, Stock_Level, Unit_Measure, Display_Price) VALUES(@ID, @TypeID, @Description, @Price, @Classification, @Type, @Stock_Level, @Unit_Measure, @Display_Price)", cn);
                        cm.Parameters.AddWithValue("@ID", txtID.Text);
                        cm.Parameters.AddWithValue("@Description", txtDescription.Text);
                        cm.Parameters.AddWithValue("@TypeID", txtTypeID.Text);
                        cm.Parameters.AddWithValue("@Price", Price);
                        cm.Parameters.AddWithValue("@Classification", comBoxClassification.Text);
                        cm.Parameters.AddWithValue("@Type", comBoxType.Text);
                        cm.Parameters.AddWithValue("@Stock_Level", 3);
                        cm.Parameters.AddWithValue("@Unit_Measure", txtUnitMeasr.Text);
                        cm.Parameters.AddWithValue("@Display_Price", displayPrice);
                        cm.ExecuteNonQuery();
                        cn.Close();
                        MessageBox.Show("Record has been successfully saved.");
                        ClearItem();
                        btnUpdateItem.Enabled = false;
                        classLoadData.LoadRecordsItem(frmList.dataGridViewItems, frmList.txtSearch);                     
                        this.Close();
                    }
                }
                else if (duplicate == true)
                {
                    MessageBox.Show("That Description is already on the record", title, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
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
                double Price = double.Parse(txtPrice.Text);
                string displayPrice = Price.ToString("#,##0.00");//₱
               
                    if (MessageBox.Show("Are you sure you want to update this record?", title, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        cn.Open();
                        cm = new SqlCommand("UPDATE tblItem SET Item_ID = @ItemID, Type_ID = @TypeID, Description = @Description, Price = @Price, Classification = @Classification, Display_Price = @Display_Price WHERE Item_ID LIKE '" + txtID.Text + "'", cn);
                        cm.Parameters.AddWithValue("@ItemID", txtID.Text);
                        cm.Parameters.AddWithValue("@Description", txtDescription.Text);
                        cm.Parameters.AddWithValue("@Price", Price);
                        cm.Parameters.AddWithValue("@TypeID", txtTypeID.Text);
                        cm.Parameters.AddWithValue("@Display_Price", displayPrice);
                        cm.Parameters.AddWithValue("@Classification", comBoxClassification.Text);
                        cm.ExecuteNonQuery();
                        cn.Close();
                        MessageBox.Show("Record has been successfully updated.");
                        ClearItem();
                        btnSaveItem.Enabled = false;
                        classLoadData.LoadRecordsItem(frmList.dataGridViewItems, frmList.txtSearch);                  
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

        public void scanForDuplicateName(string col, string tbl, TextBox Name, out bool found)
        {            
            cn = new SqlConnection(dbcon.MyConnection());            
            cn.Open();
            SqlCommand cm = new SqlCommand("SELECT "+ col + " FROM " + tbl + "  WHERE " + col + " LIKE @Name", cn);
            cm.Parameters.AddWithValue("@Name", Name.Text);            
            dr = cm.ExecuteReader();
            dr.Read();
            if (dr.HasRows)
            {                          
                found = true;
            }
            else
            {
                found = false;                
            }
            dr.Close();
            cn.Close();
        }

        private void tabControlCreateNew_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtPrice_KeyPress_1(object sender, KeyPressEventArgs e)
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
    }
}
