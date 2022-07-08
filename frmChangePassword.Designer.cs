namespace Capstone
{
    partial class frmChangePassword
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
            this.btnChangePassword = new System.Windows.Forms.Button();
            this.txtConfirmNewPassword = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCloseChangePassword = new System.Windows.Forms.PictureBox();
            this.txtOldPassword = new System.Windows.Forms.TextBox();
            this.txtNewPassword = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCloseChangePassword)).BeginInit();
            this.SuspendLayout();
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.BackColor = System.Drawing.Color.LimeGreen;
            this.btnChangePassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChangePassword.FlatAppearance.BorderSize = 0;
            this.btnChangePassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangePassword.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnChangePassword.ForeColor = System.Drawing.Color.White;
            this.btnChangePassword.Location = new System.Drawing.Point(196, 267);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(153, 49);
            this.btnChangePassword.TabIndex = 41;
            this.btnChangePassword.Text = "Save";
            this.btnChangePassword.UseVisualStyleBackColor = false;
            // 
            // txtConfirmNewPassword
            // 
            this.txtConfirmNewPassword.Enabled = false;
            this.txtConfirmNewPassword.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtConfirmNewPassword.Location = new System.Drawing.Point(35, 196);
            this.txtConfirmNewPassword.Name = "txtConfirmNewPassword";
            this.txtConfirmNewPassword.PlaceholderText = "Confirm New Password";
            this.txtConfirmNewPassword.Size = new System.Drawing.Size(484, 47);
            this.txtConfirmNewPassword.TabIndex = 40;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnCloseChangePassword);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(548, 57);
            this.panel1.TabIndex = 38;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(264, 41);
            this.label1.TabIndex = 4;
            this.label1.Text = "Change Password";
            // 
            // btnCloseChangePassword
            // 
            this.btnCloseChangePassword.BackColor = System.Drawing.Color.Transparent;
            this.btnCloseChangePassword.BackgroundImage = global::Capstone.Properties.Resources.CloseTab;
            this.btnCloseChangePassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCloseChangePassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCloseChangePassword.Location = new System.Drawing.Point(491, 12);
            this.btnCloseChangePassword.Name = "btnCloseChangePassword";
            this.btnCloseChangePassword.Padding = new System.Windows.Forms.Padding(3);
            this.btnCloseChangePassword.Size = new System.Drawing.Size(40, 38);
            this.btnCloseChangePassword.TabIndex = 0;
            this.btnCloseChangePassword.TabStop = false;
            this.btnCloseChangePassword.Click += new System.EventHandler(this.btnCloseChangePassword_Click);
            // 
            // txtOldPassword
            // 
            this.txtOldPassword.Enabled = false;
            this.txtOldPassword.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtOldPassword.Location = new System.Drawing.Point(35, 90);
            this.txtOldPassword.Name = "txtOldPassword";
            this.txtOldPassword.PlaceholderText = "Old Password";
            this.txtOldPassword.Size = new System.Drawing.Size(484, 47);
            this.txtOldPassword.TabIndex = 45;
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNewPassword.Location = new System.Drawing.Point(35, 143);
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.PlaceholderText = "New Password";
            this.txtNewPassword.Size = new System.Drawing.Size(484, 47);
            this.txtNewPassword.TabIndex = 43;
            // 
            // frmChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(548, 340);
            this.Controls.Add(this.btnChangePassword);
            this.Controls.Add(this.txtConfirmNewPassword);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtOldPassword);
            this.Controls.Add(this.txtNewPassword);
            this.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmChangePassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmChangePassword";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCloseChangePassword)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnChangePassword;
        private TextBox txtConfirmNewPassword;
        private Panel panel1;
        private Label label1;
        private PictureBox btnCloseChangePassword;
        private TextBox txtOldPassword;
        private TextBox txtNewPassword;
    }
}