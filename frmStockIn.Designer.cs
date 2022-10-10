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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControlStockIn = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.btnSaveStockIn = new System.Windows.Forms.Button();
            this.btnClearStock = new System.Windows.Forms.Button();
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
            this.individualID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblCheck = new System.Windows.Forms.Label();
            this.ClickSearchItem = new System.Windows.Forms.LinkLabel();
            this.GenerateStockID = new System.Windows.Forms.LinkLabel();
            this.dateStockIn = new System.Windows.Forms.DateTimePicker();
            this.txtStockInBy = new System.Windows.Forms.TextBox();
            this.txtStockID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panelStockOnHand = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.dataGridViewOnHand = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Classification = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.tabControlStockIn.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStockItems)).BeginInit();
            this.panel2.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panelStockOnHand.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOnHand)).BeginInit();
            this.panel6.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1315, 57);
            this.panel1.TabIndex = 3;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.btnClose);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel7.Location = new System.Drawing.Point(1258, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(57, 57);
            this.panel7.TabIndex = 5;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.BackgroundImage = global::Capstone.Properties.Resources.CloseTab;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Location = new System.Drawing.Point(5, 13);
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
            this.label1.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 45);
            this.label1.TabIndex = 4;
            this.label1.Text = "Stock In";
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
            this.panel3.Controls.Add(this.panel8);
            this.panel3.Controls.Add(this.dataGridViewStockItems);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 206);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1301, 614);
            this.panel3.TabIndex = 1;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.btnSaveStockIn);
            this.panel8.Controls.Add(this.btnClearStock);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel8.Location = new System.Drawing.Point(0, 550);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(314, 64);
            this.panel8.TabIndex = 25;
            // 
            // btnSaveStockIn
            // 
            this.btnSaveStockIn.BackColor = System.Drawing.Color.LimeGreen;
            this.btnSaveStockIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveStockIn.FlatAppearance.BorderSize = 0;
            this.btnSaveStockIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveStockIn.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSaveStockIn.ForeColor = System.Drawing.Color.White;
            this.btnSaveStockIn.Location = new System.Drawing.Point(9, 6);
            this.btnSaveStockIn.Name = "btnSaveStockIn";
            this.btnSaveStockIn.Size = new System.Drawing.Size(140, 49);
            this.btnSaveStockIn.TabIndex = 23;
            this.btnSaveStockIn.Text = "Save";
            this.btnSaveStockIn.UseVisualStyleBackColor = false;
            this.btnSaveStockIn.Click += new System.EventHandler(this.btnSaveStockIn_Click);
            // 
            // btnClearStock
            // 
            this.btnClearStock.BackColor = System.Drawing.Color.Red;
            this.btnClearStock.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClearStock.FlatAppearance.BorderSize = 0;
            this.btnClearStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearStock.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnClearStock.ForeColor = System.Drawing.Color.White;
            this.btnClearStock.Location = new System.Drawing.Point(155, 6);
            this.btnClearStock.Name = "btnClearStock";
            this.btnClearStock.Size = new System.Drawing.Size(140, 49);
            this.btnClearStock.TabIndex = 24;
            this.btnClearStock.Text = "Clear";
            this.btnClearStock.UseVisualStyleBackColor = false;
            this.btnClearStock.Click += new System.EventHandler(this.btnClearStock_Click);
            // 
            // dataGridViewStockItems
            // 
            this.dataGridViewStockItems.AllowUserToAddRows = false;
            this.dataGridViewStockItems.AllowUserToResizeColumns = false;
            this.dataGridViewStockItems.AllowUserToResizeRows = false;
            this.dataGridViewStockItems.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewStockItems.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewStockItems.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
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
            this.Column1,
            this.individualID});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewStockItems.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewStockItems.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridViewStockItems.EnableHeadersVisualStyles = false;
            this.dataGridViewStockItems.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewStockItems.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewStockItems.Name = "dataGridViewStockItems";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewStockItems.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
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
            this.NumStockIn.Frozen = true;
            this.NumStockIn.HeaderText = "#";
            this.NumStockIn.MinimumWidth = 6;
            this.NumStockIn.Name = "NumStockIn";
            this.NumStockIn.ReadOnly = true;
            this.NumStockIn.Width = 55;
            // 
            // EDIT
            // 
            this.EDIT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.EDIT.Frozen = true;
            this.EDIT.HeaderText = "";
            this.EDIT.Image = global::Capstone.Properties.Resources.Edit;
            this.EDIT.MinimumWidth = 6;
            this.EDIT.Name = "EDIT";
            this.EDIT.Width = 6;
            // 
            // DeleteStockIn
            // 
            this.DeleteStockIn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.DeleteStockIn.Frozen = true;
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
            this.STOCK_ID.Visible = false;
            this.STOCK_ID.Width = 125;
            // 
            // DescStockIn
            // 
            this.DescStockIn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DescStockIn.HeaderText = "DESCRIPTION";
            this.DescStockIn.MinimumWidth = 6;
            this.DescStockIn.Name = "DescStockIn";
            this.DescStockIn.ReadOnly = true;
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
            this.EXPIRATION.MaxInputLength = 7;
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
            this.ITEM_ID.Visible = false;
            this.ITEM_ID.Width = 125;
            // 
            // TypeStockIn
            // 
            this.TypeStockIn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TypeStockIn.HeaderText = "TYPE";
            this.TypeStockIn.MinimumWidth = 6;
            this.TypeStockIn.Name = "TypeStockIn";
            this.TypeStockIn.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.HeaderText = "";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Visible = false;
            // 
            // individualID
            // 
            this.individualID.HeaderText = "num";
            this.individualID.MinimumWidth = 6;
            this.individualID.Name = "individualID";
            this.individualID.ReadOnly = true;
            this.individualID.Visible = false;
            this.individualID.Width = 125;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.lblCheck);
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
            this.panel2.Size = new System.Drawing.Size(1301, 203);
            this.panel2.TabIndex = 0;
            // 
            // lblCheck
            // 
            this.lblCheck.AutoSize = true;
            this.lblCheck.Location = new System.Drawing.Point(54, 150);
            this.lblCheck.Name = "lblCheck";
            this.lblCheck.Size = new System.Drawing.Size(81, 38);
            this.lblCheck.TabIndex = 10;
            this.lblCheck.Text = "        ";
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
            this.txtStockInBy.Enabled = false;
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
            this.tabPage2.Controls.Add(this.panelStockOnHand);
            this.tabPage2.Location = new System.Drawing.Point(4, 46);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1307, 823);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Stock On Hand";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panelStockOnHand
            // 
            this.panelStockOnHand.Controls.Add(this.panel5);
            this.panelStockOnHand.Controls.Add(this.panel6);
            this.panelStockOnHand.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelStockOnHand.Location = new System.Drawing.Point(3, 3);
            this.panelStockOnHand.Name = "panelStockOnHand";
            this.panelStockOnHand.Size = new System.Drawing.Size(1301, 817);
            this.panelStockOnHand.TabIndex = 6;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.dataGridViewOnHand);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 79);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1301, 738);
            this.panel5.TabIndex = 1;
            // 
            // dataGridViewOnHand
            // 
            this.dataGridViewOnHand.AllowUserToAddRows = false;
            this.dataGridViewOnHand.AllowUserToResizeColumns = false;
            this.dataGridViewOnHand.AllowUserToResizeRows = false;
            this.dataGridViewOnHand.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewOnHand.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewOnHand.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewOnHand.ColumnHeadersHeight = 40;
            this.dataGridViewOnHand.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewOnHand.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn10,
            this.Classification});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewOnHand.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewOnHand.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewOnHand.EnableHeadersVisualStyles = false;
            this.dataGridViewOnHand.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewOnHand.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewOnHand.Name = "dataGridViewOnHand";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewOnHand.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewOnHand.RowHeadersVisible = false;
            this.dataGridViewOnHand.RowHeadersWidth = 51;
            this.dataGridViewOnHand.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewOnHand.RowTemplate.Height = 35;
            this.dataGridViewOnHand.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewOnHand.Size = new System.Drawing.Size(1301, 738);
            this.dataGridViewOnHand.TabIndex = 5;
            this.dataGridViewOnHand.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewOnHand_CellClick);
            this.dataGridViewOnHand.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewOnHand_CellContentClick);
            this.dataGridViewOnHand.SelectionChanged += new System.EventHandler(this.dataGridViewOnHand_SelectionChanged);
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn2.Frozen = true;
            this.dataGridViewTextBoxColumn2.HeaderText = "#";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 61;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn9.HeaderText = "ITEM ID";
            this.dataGridViewTextBoxColumn9.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Visible = false;
            this.dataGridViewTextBoxColumn9.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn4.HeaderText = "ITEM DESCRIPTION";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn5.HeaderText = "STOCK ON HAND";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 264;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn10.HeaderText = "TYPE";
            this.dataGridViewTextBoxColumn10.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            this.dataGridViewTextBoxColumn10.Width = 105;
            // 
            // Classification
            // 
            this.Classification.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Classification.HeaderText = "CLASSIFICATION";
            this.Classification.MaxInputLength = 7;
            this.Classification.MinimumWidth = 6;
            this.Classification.Name = "Classification";
            this.Classification.ReadOnly = true;
            this.Classification.Width = 248;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.panel4);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1301, 79);
            this.panel6.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DimGray;
            this.panel4.Controls.Add(this.txtSearch);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1301, 79);
            this.panel4.TabIndex = 1;
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSearch.Location = new System.Drawing.Point(16, 22);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PlaceholderText = "Search Here";
            this.txtSearch.Size = new System.Drawing.Size(717, 43);
            this.txtSearch.TabIndex = 23;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
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
            this.panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.tabControlStockIn.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStockItems)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.panelStockOnHand.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOnHand)).EndInit();
            this.panel6.ResumeLayout(false);
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
        private Panel panel3;
        private LinkLabel ClickSearchItem;
        private Panel panel4;
        public DateTimePicker dateStockIn;
        public TextBox txtStockInBy;
        public TextBox txtStockID;
        public Button btnSaveStockIn;
        public LinkLabel GenerateStockID;
        public DataGridView dataGridViewStockItems;
        private TextBox txtSearch;
        public Label lblCheck;
        public DataGridView dataGridViewOnHand;
        private Panel panelStockOnHand;
        private Panel panel5;
        private Panel panel6;
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
        private DataGridViewTextBoxColumn individualID;
        public Label label3;
        private Panel panel7;
        private Panel panel8;
        public Button btnClearStock;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private DataGridViewTextBoxColumn Classification;
    }
}