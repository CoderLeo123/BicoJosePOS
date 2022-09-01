namespace Capstone
{
    partial class frmExpiration
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
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridViewExpDate = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExpDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Select = new System.Windows.Forms.DataGridViewImageColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewSelected = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.plus = new System.Windows.Forms.DataGridViewImageColumn();
            this.Delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblPrice = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.CONSUMABLE = new System.Windows.Forms.TabPage();
            this.panelC = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.NONCONSUMABLE = new System.Windows.Forms.TabPage();
            this.lblName2 = new System.Windows.Forms.Label();
            this.panelNC = new System.Windows.Forms.Panel();
            this.lblPrice2 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewExpDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSelected)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.CONSUMABLE.SuspendLayout();
            this.panelC.SuspendLayout();
            this.panel6.SuspendLayout();
            this.NONCONSUMABLE.SuspendLayout();
            this.panelNC.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.BackgroundImage = global::Capstone.Properties.Resources.CloseTab;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Location = new System.Drawing.Point(749, 9);
            this.btnClose.Name = "btnClose";
            this.btnClose.Padding = new System.Windows.Forms.Padding(3);
            this.btnClose.Size = new System.Drawing.Size(40, 38);
            this.btnClose.TabIndex = 0;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(801, 57);
            this.panel1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(277, 41);
            this.label1.TabIndex = 4;
            this.label1.Text = "Consumable Items";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(119, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(574, 38);
            this.label2.TabIndex = 5;
            this.label2.Text = "These are the available expiration date under";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(703, 38);
            this.label3.TabIndex = 6;
            this.label3.Text = "Choose the stock/s with the appropriate Expiration date";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.ForeColor = System.Drawing.Color.Red;
            this.lblName.Location = new System.Drawing.Point(153, 71);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(81, 38);
            this.lblName.TabIndex = 7;
            this.lblName.Text = "        ";
            this.lblName.Click += new System.EventHandler(this.lblName_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridViewExpDate);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 274);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(789, 165);
            this.panel2.TabIndex = 8;
            // 
            // dataGridViewExpDate
            // 
            this.dataGridViewExpDate.AllowUserToAddRows = false;
            this.dataGridViewExpDate.AllowUserToResizeColumns = false;
            this.dataGridViewExpDate.AllowUserToResizeRows = false;
            this.dataGridViewExpDate.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewExpDate.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewExpDate.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewExpDate.ColumnHeadersHeight = 40;
            this.dataGridViewExpDate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewExpDate.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.ExpDate,
            this.Stock,
            this.Select,
            this.ID});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewExpDate.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewExpDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewExpDate.EnableHeadersVisualStyles = false;
            this.dataGridViewExpDate.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewExpDate.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewExpDate.Name = "dataGridViewExpDate";
            this.dataGridViewExpDate.RowHeadersVisible = false;
            this.dataGridViewExpDate.RowHeadersWidth = 51;
            this.dataGridViewExpDate.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewExpDate.RowTemplate.Height = 29;
            this.dataGridViewExpDate.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewExpDate.Size = new System.Drawing.Size(789, 165);
            this.dataGridViewExpDate.TabIndex = 7;
            this.dataGridViewExpDate.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewExpDate_CellContentClick);
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
            // ExpDate
            // 
            this.ExpDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ExpDate.HeaderText = "Expiration Date";
            this.ExpDate.MinimumWidth = 6;
            this.ExpDate.Name = "ExpDate";
            this.ExpDate.ReadOnly = true;
            // 
            // Stock
            // 
            this.Stock.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Stock.HeaderText = "Available Stocks";
            this.Stock.MinimumWidth = 6;
            this.Stock.Name = "Stock";
            this.Stock.ReadOnly = true;
            // 
            // Select
            // 
            this.Select.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Select.HeaderText = "";
            this.Select.Image = global::Capstone.Properties.Resources.AddNew;
            this.Select.MinimumWidth = 6;
            this.Select.Name = "Select";
            this.Select.Width = 6;
            // 
            // ID
            // 
            this.ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.ID.HeaderText = "ItemID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.Width = 126;
            // 
            // dataGridViewSelected
            // 
            this.dataGridViewSelected.AllowUserToAddRows = false;
            this.dataGridViewSelected.AllowUserToResizeColumns = false;
            this.dataGridViewSelected.AllowUserToResizeRows = false;
            this.dataGridViewSelected.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewSelected.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewSelected.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewSelected.ColumnHeadersHeight = 40;
            this.dataGridViewSelected.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewSelected.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.Qty,
            this.Total,
            this.plus,
            this.Delete,
            this.dataGridViewTextBoxColumn4});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewSelected.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewSelected.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewSelected.EnableHeadersVisualStyles = false;
            this.dataGridViewSelected.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewSelected.Location = new System.Drawing.Point(0, 51);
            this.dataGridViewSelected.Name = "dataGridViewSelected";
            this.dataGridViewSelected.RowHeadersVisible = false;
            this.dataGridViewSelected.RowHeadersWidth = 51;
            this.dataGridViewSelected.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewSelected.RowTemplate.Height = 29;
            this.dataGridViewSelected.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewSelected.Size = new System.Drawing.Size(789, 143);
            this.dataGridViewSelected.TabIndex = 8;
            this.dataGridViewSelected.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSelected_CellContentClick);
            this.dataGridViewSelected.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSelected_CellEndEdit);
            this.dataGridViewSelected.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSelected_CellValueChanged);
            this.dataGridViewSelected.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dataGridViewSelected_RowsAdded);
            this.dataGridViewSelected.RowValidating += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dataGridViewSelected_RowValidating);
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn2.HeaderText = "#";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 61;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.HeaderText = "Expiration Date";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // Qty
            // 
            this.Qty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Qty.HeaderText = "Quantity";
            this.Qty.MaxInputLength = 3;
            this.Qty.MinimumWidth = 6;
            this.Qty.Name = "Qty";
            this.Qty.ReadOnly = true;
            // 
            // Total
            // 
            this.Total.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Total.HeaderText = "Cost";
            this.Total.MinimumWidth = 6;
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            this.Total.Width = 98;
            // 
            // plus
            // 
            this.plus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.plus.HeaderText = "";
            this.plus.Image = global::Capstone.Properties.Resources._Add;
            this.plus.MinimumWidth = 6;
            this.plus.Name = "plus";
            this.plus.Width = 6;
            // 
            // Delete
            // 
            this.Delete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Delete.HeaderText = "";
            this.Delete.Image = global::Capstone.Properties.Resources._Delete;
            this.Delete.MinimumWidth = 6;
            this.Delete.Name = "Delete";
            this.Delete.Width = 6;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewTextBoxColumn4.HeaderText = "ItemID";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Visible = false;
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel4.Controls.Add(this.label5);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(789, 51);
            this.panel4.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(11, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(223, 41);
            this.label5.TabIndex = 4;
            this.label5.Text = "Selected Items";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.LimeGreen;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(3, 6);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(153, 49);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnSave);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 633);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(789, 68);
            this.panel3.TabIndex = 9;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.ForeColor = System.Drawing.Color.Red;
            this.lblPrice.Location = new System.Drawing.Point(341, 136);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(81, 38);
            this.lblPrice.TabIndex = 11;
            this.lblPrice.Text = "        ";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.CONSUMABLE);
            this.tabControl1.Controls.Add(this.NONCONSUMABLE);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 57);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(801, 713);
            this.tabControl1.TabIndex = 12;
            // 
            // CONSUMABLE
            // 
            this.CONSUMABLE.Controls.Add(this.panelC);
            this.CONSUMABLE.Location = new System.Drawing.Point(4, 46);
            this.CONSUMABLE.Name = "CONSUMABLE";
            this.CONSUMABLE.Padding = new System.Windows.Forms.Padding(3);
            this.CONSUMABLE.Size = new System.Drawing.Size(793, 663);
            this.CONSUMABLE.TabIndex = 0;
            this.CONSUMABLE.Text = "Consumable ";
            this.CONSUMABLE.UseVisualStyleBackColor = true;
            // 
            // panelC
            // 
            this.panelC.Controls.Add(this.panel2);
            this.panelC.Controls.Add(this.panel6);
            this.panelC.Controls.Add(this.label2);
            this.panelC.Controls.Add(this.label3);
            this.panelC.Controls.Add(this.panel3);
            this.panelC.Controls.Add(this.lblPrice);
            this.panelC.Controls.Add(this.lblName);
            this.panelC.Location = new System.Drawing.Point(4, -14);
            this.panelC.Name = "panelC";
            this.panelC.Size = new System.Drawing.Size(789, 701);
            this.panelC.TabIndex = 12;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.dataGridViewSelected);
            this.panel6.Controls.Add(this.panel4);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel6.Location = new System.Drawing.Point(0, 439);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(789, 194);
            this.panel6.TabIndex = 0;
            // 
            // NONCONSUMABLE
            // 
            this.NONCONSUMABLE.Controls.Add(this.lblName2);
            this.NONCONSUMABLE.Controls.Add(this.panelNC);
            this.NONCONSUMABLE.Location = new System.Drawing.Point(4, 46);
            this.NONCONSUMABLE.Name = "NONCONSUMABLE";
            this.NONCONSUMABLE.Padding = new System.Windows.Forms.Padding(3);
            this.NONCONSUMABLE.Size = new System.Drawing.Size(793, 663);
            this.NONCONSUMABLE.TabIndex = 1;
            this.NONCONSUMABLE.Text = "Non-Consumable";
            this.NONCONSUMABLE.UseVisualStyleBackColor = true;
            // 
            // lblName2
            // 
            this.lblName2.AutoSize = true;
            this.lblName2.ForeColor = System.Drawing.Color.Red;
            this.lblName2.Location = new System.Drawing.Point(142, 81);
            this.lblName2.Name = "lblName2";
            this.lblName2.Size = new System.Drawing.Size(81, 38);
            this.lblName2.TabIndex = 8;
            this.lblName2.Text = "        ";
            // 
            // panelNC
            // 
            this.panelNC.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelNC.Controls.Add(this.lblPrice2);
            this.panelNC.Controls.Add(this.lblTotal);
            this.panelNC.Controls.Add(this.label6);
            this.panelNC.Controls.Add(this.label7);
            this.panelNC.Controls.Add(this.txtQuantity);
            this.panelNC.Location = new System.Drawing.Point(117, 152);
            this.panelNC.Name = "panelNC";
            this.panelNC.Size = new System.Drawing.Size(538, 357);
            this.panelNC.TabIndex = 0;
            // 
            // lblPrice2
            // 
            this.lblPrice2.AutoSize = true;
            this.lblPrice2.Font = new System.Drawing.Font("Segoe UI", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPrice2.ForeColor = System.Drawing.Color.Red;
            this.lblPrice2.Location = new System.Drawing.Point(347, 200);
            this.lblPrice2.Name = "lblPrice2";
            this.lblPrice2.Size = new System.Drawing.Size(78, 62);
            this.lblPrice2.TabIndex = 43;
            this.lblPrice2.Text = "  0";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTotal.Location = new System.Drawing.Point(308, 262);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(99, 81);
            this.lblTotal.TabIndex = 42;
            this.lblTotal.Text = "  0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(86, 277);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(141, 62);
            this.label6.TabIndex = 41;
            this.label6.Text = "Total:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(62, 200);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(243, 62);
            this.label7.TabIndex = 40;
            this.label7.Text = "Unit Price:";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Font = new System.Drawing.Font("Segoe UI", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtQuantity.Location = new System.Drawing.Point(86, 18);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(377, 167);
            this.txtQuantity.TabIndex = 39;
            this.txtQuantity.Text = "0";
            this.txtQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtQuantity.TextChanged += new System.EventHandler(this.txtQuantity_TextChanged);
            this.txtQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQuantity_KeyPress);
            // 
            // frmExpiration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 770);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmExpiration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewExpDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSelected)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.CONSUMABLE.ResumeLayout(false);
            this.panelC.ResumeLayout(false);
            this.panelC.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.NONCONSUMABLE.ResumeLayout(false);
            this.NONCONSUMABLE.PerformLayout();
            this.panelNC.ResumeLayout(false);
            this.panelNC.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox btnClose;
        private Panel panel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Label label5;
        public Label lblName;
        public DataGridView dataGridViewExpDate;
        public DataGridView dataGridViewSelected;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn ExpDate;
        private DataGridViewTextBoxColumn Stock;
        private DataGridViewImageColumn Select;
        private DataGridViewTextBoxColumn ID;
        public Button btnSave;
        public Label lblPrice;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn Qty;
        private DataGridViewTextBoxColumn Total;
        private DataGridViewImageColumn plus;
        private DataGridViewImageColumn Delete;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private Panel panel6;
        public Label lblName2;
        public Label lblPrice2;
        public Label lblTotal;
        private Label label6;
        private Label label7;
        public TextBox txtQuantity;
        public TabControl tabControl1;
        public TabPage CONSUMABLE;
        public TabPage NONCONSUMABLE;
        public Panel panelC;
        public Panel panelNC;
    }
}