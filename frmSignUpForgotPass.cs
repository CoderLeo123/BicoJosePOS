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
    public partial class frmSignUpForgotPass : Form
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
        public frmSignUpForgotPass()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        public void checkConfirmPass(TextBox pass, TextBox confirmPass, string result)
        {
            if (pass == confirmPass)
            {
                result = pass.Text;
            }
            else if (pass != confirmPass)
            {
                result = "Incorrect";
            }
        }
        public void validatePass(string correctPass)
        {
            string pass = "";
            checkConfirmPass(txtPasswordCreate, txtConfirmPass, pass);// correct pass or Incorrect
            if (pass.Equals("Incorrect"))
            {
                lblPasswordNotice.Text = "Those passwords didn't match. Try again";
                correctPass = "Again";
            }
            else//if (!(pass.Equals("Incorrect")))
            {
                correctPass = pass;
            }
        }
        
        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            
            string Uname = txtUserNameCreate.Text;
            string fullname = txtFirstN.Text + " " + txtLastN.Text;
            string password = "Again";
            string type = comBoxUserType.Text;
            checkConfirmPass(txtPasswordCreate, txtConfirmPass, password);
            validatePass(password);
            while (password.Equals("Again"))
            {
                validatePass(password);
            }




            cn.Open();
            cm = new SqlCommand("INSERT INTO tblUser (User_ID, Username, Password, Name, User_Type) VALUES(@User_ID, @Username, @Password, @Name, @User_Type)", cn);
            cm.Parameters.AddWithValue("@User_ID", lblUserID.Text);
            cm.Parameters.AddWithValue("@Username", txtUserNameCreate.Text);
            cm.Parameters.AddWithValue("@Password", password);
            cm.Parameters.AddWithValue("@Name", fullname);
            cm.Parameters.AddWithValue("@User_Type", comBoxUserType.Text);
            cm.ExecuteNonQuery();
            cn.Close();
            frmLogin frm = new frmLogin();
            frm.ShowDialog();
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

        private void btnResetPass_Click(object sender, EventArgs e)
        {
            string password = txtNewPassword.Text;
            cn.Open();
            cm = new SqlCommand("UPDATE tblUser SET Password = '"+ password + "' WHERE User_ID LIKE '"+ lblUserIDForgot.Text +"'", cn);
  
            cm.ExecuteNonQuery();
            cn.Close();

            frmLogin frm = new frmLogin();
            frm.ShowDialog();
            this.Close();
        }

        private void linkLabelLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmLogin frm = new frmLogin();
            frm.ShowDialog();
            this.Close();
            
        }
    }
}
