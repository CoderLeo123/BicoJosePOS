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
    public partial class frmInventory : Form
    {
        SQLiteConnection cn = new SQLiteConnection();
        SQLiteCommand cm = new SQLiteCommand();
        DBConnection dbcon = new DBConnection();
        SQLiteDataReader dr;
        ClassInventory classInvent = new ClassInventory();
        string title = "BICO-JOSE System";
        bool isPressed, unPress;
        public frmInventory()
        {
            InitializeComponent();
            textRightAlign();
        }
        public void textRightAlign()
        {

            this.dataGridViewReOrder.Columns["SafeStock"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            this.dataGridViewCritical.Columns["CritStock"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            this.dataGridViewOutStock.Columns["OutStock"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            this.dataGridViewDispose.Columns["DisStock"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            this.dataGridViewSafety.Columns["ReOStock"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
           
        }
        private void btnCloseInventory_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void colorChange(bool press, Button changeThisBtn)
        {
            if (press == true)
            {
                changeThisBtn.BackColor = Color.Red;
                
            }
            else if (press == false)
            {
                changeThisBtn.BackColor = Color.LimeGreen;
            }
        }

        
        public void checkWhatIsPress(bool btnReO, bool btnCrit, bool btnOutS, bool btnExp, bool btnSafty)
        {
            if (btnReO == true)
            {
                colorChange(true, btnReOrder); colorChange(false, btnCrittical); colorChange(false, btnOutOFStock); colorChange(false, btnExpira); colorChange(false, btnSafety);
            }
            else if (btnCrit == true)
            {
                colorChange(true, btnCrittical); colorChange(false, btnReOrder); colorChange(false, btnOutOFStock); colorChange(false, btnExpira); colorChange(false, btnSafety);
            }
            else if (btnOutS == true)
            {
                colorChange(true, btnOutOFStock); colorChange(false, btnReOrder); colorChange(false, btnCrittical); colorChange(false, btnExpira); colorChange(false, btnSafety);
            }
            else if (btnExp == true)
            {
                colorChange(true, btnExpira); colorChange(false, btnReOrder); colorChange(false, btnCrittical); colorChange(false, btnOutOFStock); colorChange(false, btnSafety);
            }
            else if (btnSafty == true)
            {
                colorChange(true, btnSafety); colorChange(false, btnReOrder); colorChange(false, btnCrittical); colorChange(false, btnOutOFStock); colorChange(false, btnExpira);
            }
        }
        private void btnReOrder_Click(object sender, EventArgs e)
        {
            tabControlInventory.TabPages.Clear();
            TabPage tab = new TabPage("RE-ORDER");
            tabControlInventory.TabPages.Add(tab);
            tab.Controls.Add(panelReOrder);
            classInvent.LoadReOrder(dataGridViewReOrder, txtSearchReOrder);            
            checkWhatIsPress(true, false, false, false, false);
        }

        private void btnOutOFStock_Click(object sender, EventArgs e)
        {
            tabControlInventory.TabPages.Clear();
            TabPage tab = new TabPage("OUT OF STOCK");
            tabControlInventory.TabPages.Add(tab);
            tab.Controls.Add(panelOutOfStock);
            classInvent.LoadOutOfStock(dataGridViewOutStock, txtSearchOutOStock);           
            checkWhatIsPress(false, false, true, false, false);
        }

        private void btnExpira_Click(object sender, EventArgs e)
        {
            tabControlInventory.TabPages.Clear();
            TabPage tab = new TabPage("EXPIRATION");
            tabControlInventory.TabPages.Add(tab);
            tab.Controls.Add(panelExpiration);
            classInvent.LoadItemWithExpiration(dataGridViewExpir, txtSearchExpirat);
            TabPage tab2 = new TabPage("DISPOSE ITEMS");
            tabControlInventory.TabPages.Add(tab2);
            tab2.Controls.Add(panelDispose);
            classInvent.LoadDispose(dataGridViewDispose, txtSearchDispose);
            checkWhatIsPress(false, false, false, true, false);
        }

        private void dataGridViewExpir_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string ITMID = dataGridViewExpir.Rows[e.RowIndex].Cells[4].Value?.ToString();
            string DateTo = DateTime.Now.ToString();

            frmExpListDispose frm = new frmExpListDispose(this);
            frm.tabControlExpLi.TabPages.Clear();
            TabPage tab = new TabPage("Expiration List");
            frm.tabControlExpLi.TabPages.Add(tab);
            tab.Controls.Add(frm.panelExpiLists);
            classInvent.LoadNearExpiration(frm.dataGridViewExpLis, frm.txtSearchExpL, ITMID);
            frm.lblITEMID.Text = ITMID;
            frm.lblDisposalDate.Text = DateTo;
            frm.ShowDialog();
        }

        private void btnSafety_Click(object sender, EventArgs e)
        {
            tabControlInventory.TabPages.Clear();
            TabPage tab = new TabPage("SAFETY LEVEL");
            tabControlInventory.TabPages.Add(tab);
            tab.Controls.Add(panelSafety);
            classInvent.LoadSafety(dataGridViewSafety, txtSearchSafety);            
            checkWhatIsPress(false, false, false, false, true);
        }

        private void txtSearchReOrder_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtSearchReOrder.Text == String.Empty)
                {
                    classInvent.LoadReOrder(dataGridViewReOrder, txtSearchReOrder);
                    return;
                }
                else
                {
                    classInvent.LoadReOrder(dataGridViewReOrder, txtSearchReOrder);
                }
            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message, title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtSearchSafety_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtSearchSafety.Text == String.Empty)
                {
                    classInvent.LoadSafety(dataGridViewSafety, txtSearchSafety);
                    return;
                }
                else
                {
                    classInvent.LoadSafety(dataGridViewSafety, txtSearchSafety);

                }
            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message, title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtSearchOutOStock_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtSearchOutOStock.Text == String.Empty)
                {
                    classInvent.LoadOutOfStock(dataGridViewOutStock, txtSearchOutOStock);
                    return;
                }
                else
                {
                    classInvent.LoadOutOfStock(dataGridViewOutStock, txtSearchOutOStock);
                }
            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message, title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtSearchCritical_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtSearchCritical.Text == String.Empty)
                {
                    classInvent.LoadCritical(dataGridViewCritical, txtSearchCritical);
                    return;
                }
                else
                {
                    classInvent.LoadCritical(dataGridViewCritical, txtSearchCritical);
                }
            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message, title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void panel12_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtSearchExpirat_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtSearchExpirat.Text == String.Empty)
                {
                    classInvent.LoadItemWithExpiration(dataGridViewExpir, txtSearchExpirat);
                    return;
                }
                else
                {
                    classInvent.LoadItemWithExpiration(dataGridViewExpir, txtSearchExpirat);
                }
            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message, title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnCrittical_Click(object sender, EventArgs e)
        {
            tabControlInventory.TabPages.Clear();
            TabPage tab = new TabPage("CRITICAL");
            tabControlInventory.TabPages.Add(tab);
            tab.Controls.Add(panelCritical);
            classInvent.LoadCritical(dataGridViewCritical, txtSearchCritical);            
            checkWhatIsPress(false, true, false, false, false);
        }

    }
}
