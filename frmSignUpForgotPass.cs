﻿using System;
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
        
        ClassLoadData classLoadData = new ClassLoadData();
        ClassGenerateID classGenerateID = new ClassGenerateID();
        ClassLoginAndSignUp classLoginMethod = new ClassLoginAndSignUp();
        string title = "BICO-JOSE System";
        private bool mouseDown;
        private Point lastLocation;
        public frmSignUpForgotPass()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
            classGenerateID.GenerateUserID(lblUserID);
            txtPasswordCreate.PasswordChar = '●';
            txtConfirmPass.PasswordChar = '●';
            txtConfirmNewPass.PasswordChar = '●'; 
            txtNewPassword.PasswordChar = '●'; 
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        //public void checkConfirmPass(TextBox pass, TextBox confirmPass, string result)
        //{
        //    if (pass == confirmPass)
        //    {
        //        result = pass.Text;
        //    }
        //    else if (pass != confirmPass)
        //    {
        //        result = "Incorrect";
        //    }
        //}
        //public void validatePass(string correctPass)
        //{
        //    string pass = "";
        //    checkConfirmPass(txtPasswordCreate, txtConfirmPass, pass);// correct pass or Incorrect
        //    if (pass.Equals("Incorrect"))
        //    {
        //        lblPasswordNotice.Text = "Those passwords didn't match. Try again";
        //        correctPass = "Again";
        //    }
        //    else//if (!(pass.Equals("Incorrect")))
        //    {
        //        correctPass = pass;
        //    }
        //}
        //public void textMinimumCharacter(TextBox textVar, Label labelNotice)
        //{
        //    string input = textVar.Text;
        //    int inputLength = input.Length;
        //    int min = 8;
        //    if (inputLength < min)
        //    {
        //        labelNotice.Text = "Use 8 characters or more";
        //    }
        //}
        //public void checkForBlank(TextBox checkText, Label labelNotice, string name)
        //{
        //    if (checkText.Text == "")
        //    {
        //        labelNotice.Text = "Don't leave the " + name + " blank";
        //        labelNotice.Visible = true;
        //    }
        //    else
        //    {
        //        labelNotice.Visible = false;
        //    }
        //}

        public void CreateTabCheckForBlank()
        {
            
            classLoginMethod.checkForBlank(txtFirstN, lblNameNotice, "Name");
            classLoginMethod.checkForBlank(txtLastN, lblNameNotice, "Name");
            classLoginMethod.checkForBlank(txtUserNameCreate, lblUserNamNotice, "Username");
            classLoginMethod.checkForBlank(txtPasswordCreate, lblPassNoticeForgot, "Password");
            classLoginMethod.checkForBlank(txtConfirmPass, lblPassNoticeForgot, "Password");
            classLoginMethod.textMinimumCharacter(txtPasswordCreate, lblPasswordNotice);
        }
        public void ResetTabCheckForBlank()
        {
            
            classLoginMethod.checkForBlank(txtUserNameForgot, lblUsernameNoticeForgot, "Username");
            classLoginMethod.checkForBlank(txtNewPassword, lblPassNoticeForgot, "Password");
            classLoginMethod.checkForBlank(txtConfirmNewPass, lblPassNoticeForgot, "Password");
            classLoginMethod.textMinimumCharacter(txtNewPassword, lblPassNoticeForgot);
            
        }
        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            
            string Uname = txtUserNameCreate.Text;
            string firtN = txtFirstN.Text;
            string lastN = txtLastN.Text;
            string fullname = firtN + " " + lastN;
            string password = txtPasswordCreate.Text;
            string confirmP = txtConfirmPass.Text;
            string type = comBoxUserType.Text;
            string correctP = "";
            classLoginMethod.validatePass(out correctP, txtPasswordCreate, txtConfirmPass, lblPasswordNotice);
            //if (password.Equals("Again"))
            //{
            //    classLoginMethod.validatePass(password, txtPasswordCreate, txtConfirmPass, lblPasswordNotice);
            //}
            

            if((Uname != "") && (firtN != "") && (lastN != "") && (password != "") && (confirmP != "") && (type != ""))
            {
                if(password != confirmP)
                {
                    txtConfirmPass.Focus();
                    txtConfirmPass.SelectAll();
                    lblPasswordNotice.Text = "Those passwords didn't match. Try again";
                    lblPasswordNotice.Visible = true;
                }
                else
                {
                    cn.Open();
                    cm = new SqlCommand("INSERT INTO tblUser (User_ID, Username, Password, Name, User_Type) VALUES(@User_ID, @Username, @Password, @Name, @User_Type)", cn);
                    cm.Parameters.AddWithValue("@User_ID", lblUserID.Text);
                    cm.Parameters.AddWithValue("@Username", Uname);
                    cm.Parameters.AddWithValue("@Password", correctP);
                    cm.Parameters.AddWithValue("@Name", fullname);
                    cm.Parameters.AddWithValue("@User_Type", type);
                    cm.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("New account has saved", title, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmLogin frm = new frmLogin();
                    frm.ShowDialog();
                    this.Close();
                }
                
            }
            else
            {
                CreateTabCheckForBlank();
                ResetTabCheckForBlank();
            }

            
            
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
            frm.txtUsername.Focus();
            frm.ShowDialog();
            this.Close(); this.Dispose();
        }

        private void linkLabelLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Dispose();
            frmLogin frm = new frmLogin();
            frm.txtUsername.Focus();
            frm.ShowDialog();
            this.Close();
            
        }

        private void txtPasswordCreate_Leave(object sender, EventArgs e)
        {
            string Uname = txtUserNameCreate.Text;
            string firtN = txtFirstN.Text;
            string lastN = txtLastN.Text;
            if ((Uname != "") && (firtN != "") && (lastN != ""))
            {
                classLoginMethod.textMinimumCharacter(txtPasswordCreate, lblPasswordNotice);
            }
            
        }

        private void txtNewPassword_Leave(object sender, EventArgs e)
        {
            classLoginMethod.textMinimumCharacter(txtNewPassword, lblPassNoticeForgot);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
            frmLogin frm = new frmLogin();
            frm.txtUsername.Focus();
            frm.ShowDialog();
        }

        private void checkBoxShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxShowPass.Checked == true)
            {
                txtPasswordCreate.PasswordChar = '\0';
                txtConfirmPass.PasswordChar = '\0';
                
            }else if (checkBoxShowPass.Checked == false)
            {
                txtPasswordCreate.PasswordChar = '●';
                txtConfirmPass.PasswordChar = '●';
            }
        }

        private void checkBoxShowPassForgot_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxShowPassForgot.Checked == true)
            {
                txtConfirmNewPass.PasswordChar = '\0';
                txtNewPassword.PasswordChar = '\0';
            }
            else if (checkBoxShowPassForgot.Checked == false)
            {
                txtConfirmNewPass.PasswordChar = '●';
                txtNewPassword.PasswordChar = '●';
                
            }
        }
    }
}