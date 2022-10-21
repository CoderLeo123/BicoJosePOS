namespace Capstone
{
    partial class frmExpListDispose
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
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tabControlExpLi = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panelExpiLists = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.dataGridViewExpLis = new System.Windows.Forms.DataGridView();
            this.NumService = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Desc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnMe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dek = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.lblItemIDCheck = new System.Windows.Forms.Label();
            this.lblITEMID = new System.Windows.Forms.Label();
            this.lblCheck = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblTrans = new System.Windows.Forms.Label();
            this.lblTransNo = new System.Windows.Forms.Label();
            this.txtSearchExpL = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.panel2.SuspendLayout();
            this.tabControlExpLi.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panelExpiLists.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewExpLis)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel9.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(750, 63);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(750, 63);
            this.panel3.TabIndex = 36;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.btnClose);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel6.Location = new System.Drawing.Point(689, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(61, 63);
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
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tabControlExpLi);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 63);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(750, 523);
            this.panel2.TabIndex = 1;
            // 
            // tabControlExpLi
            // 
            this.tabControlExpLi.Controls.Add(this.tabPage1);
            this.tabControlExpLi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlExpLi.Location = new System.Drawing.Point(0, 0);
            this.tabControlExpLi.Name = "tabControlExpLi";
            this.tabControlExpLi.SelectedIndex = 0;
            this.tabControlExpLi.Size = new System.Drawing.Size(750, 523);
            this.tabControlExpLi.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panelExpiLists);
            this.tabPage1.Location = new System.Drawing.Point(4, 46);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(742, 473);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "List";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panelExpiLists
            // 
            this.panelExpiLists.Controls.Add(this.panel7);
            this.panelExpiLists.Controls.Add(this.panel5);
            this.panelExpiLists.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelExpiLists.Location = new System.Drawing.Point(3, 3);
            this.panelExpiLists.Name = "panelExpiLists";
            this.panelExpiLists.Size = new System.Drawing.Size(736, 467);
            this.panelExpiLists.TabIndex = 0;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.dataGridViewExpLis);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(0, 57);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(736, 410);
            this.panel7.TabIndex = 1;
            // 
            // dataGridViewExpLis
            // 
            this.dataGridViewExpLis.AllowUserToAddRows = false;
            this.dataGridViewExpLis.AllowUserToResizeColumns = false;
            this.dataGridViewExpLis.AllowUserToResizeRows = false;
            this.dataGridViewExpLis.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewExpLis.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewExpLis.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewExpLis.ColumnHeadersHeight = 40;
            this.dataGridViewExpLis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewExpLis.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NumService,
            this.Num,
            this.Desc,
            this.Price,
            this.UnMe,
            this.dek});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewExpLis.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewExpLis.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewExpLis.EnableHeadersVisualStyles = false;
            this.dataGridViewExpLis.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewExpLis.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewExpLis.Name = "dataGridViewExpLis";
            this.dataGridViewExpLis.RowHeadersVisible = false;
            this.dataGridViewExpLis.RowHeadersWidth = 51;
            this.dataGridViewExpLis.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewExpLis.RowTemplate.Height = 35;
            this.dataGridViewExpLis.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewExpLis.Size = new System.Drawing.Size(736, 410);
            this.dataGridViewExpLis.TabIndex = 8;
            this.dataGridViewExpLis.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewExpLis_CellContentClick);
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
            // Num
            // 
            this.Num.HeaderText = "NUM";
            this.Num.MinimumWidth = 6;
            this.Num.Name = "Num";
            this.Num.ReadOnly = true;
            this.Num.Visible = false;
            this.Num.Width = 125;
            // 
            // Desc
            // 
            this.Desc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Desc.HeaderText = "EXPIRATION";
            this.Desc.MinimumWidth = 6;
            this.Desc.Name = "Desc";
            this.Desc.ReadOnly = true;
            // 
            // Price
            // 
            this.Price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Price.HeaderText = "STOCK";
            this.Price.MinimumWidth = 6;
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            // 
            // UnMe
            // 
            this.UnMe.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.UnMe.HeaderText = "UNIT";
            this.UnMe.MinimumWidth = 6;
            this.UnMe.Name = "UnMe";
            this.UnMe.ReadOnly = true;
            this.UnMe.Width = 106;
            // 
            // dek
            // 
            this.dek.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dek.HeaderText = "";
            this.dek.Image = global::Capstone.Properties.Resources._Delete;
            this.dek.MinimumWidth = 6;
            this.dek.Name = "dek";
            this.dek.ReadOnly = true;
            this.dek.Width = 6;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.panel9);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(736, 57);
            this.panel5.TabIndex = 0;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.DimGray;
            this.panel9.Controls.Add(this.lblItemIDCheck);
            this.panel9.Controls.Add(this.lblITEMID);
            this.panel9.Controls.Add(this.lblCheck);
            this.panel9.Controls.Add(this.label7);
            this.panel9.Controls.Add(this.lblTrans);
            this.panel9.Controls.Add(this.lblTransNo);
            this.panel9.Controls.Add(this.txtSearchExpL);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel9.Location = new System.Drawing.Point(0, 0);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(736, 57);
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
            // lblITEMID
            // 
            this.lblITEMID.AutoSize = true;
            this.lblITEMID.Location = new System.Drawing.Point(679, 15);
            this.lblITEMID.Name = "lblITEMID";
            this.lblITEMID.Size = new System.Drawing.Size(65, 38);
            this.lblITEMID.TabIndex = 9;
            this.lblITEMID.Text = "      ";
            this.lblITEMID.Visible = false;
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
            // txtSearchExpL
            // 
            this.txtSearchExpL.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSearchExpL.Location = new System.Drawing.Point(23, 10);
            this.txtSearchExpL.Name = "txtSearchExpL";
            this.txtSearchExpL.PlaceholderText = "Search Here";
            this.txtSearchExpL.Size = new System.Drawing.Size(619, 38);
            this.txtSearchExpL.TabIndex = 0;
            // 
            // frmExpListDispose
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 586);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmExpListDispose";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmExpListDispose";
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.panel2.ResumeLayout(false);
            this.tabControlExpLi.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panelExpiLists.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewExpLis)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Panel panel3;
        private Panel panel6;
        private PictureBox btnClose;
        private Panel panel2;
        public TabControl tabControlExpLi;
        private TabPage tabPage1;
        public Panel panelExpiLists;
        private Panel panel7;
        public DataGridView dataGridViewExpLis;
        private Panel panel5;
        private Panel panel9;
        private Label lblItemIDCheck;
        public Label lblITEMID;
        public Label lblCheck;
        private Label label7;
        public Label lblTrans;
        private Label lblTransNo;
        public TextBox txtSearchExpL;
        private DataGridViewTextBoxColumn NumService;
        private DataGridViewTextBoxColumn Num;
        private DataGridViewTextBoxColumn Desc;
        private DataGridViewTextBoxColumn Price;
        private DataGridViewTextBoxColumn UnMe;
        private DataGridViewImageColumn dek;
    }
}