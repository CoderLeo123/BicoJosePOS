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
    public partial class frmPermission : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        SqlDataReader dr;
        ClassGenerateID classGenerateID = new ClassGenerateID();
        ClassLoadData classLoadData = new ClassLoadData();
        string title = "BICO-JOSE System";
        private bool mouseDown;
        private Point lastLocation;
        public frmPermission()
        {
            InitializeComponent();
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

        private void btnResetPass_Click(object sender, EventArgs e)//btnConfirmPassPermision
        {
            string permision = "Denied";
            string adminPass = "";
            string userID = "";
            cn.Open();
            cm = new SqlCommand("SELECT Password, User_ID FROM tblUser WHERE Password LIKE '" + txtAdminPassword.Text + "'", cn);
            dr = cm.ExecuteReader();
            dr.Read();
            if (dr.HasRows)
            {
                adminPass = dr[0].ToString();
                userID = dr[1].ToString();
            }
            cm.ExecuteNonQuery();
            cn.Close();

            if (txtAdminPassword.Text != adminPass)
            {
                
                txtAdminPassword.SelectAll();
                lblAdminPassNotice.Text = "Incorrect credentials";

            }
            else if (txtAdminPassword.Text == adminPass)
            {
                permision = "Granted";
                lblAdminPassNotice.Text = "Permision Granted";
                this.Close();
            }

        }
    }
}
