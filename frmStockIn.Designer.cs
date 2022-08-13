namespace Capstone
{
    partial class frmStockIn
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.tabControlStockIn = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnSaveStockIn = new System.Windows.Forms.Button();
            this.dataGridViewStockItems = new System.Windows.Forms.DataGridView();
            this.NumStockIn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EDIT = new System.Windows.Forms.DataGridViewImageColumn();
            this.DeleteStockIn = new System.Windows.Forms.DataGridViewImageColumn();
            this.STOCK_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescStockIn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuantityStockIn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EXPIRATION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StockInDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StockInBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ITEM_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TypeStockIn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ClickSearchItem = new System.Windows.Forms.LinkLabel();
            this.GenerateStockID = new System.Windows.Forms.LinkLabel();
            this.dateStockIn = new System.Windows.Forms.DateTimePicker();
            this.txtStockInBy = new System.Windows.Forms.TextBox();
            this.txtStockID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridViewStockHist = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.INVENTORYID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StockID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuantityHistory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StockDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExpirationHistory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StockBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemIDHistory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TypeHistory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnLoadHistory = new System.Windows.Forms.Button();
            this.dateEnd = new System.Windows.Forms.DateTimePicker();
            this.dateStart = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.tabControlStockIn.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStockItems)).BeginInit();
            this.panel2.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStockHist)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1315, 57);
            this.panel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 45);
            this.label1.TabIndex = 4;
            this.label1.Text = "Stock In";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.BackgroundImage = global::Capstone.Properties.Resources.CloseTab;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Location = new System.Drawing.Point(1260, 9);
            this.btnClose.Name = "btnClose";
            this.btnClose.Padding = new System.Windows.Forms.Padding(3);
            this.btnClose.Size = new System.Drawing.Size(40, 38);
            this.btnClose.TabIndex = 0;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // tabControlStockIn
            // 
            this.tabControlStockIn.Controls.Add(this.tabPage1);
            this.tabControlStockIn.Controls.Add(this.tabPage2);
            this.tabControlStockIn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlStockIn.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tabControlStockIn.Location = new System.Drawing.Point(0, 57);
            this.tabControlStockIn.Name = "tabControlStockIn";
            this.tabControlStockIn.SelectedIndex = 0;
            this.tabControlStockIn.Size = new System.Drawing.Size(1315, 873);
            this.tabControlStockIn.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel3);
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Location = new System.Drawing.Point(4, 46);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1307, 823);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Stock Entry";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnSaveStockIn);
            this.panel3.Controls.Add(this.dataGridViewStockItems);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 212);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1301, 608);
            this.panel3.TabIndex = 1;
            // 
            // btnSaveStockIn
            // 
            this.btnSaveStockIn.BackColor = System.Drawing.Color.LimeGreen;
            this.btnSaveStockIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveStockIn.FlatAppearance.BorderSize = 0;
            this.btnSaveStockIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveStockIn.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSaveStockIn.ForeColor = System.Drawing.Color.White;
            this.btnSaveStockIn.Location = new System.Drawing.Point(5, 556);
            this.btnSaveStockIn.Name = "btnSaveStockIn";
            this.btnSaveStockIn.Size = new System.Drawing.Size(140, 49);
            this.btnSaveStockIn.TabIndex = 23;
            this.btnSaveStockIn.Text = "Save";
            this.btnSaveStockIn.UseVisualStyleBackColor = false;
            this.btnSaveStockIn.Click += new System.EventHandler(this.btnSaveStockIn_Click);
            // 
            // dataGridViewStockItems
            // 
            this.dataGridViewStockItems.AllowUserToAddRows = false;
            this.dataGridViewStockItems.AllowUserToResizeColumns = false;
            this.dataGridViewStockItems.AllowUserToResizeRows = false;
            this.dataGridViewStockItems.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewStockItems.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewStockItems.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewStockItems.ColumnHeadersHeight = 40;
            this.dataGridViewStockItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewStockItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NumStockIn,
            this.EDIT,
            this.DeleteStockIn,
            this.STOCK_ID,
            this.DescStockIn,
            this.QuantityStockIn,
            this.EXPIRATION,
            this.StockInDate,
            this.StockInBy,
            this.ITEM_ID,
            this.TypeStockIn,
            this.Column1});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewStockItems.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewStockItems.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridViewStockItems.EnableHeadersVisualStyles = false;
            this.dataGridViewStockItems.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewStockItems.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewStockItems.Name = "dataGridViewStockItems";
            this.dataGridViewStockItems.RowHeadersVisible = false;
            this.dataGridViewStockItems.RowHeadersWidth = 51;
            this.dataGridViewStockItems.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewStockItems.RowTemplate.Height = 29;
            this.dataGridViewStockItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewStockItems.Size = new System.Drawing.Size(1301, 550);
            this.dataGridViewStockItems.TabIndex = 3;
            this.dataGridViewStockItems.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewStockItems_CellContentClick);
            this.dataGridViewStockItems.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dataGridViewStockItems_RowsAdded);
            this.dataGridViewStockItems.SelectionChanged += new System.EventHandler(this.dataGridViewStockItems_SelectionChanged);
            // 
            // NumStockIn
            // 
            this.NumStockIn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.NumStockIn.HeaderText = "ID";
            this.NumStockIn.MinimumWidth = 6;
            this.NumStockIn.Name = "NumStockIn";
            this.NumStockIn.ReadOnly = true;
            this.NumStockIn.Width = 63;
            // 
            // EDIT
            // 
            this.EDIT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.EDIT.HeaderText = "";
            this.EDIT.Image = global::Capstone.Properties.Resources.Edit;
            this.EDIT.MinimumWidth = 6;
            this.EDIT.Name = "EDIT";
            this.EDIT.Width = 6;
            // 
            // DeleteStockIn
            // 
            this.DeleteStockIn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.DeleteStockIn.HeaderText = "";
            this.DeleteStockIn.MinimumWidth = 6;
            this.DeleteStockIn.Name = "DeleteStockIn";
            this.DeleteStockIn.Width = 6;
            // 
            // STOCK_ID
            // 
            this.STOCK_ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.STOCK_ID.HeaderText = "STOCK ID";
            this.STOCK_ID.MinimumWidth = 6;
            this.STOCK_ID.Name = "STOCK_ID";
            this.STOCK_ID.ReadOnly = true;
            this.STOCK_ID.Width = 136;
            // 
            // DescStockIn
            // 
            this.DescStockIn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.DescStockIn.HeaderText = "DESCRIPTION";
            this.DescStockIn.MinimumWidth = 6;
            this.DescStockIn.Name = "DescStockIn";
            this.DescStockIn.ReadOnly = true;
            this.DescStockIn.Width = 180;
            // 
            // QuantityStockIn
            // 
            this.QuantityStockIn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.QuantityStockIn.HeaderText = "QTY";
            this.QuantityStockIn.MinimumWidth = 6;
            this.QuantityStockIn.Name = "QuantityStockIn";
            this.QuantityStockIn.ReadOnly = true;
            this.QuantityStockIn.Width = 82;
            // 
            // EXPIRATION
            // 
            this.EXPIRATION.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.EXPIRATION.HeaderText = "EXPIRATION";
            this.EXPIRATION.MinimumWidth = 6;
            this.EXPIRATION.Name = "EXPIRATION";
            this.EXPIRATION.ReadOnly = true;
            this.EXPIRATION.Width = 165;
            // 
            // StockInDate
            // 
            this.StockInDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.StockInDate.HeaderText = "STOCK IN DATE";
            this.StockInDate.MinimumWidth = 6;
            this.StockInDate.Name = "StockInDate";
            this.StockInDate.ReadOnly = true;
            this.StockInDate.Width = 195;
            // 
            // StockInBy
            // 
            this.StockInBy.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.StockInBy.HeaderText = "STOCK IN BY";
            this.StockInBy.MinimumWidth = 6;
            this.StockInBy.Name = "StockInBy";
            this.StockInBy.ReadOnly = true;
            this.StockInBy.Width = 168;
            // 
            // ITEM_ID
            // 
            this.ITEM_ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ITEM_ID.HeaderText = "ITEM ID";
            this.ITEM_ID.MinimumWidth = 6;
            this.ITEM_ID.Name = "ITEM_ID";
            this.ITEM_ID.ReadOnly = true;
            this.ITEM_ID.Width = 120;
            // 
            // TypeStockIn
            // 
            this.TypeStockIn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.TypeStockIn.HeaderText = "TYPE";
            this.TypeStockIn.MinimumWidth = 6;
            this.TypeStockIn.Name = "TypeStockIn";
            this.TypeStockIn.ReadOnly = true;
            this.TypeStockIn.Width = 91;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.HeaderText = "";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.ClickSearchItem);
            this.panel2.Controls.Add(this.GenerateStockID);
            this.panel2.Controls.Add(this.dateStockIn);
            this.panel2.Controls.Add(this.txtStockInBy);
            this.panel2.Controls.Add(this.txtStockID);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1301, 209);
            this.panel2.TabIndex = 0;
            // 
            // ClickSearchItem
            // 
            this.ClickSearchItem.AutoSize = true;
            this.ClickSearchItem.LinkColor = System.Drawing.Color.Navy;
            this.ClickSearchItem.Location = new System.Drawing.Point(681, 86);
            this.ClickSearchItem.Name = "ClickSearchItem";
            this.ClickSearchItem.Size = new System.Drawing.Size(352, 38);
            this.ClickSearchItem.TabIndex = 9;
            this.ClickSearchItem.TabStop = true;
            this.ClickSearchItem.Text = "[Click Here to Browse Item]";
            this.ClickSearchItem.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ClickSearchItem_LinkClicked);
            // 
            // GenerateStockID
            // 
            this.GenerateStockID.AutoSize = true;
            this.GenerateStockID.LinkColor = System.Drawing.Color.Navy;
            this.GenerateStockID.Location = new System.Drawing.Point(515, 21);
            this.GenerateStockID.Name = "GenerateStockID";
            this.GenerateStockID.Size = new System.Drawing.Size(146, 38);
            this.GenerateStockID.TabIndex = 8;
            this.GenerateStockID.TabStop = true;
            this.GenerateStockID.Text = "[Generate]";
            this.GenerateStockID.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.GenerateStockID_LinkClicked);
            // 
            // dateStockIn
            // 
            this.dateStockIn.Enabled = false;
            this.dateStockIn.Location = new System.Drawing.Point(226, 81);
            this.dateStockIn.Name = "dateStockIn";
            this.dateStockIn.Size = new System.Drawing.Size(423, 43);
            this.dateStockIn.TabIndex = 5;
            // 
            // txtStockInBy
            // 
            this.txtStockInBy.Location = new System.Drawing.Point(873, 18);
            this.txtStockInBy.Name = "txtStockInBy";
            this.txtStockInBy.PlaceholderText = "Cashier";
            this.txtStockInBy.Size = new System.Drawing.Size(372, 43);
            this.txtStockInBy.TabIndex = 4;
            // 
            // txtStockID
            // 
            this.txtStockID.Enabled = false;
            this.txtStockID.Location = new System.Drawing.Point(226, 21);
            this.txtStockID.Name = "txtStockID";
            this.txtStockID.PlaceholderText = "S000000";
            this.txtStockID.Size = new System.Drawing.Size(279, 43);
            this.txtStockID.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(180, 38);
            this.label4.TabIndex = 2;
            this.label4.Text = "Stock In Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(681, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 38);
            this.label3.TabIndex = 1;
            this.label3.Text = "Stock In By";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 38);
            this.label2.TabIndex = 0;
            this.label2.Text = "Stock ID";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridViewStockHist);
            this.tabPage2.Controls.Add(this.panel4);
            this.tabPage2.Location = new System.Drawing.Point(4, 46);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1307, 823);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Stock In History";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridViewStockHist
            // 
            this.dataGridViewStockHist.AllowUserToAddRows = false;
            this.dataGridViewStockHist.AllowUserToResizeColumns = false;
            this.dataGridViewStockHist.AllowUserToResizeRows = false;
            this.dataGridViewStockHist.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewStockHist.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewStockHist.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridViewStockHist.ColumnHeadersHeight = 40;
            this.dataGridViewStockHist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewStockHist.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.INVENTORYID,
            this.StockID,
            this.Description,
            this.QuantityHistory,
            this.StockDate,
            this.ExpirationHistory,
            this.StockBy,
            this.ItemIDHistory,
            this.TypeHistory});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewStockHist.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridViewStockHist.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewStockHist.EnableHeadersVisualStyles = false;
            this.dataGridViewStockHist.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewStockHist.Location = new System.Drawing.Point(3, 89);
            this.dataGridViewStockHist.Name = "dataGridViewStockHist";
            this.dataGridViewStockHist.RowHeadersVisible = false;
            this.dataGridViewStockHist.RowHeadersWidth = 51;
            this.dataGridViewStockHist.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewStockHist.RowTemplate.Height = 29;
            this.dataGridViewStockHist.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewStockHist.Size = new System.Drawing.Size(1301, 731);
            this.dataGridViewStockHist.TabIndex = 4;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn1.HeaderText = "#";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 61;
            // 
            // INVENTORYID
            // 
            this.INVENTORYID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.INVENTORYID.HeaderText = "ID";
            this.INVENTORYID.MinimumWidth = 6;
            this.INVENTORYID.Name = "INVENTORYID";
            this.INVENTORYID.Width = 71;
            // 
            // StockID
            // 
            this.StockID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.StockID.HeaderText = "STOCK ID";
            this.StockID.MinimumWidth = 6;
            this.StockID.Name = "StockID";
            this.StockID.Width = 162;
            // 
            // Description
            // 
            this.Description.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Description.HeaderText = "DESCRIPTION";
            this.Description.MinimumWidth = 6;
            this.Description.Name = "Description";
            this.Description.Width = 214;
            // 
            // QuantityHistory
            // 
            this.QuantityHistory.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.QuantityHistory.HeaderText = "QTY";
            this.QuantityHistory.MinimumWidth = 6;
            this.QuantityHistory.Name = "QuantityHistory";
            this.QuantityHistory.Width = 95;
            // 
            // StockDate
            // 
            this.StockDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.StockDate.HeaderText = "STOCK IN DATE";
            this.StockDate.MinimumWidth = 6;
            this.StockDate.Name = "StockDate";
            this.StockDate.Width = 235;
            // 
            // ExpirationHistory
            // 
            this.ExpirationHistory.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ExpirationHistory.HeaderText = "EXPIRATION";
            this.ExpirationHistory.MinimumWidth = 6;
            this.ExpirationHistory.Name = "ExpirationHistory";
            this.ExpirationHistory.Width = 195;
            // 
            // StockBy
            // 
            this.StockBy.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.StockBy.HeaderText = "STOCK IN BY";
            this.StockBy.MinimumWidth = 6;
            this.StockBy.Name = "StockBy";
            this.StockBy.Width = 201;
            // 
            // ItemIDHistory
            // 
            this.ItemIDHistory.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ItemIDHistory.HeaderText = "ITEM ID";
            this.ItemIDHistory.MinimumWidth = 6;
            this.ItemIDHistory.Name = "ItemIDHistory";
            this.ItemIDHistory.Width = 140;
            // 
            // TypeHistory
            // 
            this.TypeHistory.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.TypeHistory.HeaderText = "TYPE";
            this.TypeHistory.MinimumWidth = 6;
            this.TypeHistory.Name = "TypeHistory";
            this.TypeHistory.Width = 105;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DimGray;
            this.panel4.Controls.Add(this.btnLoadHistory);
            this.panel4.Controls.Add(this.dateEnd);
            this.panel4.Controls.Add(this.dateStart);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(3, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1301, 86);
            this.panel4.TabIndex = 1;
            // 
            // btnLoadHistory
            // 
            this.btnLoadHistory.BackColor = System.Drawing.Color.LimeGreen;
            this.btnLoadHistory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLoadHistory.FlatAppearance.BorderSize = 0;
            this.btnLoadHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoadHistory.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLoadHistory.ForeColor = System.Drawing.Color.White;
            this.btnLoadHistory.Location = new System.Drawing.Point(815, 18);
            this.btnLoadHistory.Name = "btnLoadHistory";
            this.btnLoadHistory.Size = new System.Drawing.Size(186, 49);
            this.btnLoadHistory.TabIndex = 22;
            this.btnLoadHistory.Text = "Load Record";
            this.btnLoadHistory.UseVisualStyleBackColor = false;
            this.btnLoadHistory.Click += new System.EventHandler(this.btnLoadHistory_Click);
            // 
            // dateEnd
            // 
            this.dateEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateEnd.Location = new System.Drawing.Point(579, 18);
            this.dateEnd.Name = "dateEnd";
            this.dateEnd.Size = new System.Drawing.Size(214, 43);
            this.dateEnd.TabIndex = 6;
            // 
            // dateStart
            // 
            this.dateStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateStart.Location = new System.Drawing.Point(347, 18);
            this.dateStart.Name = "dateStart";
            this.dateStart.Size = new System.Drawing.Size(214, 43);
            this.dateStart.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(15, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(335, 38);
            this.label7.TabIndex = 2;
            this.label7.Text = "Filter By Date (From - To)";
            // 
            // frmStockIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1315, 930);
            this.Controls.Add(this.tabControlStockIn);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmStockIn";
            this.Text = "frmStockIn";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.tabControlStockIn.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStockItems)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStockHist)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Label label1;
        private PictureBox btnClose;
        private TabControl tabControlStockIn;
        private TabPage tabPage1;
        private Panel panel2;
        private Label label2;
        private TabPage tabPage2;
        private Label label4;
        private Label label3;
        private Panel panel3;
        private LinkLabel ClickSearchItem;
        private DataGridView dataGridViewStockHist;
        private Panel panel4;
        private DateTimePicker dateEnd;
        private DateTimePicker dateStart;
        private Label label7;
        private Button btnLoadHistory;
        public DateTimePicker dateStockIn;
        public TextBox txtStockInBy;
        public TextBox txtStockID;
        public Button btnSaveStockIn;
        public LinkLabel GenerateStockID;
        public DataGridView dataGridViewStockItems;
        private DataGridViewTextBoxColumn NumStockIn;
        private DataGridViewImageColumn EDIT;
        private DataGridViewImageColumn DeleteStockIn;
        private DataGridViewTextBoxColumn STOCK_ID;
        private DataGridViewTextBoxColumn DescStockIn;
        private DataGridViewTextBoxColumn QuantityStockIn;
        private DataGridViewTextBoxColumn EXPIRATION;
        private DataGridViewTextBoxColumn StockInDate;
        private DataGridViewTextBoxColumn StockInBy;
        private DataGridViewTextBoxColumn ITEM_ID;
        private DataGridViewTextBoxColumn TypeStockIn;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn INVENTORYID;
        private DataGridViewTextBoxColumn StockID;
        private DataGridViewTextBoxColumn Description;
        private DataGridViewTextBoxColumn QuantityHistory;
        private DataGridViewTextBoxColumn StockDate;
        private DataGridViewTextBoxColumn ExpirationHistory;
        private DataGridViewTextBoxColumn StockBy;
        private DataGridViewTextBoxColumn ItemIDHistory;
        private DataGridViewTextBoxColumn TypeHistory;
    }
}