namespace Capstone
{
    partial class frmSignUpForgotPass
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.tabControlRegister = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panelSignUp = new System.Windows.Forms.Panel();
            this.panelForgotPass = new System.Windows.Forms.Panel();
            this.btnCreateAccount = new System.Windows.Forms.Button();
            this.txtUserNameCreate = new System.Windows.Forms.TextBox();
            this.txtFirstN = new System.Windows.Forms.TextBox();
            this.txtConfirmPass = new System.Windows.Forms.TextBox();
            this.txtPasswordCreate = new System.Windows.Forms.TextBox();
            this.txtLastN = new System.Windows.Forms.TextBox();
            this.checkBoxShowPass = new System.Windows.Forms.CheckBox();
            this.linkLabelLogin = new System.Windows.Forms.LinkLabel();
            this.lblNameNotice = new System.Windows.Forms.Label();
            this.lblUserNamNotice = new System.Windows.Forms.Label();
            this.lblPasswordNotice = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comBoxUserType = new System.Windows.Forms.ComboBox();
            this.lblPassNoticeForgot = new System.Windows.Forms.Label();
            this.checkBoxShowPassForgot = new System.Windows.Forms.CheckBox();
            this.txtConfirmNewPass = new System.Windows.Forms.TextBox();
            this.txtNewPassword = new System.Windows.Forms.TextBox();
            this.btnResetPass = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblUsernameNoticeForgot = new System.Windows.Forms.Label();
            this.txtUserNameForgot = new System.Windows.Forms.TextBox();
            this.lblUserID = new System.Windows.Forms.Label();
            this.lblUserIDForgot = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.tabControlRegister.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panelSignUp.SuspendLayout();
            this.panelForgotPass.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(647, 57);
            this.panel1.TabIndex = 34;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.btnClose);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel6.Location = new System.Drawing.Point(586, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(61, 57);
            this.panel6.TabIndex = 1;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.BackgroundImage = global::Capstone.Properties.Resources.CloseTab;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Location = new System.Drawing.Point(12, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Padding = new System.Windows.Forms.Padding(3);
            this.btnClose.Size = new System.Drawing.Size(40, 38);
            this.btnClose.TabIndex = 0;
            this.btnClose.TabStop = false;
            // 
            // tabControlRegister
            // 
            this.tabControlRegister.Controls.Add(this.tabPage1);
            this.tabControlRegister.Controls.Add(this.tabPage2);
            this.tabControlRegister.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlRegister.Location = new System.Drawing.Point(0, 57);
            this.tabControlRegister.Name = "tabControlRegister";
            this.tabControlRegister.SelectedIndex = 0;
            this.tabControlRegister.Size = new System.Drawing.Size(647, 575);
            this.tabControlRegister.TabIndex = 35;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panelSignUp);
            this.tabPage1.Location = new System.Drawing.Point(4, 46);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(639, 525);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Register";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panelForgotPass);
            this.tabPage2.Location = new System.Drawing.Point(4, 46);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(639, 525);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Forgot Password";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panelSignUp
            // 
            this.panelSignUp.Controls.Add(this.lblUserID);
            this.panelSignUp.Controls.Add(this.comBoxUserType);
            this.panelSignUp.Controls.Add(this.label4);
            this.panelSignUp.Controls.Add(this.lblPasswordNotice);
            this.panelSignUp.Controls.Add(this.lblUserNamNotice);
            this.panelSignUp.Controls.Add(this.lblNameNotice);
            this.panelSignUp.Controls.Add(this.linkLabelLogin);
            this.panelSignUp.Controls.Add(this.checkBoxShowPass);
            this.panelSignUp.Controls.Add(this.txtLastN);
            this.panelSignUp.Controls.Add(this.txtConfirmPass);
            this.panelSignUp.Controls.Add(this.txtPasswordCreate);
            this.panelSignUp.Controls.Add(this.btnCreateAccount);
            this.panelSignUp.Controls.Add(this.txtUserNameCreate);
            this.panelSignUp.Controls.Add(this.txtFirstN);
            this.panelSignUp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSignUp.Location = new System.Drawing.Point(3, 3);
            this.panelSignUp.Name = "panelSignUp";
            this.panelSignUp.Size = new System.Drawing.Size(633, 519);
            this.panelSignUp.TabIndex = 0;
            // 
            // panelForgotPass
            // 
            this.panelForgotPass.Controls.Add(this.lblUserIDForgot);
            this.panelForgotPass.Controls.Add(this.lblUsernameNoticeForgot);
            this.panelForgotPass.Controls.Add(this.txtUserNameForgot);
            this.panelForgotPass.Controls.Add(this.label2);
            this.panelForgotPass.Controls.Add(this.lblPassNoticeForgot);
            this.panelForgotPass.Controls.Add(this.checkBoxShowPassForgot);
            this.panelForgotPass.Controls.Add(this.txtConfirmNewPass);
            this.panelForgotPass.Controls.Add(this.txtNewPassword);
            this.panelForgotPass.Controls.Add(this.btnResetPass);
            this.panelForgotPass.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelForgotPass.Location = new System.Drawing.Point(3, 3);
            this.panelForgotPass.Name = "panelForgotPass";
            this.panelForgotPass.Size = new System.Drawing.Size(633, 519);
            this.panelForgotPass.TabIndex = 0;
            // 
            // btnCreateAccount
            // 
            this.btnCreateAccount.BackColor = System.Drawing.Color.LimeGreen;
            this.btnCreateAccount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCreateAccount.FlatAppearance.BorderSize = 0;
            this.btnCreateAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateAccount.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCreateAccount.ForeColor = System.Drawing.Color.White;
            this.btnCreateAccount.Location = new System.Drawing.Point(209, 398);
            this.btnCreateAccount.Name = "btnCreateAccount";
            this.btnCreateAccount.Size = new System.Drawing.Size(192, 58);
            this.btnCreateAccount.TabIndex = 70;
            this.btnCreateAccount.Text = "SIGN UP";
            this.btnCreateAccount.UseVisualStyleBackColor = false;
            this.btnCreateAccount.Click += new System.EventHandler(this.btnCreateAccount_Click);
            // 
            // txtUserNameCreate
            // 
            this.txtUserNameCreate.BackColor = System.Drawing.Color.LightCyan;
            this.txtUserNameCreate.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtUserNameCreate.Location = new System.Drawing.Point(13, 176);
            this.txtUserNameCreate.Name = "txtUserNameCreate";
            this.txtUserNameCreate.PlaceholderText = "Username";
            this.txtUserNameCreate.Size = new System.Drawing.Size(329, 43);
            this.txtUserNameCreate.TabIndex = 69;
            // 
            // txtFirstN
            // 
            this.txtFirstN.BackColor = System.Drawing.Color.LightCyan;
            this.txtFirstN.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtFirstN.Location = new System.Drawing.Point(13, 87);
            this.txtFirstN.Name = "txtFirstN";
            this.txtFirstN.PlaceholderText = "First Name";
            this.txtFirstN.Size = new System.Drawing.Size(260, 43);
            this.txtFirstN.TabIndex = 68;
            // 
            // txtConfirmPass
            // 
            this.txtConfirmPass.BackColor = System.Drawing.Color.LightCyan;
            this.txtConfirmPass.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtConfirmPass.Location = new System.Drawing.Point(347, 262);
            this.txtConfirmPass.Name = "txtConfirmPass";
            this.txtConfirmPass.PlaceholderText = "Confirm";
            this.txtConfirmPass.Size = new System.Drawing.Size(260, 43);
            this.txtConfirmPass.TabIndex = 73;
            this.txtConfirmPass.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtPasswordCreate
            // 
            this.txtPasswordCreate.BackColor = System.Drawing.Color.LightCyan;
            this.txtPasswordCreate.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPasswordCreate.Location = new System.Drawing.Point(13, 262);
            this.txtPasswordCreate.Name = "txtPasswordCreate";
            this.txtPasswordCreate.PlaceholderText = "Password";
            this.txtPasswordCreate.Size = new System.Drawing.Size(260, 43);
            this.txtPasswordCreate.TabIndex = 72;
            // 
            // txtLastN
            // 
            this.txtLastN.BackColor = System.Drawing.Color.LightCyan;
            this.txtLastN.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtLastN.Location = new System.Drawing.Point(347, 87);
            this.txtLastN.Name = "txtLastN";
            this.txtLastN.PlaceholderText = "Last Name";
            this.txtLastN.Size = new System.Drawing.Size(260, 43);
            this.txtLastN.TabIndex = 74;
            // 
            // checkBoxShowPass
            // 
            this.checkBoxShowPass.AutoSize = true;
            this.checkBoxShowPass.Location = new System.Drawing.Point(13, 350);
            this.checkBoxShowPass.Name = "checkBoxShowPass";
            this.checkBoxShowPass.Size = new System.Drawing.Size(229, 42);
            this.checkBoxShowPass.TabIndex = 75;
            this.checkBoxShowPass.Text = "Show Password";
            this.checkBoxShowPass.UseVisualStyleBackColor = true;
            // 
            // linkLabelLogin
            // 
            this.linkLabelLogin.AutoSize = true;
            this.linkLabelLogin.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.linkLabelLogin.Location = new System.Drawing.Point(262, 459);
            this.linkLabelLogin.Name = "linkLabelLogin";
            this.linkLabelLogin.Size = new System.Drawing.Size(80, 31);
            this.linkLabelLogin.TabIndex = 76;
            this.linkLabelLogin.TabStop = true;
            this.linkLabelLogin.Text = "LOGIN";
            this.linkLabelLogin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelLogin_LinkClicked);
            // 
            // lblNameNotice
            // 
            this.lblNameNotice.AutoSize = true;
            this.lblNameNotice.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNameNotice.ForeColor = System.Drawing.Color.Red;
            this.lblNameNotice.Location = new System.Drawing.Point(13, 135);
            this.lblNameNotice.Name = "lblNameNotice";
            this.lblNameNotice.Size = new System.Drawing.Size(148, 31);
            this.lblNameNotice.TabIndex = 77;
            this.lblNameNotice.Text = "Name Notice";
            this.lblNameNotice.Visible = false;
            // 
            // lblUserNamNotice
            // 
            this.lblUserNamNotice.AutoSize = true;
            this.lblUserNamNotice.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblUserNamNotice.ForeColor = System.Drawing.Color.Red;
            this.lblUserNamNotice.Location = new System.Drawing.Point(13, 222);
            this.lblUserNamNotice.Name = "lblUserNamNotice";
            this.lblUserNamNotice.Size = new System.Drawing.Size(186, 31);
            this.lblUserNamNotice.TabIndex = 78;
            this.lblUserNamNotice.Text = "Username notice";
            this.lblUserNamNotice.Visible = false;
            // 
            // lblPasswordNotice
            // 
            this.lblPasswordNotice.AutoSize = true;
            this.lblPasswordNotice.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPasswordNotice.ForeColor = System.Drawing.Color.Red;
            this.lblPasswordNotice.Location = new System.Drawing.Point(13, 316);
            this.lblPasswordNotice.Name = "lblPasswordNotice";
            this.lblPasswordNotice.Size = new System.Drawing.Size(183, 31);
            this.lblPasswordNotice.TabIndex = 79;
            this.lblPasswordNotice.Text = "Password Notice";
            this.lblPasswordNotice.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(138, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(352, 50);
            this.label4.TabIndex = 80;
            this.label4.Text = "Create your account";
            // 
            // comBoxUserType
            // 
            this.comBoxUserType.BackColor = System.Drawing.Color.LightCyan;
            this.comBoxUserType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comBoxUserType.FormattingEnabled = true;
            this.comBoxUserType.Items.AddRange(new object[] {
            "Cashier",
            "Admin"});
            this.comBoxUserType.Location = new System.Drawing.Point(416, 176);
            this.comBoxUserType.Name = "comBoxUserType";
            this.comBoxUserType.Size = new System.Drawing.Size(191, 45);
            this.comBoxUserType.TabIndex = 81;
            // 
            // lblPassNoticeForgot
            // 
            this.lblPassNoticeForgot.AutoSize = true;
            this.lblPassNoticeForgot.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPassNoticeForgot.ForeColor = System.Drawing.Color.Red;
            this.lblPassNoticeForgot.Location = new System.Drawing.Point(19, 249);
            this.lblPassNoticeForgot.Name = "lblPassNoticeForgot";
            this.lblPassNoticeForgot.Size = new System.Drawing.Size(183, 31);
            this.lblPassNoticeForgot.TabIndex = 85;
            this.lblPassNoticeForgot.Text = "Password Notice";
            this.lblPassNoticeForgot.Visible = false;
            // 
            // checkBoxShowPassForgot
            // 
            this.checkBoxShowPassForgot.AutoSize = true;
            this.checkBoxShowPassForgot.Location = new System.Drawing.Point(19, 283);
            this.checkBoxShowPassForgot.Name = "checkBoxShowPassForgot";
            this.checkBoxShowPassForgot.Size = new System.Drawing.Size(229, 42);
            this.checkBoxShowPassForgot.TabIndex = 83;
            this.checkBoxShowPassForgot.Text = "Show Password";
            this.checkBoxShowPassForgot.UseVisualStyleBackColor = true;
            // 
            // txtConfirmNewPass
            // 
            this.txtConfirmNewPass.BackColor = System.Drawing.Color.LightCyan;
            this.txtConfirmNewPass.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtConfirmNewPass.Location = new System.Drawing.Point(353, 195);
            this.txtConfirmNewPass.Name = "txtConfirmNewPass";
            this.txtConfirmNewPass.PlaceholderText = "Confirm";
            this.txtConfirmNewPass.Size = new System.Drawing.Size(260, 43);
            this.txtConfirmNewPass.TabIndex = 82;
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.BackColor = System.Drawing.Color.LightCyan;
            this.txtNewPassword.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNewPassword.Location = new System.Drawing.Point(19, 195);
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.PlaceholderText = "New Password";
            this.txtNewPassword.Size = new System.Drawing.Size(260, 43);
            this.txtNewPassword.TabIndex = 81;
            // 
            // btnResetPass
            // 
            this.btnResetPass.BackColor = System.Drawing.Color.LimeGreen;
            this.btnResetPass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnResetPass.FlatAppearance.BorderSize = 0;
            this.btnResetPass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResetPass.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnResetPass.ForeColor = System.Drawing.Color.White;
            this.btnResetPass.Location = new System.Drawing.Point(215, 331);
            this.btnResetPass.Name = "btnResetPass";
            this.btnResetPass.Size = new System.Drawing.Size(192, 58);
            this.btnResetPass.TabIndex = 80;
            this.btnResetPass.Text = "CONFIRM";
            this.btnResetPass.UseVisualStyleBackColor = false;
            this.btnResetPass.Click += new System.EventHandler(this.btnResetPass_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(127, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(361, 50);
            this.label2.TabIndex = 86;
            this.label2.Text = "Reset your password";
            // 
            // lblUsernameNoticeForgot
            // 
            this.lblUsernameNoticeForgot.AutoSize = true;
            this.lblUsernameNoticeForgot.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblUsernameNoticeForgot.ForeColor = System.Drawing.Color.Red;
            this.lblUsernameNoticeForgot.Location = new System.Drawing.Point(19, 137);
            this.lblUsernameNoticeForgot.Name = "lblUsernameNoticeForgot";
            this.lblUsernameNoticeForgot.Size = new System.Drawing.Size(186, 31);
            this.lblUsernameNoticeForgot.TabIndex = 88;
            this.lblUsernameNoticeForgot.Text = "Username notice";
            this.lblUsernameNoticeForgot.Visible = false;
            // 
            // txtUserNameForgot
            // 
            this.txtUserNameForgot.BackColor = System.Drawing.Color.LightCyan;
            this.txtUserNameForgot.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtUserNameForgot.Location = new System.Drawing.Point(19, 91);
            this.txtUserNameForgot.Name = "txtUserNameForgot";
            this.txtUserNameForgot.PlaceholderText = "Username";
            this.txtUserNameForgot.Size = new System.Drawing.Size(329, 43);
            this.txtUserNameForgot.TabIndex = 87;
            // 
            // lblUserID
            // 
            this.lblUserID.AutoSize = true;
            this.lblUserID.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblUserID.ForeColor = System.Drawing.Color.Red;
            this.lblUserID.Location = new System.Drawing.Point(459, 316);
            this.lblUserID.Name = "lblUserID";
            this.lblUserID.Size = new System.Drawing.Size(88, 31);
            this.lblUserID.TabIndex = 82;
            this.lblUserID.Text = "User ID";
            this.lblUserID.Visible = false;
            // 
            // lblUserIDForgot
            // 
            this.lblUserIDForgot.AutoSize = true;
            this.lblUserIDForgot.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblUserIDForgot.ForeColor = System.Drawing.Color.Red;
            this.lblUserIDForgot.Location = new System.Drawing.Point(400, 99);
            this.lblUserIDForgot.Name = "lblUserIDForgot";
            this.lblUserIDForgot.Size = new System.Drawing.Size(88, 31);
            this.lblUserIDForgot.TabIndex = 89;
            this.lblUserIDForgot.Text = "User ID";
            this.lblUserIDForgot.Visible = false;
            // 
            // frmSignUpForgotPass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 632);
            this.Controls.Add(this.tabControlRegister);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "frmSignUpForgotPass";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmSignUpForgotPass";
            this.panel1.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.tabControlRegister.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.panelSignUp.ResumeLayout(false);
            this.panelSignUp.PerformLayout();
            this.panelForgotPass.ResumeLayout(false);
            this.panelForgotPass.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Panel panel6;
        private PictureBox btnClose;
        public TabControl tabControlRegister;
        private TabPage tabPage1;
        public Panel panelSignUp;
        private TabPage tabPage2;
        public Panel panelForgotPass;
        public TextBox txtLastN;
        public TextBox txtConfirmPass;
        public TextBox txtPasswordCreate;
        public Button btnCreateAccount;
        public TextBox txtUserNameCreate;
        public TextBox txtFirstN;
        public ComboBox comBoxUserType;
        private Label label4;
        public LinkLabel linkLabelLogin;
        public CheckBox checkBoxShowPass;
        public Label lblNameNotice;
        public Label lblPasswordNotice;
        public Label lblUserNamNotice;
        public Label lblUsernameNoticeForgot;
        public TextBox txtUserNameForgot;
        private Label label2;
        public Label lblPassNoticeForgot;
        public CheckBox checkBoxShowPassForgot;
        public TextBox txtConfirmNewPass;
        public TextBox txtNewPassword;
        public Button btnResetPass;
        public Label lblUserID;
        public Label lblUserIDForgot;
    }
}