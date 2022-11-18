using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace Capstone
{
    internal class ClassLoginAndSignUp
    {
        SqlConnection cn = new SqlConnection();
        //SqlCommand cm = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        SqlDataReader dr;
        ClassComputations classCompute = new ClassComputations();
        string title = "BICO-JOSE System";

        public void checkConfirmPass(TextBox pass, TextBox confirmPass, out string result)
        {
            result = "Incorrect";
            if (pass.Text == confirmPass.Text)
            {
                result = pass.Text;
            }
            else if (pass.Text != confirmPass.Text)
            {
                result = "Incorrect";
            }
        }
        public void validatePass(out string correctPass, TextBox textPass, TextBox textConfirmPass, Label labelPassNotice)
        {//   txtPasswordCreate, txtConfirmPass, lblPasswordNotice
            string pass = "";//(out password, txtPasswordCreate, txtConfirmPass, lblPasswordNotice);
            checkConfirmPass(textPass, textConfirmPass, out pass);// correct pass or Incorrect
            if (pass.Equals("Incorrect"))
            {
                textConfirmPass.Focus();
                textConfirmPass.SelectAll();
                labelPassNotice.Text = "Those passwords didn't match. Try again";
                labelPassNotice.Visible = true;
                correctPass = "Again";
            }
            else//if (!(pass.Equals("Incorrect")))
            {
                correctPass = pass;
                labelPassNotice.Visible = false;
            }
        }
        public void textMinimumCharacter(TextBox textVar, Label labelNotice)
        {
            string input = textVar.Text;
            int inputLength = input.Length;
            int min = 8;
            if (inputLength < min)
            {
                textVar.Focus();
                labelNotice.Text = "Use 8 characters or more";
                labelNotice.Visible = true;
            }
            else
            {
                labelNotice.Visible = false;
            }
        }

        public void checkForBlank(TextBox checkText, Label labelNotice, string name)
        {
            if (checkText.Text == "")
            {
                labelNotice.Visible = true;//"Don't leave " + name + " blank"
                labelNotice.Text = name + " is blank";
                
            }
            else
            {
                labelNotice.Visible = false;
            }
        }
        public void checkForBlankOrIncorrectCredentials(TextBox checkText, Label labelNotice, string colName)
        {//txtUsername, lblUserNotice, "Username"
            cn = new SqlConnection(dbcon.MyConnection());
            string var = "";
            cn.Open();
            SqlCommand cm = new SqlCommand("SELECT "+ colName + " FROM tblUser WHERE " + colName + " = @Username", cn);
            cm.Parameters.AddWithValue("@Username", checkText.Text);
            dr = cm.ExecuteReader();
            dr.Read();
            if (dr.HasRows)
            {
                var = dr[0].ToString(); //correct pass               
                labelNotice.Visible = false;
                
            }
            if(var != checkText.Text)
            {
                labelNotice.Text = "Incorrect " + colName;
                labelNotice.Visible = true;
            }
            else if(var == "")
            {
                labelNotice.Text = "Don't leave the " + colName + " blank";
                labelNotice.Visible = true;
            }
            else
            {
                labelNotice.Visible = false;
            }
            dr.Close();
            cn.Close();
        }
        public void checkForAdmin()
        {//string user_ID, string UserName, string password, string Name, string userType
            cn = new SqlConnection(dbcon.MyConnection());
            cn.Open();
            SqlCommand cm = new SqlCommand("SELECT * FROM tblUser WHERE User_ID LIKE 'USR1000'", cn);
            dr = cm.ExecuteReader();
            dr.Read();
            if (dr.HasRows)
            {
                string useR_ID = dr[1].ToString();
                //UserName = dr[2].ToString();
                //password = dr[3].ToString();
                //Name = dr[4].ToString();
                //userType = dr[5].ToString();   
            }
            else
            {
                insertFirstAdmin("USR1000", "leo", "qweasd", "Leomar", "Cabug", "Master");
                
            }
            dr.Close();
            cn.Close();
        }

        public void insertFirstAdmin(string user_ID, string UserName, string password, string FName, string LName, string userType)
        {
            cn = new SqlConnection(dbcon.MyConnection());
            string Name = FName + " " + LName;

            

            cn.Open();
            SqlCommand cm = new SqlCommand("INSERT INTO tblUser (User_ID, Username, Password, Name, User_Type, FName, LName) VALUES(@User_ID, @Username, @Password, @Name, @User_Type, @FName, @LName)", cn);
            cm.Parameters.AddWithValue("@User_ID", user_ID);
            cm.Parameters.AddWithValue("@Username", UserName);
            cm.Parameters.AddWithValue("@Password", password);
            cm.Parameters.AddWithValue("@Name", Name);
            cm.Parameters.AddWithValue("@FName", FName);
            cm.Parameters.AddWithValue("@LName", LName);
            cm.Parameters.AddWithValue("@User_Type", userType);
            cm.ExecuteNonQuery();
            cn.Close();
        }
        public void selectDataTblUser(out string user_num, out string user_ID, out string UserName, out string name, out string userType, TextBox txtUser, TextBox txtPass, out bool found)
        {
            cn = new SqlConnection(dbcon.MyConnection());
            user_num = ""; user_ID = ""; UserName = ""; name = ""; userType = "";
            cn.Open();
            SqlCommand cm = new SqlCommand("SELECT * FROM tblUser WHERE Username = @Username AND Password = @Password", cn);
            cm.Parameters.AddWithValue("@Username", txtUser.Text);
            cm.Parameters.AddWithValue("@Password", txtPass.Text);
            dr = cm.ExecuteReader();
            dr.Read();
            if (dr.HasRows)
            {
                UserName = dr[2].ToString();
                name = dr[4].ToString();
                user_ID = dr[1].ToString();
                user_num = dr[0].ToString();
                userType = dr[5].ToString();
                found = true;                
            }
            else
            {
                found = false;
                checkForAdmin();
                //MessageBox.Show("Incorrect credentials", title, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            dr.Close();
            cn.Close();
        }
        public void insertLoginDateTime(string user_ID, string Login_DateTime)
        {
            cn = new SqlConnection(dbcon.MyConnection());          
            cn.Open();
            SqlCommand cm = new SqlCommand("INSERT INTO tblLoginSession (User_ID, Login_DateTime) VALUES(@User_ID, @Login_DateTime)", cn);
            cm.Parameters.AddWithValue("@User_ID", user_ID);
            cm.Parameters.AddWithValue("@Login_DateTime", Login_DateTime);            
            cm.ExecuteNonQuery();
            cn.Close();
        }
        public void selectNumSession(out string user_num, string logIn)
        {
            cn = new SqlConnection(dbcon.MyConnection());
            user_num = ""; 
            cn.Open();
            SqlCommand cm = new SqlCommand("SELECT Num FROM tblLoginSession WHERE Login_DateTime LIKE @logIn", cn);
            cm.Parameters.AddWithValue("@logIn", logIn);            
            dr = cm.ExecuteReader();
            dr.Read();
            if (dr.HasRows)
            {                               
                user_num = dr[0].ToString();                
            }            
            dr.Close();
            cn.Close();
        }
        public void insertLogOutDateTime(string User_num, string Logout_DateTime)
        {
            cn = new SqlConnection(dbcon.MyConnection());
            cn.Open();
            SqlCommand cm = new SqlCommand("UPDATE tblLoginSession SET Logout_DateTime = @Logout_DateTime WHERE Num = @User_num", cn);
            cm.Parameters.AddWithValue("@User_num", User_num);
            cm.Parameters.AddWithValue("@Logout_DateTime", Logout_DateTime);
            cm.ExecuteNonQuery();
            cn.Close();
        }

    }
}
