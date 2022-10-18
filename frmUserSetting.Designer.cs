namespace Capstone
{
    partial class frmUserSetting
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblPermitted = new System.Windows.Forms.Label();
            this.lblUserNotices = new System.Windows.Forms.Label();
            this.lblUsID = new System.Windows.Forms.Label();
            this.txtViewPass = new System.Windows.Forms.TextBox();
            this.linkLabelResetPass = new System.Windows.Forms.LinkLabel();
            this.linkLabelViewPass = new System.Windows.Forms.LinkLabel();
            this.linkLabelCreateNew = new System.Windows.Forms.LinkLabel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panelCritical = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.dataGridViewUsers = new System.Windows.Forms.DataGridView();
            this.NumService = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Desc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Typ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AYD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.lblItemIDCheck = new System.Windows.Forms.Label();
            this.lblStock = new System.Windows.Forms.Label();
            this.lblCheck = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblTrans = new System.Windows.Forms.Label();
            this.lblTransNo = new System.Windows.Forms.Label();
            this.txtSearchUsers = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panelCritical.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsers)).BeginInit();
            this.panel6.SuspendLayout();
            this.panel9.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1206, 61);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1206, 57);
            this.panel3.TabIndex = 5;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btnClose);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(1156, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(50, 57);
            this.panel5.TabIndex = 5;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.BackgroundImage = global::Capstone.Properties.Resources.CloseTab;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Location = new System.Drawing.Point(6, 9);
            this.btnClose.Name = "btnClose";
            this.btnClose.Padding = new System.Windows.Forms.Padding(3);
            this.btnClose.Size = new System.Drawing.Size(40, 38);
            this.btnClose.TabIndex = 0;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 41);
            this.label1.TabIndex = 4;
            this.label1.Text = "Setting";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblPermitted);
            this.panel2.Controls.Add(this.lblUserNotices);
            this.panel2.Controls.Add(this.lblUsID);
            this.panel2.Controls.Add(this.txtViewPass);
            this.panel2.Controls.Add(this.linkLabelResetPass);
            this.panel2.Controls.Add(this.linkLabelViewPass);
            this.panel2.Controls.Add(this.linkLabelCreateNew);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 61);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1206, 719);
            this.panel2.TabIndex = 1;
            // 
            // lblPermitted
            // 
            this.lblPermitted.AutoSize = true;
            this.lblPermitted.Location = new System.Drawing.Point(967, 445);
            this.lblPermitted.Name = "lblPermitted";
            this.lblPermitted.Size = new System.Drawing.Size(33, 38);
            this.lblPermitted.TabIndex = 7;
            this.lblPermitted.Text = "  ";
            // 
            // lblUserNotices
            // 
            this.lblUserNotices.AutoSize = true;
            this.lblUserNotices.ForeColor = System.Drawing.Color.Red;
            this.lblUserNotices.Location = new System.Drawing.Point(598, 500);
            this.lblUserNotices.Name = "lblUserNotices";
            this.lblUserNotices.Size = new System.Drawing.Size(98, 38);
            this.lblUserNotices.TabIndex = 6;
            this.lblUserNotices.Text = "Notice";
            this.lblUserNotices.Visible = false;
            // 
            // lblUsID
            // 
            this.lblUsID.AutoSize = true;
            this.lblUsID.Location = new System.Drawing.Point(928, 445);
            this.lblUsID.Name = "lblUsID";
            this.lblUsID.Size = new System.Drawing.Size(33, 38);
            this.lblUsID.TabIndex = 5;
            this.lblUsID.Text = "  ";
            this.lblUsID.Visible = false;
            // 
            // txtViewPass
            // 
            this.txtViewPass.Enabled = false;
            this.txtViewPass.Location = new System.Drawing.Point(598, 440);
            this.txtViewPass.Name = "txtViewPass";
            this.txtViewPass.Size = new System.Drawing.Size(300, 43);
            this.txtViewPass.TabIndex = 4;
            // 
            // linkLabelResetPass
            // 
            this.linkLabelResetPass.AutoSize = true;
            this.linkLabelResetPass.Location = new System.Drawing.Point(901, 589);
            this.linkLabelResetPass.Name = "linkLabelResetPass";
            this.linkLabelResetPass.Size = new System.Drawing.Size(207, 38);
            this.linkLabelResetPass.TabIndex = 3;
            this.linkLabelResetPass.TabStop = true;
            this.linkLabelResetPass.Text = "Reset Password";
            this.linkLabelResetPass.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelResetPass_LinkClicked);
            // 
            // linkLabelViewPass
            // 
            this.linkLabelViewPass.AutoSize = true;
            this.linkLabelViewPass.Location = new System.Drawing.Point(364, 443);
            this.linkLabelViewPass.Name = "linkLabelViewPass";
            this.linkLabelViewPass.Size = new System.Drawing.Size(199, 38);
            this.linkLabelViewPass.TabIndex = 2;
            this.linkLabelViewPass.TabStop = true;
            this.linkLabelViewPass.Text = "View Password";
            this.linkLabelViewPass.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelViewPass_LinkClicked);
            // 
            // linkLabelCreateNew
            // 
            this.linkLabelCreateNew.AutoSize = true;
            this.linkLabelCreateNew.Location = new System.Drawing.Point(159, 589);
            this.linkLabelCreateNew.Name = "linkLabelCreateNew";
            this.linkLabelCreateNew.Size = new System.Drawing.Size(270, 38);
            this.linkLabelCreateNew.TabIndex = 1;
            this.linkLabelCreateNew.TabStop = true;
            this.linkLabelCreateNew.Text = "Create New Account";
            this.linkLabelCreateNew.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelCreateNew_LinkClicked);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panelCritical);
            this.panel4.Location = new System.Drawing.Point(159, 77);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(949, 336);
            this.panel4.TabIndex = 0;
            // 
            // panelCritical
            // 
            this.panelCritical.Controls.Add(this.panel7);
            this.panelCritical.Controls.Add(this.panel6);
            this.panelCritical.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCritical.Location = new System.Drawing.Point(0, 0);
            this.panelCritical.Name = "panelCritical";
            this.panelCritical.Size = new System.Drawing.Size(949, 336);
            this.panelCritical.TabIndex = 1;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.dataGridViewUsers);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(0, 57);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(949, 279);
            this.panel7.TabIndex = 1;
            // 
            // dataGridViewUsers
            // 
            this.dataGridViewUsers.AllowUserToAddRows = false;
            this.dataGridViewUsers.AllowUserToResizeColumns = false;
            this.dataGridViewUsers.AllowUserToResizeRows = false;
            this.dataGridViewUsers.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewUsers.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewUsers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewUsers.ColumnHeadersHeight = 40;
            this.dataGridViewUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NumService,
            this.Desc,
            this.Typ,
            this.Price,
            this.AYD});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewUsers.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewUsers.EnableHeadersVisualStyles = false;
            this.dataGridViewUsers.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewUsers.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewUsers.Name = "dataGridViewUsers";
            this.dataGridViewUsers.RowHeadersVisible = false;
            this.dataGridViewUsers.RowHeadersWidth = 51;
            this.dataGridViewUsers.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewUsers.RowTemplate.Height = 35;
            this.dataGridViewUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewUsers.Size = new System.Drawing.Size(949, 279);
            this.dataGridViewUsers.TabIndex = 8;
            this.dataGridViewUsers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewUsers_CellContentClick);
            // 
            // NumService
            // 
            this.NumService.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.NumService.HeaderText = "#";
            this.NumService.MinimumWidth = 6;
            this.NumService.Name = "NumService";
            this.NumService.ReadOnly = true;
            this.NumService.Width = 61;
            // 
            // Desc
            // 
            this.Desc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Desc.HeaderText = "NAME";
            this.Desc.MinimumWidth = 6;
            this.Desc.Name = "Desc";
            this.Desc.ReadOnly = true;
            // 
            // Typ
            // 
            this.Typ.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Typ.HeaderText = "USERNAME";
            this.Typ.MinimumWidth = 6;
            this.Typ.Name = "Typ";
            this.Typ.ReadOnly = true;
            // 
            // Price
            // 
            this.Price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Price.HeaderText = "ROLE";
            this.Price.MinimumWidth = 6;
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            this.Price.Width = 109;
            // 
            // AYD
            // 
            this.AYD.HeaderText = "USER ID";
            this.AYD.MinimumWidth = 6;
            this.AYD.Name = "AYD";
            this.AYD.ReadOnly = true;
            this.AYD.Visible = false;
            this.AYD.Width = 125;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.panel9);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(949, 57);
            this.panel6.TabIndex = 0;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.DimGray;
            this.panel9.Controls.Add(this.lblItemIDCheck);
            this.panel9.Controls.Add(this.lblStock);
            this.panel9.Controls.Add(this.lblCheck);
            this.panel9.Controls.Add(this.label7);
            this.panel9.Controls.Add(this.lblTrans);
            this.panel9.Controls.Add(this.lblTransNo);
            this.panel9.Controls.Add(this.txtSearchUsers);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel9.Location = new System.Drawing.Point(0, 0);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(949, 57);
            this.panel9.TabIndex = 38;
            // 
            // lblItemIDCheck
            // 
            this.lblItemIDCheck.AutoSize = true;
            this.lblItemIDCheck.Location = new System.Drawing.Point(795, 18);
            this.lblItemIDCheck.Name = "lblItemIDCheck";
            this.lblItemIDCheck.Size = new System.Drawing.Size(65, 38);
            this.lblItemIDCheck.TabIndex = 10;
            this.lblItemIDCheck.Text = "      ";
            this.lblItemIDCheck.Visible = false;
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Location = new System.Drawing.Point(679, 15);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(65, 38);
            this.lblStock.TabIndex = 9;
            this.lblStock.Text = "      ";
            // 
            // lblCheck
            // 
            this.lblCheck.AutoSize = true;
            this.lblCheck.Location = new System.Drawing.Point(991, 15);
            this.lblCheck.Name = "lblCheck";
            this.lblCheck.Size = new System.Drawing.Size(89, 38);
            this.lblCheck.TabIndex = 4;
            this.lblCheck.Text = "         ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1153, 49);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 38);
            this.label7.TabIndex = 3;
            this.label7.Text = "label7";
            // 
            // lblTrans
            // 
            this.lblTrans.AutoSize = true;
            this.lblTrans.Location = new System.Drawing.Point(1188, 20);
            this.lblTrans.Name = "lblTrans";
            this.lblTrans.Size = new System.Drawing.Size(65, 38);
            this.lblTrans.TabIndex = 2;
            this.lblTrans.Text = "      ";
            this.lblTrans.Visible = false;
            // 
            // lblTransNo
            // 
            this.lblTransNo.AutoSize = true;
            this.lblTransNo.Location = new System.Drawing.Point(1162, 15);
            this.lblTransNo.Name = "lblTransNo";
            this.lblTransNo.Size = new System.Drawing.Size(0, 38);
            this.lblTransNo.TabIndex = 1;
            // 
            // txtSearchUsers
            // 
            this.txtSearchUsers.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSearchUsers.Location = new System.Drawing.Point(23, 10);
            this.txtSearchUsers.Name = "txtSearchUsers";
            this.txtSearchUsers.PlaceholderText = "Search Here";
            this.txtSearchUsers.Size = new System.Drawing.Size(619, 38);
            this.txtSearchUsers.TabIndex = 0;
            // 
            // frmUserSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1206, 780);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmUserSetting";
            this.Text = "frmUserSetting";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panelCritical.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsers)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel5;
        private PictureBox btnClose;
        private Label label1;
        private Panel panel4;
        public Panel panelCritical;
        private Panel panel7;
        public DataGridView dataGridViewUsers;
        private Panel panel6;
        private Panel panel9;
        private Label lblItemIDCheck;
        public Label lblStock;
        public Label lblCheck;
        private Label label7;
        public Label lblTrans;
        private Label lblTransNo;
        public TextBox txtSearchUsers;
        public LinkLabel linkLabelResetPass;
        public LinkLabel linkLabelViewPass;
        public LinkLabel linkLabelCreateNew;
        public TextBox txtViewPass;
        private DataGridViewTextBoxColumn NumService;
        private DataGridViewTextBoxColumn Desc;
        private DataGridViewTextBoxColumn Typ;
        private DataGridViewTextBoxColumn Price;
        private DataGridViewTextBoxColumn AYD;
        public Label lblUsID;
        private Label lblUserNotices;
        public Label lblPermitted;
    }
}