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
    public partial class frmProductsList : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        SqlDataReader dr;
        string title = "BICO-JOSE System";
        ClassGenerateID classGenerateID = new ClassGenerateID();
        ClassLoadData classLoadData = new ClassLoadData();
        //frmAddAccessories frmAdd = new frmAddAccessories();

        public frmProductsList()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
            classLoadData.LoadRecordsType(dataGridViewType, txtSearchTypeProducts);
            classLoadData.LoadRecordsProduct(dataGridViewProduct, txtSearchProduct);
            classLoadData.LoadRecordsItem(dataGridViewItems, txtSearch);
            classLoadData.LoadRecordsService(dataGridViewService, txtSearchService);
            //LoadRecordsService();
            textRightAlign();
        }

        public void textRightAlign()
        {

            this.dataGridViewItems.Columns["PriceItems"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            this.dataGridViewService.Columns["PriceService"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void dataGridViewProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

       

        private void dataGridViewProducts_CellContentClick_1(object sender, DataGridViewCellEventArgs e) //dataGridViewType
        {
             string colName = dataGridViewType.Columns[e.ColumnIndex].Name;
            string product = dataGridViewType[4, e.RowIndex].Value.ToString();
            int indextProduct = 0;
            if (colName == "Edit")
            {
                frmAddAccessories frm = new frmAddAccessories(this);

                frm.tabControlCreateNew.TabPages.Clear();
                TabPage tab = new TabPage("Type");
                frm.tabControlCreateNew.TabPages.Add(tab);
                tab.Controls.Add(frm.panelType);

                classLoadData.LoadProduct(frm.comBoxProductType);
                indextProduct = frm.comBoxProductType.Items.IndexOf(product);
                frm.comBoxProductType.SelectedIndex = indextProduct;

                frm.txtTypID.Text = dataGridViewType[1, e.RowIndex].Value.ToString();
                frm.txtProductIDType.Text = dataGridViewType[3, e.RowIndex].Value.ToString();
                frm.txtType.Text = dataGridViewType[2, e.RowIndex].Value.ToString();                
                frm.btnSaveType.Enabled = false;
                frm.btnUpdateType.Enabled = true;
                
                //frm.LoadProduct();
                frm.Size = new Size(830, 441);
                frm.ShowDialog();
            }
            else if (colName == "Delete")
            {
                if (MessageBox.Show("Are you sure you want to delete this record?", title, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cn.Open();
                    cm = new SqlCommand("DELETE FROM tblType WHERE Type_ID LIKE '" + dataGridViewType[1, e.RowIndex].Value.ToString() + "'", cn);
                    cm.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Record has been successfully deleted.", title, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    classLoadData.LoadRecordsType(dataGridViewType, txtSearchTypeProducts);
                }
            }
        }

        private void dataGridViewService_CellContentClick(object sender, DataGridViewCellEventArgs e) //dataGridViewProduct
        {
            string colName = dataGridViewProduct.Columns[e.ColumnIndex].Name;
            string product = dataGridViewProduct[4, e.RowIndex].Value.ToString();
            if (colName == "EditProduct")
            {
                frmAddAccessories frm = new frmAddAccessories(this);
                frm.tabControlCreateNew.TabPages.Clear();
                TabPage tab = new TabPage("Product");
                frm.tabControlCreateNew.TabPages.Add(tab);
                tab.Controls.Add(frm.panelProduct);

                frm.txtProdID.Text = dataGridViewProduct[1, e.RowIndex].Value.ToString();
                frm.txtProdName.Text = dataGridViewProduct[2, e.RowIndex].Value.ToString();       
                frm.btnSaveProduct.Enabled = false;
                frm.btnUpdateProduct.Enabled = true;
                frm.Size = new Size(672, 357);
                frm.ShowDialog();
            }
            else if (colName == "DeleteProduct")
            {
                if (MessageBox.Show("Are you sure you want to delete this record?", title, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cn.Open();
                    cm = new SqlCommand("DELETE FROM tblProduct WHERE Product_ID LIKE '" + dataGridViewProduct[1, e.RowIndex].Value.ToString() + "'", cn);
                    cm.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Record has been successfully deleted.", title, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    classLoadData.LoadRecordsProduct(dataGridViewProduct, txtSearchProduct);
                }
            }
        }

        private void txtSearchTypeProducts_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtSearchTypeProducts.Text == String.Empty)
                {
                    classLoadData.LoadRecordsType(dataGridViewType, txtSearchTypeProducts);
                    return;
                }
                else
                {
                    classLoadData.LoadRecordsType(dataGridViewType, txtSearchTypeProducts);
                }
            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message, title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        

        private void button1_Click(object sender, EventArgs e)//btnAddProduct
        {
            frmAddAccessories frm = new frmAddAccessories(this);
            
            frm.tabControlCreateNew.TabPages.Clear();
            TabPage tab = new TabPage("Product");
            frm.tabControlCreateNew.TabPages.Add(tab);
            tab.Controls.Add(frm.panelProduct);
            classGenerateID.GenerateProductID(frm.txtProdID);
            
            //frm.GenerateProductID();
            //classLoadData.LoadProduct(frm.comBoxProductType);
            //frm.LoadProduct();
            frm.Size = new Size(672, 357);
            frm.ShowDialog();
        }

        private void btnAddType_Click(object sender, EventArgs e)
        {
            frmAddAccessories frm = new frmAddAccessories(this);
            
            frm.tabControlCreateNew.TabPages.Clear();
            TabPage tab = new TabPage("Type");
            frm.tabControlCreateNew.TabPages.Add(tab);
            tab.Controls.Add(frm.panelType);
            classLoadData.LoadProduct(frm.comBoxProductType);
            frm.comBoxProductType.SelectedIndex = 0;
            //frm.LoadProduct();
            classGenerateID.GenerateTypeID(frm.txtTypID);
            //frm.GenerateTypeID();
            frm.Size = new Size(830, 441);
            frm.ShowDialog(); 
        }

        private void txtSearchProduct_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtSearchTypeProducts.Text == String.Empty)
                {
                    classLoadData.LoadRecordsProduct(dataGridViewProduct, txtSearchProduct);
                    return;
                }
                else
                {
                    classLoadData.LoadRecordsProduct(dataGridViewProduct, txtSearchProduct);
                }
            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message, title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridViewItems_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dataGridViewItems.Columns[e.ColumnIndex].Name;
            string type = dataGridViewItems[2, e.RowIndex].Value.ToString();
            string classi = dataGridViewItems[6, e.RowIndex].Value.ToString();
            int indexType = 0; int indexClass = 0;
            if (colName == "EditItems")
            {
                frmAddAccessories frm = new frmAddAccessories(this);

                frm.tabControlCreateNew.TabPages.Clear();
                TabPage tab = new TabPage("Item");
                frm.tabControlCreateNew.TabPages.Add(tab);
                tab.Controls.Add(frm.panelItem);
                //for load comboBox
                classLoadData.LoadType(frm.comBoxType);
                indexType = frm.comBoxType.Items.IndexOf(type);
                frm.comBoxType.SelectedIndex = indexType;
                //for predefined collection on comboBox               
                frm.comBoxClassification.SelectedItem = classi;

                frm.txtID.Text = dataGridViewItems[7, e.RowIndex].Value.ToString();
                frm.txtDescription.Text = dataGridViewItems[1, e.RowIndex].Value.ToString();
                //frm.comBoxType.SelectedItem = dataGridViewItems[2, e.RowIndex].Value.ToString();
                frm.txtProduct.Text = dataGridViewItems[3, e.RowIndex].Value.ToString();
                frm.txtPrice.Text = dataGridViewItems[4, e.RowIndex].Value.ToString();
                //frm.comBoxClassification.Text = dataGridViewItems[6, e.RowIndex].Value.ToString();
                frm.btnSaveItem.Enabled = false;
                frm.btnUpdateItem.Enabled = true;
                classLoadData.LoadType(frm.comBoxType);
                //frm.LoadType();

                frm.ShowDialog();
            }
            else if (colName == "DeleteItems")
            {
                if (MessageBox.Show("Are you sure you want to delete this record?", title, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cn.Open();
                    cm = new SqlCommand("DELETE FROM tblItem WHERE Item_ID LIKE '" + dataGridViewItems[7, e.RowIndex].Value.ToString() + "'", cn);
                    cm.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Record has been successfully deleted.", title, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    classLoadData.LoadRecordsItem(dataGridViewItems, txtSearch);

                }
            }
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            frmAddAccessories frm = new frmAddAccessories(this);
            
            frm.tabControlCreateNew.TabPages.Clear();
            TabPage tab = new TabPage("Item");
            frm.tabControlCreateNew.TabPages.Add(tab);
            tab.Controls.Add(frm.panelItem);
            
            frm.comBoxClassification.SelectedIndex = 0;
            classLoadData.LoadType(frm.comBoxType);
            frm.comBoxType.SelectedIndex = 0;
            //frm.LoadType();
            classLoadData.LoadProductItem(frm.txtProduct, frm.txtTypeID, frm.comBoxType);
            //frm.LoadProductItem();
            classGenerateID.GenerateItemID(frm.txtID);
            //frm.GenerateItemID();
            frm.ShowDialog();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtSearch.Text == String.Empty)
                {
                    classLoadData.LoadRecordsItem(dataGridViewItems, txtSearch);
                    return;
                }
                else
                {
                    classLoadData.LoadRecordsItem(dataGridViewItems, txtSearch);
                }
            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message, title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint_1(object sender, PaintEventArgs e)
        {

        }

        

        private void dataGridViewService_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dataGridViewService.Columns[e.ColumnIndex].Name;
            if (colName == "EditService")
            {
                frmAddAccessories frm = new frmAddAccessories(this);

                frm.tabControlCreateNew.TabPages.Clear();
                TabPage tab = new TabPage("Service");
                frm.tabControlCreateNew.TabPages.Add(tab);
                tab.Controls.Add(frm.panelService);

                frm.txtServiceID.Text = dataGridViewService[1, e.RowIndex].Value.ToString();
                frm.txtServiceName.Text = dataGridViewService[2, e.RowIndex].Value.ToString();
                frm.txtServiceDesc.Text = dataGridViewService[3, e.RowIndex].Value.ToString();
                frm.txtServicePrice.Text = dataGridViewService[4, e.RowIndex].Value.ToString();
                frm.btnSaveService.Enabled = false;
                frm.btnUpdateService.Enabled = true;
                frm.Size = new Size(850, 428);
                frm.ShowDialog();
            }
            else if (colName == "DeleteService")
            {
                if (MessageBox.Show("Are you sure you want to delete this record?", title, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cn.Open();
                    cm = new SqlCommand("DELETE FROM tblServices WHERE Service_ID LIKE '" + dataGridViewService[1, e.RowIndex].Value.ToString() + "'", cn);
                    cm.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Record has been successfully deleted.", title, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    classLoadData.LoadRecordsService(dataGridViewService, txtSearchService);
                    //LoadRecordsService();
                }
            }
        }

        private void txtSearchService_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtSearchService.Text == String.Empty)
                {
                    classLoadData.LoadRecordsService(dataGridViewService, txtSearchService);
                    //LoadRecordsService();
                    return;
                }
                else
                {
                    classLoadData.LoadRecordsService(dataGridViewService, txtSearchService);
                    //LoadRecordsService();
                }
            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message, title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnAddService_Click(object sender, EventArgs e)
        {
            
        }

        private void btnServiceAdd_Click(object sender, EventArgs e)
        {
            frmAddAccessories frm = new frmAddAccessories(this);
            frm.tabControlCreateNew.TabPages.Clear();
            TabPage tab = new TabPage("Service");
            frm.tabControlCreateNew.TabPages.Add(tab);
            tab.Controls.Add(frm.panelService);
            classGenerateID.GenerateServiceID(frm.txtServiceID);
            //frm.GenerateServiceID();
            frm.Size = new Size(850, 428);
            frm.ShowDialog();
        }
    }
}
