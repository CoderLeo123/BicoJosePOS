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
        string title = "BICO-JOSE System";
        public frmUserSetting()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
            LoadUsers(); LoadSession();
            if (dataGridViewUsers.Rows.Count > 0)
            {
                dataGridViewUsers.Rows[0].Selected = true;
                lblUsID.Text = dataGridViewUsers.Rows[0].Cells[4].Value.ToString();

            }
                
            
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


        public void checkWhatIsPress(bool btnReO, bool btnCrit)
        {
            if (btnReO == true)
            {
                colorChange(true, btnSetting); colorChange(false, btnSession); 
            }
            else if (btnCrit == true)
            {
                colorChange(true, btnSession); colorChange(false, btnSetting);
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
        public void LoadSession()
        {
            cn = new SqlConnection(dbcon.MyConnection());
            int i = 0;
            dataGridViewSession.Rows.Clear();
            cn.Open();
            SqlCommand cm = new SqlCommand("SELECT * FROM ViewLoginSession WHERE (Name LIKE '%" + txtSearchSession.Text + "%' OR User_Type LIKE '%" + txtSearchSession.Text + "%') Order by Num DESC", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                //                                                               2-ROLE / 5-User_Type       
                i += 1; //          0-#  1-NAME / 4-Name       1-USERNAME / 2-Username               2-ID / 5-User_ID  
                dataGridViewSession.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString());
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

        private void btnSetting_Click(object sender, EventArgs e)
        {
            tabControlUser.TabPages.Clear();
            TabPage tab = new TabPage("SETTING");
            tabControlUser.TabPages.Add(tab);
            tab.Controls.Add(panelSetting);
            LoadUsers();
            checkWhatIsPress(true, false);
        }

        private void btnSession_Click(object sender, EventArgs e)
        {
            tabControlUser.TabPages.Clear();
            TabPage tab = new TabPage("LOGIN SESSION");
            tabControlUser.TabPages.Add(tab);
            tab.Controls.Add(panelSession);
            LoadSession();
            checkWhatIsPress(false, true);
        }

        private void txtSearchSession_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtSearchSession.Text == String.Empty)
                {
                    LoadSession();
                    return;
                }
                else
                {
                    LoadSession();
                }
            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message, title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
