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
    public partial class frmUserSetting : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        SqlDataReader dr;
        public frmUserSetting()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
            LoadUsers();
            if (dataGridViewUsers.Rows.Count > 0)
            {
                dataGridViewUsers.Rows[0].Selected = true;
                lblUsID.Text = dataGridViewUsers.Rows[0].Cells[4].Value.ToString();

            }
                
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose(); this.Close();
        }

        private void linkLabelCreateNew_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmPermission frmP = new frmPermission();
            frmP.lblWhatForm.Text = "ResetPass";
            frmP.ShowDialog();

            if (frmP.lblGrant.Text == "1")
            {
                frmSignUpForgotPass frm = new frmSignUpForgotPass();
                frm.tabControlRegister.TabPages.Clear();
                TabPage tab = new TabPage("Sign Up");
                frm.tabControlRegister.TabPages.Add(tab);
                tab.Controls.Add(frm.panelSignUp);
                frm.comBoxUserType.SelectedIndex = 0;
                frm.ShowDialog();
                lblUserNotices.Visible = false;
            }
            else
            {
                lblUserNotices.Visible = true;
                lblUserNotices.Text = "Request not permitted";
            }

        }

        private void linkLabelResetPass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmPermission frmP = new frmPermission();
            frmP.lblWhatForm.Text = "ResetPass";
            frmP.ShowDialog();
            

            if (frmP.lblGrant.Text == "1")
            {
                frmSignUpForgotPass frm = new frmSignUpForgotPass();
                frm.tabControlRegister.TabPages.Clear();
                TabPage tab = new TabPage("Reset");
                frm.tabControlRegister.TabPages.Add(tab);
                tab.Controls.Add(frm.panelForgotPass);
                frm.Size = new Size(647, 517);
                //frm.txtUserNameForgot.Text = dataGridViewUsers.Rows[e.RowIndex].Cells[4].Value.ToString();
                frm.ShowDialog();
                
                lblUserNotices.Visible = false;
            }
            else
            {
                lblUserNotices.Visible = true;
                lblUserNotices.Text = "Request not permitted";
            }

            
            
        }
        public void LoadUserPassword()
        {
            cn = new SqlConnection(dbcon.MyConnection());
            
            
            cn.Open();
            SqlCommand cm = new SqlCommand("SELECT Password FROM tblUser WHERE User_ID LIKE '"+ lblUsID.Text + "'", cn);
            dr = cm.ExecuteReader();
            if (dr.Read())
            {
                txtViewPass.Text = dr[0].ToString();
            }
            else
            {
                lblUserNotices.Text = "Select a user first";
            }
            dr.Close();
            cn.Close();
        }

        public void LoadUsers()
        {
            cn = new SqlConnection(dbcon.MyConnection());
            int i = 0;
            dataGridViewUsers.Rows.Clear();
            cn.Open();
            SqlCommand cm = new SqlCommand("SELECT * FROM tblUser Order by Num", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                //                                                               2-ROLE / 5-User_Type       
                i += 1; //          0-#  1-NAME / 4-Name       1-USERNAME / 2-Username               2-ID / 5-User_ID  
                dataGridViewUsers.Rows.Add(i, dr[4].ToString(), dr[2].ToString(), dr[5].ToString(), dr[1].ToString());
            }
            dr.Close();
            cn.Close();
        }
        private void linkLabelViewPass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
            frmPermission frm = new frmPermission();
            frm.lblWhatForm.Text = "UserSetting";
            frm.ShowDialog();

           
            if (frm.lblGrant.Text == "1")
            {
                LoadUserPassword();

                lblUserNotices.Visible = false;
            }
            else
            {
                lblUserNotices.Visible = true;
                lblUserNotices.Text = "Request not permitted";
                lblPermitted.Text = "Denied";
            }
            
        }

        private void dataGridViewUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            lblUsID.Text = dataGridViewUsers.Rows[e.RowIndex].Cells[4].Value.ToString();
        }
    }
}
