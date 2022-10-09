namespace Capstone
{
    partial class frmPermission
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
            this.lblAdminPassNotice = new System.Windows.Forms.Label();
            this.txtAdminPassword = new System.Windows.Forms.TextBox();
            this.btnConfirmPassPermision = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(620, 64);
            this.panel1.TabIndex = 35;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.btnClose);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel6.Location = new System.Drawing.Point(559, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(61, 64);
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
            // lblAdminPassNotice
            // 
            this.lblAdminPassNotice.AutoSize = true;
            this.lblAdminPassNotice.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAdminPassNotice.ForeColor = System.Drawing.Color.Red;
            this.lblAdminPassNotice.Location = new System.Drawing.Point(29, 188);
            this.lblAdminPassNotice.Name = "lblAdminPassNotice";
            this.lblAdminPassNotice.Size = new System.Drawing.Size(183, 31);
            this.lblAdminPassNotice.TabIndex = 88;
            this.lblAdminPassNotice.Text = "Password Notice";
            this.lblAdminPassNotice.Visible = false;
            // 
            // txtAdminPassword
            // 
            this.txtAdminPassword.BackColor = System.Drawing.Color.LightCyan;
            this.txtAdminPassword.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtAdminPassword.Location = new System.Drawing.Point(29, 134);
            this.txtAdminPassword.Name = "txtAdminPassword";
            this.txtAdminPassword.PlaceholderText = "Admin Password";
            this.txtAdminPassword.Size = new System.Drawing.Size(351, 43);
            this.txtAdminPassword.TabIndex = 87;
            // 
            // btnConfirmPassPermision
            // 
            this.btnConfirmPassPermision.BackColor = System.Drawing.Color.LimeGreen;
            this.btnConfirmPassPermision.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfirmPassPermision.FlatAppearance.BorderSize = 0;
            this.btnConfirmPassPermision.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmPassPermision.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnConfirmPassPermision.ForeColor = System.Drawing.Color.White;
            this.btnConfirmPassPermision.Location = new System.Drawing.Point(407, 126);
            this.btnConfirmPassPermision.Name = "btnConfirmPassPermision";
            this.btnConfirmPassPermision.Size = new System.Drawing.Size(192, 58);
            this.btnConfirmPassPermision.TabIndex = 86;
            this.btnConfirmPassPermision.Text = "CONFIRM";
            this.btnConfirmPassPermision.UseVisualStyleBackColor = false;
            this.btnConfirmPassPermision.Click += new System.EventHandler(this.btnResetPass_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(171, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(243, 41);
            this.label2.TabIndex = 89;
            this.label2.Text = "Admin Permision";
            // 
            // frmPermission
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 253);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblAdminPassNotice);
            this.Controls.Add(this.txtAdminPassword);
            this.Controls.Add(this.btnConfirmPassPermision);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "frmPermission";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPermission";
            this.panel1.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private Panel panel6;
        private PictureBox btnClose;
        public Label lblAdminPassNotice;
        public TextBox txtAdminPassword;
        public Button btnConfirmPassPermision;
        private Label label2;
    }
}