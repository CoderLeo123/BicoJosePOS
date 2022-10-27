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
    public partial class frmLogin : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        SqlDataReader dr;
        ClassLoginAndSignUp classLoginMethod = new ClassLoginAndSignUp();
        ClassLoadData classLoadData = new ClassLoadData();
        string title = "BICO-JOSE System";
        private bool mouseDown;
        private Point lastLocation;
        public frmLogin()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
            txtPassword.PasswordChar = '●'; txtPassword.MaxLength = 14;
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Dispose(); this.Close();
        }
       
        //public void insertFirstAdmin(string user_ID, string UserName, string password, string FName, string LName, string userType)
        //{
        //    string Name = FName + " " + LName;
        //    cn.Open();
        //    cm = new SqlCommand("INSERT INTO tblUser (User_ID, Username, Password, Name, User_Type) VALUES(@User_ID, @Username, @Password, @Name, @User_Type)", cn);
        //    cm.Parameters.AddWithValue("@User_ID", user_ID);
        //    cm.Parameters.AddWithValue("@Username", UserName);
        //    cm.Parameters.AddWithValue("@Password", password);
        //    cm.Parameters.AddWithValue("@Name", Name);
        //    cm.Parameters.AddWithValue("@User_Type", userType);
        //    cm.ExecuteNonQuery();
        //    cn.Close();
        //}
        //public void selectDataTblUser(string user_ID, string UserName, string password, string userType, TextBox txtUser, TextBox txtPass)
        //{
        //    cn.Open();
        //    cm = new SqlCommand("SELECT Username, Password, User_ID FROM tblUser WHERE Username LIKE '" + txtUser.Text + "' AND Password LIKE '" + txtPass.Text + "'", cn);
        //    dr = cm.ExecuteReader();
        //    dr.Read();
        //    if (dr.HasRows)
        //    {
        //        UserName = dr[0].ToString();
        //        password = dr[1].ToString();
        //        user_ID = dr[2].ToString();
        //    }
        //    else
        //    {
        //        insertFirstAdmin("USR1000", "leo", "qweasd", "Leomar", "Cabug", "Admin");
        //    }
        //    cm.ExecuteNonQuery();
        //    cn.Close();
        //}
        private void btnLogin_Click(object sender, EventArgs e)
        {
            int attempt = 0;
            attempt++;
            bool found = false;
            string UName = "";
            string CompleteName = "";
            string Pass = "";
            string ID = "";
            string num = "";
            string type = "";
            string loginTime = DateTime.Now.ToString();
            classLoginMethod.selectDataTblUser(out num, out ID, out UName, out CompleteName, out type, txtUsername, txtPassword, out found);// for checking
            


            if (found == false)
            {
                MessageBox.Show("Invalid credentials. Try again", title, MessageBoxButtons.OK, MessageBoxIcon.Information);
                //classLoginMethod.checkForBlank(txtUsername, lblUserNotice, "Username");
                //classLoginMethod.checkForBlank(txtPassword, lblPasswordNotice, "Password");
                classLoginMethod.checkForBlankOrIncorrectCredentials(txtUsername, lblUserNotice, "Username");
                classLoginMethod.checkForBlankOrIncorrectCredentials(txtPassword, lblPasswordNotice, "Password");
            }
            else if (found == true)
            {
                classLoginMethod.insertLoginDateTime(ID, loginTime);
                if (type.Equals("Admin"))
                {
                    frmAdmin frm = new frmAdmin();
                    frm.lblName.Text = CompleteName;
                    frm.lblUserNum.Text = num;
                    frm.btnBackupArch.Visible = false;
                    frm.btnUserSettings.Visible = false;
                    frm.btnCashier.Visible = false;
                    frm.btnPatientR.Visible = false;
                    frm.ShowDialog();
                    this.Dispose(); this.Close();
                }
                else if (type.Equals("Cashier"))
                {
                    frmCashier frm = new frmCashier();
                    frm.lblCashierName.Text = CompleteName;
                    frm.lblUserNum.Text = num;
                    frm.ShowDialog();
                    this.Dispose(); this.Close();
                }
                else if (type.Equals("Master"))
                {
                    frmAdmin frm = new frmAdmin();
                    frm.lblName.Text = CompleteName;
                    frm.lblUserNum.Text = num;
                    frm.ShowDialog();
                    //frmLogin frmL = new frmLogin();
                    //frmL.Close();
                    this.Hide();  this.Close(); 

                }
                else
                {
                    MessageBox.Show("User type is not defined", title, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                this.Dispose(); this.Close();
            }
            else if(attempt < 0)
            {
                MessageBox.Show("Create account first if you do not have any", title, MessageBoxButtons.OK, MessageBoxIcon.Information);
                attempt = 0;
            }
            
        }

        private void linkLabelForgotP_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //frmSignUpForgotPass frm = new frmSignUpForgotPass();
            //frm.tabControlRegister.TabPages.Clear();
            //TabPage tab = new TabPage("Reset");
            //frm.tabControlRegister.TabPages.Add(tab);
            //tab.Controls.Add(frm.panelForgotPass);
            //frm.Size = new Size(647, 517);
            
            //frm.ShowDialog();

        }

        private void linkLabelCreateAccount_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //frmSignUpForgotPass frm = new frmSignUpForgotPass();
            //frm.tabControlRegister.TabPages.Clear();
            //TabPage tab = new TabPage("Sign Up");
            //frm.tabControlRegister.TabPages.Add(tab);
            //tab.Controls.Add(frm.panelSignUp);
            //frm.comBoxUserType.SelectedIndex = 0;
            //frm.ShowDialog();
        }

        private void checkBoxShowPassL_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxShowPassL.Checked == true)
            {
                txtPassword.PasswordChar = '\0';

            }
            else if (checkBoxShowPassL.Checked == false)
            {
                txtPassword.PasswordChar = '●';

            }
        }
    }
}
