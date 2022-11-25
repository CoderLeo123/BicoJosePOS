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
    public partial class frmDashboardDetails : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        SqlDataReader dr;
        private bool mouseDown;
        private Point lastLocation;
        public frmDashboardDetails()
        {
            cn = new SqlConnection(dbcon.MyConnection());
            InitializeComponent();
           
        }

        public void LoadExpList()
        {
            cn = new SqlConnection(dbcon.MyConnection());
            int i = 0;
            dataGridViewExpira.Rows.Clear();
            cn.Open();
            SqlCommand cm = new SqlCommand("SELECT * FROM tblExpList WHERE Quantity > 0 ORDER BY Expiration_Date ASC", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                //                                          2-ROLE / 2-User_Type       
                i += 1; //          0-#  1-NAME / 1-Name           
                dataGridViewExpira.Rows.Add(i, dr[2].ToString(), dr[3].ToString(), dr[4].ToString());
            }
            dr.Close();
            cn.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void panel3_MouseLeave(object sender, EventArgs e)
        {

        }

        private void panel3_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
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

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
