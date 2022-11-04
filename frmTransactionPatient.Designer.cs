namespace Capstone
{
    partial class frmTransactionPatient
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTransactionPatient));
            this.panelTop = new System.Windows.Forms.Panel();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.panelFill = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.panelRTrans = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.dataGridViewRTrans = new System.Windows.Forms.DataGridView();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.txtSearchRTrans = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.NumService = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Desc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnMe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TDATE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ADD = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridViewSTrans = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearchSTrans = new System.Windows.Forms.TextBox();
            this.lblCurrentTransN = new System.Windows.Forms.Label();
            this.lblTransSNo = new System.Windows.Forms.Label();
            this.printDocumentReceipt = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocumentSettled = new System.Drawing.Printing.PrintDocument();
            this.lblPatientID = new System.Windows.Forms.Label();
            this.panelTop.SuspendLayout();
            this.panelBottom.SuspendLayout();
            this.panelFill.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.panelRTrans.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRTrans)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSTrans)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel8.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.panel3);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1041, 58);
            this.panelTop.TabIndex = 0;
            // 
            // panelBottom
            // 
            this.panelBottom.Controls.Add(this.panel1);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(0, 276);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(1041, 246);
            this.panelBottom.TabIndex = 1;
            // 
            // panelFill
            // 
            this.panelFill.Controls.Add(this.panelRTrans);
            this.panelFill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFill.Location = new System.Drawing.Point(0, 58);
            this.panelFill.Name = "panelFill";
            this.panelFill.Size = new System.Drawing.Size(1041, 218);
            this.panelFill.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel3.Controls.Add(this.lblPatientID);
            this.panel3.Controls.Add(this.lblTransSNo);
            this.panel3.Controls.Add(this.lblCurrentTransN);
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1041, 58);
            this.panel3.TabIndex = 37;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.btnClose);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel6.Location = new System.Drawing.Point(980, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(61, 58);
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
            // panelRTrans
            // 
            this.panelRTrans.Controls.Add(this.panel7);
            this.panelRTrans.Controls.Add(this.panel5);
            this.panelRTrans.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRTrans.Location = new System.Drawing.Point(0, 0);
            this.panelRTrans.Name = "panelRTrans";
            this.panelRTrans.Size = new System.Drawing.Size(1041, 218);
            this.panelRTrans.TabIndex = 1;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.dataGridViewRTrans);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(0, 57);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(1041, 161);
            this.panel7.TabIndex = 1;
            // 
            // dataGridViewRTrans
            // 
            this.dataGridViewRTrans.AllowUserToAddRows = false;
            this.dataGridViewRTrans.AllowUserToResizeColumns = false;
            this.dataGridViewRTrans.AllowUserToResizeRows = false;
            this.dataGridViewRTrans.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewRTrans.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewRTrans.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewRTrans.ColumnHeadersHeight = 40;
            this.dataGridViewRTrans.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewRTrans.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NumService,
            this.Desc,
            this.Price,
            this.UnMe,
            this.TDATE,
            this.ADD});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewRTrans.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewRTrans.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewRTrans.EnableHeadersVisualStyles = false;
            this.dataGridViewRTrans.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewRTrans.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewRTrans.Name = "dataGridViewRTrans";
            this.dataGridViewRTrans.RowHeadersVisible = false;
            this.dataGridViewRTrans.RowHeadersWidth = 51;
            this.dataGridViewRTrans.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewRTrans.RowTemplate.Height = 35;
            this.dataGridViewRTrans.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewRTrans.Size = new System.Drawing.Size(1041, 161);
            this.dataGridViewRTrans.TabIndex = 8;
            this.dataGridViewRTrans.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewRTrans_CellContentClick);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.panel9);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1041, 57);
            this.panel5.TabIndex = 0;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.DimGray;
            this.panel9.Controls.Add(this.label3);
            this.panel9.Controls.Add(this.txtSearchRTrans);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel9.Location = new System.Drawing.Point(0, 0);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(1041, 57);
            this.panel9.TabIndex = 38;
            // 
            // txtSearchRTrans
            // 
            this.txtSearchRTrans.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSearchRTrans.Location = new System.Drawing.Point(410, 13);
            this.txtSearchRTrans.Name = "txtSearchRTrans";
            this.txtSearchRTrans.PlaceholderText = "Search for Customer Here";
            this.txtSearchRTrans.Size = new System.Drawing.Size(619, 38);
            this.txtSearchRTrans.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(3, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(297, 41);
            this.label3.TabIndex = 2;
            this.label3.Text = "Regular Transaction";
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
            this.Desc.HeaderText = "INVOICE";
            this.Desc.MinimumWidth = 6;
            this.Desc.Name = "Desc";
            this.Desc.ReadOnly = true;
            // 
            // Price
            // 
            this.Price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Price.HeaderText = "CUSTOMER";
            this.Price.MinimumWidth = 6;
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            // 
            // UnMe
            // 
            this.UnMe.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.UnMe.HeaderText = "CASHIER";
            this.UnMe.MinimumWidth = 6;
            this.UnMe.Name = "UnMe";
            this.UnMe.ReadOnly = true;
            this.UnMe.Width = 152;
            // 
            // TDATE
            // 
            this.TDATE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.TDATE.HeaderText = "DATE";
            this.TDATE.MinimumWidth = 6;
            this.TDATE.Name = "TDATE";
            this.TDATE.ReadOnly = true;
            this.TDATE.Width = 108;
            // 
            // ADD
            // 
            this.ADD.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ADD.HeaderText = "";
            this.ADD.Image = global::Capstone.Properties.Resources.AddNew;
            this.ADD.MinimumWidth = 6;
            this.ADD.Name = "ADD";
            this.ADD.ReadOnly = true;
            this.ADD.Width = 6;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1041, 246);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridViewSTrans);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 57);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1041, 189);
            this.panel2.TabIndex = 1;
            // 
            // dataGridViewSTrans
            // 
            this.dataGridViewSTrans.AllowUserToAddRows = false;
            this.dataGridViewSTrans.AllowUserToResizeColumns = false;
            this.dataGridViewSTrans.AllowUserToResizeRows = false;
            this.dataGridViewSTrans.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewSTrans.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewSTrans.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridViewSTrans.ColumnHeadersHeight = 40;
            this.dataGridViewSTrans.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewSTrans.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewImageColumn1});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewSTrans.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridViewSTrans.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewSTrans.EnableHeadersVisualStyles = false;
            this.dataGridViewSTrans.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewSTrans.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewSTrans.Name = "dataGridViewSTrans";
            this.dataGridViewSTrans.RowHeadersVisible = false;
            this.dataGridViewSTrans.RowHeadersWidth = 51;
            this.dataGridViewSTrans.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewSTrans.RowTemplate.Height = 35;
            this.dataGridViewSTrans.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewSTrans.Size = new System.Drawing.Size(1041, 189);
            this.dataGridViewSTrans.TabIndex = 8;
            this.dataGridViewSTrans.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSTrans_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn1.HeaderText = "#";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 61;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.HeaderText = "INVOICE";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.HeaderText = "CUSTOMER";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn4.HeaderText = "CASHIER";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 152;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn5.HeaderText = "DATE";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 108;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = global::Capstone.Properties.Resources.AddNew;
            this.dataGridViewImageColumn1.MinimumWidth = 6;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            this.dataGridViewImageColumn1.Width = 6;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel8);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1041, 57);
            this.panel4.TabIndex = 0;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.DimGray;
            this.panel8.Controls.Add(this.label1);
            this.panel8.Controls.Add(this.txtSearchSTrans);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel8.Location = new System.Drawing.Point(0, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(1041, 57);
            this.panel8.TabIndex = 38;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(3, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(343, 41);
            this.label1.TabIndex = 2;
            this.label1.Text = "Settlement Transaction";
            // 
            // txtSearchSTrans
            // 
            this.txtSearchSTrans.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSearchSTrans.Location = new System.Drawing.Point(410, 13);
            this.txtSearchSTrans.Name = "txtSearchSTrans";
            this.txtSearchSTrans.PlaceholderText = "Search for Customer Here";
            this.txtSearchSTrans.Size = new System.Drawing.Size(619, 38);
            this.txtSearchSTrans.TabIndex = 0;
            // 
            // lblCurrentTransN
            // 
            this.lblCurrentTransN.AutoSize = true;
            this.lblCurrentTransN.Location = new System.Drawing.Point(508, 14);
            this.lblCurrentTransN.Name = "lblCurrentTransN";
            this.lblCurrentTransN.Size = new System.Drawing.Size(49, 38);
            this.lblCurrentTransN.TabIndex = 2;
            this.lblCurrentTransN.Text = "    ";
            this.lblCurrentTransN.Visible = false;
            // 
            // lblTransSNo
            // 
            this.lblTransSNo.AutoSize = true;
            this.lblTransSNo.Location = new System.Drawing.Point(585, 12);
            this.lblTransSNo.Name = "lblTransSNo";
            this.lblTransSNo.Size = new System.Drawing.Size(49, 38);
            this.lblTransSNo.TabIndex = 3;
            this.lblTransSNo.Text = "    ";
            this.lblTransSNo.Visible = false;
            // 
            // printDocumentReceipt
            // 
            this.printDocumentReceipt.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocumentReceipt_PrintPage);
            // 
            // printPreviewDialog
            // 
            this.printPreviewDialog.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog.Enabled = true;
            this.printPreviewDialog.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog.Icon")));
            this.printPreviewDialog.Name = "printPreviewDialog";
            this.printPreviewDialog.Visible = false;
            // 
            // printDocumentSettled
            // 
            this.printDocumentSettled.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocumentSettled_PrintPage);
            // 
            // lblPatientID
            // 
            this.lblPatientID.AutoSize = true;
            this.lblPatientID.Location = new System.Drawing.Point(423, 9);
            this.lblPatientID.Name = "lblPatientID";
            this.lblPatientID.Size = new System.Drawing.Size(49, 38);
            this.lblPatientID.TabIndex = 4;
            this.lblPatientID.Text = "    ";
            this.lblPatientID.Visible = false;
            // 
            // frmTransactionPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1041, 522);
            this.Controls.Add(this.panelFill);
            this.Controls.Add(this.panelBottom);
            this.Controls.Add(this.panelTop);
            this.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "frmTransactionPatient";
            this.Text = "frmTransactionPatient";
            this.panelTop.ResumeLayout(false);
            this.panelBottom.ResumeLayout(false);
            this.panelFill.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.panelRTrans.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRTrans)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSTrans)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panelTop;
        private Panel panel3;
        private Panel panel6;
        private PictureBox btnClose;
        private Panel panelBottom;
        private Panel panelFill;
        public Panel panelRTrans;
        private Panel panel7;
        public DataGridView dataGridViewRTrans;
        private Panel panel5;
        private Panel panel9;
        public TextBox txtSearchRTrans;
        private DataGridViewTextBoxColumn NumService;
        private DataGridViewTextBoxColumn Desc;
        private DataGridViewTextBoxColumn Price;
        private DataGridViewTextBoxColumn UnMe;
        private DataGridViewTextBoxColumn TDATE;
        private DataGridViewImageColumn ADD;
        private Label label3;
        public Panel panel1;
        private Panel panel2;
        public DataGridView dataGridViewSTrans;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewImageColumn dataGridViewImageColumn1;
        private Panel panel4;
        private Panel panel8;
        private Label label1;
        public TextBox txtSearchSTrans;
        private Label lblTransSNo;
        private Label lblCurrentTransN;
        private System.Drawing.Printing.PrintDocument printDocumentReceipt;
        private PrintPreviewDialog printPreviewDialog;
        private System.Drawing.Printing.PrintDocument printDocumentSettled;
        public Label lblPatientID;
    }
}