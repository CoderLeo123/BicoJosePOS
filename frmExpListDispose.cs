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
    public partial class frmExpListDispose : Form
    {
        SQLiteConnection cn = new SQLiteConnection();
        SQLiteCommand cm = new SQLiteCommand();
        DBConnection dbcon = new DBConnection();
        SQLiteDataReader dr;
        ClassInventory classInvent = new ClassInventory();
        string title = "BICO-JOSE System";
        frmInventory frmL;
        private bool mouseDown;
        private Point lastLocation;
        public frmExpListDispose(frmInventory frmL)
        {
            InitializeComponent();
            cn = new SQLiteConnection(dbcon.MyConnection);
            this.frmL = frmL;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridViewExpLis_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dataGridViewExpLis.Columns[e.ColumnIndex].Name;
            string ITMID = lblITEMID.Text;
            int disposeQty = int.Parse(dataGridViewExpLis.Rows[e.RowIndex].Cells[3].Value.ToString());
            if (colName == "dek")
            {
                if (MessageBox.Show("Dispose this Item?", title, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    frmPermission frmP = new frmPermission();
                    frmP.ShowDialog();

                    if (frmP.lblGrant.Text == "1")
                    {
                        cn.Open();
                        cm = new SQLiteCommand("Update tblStockInventory SET Status = 'Dispose', Disposal_Date = '" +lblDisposalDate.Text+"' WHERE id LIKE '" + dataGridViewExpLis.Rows[e.RowIndex].Cells[1].Value.ToString() + "'", cn);
                        cm.ExecuteNonQuery();
                        cn.Close();

                        cn.Open();
                        cm = new SQLiteCommand("Update tblItem SET Quantity = Quantity - " + disposeQty + " WHERE Item_ID LIKE '" + ITMID + "'", cn);
                        cm.ExecuteNonQuery();
                        cn.Close();

                        cn.Open();
                        cm = new SQLiteCommand("Update tblStock SET Item_Status = 'Dispose' WHERE Num LIKE '" + dataGridViewExpLis.Rows[e.RowIndex].Cells[5].Value.ToString() + "'", cn);
                        cm.ExecuteNonQuery();
                        cn.Close();

                        MessageBox.Show("Item has been successfully dispose.", title, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        classInvent.LoadNearExpiration(dataGridViewExpLis, txtSearchExpL, ITMID);
                        classInvent.LoadItemWithExpiration(frmL.dataGridViewExpir, frmL.txtSearchExpirat);
                        classInvent.LoadDispose(frmL.dataGridViewDispose, frmL.txtSearchDispose);
                        this.Close();
                    }
                    

                }
            }
        }

        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;

        }

        private void panel3_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void panel3_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;

        }
    }
}
