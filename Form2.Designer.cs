namespace Capstone
{
    partial class frmItemsList
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnAddAccessories = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridViewItems = new System.Windows.Forms.DataGridView();
            this.NumItems = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescriptionItems = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TypeItems = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductItems = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PriceItems = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Classification = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EditItems = new System.Windows.Forms.DataGridViewImageColumn();
            this.DeleteItems = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGridViewService = new System.Windows.Forms.DataGridView();
            this.NumService = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ServiceID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescriptionService = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PriceService = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EditService = new System.Windows.Forms.DataGridViewImageColumn();
            this.DeleteService = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.txtSearchService = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAddService = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewItems)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewService)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddService)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1315, 116);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint_1);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DimGray;
            this.panel2.Controls.Add(this.txtSearch);
            this.panel2.Controls.Add(this.btnAddAccessories);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 53);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1315, 63);
            this.panel2.TabIndex = 36;
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSearch.Location = new System.Drawing.Point(12, 14);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PlaceholderText = "Search Here";
            this.txtSearch.Size = new System.Drawing.Size(534, 38);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // btnAddAccessories
            // 
            this.btnAddAccessories.BackColor = System.Drawing.Color.LimeGreen;
            this.btnAddAccessories.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddAccessories.FlatAppearance.BorderSize = 0;
            this.btnAddAccessories.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddAccessories.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddAccessories.ForeColor = System.Drawing.Color.White;
            this.btnAddAccessories.Location = new System.Drawing.Point(1152, 8);
            this.btnAddAccessories.Name = "btnAddAccessories";
            this.btnAddAccessories.Size = new System.Drawing.Size(153, 49);
            this.btnAddAccessories.TabIndex = 21;
            this.btnAddAccessories.Text = "Add Item";
            this.btnAddAccessories.UseVisualStyleBackColor = false;
            this.btnAddAccessories.Click += new System.EventHandler(this.btnAddAccessories_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 41);
            this.label1.TabIndex = 4;
            this.label1.Text = "Items List";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::Capstone.Properties.Resources.CloseTab;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Location = new System.Drawing.Point(1259, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Padding = new System.Windows.Forms.Padding(3);
            this.pictureBox1.Size = new System.Drawing.Size(40, 38);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // dataGridViewItems
            // 
            this.dataGridViewItems.AllowUserToAddRows = false;
            this.dataGridViewItems.AllowUserToResizeColumns = false;
            this.dataGridViewItems.AllowUserToResizeRows = false;
            this.dataGridViewItems.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewItems.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewItems.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewItems.ColumnHeadersHeight = 40;
            this.dataGridViewItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NumItems,
            this.ItemID,
            this.DescriptionItems,
            this.TypeItems,
            this.ProductItems,
            this.PriceItems,
            this.Quantity,
            this.Classification,
            this.Type_ID,
            this.EditItems,
            this.DeleteItems});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewItems.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewItems.EnableHeadersVisualStyles = false;
            this.dataGridViewItems.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewItems.Location = new System.Drawing.Point(0, 116);
            this.dataGridViewItems.Name = "dataGridViewItems";
            this.dataGridViewItems.RowHeadersVisible = false;
            this.dataGridViewItems.RowHeadersWidth = 51;
            this.dataGridViewItems.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewItems.RowTemplate.Height = 29;
            this.dataGridViewItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewItems.Size = new System.Drawing.Size(1315, 814);
            this.dataGridViewItems.TabIndex = 2;
            this.dataGridViewItems.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // NumItems
            // 
            this.NumItems.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.NumItems.Frozen = true;
            this.NumItems.HeaderText = "#";
            this.NumItems.MinimumWidth = 6;
            this.NumItems.Name = "NumItems";
            this.NumItems.ReadOnly = true;
            this.NumItems.Width = 51;
            // 
            // ItemID
            // 
            this.ItemID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ItemID.Frozen = true;
            this.ItemID.HeaderText = "ITEM ID";
            this.ItemID.MinimumWidth = 6;
            this.ItemID.Name = "ItemID";
            this.ItemID.ReadOnly = true;
            this.ItemID.Width = 114;
            // 
            // DescriptionItems
            // 
            this.DescriptionItems.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.DescriptionItems.HeaderText = "DESCRIPTION";
            this.DescriptionItems.MinimumWidth = 6;
            this.DescriptionItems.Name = "DescriptionItems";
            this.DescriptionItems.ReadOnly = true;
            this.DescriptionItems.Width = 168;
            // 
            // TypeItems
            // 
            this.TypeItems.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TypeItems.HeaderText = "TYPE";
            this.TypeItems.MinimumWidth = 6;
            this.TypeItems.Name = "TypeItems";
            this.TypeItems.ReadOnly = true;
            // 
            // ProductItems
            // 
            this.ProductItems.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ProductItems.HeaderText = "PRODUCT";
            this.ProductItems.MinimumWidth = 6;
            this.ProductItems.Name = "ProductItems";
            this.ProductItems.ReadOnly = true;
            this.ProductItems.Width = 132;
            // 
            // PriceItems
            // 
            this.PriceItems.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.PriceItems.HeaderText = "PRICE";
            this.PriceItems.MinimumWidth = 6;
            this.PriceItems.Name = "PriceItems";
            this.PriceItems.ReadOnly = true;
            this.PriceItems.Width = 93;
            // 
            // Quantity
            // 
            this.Quantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Quantity.HeaderText = "QUANTITY";
            this.Quantity.MinimumWidth = 6;
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            this.Quantity.Width = 140;
            // 
            // Classification
            // 
            this.Classification.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Classification.HeaderText = "CLASSIFICATION";
            this.Classification.MinimumWidth = 6;
            this.Classification.Name = "Classification";
            this.Classification.ReadOnly = true;
            this.Classification.Width = 193;
            // 
            // Type_ID
            // 
            this.Type_ID.HeaderText = "TYPE ID";
            this.Type_ID.MinimumWidth = 6;
            this.Type_ID.Name = "Type_ID";
            this.Type_ID.ReadOnly = true;
            this.Type_ID.Visible = false;
            this.Type_ID.Width = 125;
            // 
            // EditItems
            // 
            this.EditItems.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.EditItems.HeaderText = "";
            this.EditItems.Image = global::Capstone.Properties.Resources.Edit;
            this.EditItems.MinimumWidth = 6;
            this.EditItems.Name = "EditItems";
            this.EditItems.Width = 6;
            // 
            // DeleteItems
            // 
            this.DeleteItems.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.DeleteItems.HeaderText = "";
            this.DeleteItems.Image = global::Capstone.Properties.Resources._Delete;
            this.DeleteItems.MinimumWidth = 6;
            this.DeleteItems.Name = "DeleteItems";
            this.DeleteItems.Width = 6;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dataGridViewService);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 603);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1315, 327);
            this.panel3.TabIndex = 3;
            // 
            // dataGridViewService
            // 
            this.dataGridViewService.AllowUserToAddRows = false;
            this.dataGridViewService.AllowUserToResizeColumns = false;
            this.dataGridViewService.AllowUserToResizeRows = false;
            this.dataGridViewService.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewService.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewService.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewService.ColumnHeadersHeight = 40;
            this.dataGridViewService.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewService.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NumService,
            this.ServiceID,
            this.NAME,
            this.DescriptionService,
            this.PriceService,
            this.EditService,
            this.DeleteService});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewService.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewService.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewService.EnableHeadersVisualStyles = false;
            this.dataGridViewService.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewService.Location = new System.Drawing.Point(0, 115);
            this.dataGridViewService.Name = "dataGridViewService";
            this.dataGridViewService.RowHeadersVisible = false;
            this.dataGridViewService.RowHeadersWidth = 51;
            this.dataGridViewService.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewService.RowTemplate.Height = 29;
            this.dataGridViewService.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewService.Size = new System.Drawing.Size(1315, 212);
            this.dataGridViewService.TabIndex = 6;
            this.dataGridViewService.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewService_CellContentClick);
            // 
            // NumService
            // 
            this.NumService.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.NumService.HeaderText = "#";
            this.NumService.MinimumWidth = 6;
            this.NumService.Name = "NumService";
            this.NumService.ReadOnly = true;
            this.NumService.Width = 51;
            // 
            // ServiceID
            // 
            this.ServiceID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.ServiceID.HeaderText = "SERVICE ID";
            this.ServiceID.MinimumWidth = 6;
            this.ServiceID.Name = "ServiceID";
            this.ServiceID.ReadOnly = true;
            this.ServiceID.Width = 143;
            // 
            // NAME
            // 
            this.NAME.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NAME.HeaderText = "NAME";
            this.NAME.MinimumWidth = 6;
            this.NAME.Name = "NAME";
            this.NAME.ReadOnly = true;
            // 
            // DescriptionService
            // 
            this.DescriptionService.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DescriptionService.HeaderText = "DESCRIPTION";
            this.DescriptionService.MinimumWidth = 6;
            this.DescriptionService.Name = "DescriptionService";
            this.DescriptionService.ReadOnly = true;
            // 
            // PriceService
            // 
            this.PriceService.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.PriceService.HeaderText = "PRICE";
            this.PriceService.MinimumWidth = 6;
            this.PriceService.Name = "PriceService";
            this.PriceService.ReadOnly = true;
            this.PriceService.Width = 93;
            // 
            // EditService
            // 
            this.EditService.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.EditService.HeaderText = "";
            this.EditService.Image = global::Capstone.Properties.Resources.Edit;
            this.EditService.MinimumWidth = 6;
            this.EditService.Name = "EditService";
            this.EditService.Width = 6;
            // 
            // DeleteService
            // 
            this.DeleteService.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.DeleteService.HeaderText = "";
            this.DeleteService.Image = global::Capstone.Properties.Resources._Delete;
            this.DeleteService.MinimumWidth = 6;
            this.DeleteService.Name = "DeleteService";
            this.DeleteService.Width = 6;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel4.Controls.Add(this.panel8);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.btnAddService);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1315, 115);
            this.panel4.TabIndex = 7;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.DimGray;
            this.panel8.Controls.Add(this.txtSearchService);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel8.Location = new System.Drawing.Point(0, 61);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(1315, 54);
            this.panel8.TabIndex = 36;
            // 
            // txtSearchService
            // 
            this.txtSearchService.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSearchService.Location = new System.Drawing.Point(692, 9);
            this.txtSearchService.Name = "txtSearchService";
            this.txtSearchService.PlaceholderText = "Search Here";
            this.txtSearchService.Size = new System.Drawing.Size(599, 38);
            this.txtSearchService.TabIndex = 0;
            this.txtSearchService.TextChanged += new System.EventHandler(this.txtSearchService_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 41);
            this.label2.TabIndex = 4;
            this.label2.Text = "Services List";
            // 
            // btnAddService
            // 
            this.btnAddService.BackColor = System.Drawing.Color.Transparent;
            this.btnAddService.BackgroundImage = global::Capstone.Properties.Resources.AddNew;
            this.btnAddService.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddService.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddService.Location = new System.Drawing.Point(1260, 9);
            this.btnAddService.Name = "btnAddService";
            this.btnAddService.Size = new System.Drawing.Size(39, 38);
            this.btnAddService.TabIndex = 3;
            this.btnAddService.TabStop = false;
            this.btnAddService.Click += new System.EventHandler(this.btnAddService_Click);
            // 
            // frmItemsList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1315, 930);
            this.ControlBox = false;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.dataGridViewItems);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmItemsList";
            this.Text = "Form2";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewItems)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewService)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddService)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private DataGridView dataGridViewItems;
        private Label label1;
        private PictureBox pictureBox1;
        private Button btnAddAccessories;
        private Panel panel2;
        private TextBox txtSearch;
        private Panel panel3;
        private DataGridView dataGridViewService;
        private DataGridViewTextBoxColumn NumService;
        private DataGridViewTextBoxColumn ServiceID;
        private DataGridViewTextBoxColumn NAME;
        private DataGridViewTextBoxColumn DescriptionService;
        private DataGridViewTextBoxColumn PriceService;
        private DataGridViewImageColumn EditService;
        private DataGridViewImageColumn DeleteService;
        private Panel panel4;
        private Panel panel8;
        public TextBox txtSearchService;
        private Label label2;
        private PictureBox btnAddService;
        private DataGridViewTextBoxColumn NumItems;
        private DataGridViewTextBoxColumn ItemID;
        private DataGridViewTextBoxColumn DescriptionItems;
        private DataGridViewTextBoxColumn TypeItems;
        private DataGridViewTextBoxColumn ProductItems;
        private DataGridViewTextBoxColumn PriceItems;
        private DataGridViewTextBoxColumn Quantity;
        private DataGridViewTextBoxColumn Classification;
        private DataGridViewTextBoxColumn Type_ID;
        private DataGridViewImageColumn EditItems;
        private DataGridViewImageColumn DeleteItems;
    }
}