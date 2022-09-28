﻿namespace Capstone
{
    partial class frmEditStock
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
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.dateExpiration = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.btnPerishable = new System.Windows.Forms.Button();
            this.btnNonPerishable = new System.Windows.Forms.Button();
            this.lblCheck = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.comBoxUnit = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControlStock = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panelEditStock = new System.Windows.Forms.Panel();
            this.btnDeleteUnit = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panelAddUnit = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSaveUnit = new System.Windows.Forms.Button();
            this.txtUnit = new System.Windows.Forms.TextBox();
            this.btnCancelUnit = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.panelStockDetail = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.dataGridViewDetails = new System.Windows.Forms.DataGridView();
            this.NumService = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeliveryDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Expiration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StockBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StockID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel4 = new System.Windows.Forms.Panel();
            this.labelItemID = new System.Windows.Forms.Label();
            this.labelItemName = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.tabControlStock.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panelEditStock.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panelAddUnit.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.panelStockDetail.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDetails)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(726, 57);
            this.panel1.TabIndex = 33;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.btnClose);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel6.Location = new System.Drawing.Point(665, 0);
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
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // txtQuantity
            // 
            this.txtQuantity.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtQuantity.Location = new System.Drawing.Point(249, 174);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.PlaceholderText = "0";
            this.txtQuantity.Size = new System.Drawing.Size(199, 38);
            this.txtQuantity.TabIndex = 42;
            this.txtQuantity.TextChanged += new System.EventHandler(this.txtQuantity_TextChanged);
            this.txtQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQuantity_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(32, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 41);
            this.label4.TabIndex = 41;
            this.label4.Text = "Quantity";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Red;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(407, 295);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(153, 49);
            this.btnCancel.TabIndex = 38;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.SteelBlue;
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(248, 295);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(153, 49);
            this.btnUpdate.TabIndex = 37;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // dateExpiration
            // 
            this.dateExpiration.Location = new System.Drawing.Point(249, 45);
            this.dateExpiration.Name = "dateExpiration";
            this.dateExpiration.Size = new System.Drawing.Size(423, 43);
            this.dateExpiration.TabIndex = 44;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(205, 38);
            this.label6.TabIndex = 43;
            this.label6.Text = "Expiration Date";
            // 
            // btnPerishable
            // 
            this.btnPerishable.BackColor = System.Drawing.Color.LimeGreen;
            this.btnPerishable.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPerishable.FlatAppearance.BorderSize = 0;
            this.btnPerishable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPerishable.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPerishable.ForeColor = System.Drawing.Color.White;
            this.btnPerishable.Location = new System.Drawing.Point(249, 105);
            this.btnPerishable.Name = "btnPerishable";
            this.btnPerishable.Size = new System.Drawing.Size(153, 49);
            this.btnPerishable.TabIndex = 45;
            this.btnPerishable.Text = "Perishable";
            this.btnPerishable.UseVisualStyleBackColor = false;
            this.btnPerishable.Click += new System.EventHandler(this.btnPerishable_Click);
            // 
            // btnNonPerishable
            // 
            this.btnNonPerishable.BackColor = System.Drawing.Color.LimeGreen;
            this.btnNonPerishable.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNonPerishable.FlatAppearance.BorderSize = 0;
            this.btnNonPerishable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNonPerishable.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnNonPerishable.ForeColor = System.Drawing.Color.White;
            this.btnNonPerishable.Location = new System.Drawing.Point(420, 105);
            this.btnNonPerishable.Name = "btnNonPerishable";
            this.btnNonPerishable.Size = new System.Drawing.Size(202, 49);
            this.btnNonPerishable.TabIndex = 46;
            this.btnNonPerishable.Text = "Non-Perishable";
            this.btnNonPerishable.UseVisualStyleBackColor = false;
            this.btnNonPerishable.Click += new System.EventHandler(this.btnNonPerishable_Click);
            // 
            // lblCheck
            // 
            this.lblCheck.AutoSize = true;
            this.lblCheck.Location = new System.Drawing.Point(32, 109);
            this.lblCheck.Name = "lblCheck";
            this.lblCheck.Size = new System.Drawing.Size(81, 38);
            this.lblCheck.TabIndex = 47;
            this.lblCheck.Text = "        ";
            this.lblCheck.Visible = false;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(32, 231);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(81, 38);
            this.lblID.TabIndex = 48;
            this.lblID.Text = "        ";
            this.lblID.Visible = false;
            // 
            // comBoxUnit
            // 
            this.comBoxUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comBoxUnit.FormattingEnabled = true;
            this.comBoxUnit.Location = new System.Drawing.Point(249, 228);
            this.comBoxUnit.Name = "comBoxUnit";
            this.comBoxUnit.Size = new System.Drawing.Size(199, 45);
            this.comBoxUnit.TabIndex = 49;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(32, 232);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(195, 41);
            this.label2.TabIndex = 50;
            this.label2.Text = "Unit Measure";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LimeGreen;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(469, 227);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(153, 49);
            this.button1.TabIndex = 51;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabControlStock
            // 
            this.tabControlStock.Controls.Add(this.tabPage1);
            this.tabControlStock.Controls.Add(this.tabPage2);
            this.tabControlStock.Controls.Add(this.tabPage3);
            this.tabControlStock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlStock.Location = new System.Drawing.Point(0, 57);
            this.tabControlStock.Name = "tabControlStock";
            this.tabControlStock.SelectedIndex = 0;
            this.tabControlStock.Size = new System.Drawing.Size(726, 439);
            this.tabControlStock.TabIndex = 52;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panelEditStock);
            this.tabPage1.Location = new System.Drawing.Point(4, 46);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(718, 389);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Edit Stocks";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panelEditStock
            // 
            this.panelEditStock.Controls.Add(this.btnDeleteUnit);
            this.panelEditStock.Controls.Add(this.dateExpiration);
            this.panelEditStock.Controls.Add(this.button1);
            this.panelEditStock.Controls.Add(this.btnUpdate);
            this.panelEditStock.Controls.Add(this.label2);
            this.panelEditStock.Controls.Add(this.btnCancel);
            this.panelEditStock.Controls.Add(this.comBoxUnit);
            this.panelEditStock.Controls.Add(this.label4);
            this.panelEditStock.Controls.Add(this.lblID);
            this.panelEditStock.Controls.Add(this.txtQuantity);
            this.panelEditStock.Controls.Add(this.lblCheck);
            this.panelEditStock.Controls.Add(this.label6);
            this.panelEditStock.Controls.Add(this.btnNonPerishable);
            this.panelEditStock.Controls.Add(this.btnPerishable);
            this.panelEditStock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEditStock.Location = new System.Drawing.Point(3, 3);
            this.panelEditStock.Name = "panelEditStock";
            this.panelEditStock.Size = new System.Drawing.Size(712, 383);
            this.panelEditStock.TabIndex = 0;
            // 
            // btnDeleteUnit
            // 
            this.btnDeleteUnit.BackColor = System.Drawing.Color.Red;
            this.btnDeleteUnit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteUnit.FlatAppearance.BorderSize = 0;
            this.btnDeleteUnit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteUnit.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDeleteUnit.ForeColor = System.Drawing.Color.White;
            this.btnDeleteUnit.Location = new System.Drawing.Point(628, 227);
            this.btnDeleteUnit.Name = "btnDeleteUnit";
            this.btnDeleteUnit.Size = new System.Drawing.Size(64, 49);
            this.btnDeleteUnit.TabIndex = 54;
            this.btnDeleteUnit.Text = "Del";
            this.btnDeleteUnit.UseVisualStyleBackColor = false;
            this.btnDeleteUnit.Click += new System.EventHandler(this.btnDeleteUnit_Click_1);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panelAddUnit);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(718, 406);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Add";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panelAddUnit
            // 
            this.panelAddUnit.Controls.Add(this.label3);
            this.panelAddUnit.Controls.Add(this.btnSaveUnit);
            this.panelAddUnit.Controls.Add(this.txtUnit);
            this.panelAddUnit.Controls.Add(this.btnCancelUnit);
            this.panelAddUnit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelAddUnit.Location = new System.Drawing.Point(3, 3);
            this.panelAddUnit.Name = "panelAddUnit";
            this.panelAddUnit.Size = new System.Drawing.Size(712, 400);
            this.panelAddUnit.TabIndex = 56;
            this.panelAddUnit.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(89, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(195, 41);
            this.label3.TabIndex = 51;
            this.label3.Text = "Unit Measure";
            // 
            // btnSaveUnit
            // 
            this.btnSaveUnit.BackColor = System.Drawing.Color.LimeGreen;
            this.btnSaveUnit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveUnit.FlatAppearance.BorderSize = 0;
            this.btnSaveUnit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveUnit.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSaveUnit.ForeColor = System.Drawing.Color.White;
            this.btnSaveUnit.Location = new System.Drawing.Point(226, 173);
            this.btnSaveUnit.Name = "btnSaveUnit";
            this.btnSaveUnit.Size = new System.Drawing.Size(153, 49);
            this.btnSaveUnit.TabIndex = 55;
            this.btnSaveUnit.Text = "Save";
            this.btnSaveUnit.UseVisualStyleBackColor = false;
            this.btnSaveUnit.Click += new System.EventHandler(this.btnSaveUnit_Click);
            // 
            // txtUnit
            // 
            this.txtUnit.Location = new System.Drawing.Point(314, 110);
            this.txtUnit.Name = "txtUnit";
            this.txtUnit.Size = new System.Drawing.Size(224, 43);
            this.txtUnit.TabIndex = 52;
            // 
            // btnCancelUnit
            // 
            this.btnCancelUnit.BackColor = System.Drawing.Color.Red;
            this.btnCancelUnit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelUnit.FlatAppearance.BorderSize = 0;
            this.btnCancelUnit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelUnit.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCancelUnit.ForeColor = System.Drawing.Color.White;
            this.btnCancelUnit.Location = new System.Drawing.Point(385, 173);
            this.btnCancelUnit.Name = "btnCancelUnit";
            this.btnCancelUnit.Size = new System.Drawing.Size(153, 49);
            this.btnCancelUnit.TabIndex = 54;
            this.btnCancelUnit.Text = "Cancel";
            this.btnCancelUnit.UseVisualStyleBackColor = false;
            this.btnCancelUnit.Click += new System.EventHandler(this.btnCancelUnit_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.panelStockDetail);
            this.tabPage3.Location = new System.Drawing.Point(4, 46);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(718, 389);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Stock Details";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // panelStockDetail
            // 
            this.panelStockDetail.Controls.Add(this.panel5);
            this.panelStockDetail.Controls.Add(this.panel4);
            this.panelStockDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelStockDetail.Location = new System.Drawing.Point(0, 0);
            this.panelStockDetail.Name = "panelStockDetail";
            this.panelStockDetail.Size = new System.Drawing.Size(718, 389);
            this.panelStockDetail.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.dataGridViewDetails);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 64);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(718, 325);
            this.panel5.TabIndex = 8;
            // 
            // dataGridViewDetails
            // 
            this.dataGridViewDetails.AllowUserToAddRows = false;
            this.dataGridViewDetails.AllowUserToResizeColumns = false;
            this.dataGridViewDetails.AllowUserToResizeRows = false;
            this.dataGridViewDetails.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewDetails.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewDetails.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewDetails.ColumnHeadersHeight = 40;
            this.dataGridViewDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NumService,
            this.DeliveryDate,
            this.Qty,
            this.Expiration,
            this.StockBy,
            this.StockID});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewDetails.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewDetails.EnableHeadersVisualStyles = false;
            this.dataGridViewDetails.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewDetails.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewDetails.Name = "dataGridViewDetails";
            this.dataGridViewDetails.RowHeadersVisible = false;
            this.dataGridViewDetails.RowHeadersWidth = 51;
            this.dataGridViewDetails.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewDetails.RowTemplate.Height = 29;
            this.dataGridViewDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewDetails.Size = new System.Drawing.Size(718, 325);
            this.dataGridViewDetails.TabIndex = 6;
            this.dataGridViewDetails.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDetails_CellClick);
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
            // DeliveryDate
            // 
            this.DeliveryDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DeliveryDate.HeaderText = "DELIVERY DATE";
            this.DeliveryDate.MinimumWidth = 6;
            this.DeliveryDate.Name = "DeliveryDate";
            // 
            // Qty
            // 
            this.Qty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Qty.HeaderText = "QTY";
            this.Qty.MinimumWidth = 6;
            this.Qty.Name = "Qty";
            this.Qty.Width = 95;
            // 
            // Expiration
            // 
            this.Expiration.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Expiration.HeaderText = "EXPIRATION";
            this.Expiration.MinimumWidth = 6;
            this.Expiration.Name = "Expiration";
            this.Expiration.Width = 195;
            // 
            // StockBy
            // 
            this.StockBy.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.StockBy.HeaderText = "STOCKED BY";
            this.StockBy.MinimumWidth = 6;
            this.StockBy.Name = "StockBy";
            this.StockBy.Width = 199;
            // 
            // StockID
            // 
            this.StockID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.StockID.HeaderText = "STOCK ID";
            this.StockID.MinimumWidth = 6;
            this.StockID.Name = "StockID";
            this.StockID.ReadOnly = true;
            this.StockID.Visible = false;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.labelItemID);
            this.panel4.Controls.Add(this.labelItemName);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(718, 64);
            this.panel4.TabIndex = 7;
            // 
            // labelItemID
            // 
            this.labelItemID.AutoSize = true;
            this.labelItemID.Location = new System.Drawing.Point(618, 13);
            this.labelItemID.Name = "labelItemID";
            this.labelItemID.Size = new System.Drawing.Size(57, 38);
            this.labelItemID.TabIndex = 26;
            this.labelItemID.Text = "     ";
            this.labelItemID.Visible = false;
            // 
            // labelItemName
            // 
            this.labelItemName.AutoSize = true;
            this.labelItemName.ForeColor = System.Drawing.Color.Red;
            this.labelItemName.Location = new System.Drawing.Point(105, 13);
            this.labelItemName.Name = "labelItemName";
            this.labelItemName.Size = new System.Drawing.Size(154, 38);
            this.labelItemName.TabIndex = 25;
            this.labelItemName.Text = "Item Name";
            // 
            // frmEditStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 496);
            this.Controls.Add(this.tabControlStock);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmEditStock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmEditStock";
            this.panel1.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.tabControlStock.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panelEditStock.ResumeLayout(false);
            this.panelEditStock.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.panelAddUnit.ResumeLayout(false);
            this.panelAddUnit.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.panelStockDetail.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDetails)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private PictureBox btnClose;
        public TextBox txtQuantity;
        private Label label4;
        private Button btnCancel;
        public Button btnUpdate;
        public DateTimePicker dateExpiration;
        private Label label6;
        public Button btnPerishable;
        public Button btnNonPerishable;
        private Label lblCheck;
        public Label lblID;
        private ComboBox comBoxUnit;
        private Label label2;
        public Button button1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        public Button btnSaveUnit;
        public Panel panelAddUnit;
        public Button btnCancelUnit;
        public TextBox txtUnit;
        public Label label3;
        public TabControl tabControlStock;
        public Panel panelEditStock;
        public Button btnDeleteUnit;
        private TabPage tabPage3;
        private Panel panel5;
        private Panel panel4;
        private Panel panel6;
        public DataGridView dataGridViewDetails;
        public Label labelItemID;
        public Label labelItemName;
        public Panel panelStockDetail;
        private DataGridViewTextBoxColumn NumService;
        private DataGridViewTextBoxColumn DeliveryDate;
        private DataGridViewTextBoxColumn Qty;
        private DataGridViewTextBoxColumn Expiration;
        private DataGridViewTextBoxColumn StockBy;
        private DataGridViewTextBoxColumn StockID;
    }
}