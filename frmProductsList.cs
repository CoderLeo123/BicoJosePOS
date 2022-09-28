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

        public frmProductsList()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
            LoadRecordsType();
            LoadRecordsProduct();
            LoadRecordsItem();
            LoadRecordsService();

        }
        public void LoadRecordsType()
        {
            int i = 0;
           dataGridViewType.Rows.Clear();
            cn.Open();
            cm = new SqlCommand("SELECT * FROM JoinProductType WHERE Type LIKE '%" + txtSearchTypeProducts.Text + "%' OR Product LIKE '%" + txtSearchTypeProducts.Text + "%' Order by Type_ID", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {                             //                       2-TYPE / 2-Type              4-PRODUCT / 3-Product         
                i += 1;                   //0-#  1-TYPE ID / 1-Type_ID          3-PRODUCT ID / 0-Product_ID                  
                dataGridViewType.Rows.Add(i, dr[1].ToString(), dr[2].ToString(), dr[0].ToString(), dr[3].ToString());
            }
            dr.Close();
            cn.Close();
        }
        public void LoadRecordsProduct()
        {
            int i = 0;
            dataGridViewProduct.Rows.Clear();
            cn.Open();
            cm = new SqlCommand("SELECT * FROM tblProduct WHERE Product LIKE '%" + txtSearchProduct.Text + "%' Order by Product_ID", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {                             //                     3-PRODUCT / 3-Product              
                i += 1;                   //0-#  1-PRODUCT ID / 1-Product_ID       
                dataGridViewProduct.Rows.Add(i, dr[1].ToString(), dr[2].ToString());
            }
            dr.Close();
            cn.Close();
        }
        public void LoadRecordsItem()
        {
            int i = 0;
            dataGridViewItems.Rows.Clear();
            cn.Open();
            cm = new SqlCommand("SELECT * FROM ViewItemProductType WHERE Description LIKE '%" + txtSearch.Text + "%' OR Type LIKE '%" + txtSearch.Text + "%' Order by Item_ID", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {                         //     2-DESCRIPTION / 1-Description       4-PRODUCT / 3-Product                  6-QUANTITY / 5-Quantity                          7-TYPE ID / 5-Type_ID
                i += 1;              // 0-#                  3-TYPE / 2-Type                     5-PRICE / 4-Price                   7-CLASSIFICATION / 6-Classification
                dataGridViewItems.Rows.Add(i, dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString(), dr[6].ToString(), dr[0].ToString(), Properties.Resources.Edit, Properties.Resources._Delete);
            }
            dr.Close();
            cn.Close();
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
            if (colName == "Edit")
            {
                frmAddAccessories frm = new frmAddAccessories(this);

                frm.tabControlCreateNew.TabPages.Clear();
                TabPage tab = new TabPage("Type");
                frm.tabControlCreateNew.TabPages.Add(tab);
                tab.Controls.Add(frm.panelType);

                frm.txtTypID.Text = dataGridViewType[1, e.RowIndex].Value.ToString();
                frm.txtProductIDType.Text = dataGridViewType[3, e.RowIndex].Value.ToString();
                frm.txtType.Text = dataGridViewType[2, e.RowIndex].Value.ToString();
                frm.comBoxProductType.Text = dataGridViewType[4, e.RowIndex].Value.ToString();
                frm.btnSaveType.Enabled = false;
                frm.btnUpdateType.Enabled = true;
                
                frm.LoadProduct();
                frm.ShowDialog();
            }
            else if (colName == "Delete")
            {
                if (MessageBox.Show("Are you sure you want to delete this record?", title, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cn.Open();
                    cm = new SqlCommand("DELETE FROM tblProductType WHERE Type_ID LIKE '" + dataGridViewType[1, e.RowIndex].Value.ToString() + "'", cn);
                    cm.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Record has been successfully deleted.", title, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadRecordsType();
                }
            }
        }

        private void dataGridViewService_CellContentClick(object sender, DataGridViewCellEventArgs e) //dataGridViewProduct
        {
            string colName = dataGridViewProduct.Columns[e.ColumnIndex].Name;
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
                    LoadRecordsProduct();
                }
            }
        }

        private void txtSearchTypeProducts_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtSearchTypeProducts.Text == String.Empty)
                {
                    LoadRecordsType();
                    return;
                }
                else
                {
                    LoadRecordsType();
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
            frm.GenerateProductID();
            frm.LoadProduct();
            frm.ShowDialog();
        }

        private void btnAddType_Click(object sender, EventArgs e)
        {
            frmAddAccessories frm = new frmAddAccessories(this);
            
            frm.tabControlCreateNew.TabPages.Clear();
            TabPage tab = new TabPage("Type");
            frm.tabControlCreateNew.TabPages.Add(tab);
            tab.Controls.Add(frm.panelType);
            frm.LoadProduct();
            frm.GenerateTypeID();
            frm.ShowDialog();
        }

        private void txtSearchProduct_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtSearchTypeProducts.Text == String.Empty)
                {
                    LoadRecordsProduct();
                    return;
                }
                else
                {
                    LoadRecordsProduct();
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
            if (colName == "EditItems")
            {
                frmAddAccessories frm = new frmAddAccessories(this);

                frm.tabControlCreateNew.TabPages.Clear();
                TabPage tab = new TabPage("Item");
                frm.tabControlCreateNew.TabPages.Add(tab);
                tab.Controls.Add(frm.panelItem);

                frm.txtID.Text = dataGridViewItems[7, e.RowIndex].Value.ToString();
                frm.txtDescription.Text = dataGridViewItems[1, e.RowIndex].Value.ToString();
                frm.comBoxType.SelectedItem = dataGridViewItems[2, e.RowIndex].Value.ToString();
                frm.txtProduct.Text = dataGridViewItems[3, e.RowIndex].Value.ToString();
                frm.txtPrice.Text = dataGridViewItems[4, e.RowIndex].Value.ToString();
                frm.comBoxClassification.Text = dataGridViewItems[6, e.RowIndex].Value.ToString();
                frm.btnSaveItem.Enabled = false;
                frm.btnUpdateItem.Enabled = true;

                frm.LoadType();
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
                    LoadRecordsItem();

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
            frm.LoadType();
            frm.LoadProductItem();
            frm.GenerateItemID();
            frm.ShowDialog();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtSearch.Text == String.Empty)
                {
                    LoadRecordsItem();
                    return;
                }
                else
                {
                    LoadRecordsItem();
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

        public void LoadRecordsService()
        {
            int i = 0;
            dataGridViewService.Rows.Clear();
            cn.Open();
            cm = new SqlCommand("SELECT * FROM tblServices WHERE Name LIKE '%" + txtSearchService.Text + "%' OR Description LIKE '%" + txtSearchService.Text + "%' Order by Service_ID", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {                            //                       2-NAME / 2-Name                   4-PRICE / 4-Price
                i += 1;                //0-#  1-SERVICE ID / 1-Service_ID       3-DESCRIPTION / 3-Description
                dataGridViewService.Rows.Add(i, dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString());
            }
            dr.Close();
            cn.Close();
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
                    LoadRecordsService();
                }
            }
        }

        private void txtSearchService_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtSearchService.Text == String.Empty)
                {
                    LoadRecordsService();
                    return;
                }
                else
                {
                    LoadRecordsService();
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
            frm.GenerateServiceID();
            frm.ShowDialog();
        }
    }
}
