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
    public partial class frmInventory : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        SqlDataReader dr;
        ClassInventory classInvent = new ClassInventory();
        string title = "BICO-JOSE System";
        bool isPressed, unPress;
        public frmInventory()
        {
            InitializeComponent();
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

        
        public void checkWhatIsPress(bool btnReO, bool btnCrit, bool btnOutS, bool btnExp)
        {
            if (btnReO == true)
            {
                colorChange(true, btnReOrder); colorChange(false, btnCrittical); colorChange(false, btnOutOFStock); colorChange(false, btnExpira);
            }
            else if (btnCrit == true)
            {
                colorChange(true, btnCrittical); colorChange(false, btnReOrder); colorChange(false, btnOutOFStock); colorChange(false, btnExpira);
            }
            else if (btnOutS == true)
            {
                colorChange(true, btnOutOFStock); colorChange(false, btnReOrder); colorChange(false, btnCrittical); colorChange(false, btnExpira);
            }
            else if (btnExp == true)
            {
                colorChange(true, btnExpira); colorChange(false, btnReOrder); colorChange(false, btnCrittical); colorChange(false, btnOutOFStock);
            }
        }
        private void btnReOrder_Click(object sender, EventArgs e)
        {
            tabControlInventory.TabPages.Clear();
            TabPage tab = new TabPage("RE-ORDER");
            tabControlInventory.TabPages.Add(tab);
            tab.Controls.Add(panelReOrder);
            classInvent.LoadReOrder(dataGridViewReOrder, txtSearchReOrder);            
            checkWhatIsPress(true, false, false, false);
        }

        private void btnOutOFStock_Click(object sender, EventArgs e)
        {
            tabControlInventory.TabPages.Clear();
            TabPage tab = new TabPage("OUT OF STOCK");
            tabControlInventory.TabPages.Add(tab);
            tab.Controls.Add(panelOutOfStock);
            classInvent.LoadOutOfStock(dataGridViewOutStock, txtSearchOutOStock);           
            checkWhatIsPress(false, false, true, false);
        }

        private void btnExpira_Click(object sender, EventArgs e)
        {
            tabControlInventory.TabPages.Clear();
            TabPage tab = new TabPage("EXPIRATION");
            tabControlInventory.TabPages.Add(tab);
            tab.Controls.Add(panelExpiration);
            classInvent.LoadItemWithExpiration(dataGridViewExpir, txtSearchExpirat);
            checkWhatIsPress(false, false, false, true);
        }

        private void dataGridViewExpir_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string ITMID = dataGridViewExpir.Rows[e.RowIndex].Cells[4].Value.ToString();

            frmExpListDispose frm = new frmExpListDispose();
            frm.tabControlExpLi.TabPages.Clear();
            TabPage tab = new TabPage("Expiration List");
            frm.tabControlExpLi.TabPages.Add(tab);
            tab.Controls.Add(frm.panelExpiLists);
            classInvent.LoadNearExpiration(frm.dataGridViewExpLis, frm.txtSearchExpL, ITMID);
            frm.lblITEMID.Text = ITMID;
            frm.ShowDialog();
        }

        private void btnCrittical_Click(object sender, EventArgs e)
        {
            tabControlInventory.TabPages.Clear();
            TabPage tab = new TabPage("CRITICAL");
            tabControlInventory.TabPages.Add(tab);
            tab.Controls.Add(panelCritical);
            classInvent.LoadCritical(dataGridViewCritical, txtSearchCritical);            
            checkWhatIsPress(false, true, false, false);
        }
    }
}
