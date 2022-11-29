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
    public partial class frmPermission : Form
    {
        SQLiteConnection cn = new SQLiteConnection();
        SQLiteCommand cm = new SQLiteCommand();
        DBConnection dbcon = new DBConnection();
        SQLiteDataReader dr;
        ClassGenerateID classGenerateID = new ClassGenerateID();
        ClassLoadData classLoadData = new ClassLoadData();
        string title = "BICO-JOSE System";
        private bool mouseDown;
        private Point lastLocation;
        public frmPermission()
        {
            InitializeComponent();
            cn = new SQLiteConnection(dbcon.MyConnection);
            confirm();
            lblGrant.Text = "0";
            txtAdminPassword.PasswordChar = '●'; txtAdminPassword.MaxLength = 14;

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
        //public void whatForm()
        //{
        //    string grant = "Granted";
        //    if (lblWhatForm.Text == "UserSetting")
        //    {
        //        frmUserSetting frm = new frmUserSetting();
        //        frm.lblPermitted.Text = "Granted";
        //    }else if (lblWhatForm.Equals("CreateAccount"))
        //    {
        //        frmSignUpForgotPass frm = new frmSignUpForgotPass();
        //        frm.lblPermi.Text = grant;
        //    }
        //    else if (lblWhatForm.Equals("ResetPass"))
        //    {
        //        frmSignUpForgotPass frm = new frmSignUpForgotPass();
        //        frm.lblPermi.Text = grant;
        //    }
        //}
        public void confirm()
        {
            string adminPass = "";
            string userID = "";



            cn.Open();
            cm = new SQLiteCommand("SELECT Password, User_ID FROM tblUser WHERE Password LIKE '%" + txtAdminPassword.Text + "%' AND User_Type LIKE '%Master%'", cn);
            dr = cm.ExecuteReader();
            dr.Read();
            if (dr.HasRows)
            {
                adminPass = dr[0].ToString();
                userID = dr[1].ToString();
            }
            dr.Close();
            cn.Close();

            if (txtAdminPassword.Text != adminPass)
            {

                txtAdminPassword.Focus(); txtAdminPassword.SelectAll();
                lblAdminPassNotice.Visible = true;
                lblAdminPassNotice.Text = "Incorrect credentials";
                lblGrant.Text = "0";

            }
            else if (txtAdminPassword.Text == adminPass)
            {
                
                
                lblGrant.Text = "1";
                lblAdminPassNotice.Text = "Permision Granted";
                //this.Close();
                this.Hide();
            }
        }

        private void btnResetPass_Click(object sender, EventArgs e)//btnConfirmPassPermision
        {
            confirm();
            

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkBoxShowPassL_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxShowPassL.Checked == true)
            {
                txtAdminPassword.PasswordChar = '\0';

            }
            else if (checkBoxShowPassL.Checked == false)
            {
                txtAdminPassword.PasswordChar = '●';

            }
        }
    }
}
